using Mpv.NET.Player;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Xabe.FFmpeg;

namespace VideoLoopScreensaver
{
	public partial class ScreensaverForm : Form
	{
		private MpvPlayer player;
		private Point startMousePos = Point.Empty;
		private bool previewMode = false;

		//Fullscreen mode
		public ScreensaverForm()
		{
			InitializeComponent();
			WindowState = FormWindowState.Normal;
			FormBorderStyle = FormBorderStyle.None;
			WindowState = FormWindowState.Maximized;
			Cursor.Hide();
			
			//Steal the focus
			TopMost = true;
			Activate();

			KeyDown += (object sender, KeyEventArgs e) => Application.Exit();
			MouseDown += (object sender, MouseEventArgs e) => Application.Exit();

			if (Program.Settings.ExitOnMouse)
			{
				startMousePos = MousePosition;
				MouseMove += ScreensaverForm_MouseMove;
			}

			if (Program.Settings.EnableTimer)
			{
				Timer timer = new Timer{
					Interval = Program.Settings.TimerMinutes * 60000,
					Enabled = true
				};

				timer.Tick += (object sender, EventArgs e) => {
					WinFunctions.MonitorOff();
					Application.Exit();
				};
			}

			InitVideo();
		}

		//Preview mode
		public ScreensaverForm(IntPtr PreviewWndHandle)
		{
			InitializeComponent();

			// Set the preview window as the parent of this window
			WinFunctions.SetParent(this.Handle, PreviewWndHandle);

			// Make this a child window so it will close when the parent dialog closes
			// GWL_STYLE = -16, WS_CHILD = 0x40000000
			WinFunctions.SetWindowLong(this.Handle, -16, new IntPtr(WinFunctions.GetWindowLong(this.Handle, -16) | 0x40000000));

			// Place the window inside the parent
			WinFunctions.GetClientRect(PreviewWndHandle, out Rectangle ParentRect);
			Size = ParentRect.Size;
			Location = new Point(0, 0);

			previewMode = true;
			InitVideo();
		}

		private void InitVideo()
		{
			if (!File.Exists(Program.Settings.PlaybackVideoPath))
				FatalError("Video file not set. Please select a video file in screensaver settings.");

			Environment.CurrentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

			try
			{
				player = new MpvPlayer(this.Handle) {
					Loop = true,
					Volume = Program.Settings.Volume
				};
			}
			catch
			{
				FatalError("Failed to initialize MVP player. Make sure mvp-1.dll is in the same directory as VideoLoopScreensaver.scr or in \"libs\" subfolder.", showInPreview: true);
			}

			player.MediaError += (object sender, EventArgs e) =>
				FatalError("Failed to load video. Make sure you selected a valid video file. Otherwise, the player doesn't support that video format.");

			player.Load(Program.Settings.PlaybackVideoPath);
			player.Resume();
		}

		private void ScreensaverForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (PointDistance(e.Location, startMousePos) > 5)
				Application.Exit();

			int PointDistance(Point pointA, Point pointB)
			{
				return (int)Math.Sqrt(Math.Pow(pointA.X - pointB.X, 2) + Math.Pow(pointA.Y - pointB.Y, 2));
			}
		}

		private void FatalError(string message, bool showInPreview = false)
		{
			if (!previewMode || showInPreview)
			{
				Cursor.Show();
				MessageBox.Show(message, Program.DialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			Environment.Exit(1);
		}

		private async void Test()
		{
			string inputFile = "";
			string outputFile = "";
			IConversionResult result = await FFmpeg.Conversions.New().Start($"-i \"{inputFile}\" -c:v libx264 -profile:v baseline \"{outputFile}.mp4\"");
		}
	}
}
