/*
 * Дата: 13.05.2018
 * Время: 20:17
 */
namespace SaveRestoreSettings_1C
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button SaveSettings;
		private System.Windows.Forms.Button RestoreSettings;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.SaveSettings = new System.Windows.Forms.Button();
			this.RestoreSettings = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// SaveSettings
			// 
			this.SaveSettings.Location = new System.Drawing.Point(13, 28);
			this.SaveSettings.Name = "SaveSettings";
			this.SaveSettings.Size = new System.Drawing.Size(220, 40);
			this.SaveSettings.TabIndex = 0;
			this.SaveSettings.Text = "Сохранить  настройки";
			this.SaveSettings.UseVisualStyleBackColor = true;
			this.SaveSettings.Click += new System.EventHandler(this.SaveSettingsClick);
			// 
			// RestoreSettings
			// 
			this.RestoreSettings.Location = new System.Drawing.Point(13, 74);
			this.RestoreSettings.Name = "RestoreSettings";
			this.RestoreSettings.Size = new System.Drawing.Size(220, 39);
			this.RestoreSettings.TabIndex = 1;
			this.RestoreSettings.Text = "Восстановить настройки";
			this.RestoreSettings.UseVisualStyleBackColor = true;
			this.RestoreSettings.Click += new System.EventHandler(this.RestoreSettingsClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(253, 134);
			this.Controls.Add(this.RestoreSettings);
			this.Controls.Add(this.SaveSettings);
			this.Name = "MainForm";
			this.Text = "Настройки 1С";
			this.ResumeLayout(false);

		}
	}
}
