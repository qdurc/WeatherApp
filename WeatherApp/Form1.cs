using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Runtime.InteropServices;
using System.Text.Json.Nodes;

namespace WeatherApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private async void button1_Click(object sender, EventArgs e)
		{
			string apiKey = "e59fcf6d8ae79cd6c9cd7adb1941ff03";
			string city = textBox1.Text;

			if (city.Length < 0)
			{
				MessageBox.Show("Por favor, introduzca una ciudad correctamente.");
				return;
			}

			using HttpClient client = new HttpClient();
			using WebClient webClient = new WebClient();
			try
			{
				string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&lang=es&units=metric";
				HttpResponseMessage response = await client.GetAsync(url);
				if (response.IsSuccessStatusCode)
				{
					string responseBody = await response.Content.ReadAsStringAsync();
					var jsonResponse = JObject.Parse(responseBody);
					double latitude = (double)jsonResponse["coord"]["lat"];
					double longitude = (double)jsonResponse["coord"]["lon"];
					decimal temperature = (decimal)jsonResponse["main"]["temp"];
					string weatherDescription = (string)jsonResponse["weather"][0]["description"];
					string weatherEmote = (string)jsonResponse["weather"][0]["icon"];
					string weatherIconUrl = $"http://openweathermap.org/img/w/{weatherEmote}.png";
					string recommendation = "";

					switch (weatherEmote)
					{
						case "01d":
						case "01n":
						default:
							{
								recommendation = "Camisetas de manga corta\nPantalones cortos o faldas\nSombrero o gorra\nCalzado cómodo";
								break;
							}
						case "02d":
						case "02n":
							{
								recommendation = "Camisetas de manga corta\nPantalones o shorts\nChaqueta o sudadera liviana\nCalzado cómodo";
								break;
							}
						case "03d":
						case "03n":
							{
								recommendation = "Camisetas de manga corta\nPantalones\nChaqueta ligera o suéter\nCalzado cómodo";
								break;
							}
						case "04d":
						case "04n":
							{
								recommendation = "Camisetas\nPantalones\nChaqueta ligera o suéter\nCalzado cómodo\nCapa adicional";
								break;
							}
						case "09d":
						case "09n":
						case "10d":
						case "10n":
							{
								recommendation = "Camisetas\nPantalones\nChaqueta ligera o suéter\nCalzado cómodo\nCapa adicional";
								break;
							}

						case "11d":
						case "11n":
							{
								recommendation = "Chaqueta o impermeable resistente\nPantalones impermeables\nCalzado impermeable y antideslizante";
								break;
							}
						case "13d":
						case "13n":
							{
								recommendation = "Capa base térmica\nChaqueta y pantalones impermeables\nBotas";
								break;
							}
						case "50d":
						case "50n":
							{
								recommendation = "Chaqueta ligera\nCamiseta de manga larga\nCalzado adecuado";
								break;
							}
					}

					using (var stream = webClient.OpenRead(weatherIconUrl))
					{
						var img = Image.FromStream(stream);
						pictureBox1.Image = img;
						pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
					}
					var msg = $"Latitude: {latitude}" + $"\nLongitude: {longitude}" + $"\nTemperature: {temperature}°C" + $"\nClimate: {weatherDescription}" + $"\nVestimenta recomendada: {recommendation}";
					richTextBox1.Text = msg;
				}
				else
				{
					Console.WriteLine("Request failed with status code: " + response.StatusCode);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("An error occurred: " + ex.Message);
			}
		}
	}
}