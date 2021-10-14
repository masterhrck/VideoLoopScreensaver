using System;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace VideoLoopScreensaver
{
	static class WinFunctions
	{
		[DllImport("user32.dll")]
		public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		[DllImport("user32.dll")]
		public static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		[DllImport("user32.dll")]
		public static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

		[DllImport("user32.dll")]
		static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
		
		public static void MonitorOff()
		{
			const int WmSyscommand = 0x0112;
			const int ScMonitorpower = 0xF170;
			const int MonitorShutoff = 2;

			SendMessage(new Form().Handle, WmSyscommand, ScMonitorpower, MonitorShutoff);
		}
	}
}
