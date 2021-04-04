using Config.Net;
using System;
using System.Windows.Forms;

namespace VideoLoopScreensaver
{
	static class Program
	{
		public const string ErrorDialogTitle = "Video Loop Screensaver";
		public static ISettings Settings = new ConfigurationBuilder<ISettings>().UseIniFile(Application.UserAppDataPath + @"\settings.ini").Build();

		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			string flag = "";
			string handle = "";

			if (args.Length == 1)
			{
				string[] parts = args[0].Split(':');
				flag = parts[0];

				if (parts.Length >= 2)
					handle = parts[1];
			}
			else if (args.Length >= 2)
			{
				flag = args[0];
				handle = args[1];
			}

			flag = flag.ToLower().Trim();

			//Preview mode
			if (flag == "/p")
			{
				IntPtr previewWndHandle = IntPtr.Zero;

				try
				{
					previewWndHandle = new IntPtr(long.Parse(handle));
				}
				catch
				{
					Environment.Exit(1);
				}

				Application.Run(new ScreensaverForm(previewWndHandle));
			}
			//Fullscreen mode
			else if (flag == "/s")
			{
				Application.Run(new ScreensaverForm());
			}
			//Config mode
			else
			{
				Application.Run(new ConfigForm());
			}
		}
	}
}
