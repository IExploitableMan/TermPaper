namespace TermPaper
{
	partial class LabelInit
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
			this.components = new System.ComponentModel.Container();
			this.frameBox = new System.Windows.Forms.PictureBox();
			this.applyButton = new System.Windows.Forms.Button();
			this.tictac = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.frameBox)).BeginInit();
			this.SuspendLayout();
			// 
			// frameBox
			// 
			this.frameBox.Location = new System.Drawing.Point(12, 12);
			this.frameBox.Name = "frameBox";
			this.frameBox.Size = new System.Drawing.Size(620, 480);
			this.frameBox.TabIndex = 1;
			this.frameBox.TabStop = false;
			// 
			// applyButton
			// 
			this.applyButton.Location = new System.Drawing.Point(12, 498);
			this.applyButton.Name = "applyButton";
			this.applyButton.Size = new System.Drawing.Size(620, 40);
			this.applyButton.TabIndex = 11;
			this.applyButton.Text = "Применить";
			this.applyButton.UseVisualStyleBackColor = true;
			this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
			// 
			// tictac
			// 
			this.tictac.Enabled = true;
			this.tictac.Tick += new System.EventHandler(this.tictac_Tick);
			// 
			// LabelInit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 549);
			this.Controls.Add(this.applyButton);
			this.Controls.Add(this.frameBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "LabelInit";
			this.Text = "Инициализация метки | Лубяной Иван © 2023";
			this.Load += new System.EventHandler(this.LabelInit_Load);
			((System.ComponentModel.ISupportInitialize)(this.frameBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private PictureBox frameBox;
		private Button applyButton;
		private System.Windows.Forms.Timer tictac;
	}
}