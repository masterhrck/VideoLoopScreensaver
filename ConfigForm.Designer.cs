
namespace VideoLoopScreensaver
{
	partial class ConfigForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.trackBarVolume = new System.Windows.Forms.TrackBar();
			this.groupBoxVideoPath = new System.Windows.Forms.GroupBox();
			this.checkBoxConversion = new System.Windows.Forms.CheckBox();
			this.textBoxStoredVideo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonChange = new System.Windows.Forms.Button();
			this.groupBoxVolume = new System.Windows.Forms.GroupBox();
			this.checkBoxVolumeMute = new System.Windows.Forms.CheckBox();
			this.checkBoxMouseExit = new System.Windows.Forms.CheckBox();
			this.buttonClose = new System.Windows.Forms.Button();
			this.openFileDialogChange = new System.Windows.Forms.OpenFileDialog();
			this.numericTimer = new System.Windows.Forms.NumericUpDown();
			this.checkBoxTimer = new System.Windows.Forms.CheckBox();
			this.labelTimer = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
			this.groupBoxVideoPath.SuspendLayout();
			this.groupBoxVolume.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericTimer)).BeginInit();
			this.SuspendLayout();
			// 
			// trackBarVolume
			// 
			this.trackBarVolume.Location = new System.Drawing.Point(5, 21);
			this.trackBarVolume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.trackBarVolume.Maximum = 100;
			this.trackBarVolume.Name = "trackBarVolume";
			this.trackBarVolume.Size = new System.Drawing.Size(484, 45);
			this.trackBarVolume.TabIndex = 2;
			this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
			// 
			// groupBoxVideoPath
			// 
			this.groupBoxVideoPath.Controls.Add(this.checkBoxConversion);
			this.groupBoxVideoPath.Controls.Add(this.textBoxStoredVideo);
			this.groupBoxVideoPath.Controls.Add(this.label1);
			this.groupBoxVideoPath.Controls.Add(this.buttonChange);
			this.groupBoxVideoPath.Location = new System.Drawing.Point(12, 14);
			this.groupBoxVideoPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBoxVideoPath.Name = "groupBoxVideoPath";
			this.groupBoxVideoPath.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBoxVideoPath.Size = new System.Drawing.Size(611, 86);
			this.groupBoxVideoPath.TabIndex = 3;
			this.groupBoxVideoPath.TabStop = false;
			this.groupBoxVideoPath.Text = "Video file";
			// 
			// checkBoxConversion
			// 
			this.checkBoxConversion.AutoSize = true;
			this.checkBoxConversion.Location = new System.Drawing.Point(10, 52);
			this.checkBoxConversion.Margin = new System.Windows.Forms.Padding(4);
			this.checkBoxConversion.Name = "checkBoxConversion";
			this.checkBoxConversion.Size = new System.Drawing.Size(256, 20);
			this.checkBoxConversion.TabIndex = 11;
			this.checkBoxConversion.Text = "Optimize new video for faster playback";
			this.checkBoxConversion.UseVisualStyleBackColor = true;
			// 
			// textBoxStoredVideo
			// 
			this.textBoxStoredVideo.Enabled = false;
			this.textBoxStoredVideo.Location = new System.Drawing.Point(121, 23);
			this.textBoxStoredVideo.Name = "textBoxStoredVideo";
			this.textBoxStoredVideo.Size = new System.Drawing.Size(385, 22);
			this.textBoxStoredVideo.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Stored video file:";
			// 
			// buttonChange
			// 
			this.buttonChange.Location = new System.Drawing.Point(512, 19);
			this.buttonChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonChange.Name = "buttonChange";
			this.buttonChange.Size = new System.Drawing.Size(93, 30);
			this.buttonChange.TabIndex = 1;
			this.buttonChange.Text = "Change";
			this.buttonChange.UseVisualStyleBackColor = true;
			this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
			// 
			// groupBoxVolume
			// 
			this.groupBoxVolume.Controls.Add(this.checkBoxVolumeMute);
			this.groupBoxVolume.Controls.Add(this.trackBarVolume);
			this.groupBoxVolume.Location = new System.Drawing.Point(12, 104);
			this.groupBoxVolume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBoxVolume.Name = "groupBoxVolume";
			this.groupBoxVolume.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBoxVolume.Size = new System.Drawing.Size(611, 79);
			this.groupBoxVolume.TabIndex = 4;
			this.groupBoxVolume.TabStop = false;
			this.groupBoxVolume.Text = "Volume";
			// 
			// checkBoxVolumeMute
			// 
			this.checkBoxVolumeMute.AutoSize = true;
			this.checkBoxVolumeMute.Location = new System.Drawing.Point(497, 22);
			this.checkBoxVolumeMute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.checkBoxVolumeMute.Name = "checkBoxVolumeMute";
			this.checkBoxVolumeMute.Size = new System.Drawing.Size(56, 20);
			this.checkBoxVolumeMute.TabIndex = 3;
			this.checkBoxVolumeMute.Text = "Mute";
			this.checkBoxVolumeMute.UseVisualStyleBackColor = true;
			this.checkBoxVolumeMute.CheckedChanged += new System.EventHandler(this.checkBoxVolumeMute_CheckedChanged);
			// 
			// checkBoxMouseExit
			// 
			this.checkBoxMouseExit.AutoSize = true;
			this.checkBoxMouseExit.Checked = true;
			this.checkBoxMouseExit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxMouseExit.Location = new System.Drawing.Point(12, 187);
			this.checkBoxMouseExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.checkBoxMouseExit.Name = "checkBoxMouseExit";
			this.checkBoxMouseExit.Size = new System.Drawing.Size(257, 20);
			this.checkBoxMouseExit.TabIndex = 5;
			this.checkBoxMouseExit.Text = "End screensaver on mouse movement";
			this.checkBoxMouseExit.UseVisualStyleBackColor = true;
			// 
			// buttonClose
			// 
			this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonClose.Location = new System.Drawing.Point(539, 266);
			this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(93, 30);
			this.buttonClose.TabIndex = 7;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// numericTimer
			// 
			this.numericTimer.Location = new System.Drawing.Point(189, 213);
			this.numericTimer.Margin = new System.Windows.Forms.Padding(4);
			this.numericTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericTimer.Name = "numericTimer";
			this.numericTimer.Size = new System.Drawing.Size(61, 22);
			this.numericTimer.TabIndex = 8;
			this.numericTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// checkBoxTimer
			// 
			this.checkBoxTimer.AutoSize = true;
			this.checkBoxTimer.Location = new System.Drawing.Point(12, 214);
			this.checkBoxTimer.Margin = new System.Windows.Forms.Padding(4);
			this.checkBoxTimer.Name = "checkBoxTimer";
			this.checkBoxTimer.Size = new System.Drawing.Size(161, 20);
			this.checkBoxTimer.TabIndex = 9;
			this.checkBoxTimer.Text = "End screensaver after:";
			this.checkBoxTimer.UseVisualStyleBackColor = true;
			this.checkBoxTimer.CheckedChanged += new System.EventHandler(this.checkBoxTimer_CheckedChanged);
			// 
			// labelTimer
			// 
			this.labelTimer.AutoSize = true;
			this.labelTimer.Location = new System.Drawing.Point(256, 215);
			this.labelTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelTimer.Name = "labelTimer";
			this.labelTimer.Size = new System.Drawing.Size(54, 16);
			this.labelTimer.TabIndex = 10;
			this.labelTimer.Text = "minutes";
			// 
			// ConfigForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonClose;
			this.ClientSize = new System.Drawing.Size(644, 307);
			this.Controls.Add(this.labelTimer);
			this.Controls.Add(this.checkBoxTimer);
			this.Controls.Add(this.numericTimer);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.checkBoxMouseExit);
			this.Controls.Add(this.groupBoxVolume);
			this.Controls.Add(this.groupBoxVideoPath);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.Name = "ConfigForm";
			this.Text = "Video Loop Screensaver";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
			this.groupBoxVideoPath.ResumeLayout(false);
			this.groupBoxVideoPath.PerformLayout();
			this.groupBoxVolume.ResumeLayout(false);
			this.groupBoxVolume.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericTimer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TrackBar trackBarVolume;
		private System.Windows.Forms.GroupBox groupBoxVideoPath;
		private System.Windows.Forms.GroupBox groupBoxVolume;
		private System.Windows.Forms.CheckBox checkBoxVolumeMute;
		private System.Windows.Forms.CheckBox checkBoxMouseExit;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.OpenFileDialog openFileDialogChange;
		private System.Windows.Forms.NumericUpDown numericTimer;
		private System.Windows.Forms.CheckBox checkBoxTimer;
		private System.Windows.Forms.Label labelTimer;
		private System.Windows.Forms.CheckBox checkBoxConversion;
		private System.Windows.Forms.TextBox textBoxStoredVideo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonChange;
	}
}