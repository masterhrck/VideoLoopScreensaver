using System;
using System.Windows.Forms;

namespace VideoLoopScreensaver
{
	public partial class ConfigForm : Form
	{
		int volumeBeforeMute = 0;

		public ConfigForm()
		{
			InitializeComponent();

			textBoxVideoPath.Text = Properties.Settings.Default.videoFilePath;
			trackBarVolume.Value = Properties.Settings.Default.volume;
			checkBoxMouseExit.Checked = Properties.Settings.Default.mouseExit;

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
			Properties.Settings.Default.videoFilePath = textBoxVideoPath.Text;
			Properties.Settings.Default.volume = trackBarVolume.Value;
			Properties.Settings.Default.mouseExit = checkBoxMouseExit.Checked;
			Properties.Settings.Default.Save();

			Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
