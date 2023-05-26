using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace TermPaper
{
	public partial class LabelInit : Form
	{
		private Image<Bgr, byte> rect;

		public LabelInit()
		{
			InitializeComponent();
		}

		private void LabelInit_Load(object sender, EventArgs e)
		{
		}

		private void tictac_Tick(object sender, EventArgs e)
		{
			//Get + flip + resize frame
			Image<Bgr, byte> frame = Window.capture.QueryFrame().ToImage<Bgr, byte>().Flip(FlipType.Horizontal);
			CvInvoke.Resize(frame, frame, frameBox.Size, 0, 0, Inter.Linear);

			//Clone frame to get dframe (display frame)
			Image<Bgr, byte> dframe = frame.Clone();

			//Draw rect on dframe
			byte size = 70;
			Rectangle rectangle = new(frameBox.Width / 2 - size / 2, frameBox.Height / 2 - size / 2, size, size);
			dframe.Draw(rectangle, new Bgr(Color.Red));

			frame.ROI = rectangle;
			rect = frame.Copy();


			
			frameBox.Image = dframe.ToBitmap();
		}

		private void applyButton_Click(object sender, EventArgs e)
		{
			Window.label = Calculate(rect);
			Close();
		}

		private static Bgr Calculate(Image<Bgr, byte> input) 
		{
			int b = 0;
			int g = 0;
			int r = 0;
			for (int i = 0; i < input.Rows; i++)
			{
				for (int j = 0; j < input.Cols; j++)
				{
					Bgr pixel = input[i, j];
					b += (int)pixel.Blue;
					g += (int)pixel.Green;
					r += (int)pixel.Red;
				}
			}
			double b_ = (int)(b / 1f / (input.Width * input.Height));
			double g_ = (int)(g / 1f / (input.Width * input.Height));
			double r_ = (int)(r / 1f / (input.Width * input.Height));

			return new Bgr(b_, g_, r_);
		}
	}
}
