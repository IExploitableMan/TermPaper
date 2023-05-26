using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using NAudio.Midi;

namespace TermPaper
{
	public partial class Window : Form
	{
		public static VideoCapture capture;
		public static MidiOut midi;

		public static Bgr label = new(Color.Green);
		public static int color = 10;
		public static int count = 30;
		public static List<List<int>> notes = new();

		private static int lastNote = 60;

		private static bool _debug = false;

		#region Events
		public Window()
		{
			InitializeComponent();
		}

		private void EventLoad(object sender, EventArgs e)
		{
			Init();
		}

		private void tictac_Tick(object sender, EventArgs e)
		{
			ProcessFrame();
		}
		#endregion

		#region Yup
		private void ProcessFrame()
		{
			//Instant settings
			color = colorSlider.Value;
			count = countSlider.Value;

			//Get + flip + resize frame
			Image<Bgr, byte> frame = capture.QueryFrame().ToImage<Bgr, byte>().Flip(FlipType.Horizontal);
			CvInvoke.Resize(frame, frame, frameBox.Size, 0, 0, Inter.Linear);

			//Clone frame to get dframe (display frame)
			Image<Bgr, byte> dframe = frame.Clone();

			//Cropping
			List<Tuple<int, int, int>> suitableCropIndexes = new();
			for (int x = 0; x < 12; x++)
			{
				//Draw vertical lines on dframe
				dframe.Draw(
			   new LineSegment2D(
					new Point(x * frameBox.Width / 12, 0),
					new Point(x * frameBox.Width / 12, frameBox.Height)
					),
					new Bgr(Color.Red),
					2,
					LineType.Filled
				);

				for (int y = 0; y < 4; y++)
				{
					if (x == 0 && y == 0) 
					{
						_debug = true;
					}

					//Draw horizontal lines on dframe
					dframe.Draw(
						new LineSegment2D(
						new Point(0, y * frameBox.Height / 4),
						new Point(frameBox.Width, y * frameBox.Height / 4)
						),
						new Bgr(Color.Red),
						2,
						LineType.Filled
					);

					//Get crop by ROI (Region of Interest)
					frame.ROI = new(x * frameBox.Width / 12, y * frameBox.Height / 4, frameBox.Width / 12, frameBox.Height / 4);
					Image<Bgr, byte> crop = frame.Copy();
					CvInvoke.cvResetImageROI(frame);

					int result = Calculate(crop);
					if (result != -1)
					{
						suitableCropIndexes.Add(new Tuple<int, int, int>(x, y, result));
					}
				}

			}

			try
			{
				var listResult = suitableCropIndexes.OrderByDescending(x => x.Item3);
				if (!listResult.Any())
				{
					throw new InvalidOperationException();
				}
				var result = listResult.First();
				int note = notes[result.Item2][result.Item1];
				if (lastNote != note)
				{
					midi.Send(MidiMessage.StopNote(lastNote, 127, 1).RawData);
					lastNote = note;
					midi.Send(MidiMessage.StartNote(note, 127, 1).RawData);
				}
			}
			catch (InvalidOperationException) 
			{
				midi.Send(MidiMessage.StopNote(lastNote, 127, 1).RawData);
			}
			finally
			{
				Mmm(dframe);
				frameBox.Image = dframe.ToBitmap();
			}
		}

		private static int Calculate(Image<Bgr, byte> input)
		{
			int karma = 0;

			for (int i = 0; i < input.Rows; i++)
			{
				for (int j = 0; j < input.Cols; j++)
				{
					Bgr pixel = input[i, j];
					int difference = (int)(Math.Abs(pixel.Red - label.Red) + Math.Abs(pixel.Green - label.Green) + Math.Abs(pixel.Blue - label.Blue));
					if (difference <= color)
					{
						++karma;
					}
				}
			}
			int dbg = (int)(karma / 1f / (input.Width * input.Height) * 100);
			if (_debug)
			{
				Console.WriteLine(dbg + " - " + karma);
				_debug = false;
			}
			if (dbg < count)
			{
				return -1;
			}
			return karma;
		}

		private void Mmm(Image<Bgr, byte> input)
		{
			for (int i = 0; i < input.Rows; i++)
			{
				for (int j = 0; j < input.Cols; j++)
				{
					Bgr pixel = input[i, j];
					int difference = (int)(Math.Abs(pixel.Red - label.Red) + Math.Abs(pixel.Green - label.Green) + Math.Abs(pixel.Blue - label.Blue));
					if (difference < color)
					{
						input[i, j] = new Bgr(0, 0, 255);
					}
				}
			}
		}

		public static int[] GetGamma(int note, bool minor)
		{
			if (minor)
			{
				return new int[12] { note, note + 2, note + 3, note + 5, note + 7, note + 8, note + 10, note + 12, note + 14, note + 15, note + 17, note + 19 };
			}
			return new int[12] { note, note + 2, note + 4, note + 5, note + 7, note + 9, note + 11, note + 12, note + 14, note + 16, note + 17, note + 19 };
		}

		private void Init()
		{
			Form init = new Init();
			init.ShowDialog();
			midi.Send(MidiMessage.ChangePatch(16, 1).RawData);

			colorSlider.Value = color;
			countSlider.Value = count;

			Form labelInit = new LabelInit();
			labelInit.ShowDialog();

			tictac.Start();
		}
#endregion
	}
}
