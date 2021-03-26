using System;
using System.Windows.Forms;

namespace VideoLoopScreensaver
{
	static class Program
	{
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
				if (handle == "")
				{
					MessageBox.Show("Error: window handle was not provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					Environment.Exit(1);
				}

				IntPtr previewWndHandle = new IntPtr(long.Parse(handle));
				Application.Run(new ScreensaverForm(previewWndHandle));
			}
			else if(flag=="/s")
			{
				Application.Run(new ScreensaverForm());
			}
			//Config mode
			else
			{
				Application.Run(new ConfigForm());
			}
			//Fullscreen mode
			
		}
	}
}
