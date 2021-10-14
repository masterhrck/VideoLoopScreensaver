using System;
using System.IO;
using System.Windows.Forms;

namespace VideoLoopScreensaver
{
	public partial class ConfigForm : Form
	{
		int volumeBeforeMute = 0;

		public ConfigForm()
		{
			InitializeComponent();

			textBoxVideoPath.Text = Program.Settings.VideoFilePath;
			trackBarVolume.Value = Program.Settings.Volume;
			checkBoxMouseExit.Checked = Program.Settings.ExitOnMouse;

			checkBoxVolumeMute.Checked = trackBarVolume.Value == 0;
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			openFileDialog1.FileName = textBoxVideoPath.Text;
			openFileDialog1.ShowDialog();
			textBoxVideoPath.Text = openFileDialog1.FileName;
		}

		private void trackBarVolume_Scroll(object sender, EventArgs e)
		{
			checkBoxVolumeMute.Checked = trackBarVolume.Value == 0;
		}

		private void checkBoxVolumeMute_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxVolumeMute.Checked)
			{
				volumeBeforeMute = trackBarVolume.Value;
				trackBarVolume.Value = 0;
			}
			else
			{
				trackBarVolume.Value = volumeBeforeMute;
			}
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (!File.Exists(textBoxVideoPath.Text))
			{
				DialogResult result = MessageBox.Show("The video file path you entered does not exist. Are you sure you want to continue?", Program.ErrorDialogTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

				if (result == DialogResult.Cancel)
					return;
			}

			SaveAndClose();
		}

		private void SaveAndClose()
		{
			Program.Settings.VideoFilePath = textBoxVideoPath.Text;
			Program.Settings.Volume = trackBarVolume.Value;
			Program.Settings.ExitOnMouse = checkBoxMouseExit.Checked;

			Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
