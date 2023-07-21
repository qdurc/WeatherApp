namespace WeatherApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			label1 = new Label();
			button1 = new Button();
			richTextBox1 = new RichTextBox();
			groupBox1 = new GroupBox();
			pictureBox1 = new PictureBox();
			label3 = new Label();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(42, 103);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(370, 39);
			textBox1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(42, 52);
			label1.Name = "label1";
			label1.Size = new Size(94, 32);
			label1.TabIndex = 1;
			label1.Text = "Ciudad:";
			// 
			// button1
			// 
			button1.Location = new Point(147, 178);
			button1.Name = "button1";
			button1.Size = new Size(145, 53);
			button1.TabIndex = 4;
			button1.Text = "Buscar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// richTextBox1
			// 
			richTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			richTextBox1.Location = new Point(82, 602);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(513, 337);
			richTextBox1.TabIndex = 5;
			richTextBox1.Text = "";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Location = new Point(112, 34);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(483, 282);
			groupBox1.TabIndex = 6;
			groupBox1.TabStop = false;
			groupBox1.Text = "Weather";
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(181, 352);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(296, 244);
			pictureBox1.TabIndex = 7;
			pictureBox1.TabStop = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(126, 337);
			label3.Name = "label3";
			label3.Size = new Size(149, 32);
			label3.TabIndex = 8;
			label3.Text = "Clima actual:";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(710, 1018);
			Controls.Add(label3);
			Controls.Add(pictureBox1);
			Controls.Add(groupBox1);
			Controls.Add(richTextBox1);
			Name = "Form1";
			Text = "WeatherApp";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Label label1;
		private Button button1;
		private RichTextBox richTextBox1;
		private GroupBox groupBox1;
		private PictureBox pictureBox1;
		private Label label3;
	}
}