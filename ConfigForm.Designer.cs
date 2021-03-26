
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
			((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
			this.groupBoxVideoPath.SuspendLayout();
			this.groupBoxVolume.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxVideoPath
			// 
			this.textBoxVideoPath.Location = new System.Drawing.Point(6, 26);
			this.textBoxVideoPath.Name = "textBoxVideoPath";
			this.textBoxVideoPath.Size = new System.Drawing.Size(490, 27);
			this.textBoxVideoPath.TabIndex = 0;
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Location = new System.Drawing.Point(502, 26);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(94, 29);
			this.buttonBrowse.TabIndex = 1;
			this.buttonBrowse.Text = "Browse";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// trackBarVolume
			// 
			this.trackBarVolume.Location = new System.Drawing.Point(6, 26);
			this.trackBarVolume.Maximum = 100;
			this.trackBarVolume.Name = "trackBarVolume";
			this.trackBarVolume.Size = new System.Drawing.Size(484, 56);
			this.trackBarVolume.TabIndex = 2;
			this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
			// 
			// groupBoxVideoPath
			// 
			this.groupBoxVideoPath.Controls.Add(this.textBoxVideoPath);
			this.groupBoxVideoPath.Controls.Add(this.buttonBrowse);
			this.groupBoxVideoPath.Location = new System.Drawing.Point(12, 12);
			this.groupBoxVideoPath.Name = "groupBoxVideoPath";
			this.groupBoxVideoPath.Size = new System.Drawing.Size(611, 69);
			this.groupBoxVideoPath.TabIndex = 3;
			this.groupBoxVideoPath.TabStop = false;
			this.groupBoxVideoPath.Text = "Video file path";
			// 
			// groupBoxVolume
			// 
			this.groupBoxVolume.Controls.Add(this.checkBoxVolumeMute);
			this.groupBoxVolume.Controls.Add(this.trackBarVolume);
			this.groupBoxVolume.Location = new System.Drawing.Point(12, 87);
			this.groupBoxVolume.Name = "groupBoxVolume";
			this.groupBoxVolume.Size = new System.Drawing.Size(611, 90);
			this.groupBoxVolume.TabIndex = 4;
			this.groupBoxVolume.TabStop = false;
			this.groupBoxVolume.Text = "Volume";
			// 
			// checkBoxVolumeMute
			// 
			this.checkBoxVolumeMute.AutoSize = true;
			this.checkBoxVolumeMute.Location = new System.Drawing.Point(497, 27);
			this.checkBoxVolumeMute.Name = "checkBoxVolumeMute";
			this.checkBoxVolumeMute.Size = new System.Drawing.Size(65, 24);
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
			this.checkBoxMouseExit.Location = new System.Drawing.Point(12, 183);
			this.checkBoxMouseExit.Name = "checkBoxMouseExit";
			this.checkBoxMouseExit.Size = new System.Drawing.Size(280, 24);
			this.checkBoxMouseExit.TabIndex = 5;
			this.checkBoxMouseExit.Text = "End screensaver on mouse movement";
			this.checkBoxMouseExit.UseVisualStyleBackColor = true;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(429, 246);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(94, 29);
			this.buttonSave.TabIndex = 6;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(529, 246);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(94, 29);
			this.buttonCancel.TabIndex = 7;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// ConfigForm
			// 
			this.AcceptButton = this.buttonSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(644, 289);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.checkBoxMouseExit);
			this.Controls.Add(this.groupBoxVolume);
			this.Controls.Add(this.groupBoxVideoPath);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "ConfigForm";
			this.Text = "Configuration";
			((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
			this.groupBoxVideoPath.ResumeLayout(false);
			this.groupBoxVideoPath.PerformLayout();
			this.groupBoxVolume.ResumeLayout(false);
			this.groupBoxVolume.PerformLayout();
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
	}
}