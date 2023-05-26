using DirectShowLib;

namespace TermPaper
{
	public partial class Init : Form
	{
		#region Events
		public Init()
		{
			InitializeComponent();
		}

		private void Init_Load(object sender, EventArgs e)
		{
			foreach (var element in new string[] { "До мажор", "Фа-диез мажор", "Соль мажор", "До-диез мажор", "Ре мажор", "Соль-диез мажор", "Ля мажор", "Ре-диез мажор", "Ми мажор", "Ля-диез мажор", "Си мажор", "Фа мажор", /**/ "Ля минор", "Ре-диез минор", "Ми минор", "Ля-диез минор", "Си минор", "Фа минор", "Фа-диез минор", "До минор", "До-диез минор", "Соль минор", "Соль-диез минор", "Ре минор" })
			{
				gamma1.Items.Add(element);
				gamma2.Items.Add(element);
				gamma3.Items.Add(element);
				gamma4.Items.Add(element);
			}

			DsDevice[] cameras = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
			foreach (var camera in cameras)
			{
				cameraDropdown.Items.Add(camera.Name);
			}
			cameraDropdown.SelectedIndex = 0;
			soundIndexBox.Lines[0] = "0";
		}

		private void applyButton_Click(object sender, EventArgs e)
		{
			cameraDropdown.Enabled = false;
			soundIndexBox.Enabled = false;
			applyButton.Enabled = false;
			gamma1.Enabled = false;
			gamma2.Enabled = false;
			gamma3.Enabled = false;
			gamma4.Enabled = false;

			ApplyGamma(gamma1.SelectedIndex);
			ApplyGamma(gamma2.SelectedIndex);
			ApplyGamma(gamma3.SelectedIndex);
			ApplyGamma(gamma4.SelectedIndex);

			Window.capture = new(cameraDropdown.SelectedIndex);
			Window.midi = new(int.Parse(soundIndexBox.Lines[0]));

			Close();
		}
#endregion

#region Yup
		private static void ApplyGamma(int input)
		{
			int note = 60;

			switch (input)
			{
				case 0:
					break;
				case 1:
					note = 66;
					break;
				case 2:
					note = 67;
					break;
				case 3:
					note = 61;
					break;
				case 4:
					note = 62;
					break;
				case 5:
					note = 68;
					break;
				case 6:
					note = 69;
					break;
				case 7:
					note = 63;
					break;
				case 8:
					note = 64;
					break;
				case 9:
					note = 70;
					break;
				case 10:
					note = 71;
					break;
				case 11:
					note = 65;
					break;
				//---//
				case 12:
					note = 69;
					break;
				case 13:
					note = 63;
					break;
				case 14:
					note = 64;
					break;
				case 15:
					note = 70;
					break;
				case 16:
					note = 71;
					break;
				case 17:
					note = 65;
					break;
				case 18:
					note = 66;
					break;
				case 19:
					note = 60;
					break;
				case 20:
					note = 61;
					break;
				case 21:
					note = 67;
					break;
				case 22:
					note = 68;
					break;
				case 23:
					note = 62;
					break;
			}

			Window.notes.Add(Window.GetGamma(note, input > 11).ToList());
		}
#endregion
	}
}
