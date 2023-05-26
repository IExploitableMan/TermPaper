namespace TermPaper
{
	partial class Window
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
			this.components = new System.ComponentModel.Container();
			this.frameBox = new System.Windows.Forms.PictureBox();
			this.tictac = new System.Windows.Forms.Timer(this.components);
			this.i1 = new System.Windows.Forms.Label();
			this.colorSlider = new System.Windows.Forms.TrackBar();
			this.i2 = new System.Windows.Forms.Label();
			this.countSlider = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.frameBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.colorSlider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.countSlider)).BeginInit();
			this.SuspendLayout();
			// 
			// frameBox
			// 
			this.frameBox.Location = new System.Drawing.Point(12, 12);
			this.frameBox.Name = "frameBox";
			this.frameBox.Size = new System.Drawing.Size(620, 480);
			this.frameBox.TabIndex = 0;
			this.frameBox.TabStop = false;
			// 
			// tictac
			// 
			this.tictac.Interval = 10;
			this.tictac.Tick += new System.EventHandler(this.tictac_Tick);
			// 
			// i1
			// 
			this.i1.AutoSize = true;
			this.i1.Location = new System.Drawing.Point(638, 12);
			this.i1.Name = "i1";
			this.i1.Size = new System.Drawing.Size(65, 20);
			this.i1.TabIndex = 7;
			this.i1.Text = "Оттенок";
			// 
			// colorSlider
			// 
			this.colorSlider.Location = new System.Drawing.Point(638, 35);
			this.colorSlider.Maximum = 100;
			this.colorSlider.Name = "colorSlider";
			this.colorSlider.Size = new System.Drawing.Size(168, 56);
			this.colorSlider.TabIndex = 8;
			this.colorSlider.TickStyle = System.Windows.Forms.TickStyle.None;
			// 
			// i2
			// 
			this.i2.AutoSize = true;
			this.i2.Location = new System.Drawing.Point(638, 71);
			this.i2.Name = "i2";
			this.i2.Size = new System.Drawing.Size(90, 20);
			this.i2.TabIndex = 13;
			this.i2.Text = "Количество";
			// 
			// countSlider
			// 
			this.countSlider.Location = new System.Drawing.Point(638, 94);
			this.countSlider.Maximum = 100;
			this.countSlider.Name = "countSlider";
			this.countSlider.Size = new System.Drawing.Size(168, 56);
			this.countSlider.TabIndex = 14;
			this.countSlider.TickStyle = System.Windows.Forms.TickStyle.None;
			// 
			// Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(818, 506);
			this.Controls.Add(this.countSlider);
			this.Controls.Add(this.i2);
			this.Controls.Add(this.colorSlider);
			this.Controls.Add(this.i1);
			this.Controls.Add(this.frameBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Window";
			this.Text = "Окно | Лубяной Иван © 2023";
			this.Load += new System.EventHandler(this.EventLoad);
			((System.ComponentModel.ISupportInitialize)(this.frameBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.colorSlider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.countSlider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private PictureBox frameBox;
		private System.Windows.Forms.Timer tictac;
		private TextBox cameraIndexBox;
		private Label i1;
		private TrackBar colorSlider;
		private Label i2;
		private TrackBar countSlider;
	}
}