using Mpv.NET.Player;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace VideoLoopScreensaver
{
	public partial class ScreensaverForm : Form
	{
		public const string errorDialogTitle = "Video Loop Screensaver";

		private MpvPlayer player;
		private Point startMousePos = Point.Empty;
		private bool mouseInit = true;

		//Fullscreen mode
		public ScreensaverForm()
		{
			InitializeComponent();
			WindowState = FormWindowState.Normal;
			FormBorderStyle = FormBorderStyle.None;
			WindowState = FormWindowState.Maximized;
			Cursor.Hide();

			KeyDown += (object sender, KeyEventArgs e) => Application.Exit();
			if (Properties.Settings.Default.mouseExit)
			{
				MouseMove += ScreensaverForm_MouseMove;
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

			InitVideo();
		}

		private void InitVideo()
		{
			if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.videoFilePath))
			{
				if (File.Exists(Properties.Settings.Default.videoFilePath))
				{
					Environment.CurrentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

					try
					{
						player = new MpvPlayer(this.Handle)
						{
							Loop = true,
							Volume = Properties.Settings.Default.volume
						};
					}
					catch
					{
						MessageBox.Show("Failed to initialize MVP player. Make sure mvp-1.dll is in the same directory as VideoLoopScreensaver.scr or in \"libs\" subfolder.", errorDialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
						Environment.Exit(1);
					}

					player.Load(Properties.Settings.Default.videoFilePath);
					player.Resume();
				}
				else
				{
					MessageBox.Show($"Cannot find video file \"{Properties.Settings.Default.videoFilePath}\". Make sure the file exists and the screensaver has permission to access it. Otherwise, select a new video file in screensaver settings.", errorDialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
					Environment.Exit(1);
				}
			}
			else
			{
				MessageBox.Show("Video file not set. Please select a video file in screensaver settings.", errorDialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Environment.Exit(1);
			}
		}

		private void ScreensaverForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseInit)
			{
				mouseInit = false;
				startMousePos = e.Location;
			}
			else if (PointDistance(e.Location, startMousePos) > 5)
				Application.Exit();

			int PointDistance(Point pointA, Point pointB)
			{
				return (int)Math.Sqrt(Math.Pow(pointA.X - pointB.X, 2) + Math.Pow(pointA.Y - pointB.Y, 2));
			}
		}

	}
}
