
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
			this.textBoxVideoPath = new System.Windows.Forms.TextBox();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.trackBarVolume = new System.Windows.Forms.TrackBar();
			this.groupBoxVideoPath = new System.Windows.Forms.GroupBox();
			this.groupBoxVolume = new System.Windows.Forms.GroupBox();
			this.checkBoxVolumeMute = new System.Windows.Forms.CheckBox();
			this.checkBoxMouseExit = new System.Windows.Forms.CheckBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.numericTimer = new System.Windows.Forms.NumericUpDown();
			this.checkBoxTimer = new System.Windows.Forms.CheckBox();
			this.labelTimer = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
			this.groupBoxVideoPath.SuspendLayout();
			this.groupBoxVolume.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericTimer)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxVideoPath
			// 
			this.textBoxVideoPath.Location = new System.Drawing.Point(4, 17);
			this.textBoxVideoPath.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxVideoPath.Name = "textBoxVideoPath";
			this.textBoxVideoPath.Size = new System.Drawing.Size(368, 20);
			this.textBoxVideoPath.TabIndex = 0;
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Location = new System.Drawing.Point(376, 14);
			this.buttonBrowse.Margin = new System.Windows.Forms.Padding(2);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(70, 24);
			this.buttonBrowse.TabIndex = 1;
			this.buttonBrowse.Text = "Browse";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// trackBarVolume
			// 
			this.trackBarVolume.Location = new System.Drawing.Point(4, 17);
			this.trackBarVolume.Margin = new System.Windows.Forms.Padding(2);
			this.trackBarVolume.Maximum = 100;
			this.trackBarVolume.Name = "trackBarVolume";
			this.trackBarVolume.Size = new System.Drawing.Size(363, 45);
			this.trackBarVolume.TabIndex = 2;
			this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
			// 
			// groupBoxVideoPath
			// 
			this.groupBoxVideoPath.Controls.Add(this.textBoxVideoPath);
			this.groupBoxVideoPath.Controls.Add(this.buttonBrowse);
			this.groupBoxVideoPath.Location = new System.Drawing.Point(9, 8);
			this.groupBoxVideoPath.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxVideoPath.Name = "groupBoxVideoPath";
			this.groupBoxVideoPath.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxVideoPath.Size = new System.Drawing.Size(458, 47);
			this.groupBoxVideoPath.TabIndex = 3;
			this.groupBoxVideoPath.TabStop = false;
			this.groupBoxVideoPath.Text = "Video file path";
			// 
			// groupBoxVolume
			// 
			this.groupBoxVolume.Controls.Add(this.checkBoxVolumeMute);
			this.groupBoxVolume.Controls.Add(this.trackBarVolume);
			this.groupBoxVolume.Location = new System.Drawing.Point(9, 58);
			this.groupBoxVolume.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxVolume.Name = "groupBoxVolume";
			this.groupBoxVolume.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxVolume.Size = new System.Drawing.Size(458, 64);
			this.groupBoxVolume.TabIndex = 4;
			this.groupBoxVolume.TabStop = false;
			this.groupBoxVolume.Text = "Volume";
			// 
			// checkBoxVolumeMute
			// 
			this.checkBoxVolumeMute.AutoSize = true;
			this.checkBoxVolumeMute.Location = new System.Drawing.Point(373, 18);
			this.checkBoxVolumeMute.Margin = new System.Windows.Forms.Padding(2);
			this.checkBoxVolumeMute.Name = "checkBoxVolumeMute";
			this.checkBoxVolumeMute.Size = new System.Drawing.Size(50, 17);
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
			this.checkBoxMouseExit.Location = new System.Drawing.Point(9, 136);
			this.checkBoxMouseExit.Margin = new System.Windows.Forms.Padding(2);
			this.checkBoxMouseExit.Name = "checkBoxMouseExit";
			this.checkBoxMouseExit.Size = new System.Drawing.Size(207, 17);
			this.checkBoxMouseExit.TabIndex = 5;
			this.checkBoxMouseExit.Text = "End screensaver on mouse movement";
			this.checkBoxMouseExit.UseVisualStyleBackColor = true;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(322, 228);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(70, 24);
			this.buttonSave.TabIndex = 6;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(397, 228);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(70, 24);
			this.buttonCancel.TabIndex = 7;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// numericTimer
			// 
			this.numericTimer.Location = new System.Drawing.Point(142, 157);
			this.numericTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericTimer.Name = "numericTimer";
			this.numericTimer.Size = new System.Drawing.Size(46, 20);
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
			this.checkBoxTimer.Location = new System.Drawing.Point(9, 158);
			this.checkBoxTimer.Name = "checkBoxTimer";
			this.checkBoxTimer.Size = new System.Drawing.Size(133, 17);
			this.checkBoxTimer.TabIndex = 9;
			this.checkBoxTimer.Text = "End screensaver after:";
			this.checkBoxTimer.UseVisualStyleBackColor = true;
			this.checkBoxTimer.CheckedChanged += new System.EventHandler(this.checkBoxTimer_CheckedChanged);
			// 
			// labelTimer
			// 
			this.labelTimer.AutoSize = true;
			this.labelTimer.Location = new System.Drawing.Point(192, 159);
			this.labelTimer.Name = "labelTimer";
			this.labelTimer.Size = new System.Drawing.Size(43, 13);
			this.labelTimer.TabIndex = 10;
			this.labelTimer.Text = "minutes";
			// 
			// ConfigForm
			// 
			this.AcceptButton = this.buttonSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(483, 268);
			this.Controls.Add(this.labelTimer);
			this.Controls.Add(this.checkBoxTimer);
			this.Controls.Add(this.numericTimer);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.checkBoxMouseExit);
			this.Controls.Add(this.groupBoxVolume);
			this.Controls.Add(this.groupBoxVideoPath);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "ConfigForm";
			this.Text = "Video Loop Screensaver";
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

		private System.Windows.Forms.TextBox textBoxVideoPath;
		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.TrackBar trackBarVolume;
		private System.Windows.Forms.GroupBox groupBoxVideoPath;
		private System.Windows.Forms.GroupBox groupBoxVolume;
		private System.Windows.Forms.CheckBox checkBoxVolumeMute;
		private System.Windows.Forms.CheckBox checkBoxMouseExit;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.NumericUpDown numericTimer;
		private System.Windows.Forms.CheckBox checkBoxTimer;
		private System.Windows.Forms.Label labelTimer;
	}
}