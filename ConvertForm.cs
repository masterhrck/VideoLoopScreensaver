using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xabe.FFmpeg;

namespace VideoLoopScreensaver
{
	public partial class ConvertForm : Form
	{
		string outputFilePath;

		public ConvertForm(string inputFilePath, bool enableConversion)
		{
			InitializeComponent();

			if (enableConversion)
				Convert(inputFilePath);
			else
				Verify(inputFilePath);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private async void Convert(string inputVideoPath)
		{
			label.Text = "Optimizing video, please wait...";

			string tempOutputFilePath = Application.UserAppDataPath + @"\tempVideo.mp4";
			outputFilePath = Application.UserAppDataPath + @"\" + "optimized_" + Path.GetFileNameWithoutExtension(inputVideoPath) + ".mp4";

			IConversion conversion = FFmpeg.Conversions.New();
			conversion.OnProgress += Conversion_OnProgress;
			IConversionResult conversionResult = null;

			try
			{
				conversionResult = await conversion.Start($"-i \"{inputVideoPath}\" -c:v libx264 -profile:v baseline -y \"{tempOutputFilePath}\"");
			}
			catch
			{
				Failed();
				return;
			}

			if (conversionResult == null)
			{
				Failed();
				return;
			}

			DialogResult = DialogResult.OK;

			if (File.Exists(Program.Settings.PlaybackVideoPath))
				File.Delete(Program.Settings.PlaybackVideoPath);

			File.Move(tempOutputFilePath, outputFilePath);

			Program.Settings.PlaybackVideoPath = outputFilePath;

			Close();

			void Failed()
			{
				if (File.Exists(tempOutputFilePath))
					File.Delete(tempOutputFilePath);

				MessageBox.Show("Video conversion failed!", Program.DialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
			}
		}

		private void Conversion_OnProgress(object sender, Xabe.FFmpeg.Events.ConversionProgressEventArgs args)
		{
			if (progressBar.Created)
				progressBar.Invoke(new Action(() => {
					progressBar.Style = ProgressBarStyle.Continuous;
					progressBar.Value = args.Percent;
				}));
		}

		private async void Verify(string inputVideoPath)
		{
			label.Text = "Verifying video, please wait...";

			IConversion conversion = FFmpeg.Conversions.New();
			conversion.OnProgress += Conversion_OnProgress;
			IConversionResult conversionResult = null;

			try
			{
				conversionResult = await conversion.Start($"-i \"{inputVideoPath}\" -f null -");
			}
			catch
			{
				Failed();
				return;
			}

			if (conversionResult == null)
			{
				Failed();
				return;
			}

			DialogResult = DialogResult.OK;

			if (File.Exists(Program.Settings.PlaybackVideoPath))
				File.Delete(Program.Settings.PlaybackVideoPath);

			string outputFilePath = Application.UserAppDataPath + @"\" + Path.GetFileName(inputVideoPath);

			File.Copy(inputVideoPath, outputFilePath);

			Program.Settings.PlaybackVideoPath = outputFilePath;

			void Failed()
			{
				MessageBox.Show("Video verification failed!", Program.DialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
			}
		}
	}
}
