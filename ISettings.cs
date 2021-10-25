using Config.Net;

namespace VideoLoopScreensaver
{
	public interface ISettings
	{
		[Option(DefaultValue = 100)]
		int Volume { get; set; }

		[Option(DefaultValue = true)]
		bool ExitOnMouse { get; set; }

		[Option(DefaultValue = false)]
		bool EnableTimer { get; set; }

		[Option(DefaultValue = 10)]
		int TimerMinutes { get; set; }

		[Option(DefaultValue = true)]
		bool EnableConversion { get; set; }

		[Option(DefaultValue = "")]
		string SelectedVideoLastMD5 { get; set; }

		[Option(DefaultValue = "")]
		string PlaybackVideoPath { get; set; }
	}
}
