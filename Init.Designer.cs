namespace TermPaper
{
	partial class Init
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cameraDropdown = new System.Windows.Forms.ComboBox();
			this.i2 = new System.Windows.Forms.Label();
			this.i1 = new System.Windows.Forms.Label();
			this.soundIndexBox = new System.Windows.Forms.TextBox();
			this.applyButton = new System.Windows.Forms.Button();
			this.div = new System.Windows.Forms.Label();
			this.gamma1 = new System.Windows.Forms.ComboBox();
			this.i3 = new System.Windows.Forms.Label();
			this.gamma2 = new System.Windows.Forms.ComboBox();
			this.gamma3 = new System.Windows.Forms.ComboBox();
			this.gamma4 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// cameraDropdown
			// 
			this.cameraDropdown.FormattingEnabled = true;
			this.cameraDropdown.Location = new System.Drawing.Point(12, 32);
			this.cameraDropdown.Name = "cameraDropdown";
			this.cameraDropdown.Size = new System.Drawing.Size(168, 28);
			this.cameraDropdown.TabIndex = 14;
			// 
			// i2
			// 
			this.i2.AutoSize = true;
			this.i2.Location = new System.Drawing.Point(12, 63);
			this.i2.Name = "i2";
			this.i2.Size = new System.Drawing.Size(130, 20);
			this.i2.TabIndex = 13;
			this.i2.Text = "Номер динамика";
			// 
			// i1
			// 
			this.i1.AutoSize = true;
			this.i1.Location = new System.Drawing.Point(12, 9);
			this.i1.Name = "i1";
			this.i1.Size = new System.Drawing.Size(62, 20);
			this.i1.TabIndex = 12;
			this.i1.Text = "Камера";
			// 
			// soundIndexBox
			// 
			this.soundIndexBox.Location = new System.Drawing.Point(12, 86);
			this.soundIndexBox.Name = "soundIndexBox";
			this.soundIndexBox.Size = new System.Drawing.Size(168, 27);
			this.soundIndexBox.TabIndex = 11;
			this.soundIndexBox.Text = "0";
			// 
			// applyButton
			// 
			this.applyButton.Location = new System.Drawing.Point(12, 168);
			this.applyButton.Name = "applyButton";
			this.applyButton.Size = new System.Drawing.Size(361, 40);
			this.applyButton.TabIndex = 10;
			this.applyButton.Text = "Применить";
			this.applyButton.UseVisualStyleBackColor = true;
			this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
			// 
			// div
			// 
			this.div.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.div.Location = new System.Drawing.Point(197, 8);
			this.div.Name = "div";
			this.div.Size = new System.Drawing.Size(2, 155);
			this.div.TabIndex = 15;
			// 
			// gamma1
			// 
			this.gamma1.FormattingEnabled = true;
			this.gamma1.Location = new System.Drawing.Point(205, 32);
			this.gamma1.Name = "gamma1";
			this.gamma1.Size = new System.Drawing.Size(168, 28);
			this.gamma1.TabIndex = 16;
			this.gamma1.Text = "До мажор";
			// 
			// i3
			// 
			this.i3.AutoSize = true;
			this.i3.Location = new System.Drawing.Point(205, 9);
			this.i3.Name = "i3";
			this.i3.Size = new System.Drawing.Size(57, 20);
			this.i3.TabIndex = 17;
			this.i3.Text = "Гаммы";
			// 
			// gamma2
			// 
			this.gamma2.FormattingEnabled = true;
			this.gamma2.Location = new System.Drawing.Point(205, 66);
			this.gamma2.Name = "gamma2";
			this.gamma2.Size = new System.Drawing.Size(168, 28);
			this.gamma2.TabIndex = 18;
			this.gamma2.Text = "До мажор";
			// 
			// gamma3
			// 
			this.gamma3.FormattingEnabled = true;
			this.gamma3.Location = new System.Drawing.Point(205, 100);
			this.gamma3.Name = "gamma3";
			this.gamma3.Size = new System.Drawing.Size(168, 28);
			this.gamma3.TabIndex = 19;
			this.gamma3.Text = "До мажор";
			// 
			// gamma4
			// 
			this.gamma4.FormattingEnabled = true;
			this.gamma4.Location = new System.Drawing.Point(205, 134);
			this.gamma4.Name = "gamma4";
			this.gamma4.Size = new System.Drawing.Size(168, 28);
			this.gamma4.TabIndex = 20;
			this.gamma4.Text = "До мажор";
			// 
			// Init
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(386, 218);
			this.Controls.Add(this.gamma4);
			this.Controls.Add(this.gamma3);
			this.Controls.Add(this.gamma2);
			this.Controls.Add(this.i3);
			this.Controls.Add(this.gamma1);
			this.Controls.Add(this.div);
			this.Controls.Add(this.cameraDropdown);
			this.Controls.Add(this.i2);
			this.Controls.Add(this.i1);
			this.Controls.Add(this.soundIndexBox);
			this.Controls.Add(this.applyButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Init";
			this.Text = "Конфигурация | Лубяной Иван © 2023";
			this.Load += new System.EventHandler(this.Init_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ComboBox cameraDropdown;
		private Label i2;
		private Label i1;
		private TextBox soundIndexBox;
		private Button applyButton;
		private Label div;
		private ComboBox gamma1;
		private Label i3;
		private ComboBox gamma2;
		private ComboBox gamma3;
		private ComboBox gamma4;
	}
}