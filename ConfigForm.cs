using System;
using System.IO;
using System.Windows.Forms;
using Xabe.FFmpeg;
using System.Security.Cryptography;

namespace VideoLoopScreensaver
{
	public partial class ConfigForm : Form
	{
		int volumeBeforeMute = 0;

		public ConfigForm()
		{
			InitializeComponent();
			numericTimer.Maximum = decimal.MaxValue;

			textBoxStoredVideo.Text = Path.GetFileName(Program.Settings.PlaybackVideoPath);
			trackBarVolume.Value = Program.Settings.Volume;
			checkBoxMouseExit.Checked = Program.Settings.ExitOnMouse;
			numericTimer.Value = Program.Settings.TimerMinutes;
			checkBoxTimer.Checked = Program.Settings.EnableTimer;
			checkBoxConversion.Checked = Program.Settings.EnableConversion;

			checkBoxVolumeMute.Checked = trackBarVolume.Value == 0;
			numericTimer.Enabled = checkBoxTimer.Checked;
		}

		private void buttonChange_Click(object sender, EventArgs e)
		{
			if (openFileDialogChange.ShowDialog() != DialogResult.OK)
				return;

			//Store video
			using (MD5 md5 = MD5.Create())
			using (FileStream file = File.OpenRead(openFileDialogChange.FileName))
			{
				string hash = Convert.ToBase64String(md5.ComputeHash(file));

				if (hash != Program.Settings.SelectedVideoLastMD5 || Program.Settings.EnableConversion != checkBoxConversion.Checked)
				{
					//New video file detected or optimization setting changed

					DialogResult result = (new ConvertForm(openFileDialogChange.FileName, checkBoxConversion.Checked)).ShowDialog();
					if (result == DialogResult.Cancel)
						return;

					Program.Settings.SelectedVideoLastMD5 = hash;
					textBoxStoredVideo.Text = Path.GetFileName(Program.Settings.PlaybackVideoPath);
				}
			}
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

		private void checkBoxTimer_CheckedChanged(object sender, EventArgs e)
		{
			numericTimer.Enabled = checkBoxTimer.Checked;
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			//Save settings
			Program.Settings.Volume = trackBarVolume.Value;
			Program.Settings.ExitOnMouse = checkBoxMouseExit.Checked;
			Program.Settings.EnableTimer = checkBoxTimer.Checked;
			Program.Settings.TimerMinutes = (int)numericTimer.Value;
			Program.Settings.EnableConversion = checkBoxConversion.Checked;
		}
	}
}
