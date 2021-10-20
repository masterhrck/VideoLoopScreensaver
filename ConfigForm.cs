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

			textBoxVideoPath.Text = Program.Settings.VideoFilePath;
			trackBarVolume.Value = Program.Settings.Volume;
			checkBoxMouseExit.Checked = Program.Settings.ExitOnMouse;
			numericTimer.Value = Program.Settings.TimerMinutes;
			checkBoxTimer.Checked = Program.Settings.TimerEnabled;
			checkBoxConversion.Checked = Program.Settings.EnableConversion;

			checkBoxVolumeMute.Checked = trackBarVolume.Value == 0;
			numericTimer.Enabled = checkBoxTimer.Checked;
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

		private void checkBoxTimer_CheckedChanged(object sender, EventArgs e)
		{
			numericTimer.Enabled = checkBoxTimer.Checked;
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			//Validate input
			if (!File.Exists(textBoxVideoPath.Text))
			{
				DialogResult result = MessageBox.Show("The video file path you entered does not exist. Are you sure you want to continue?", Program.ErrorDialogTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

				if (result == DialogResult.Cancel)
					return;
			}

			//Store video
			using (MD5 md5 = MD5.Create())
			using (FileStream file = File.OpenRead(textBoxVideoPath.Text))
			{
				string hash = Convert.ToBase64String(md5.ComputeHash(file));

				if (hash != Program.Settings.SelectedVideoLastMD5 || Program.Settings.EnableConversion != checkBoxConversion.Checked)
				{
					//New video file detected or optimization setting changed

					DialogResult result = (new ConvertForm(textBoxVideoPath.Text, checkBoxConversion.Checked)).ShowDialog();
					if (result == DialogResult.Cancel)
						return;

					Program.Settings.SelectedVideoLastMD5 = hash;
				}
			}


			//Save settings
			Program.Settings.VideoFilePath = textBoxVideoPath.Text;
			Program.Settings.Volume = trackBarVolume.Value;
			Program.Settings.ExitOnMouse = checkBoxMouseExit.Checked;
			Program.Settings.TimerEnabled = checkBoxTimer.Checked;
			Program.Settings.TimerMinutes = (int)numericTimer.Value;
			Program.Settings.EnableConversion = checkBoxConversion.Checked;

			Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void textBoxVideoPath_Leave(object sender, EventArgs e)
		{
			textBoxVideoPath.Text = textBoxVideoPath.Text.Trim().Trim('\"');
		}
	}
}
