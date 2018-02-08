
namespace SQL_Backup
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.BaseName = new System.Windows.Forms.ComboBox();
			this.labelbase = new System.Windows.Forms.Label();
			this.labelbackUpdestination = new System.Windows.Forms.Label();
			this.tbBackupDestination = new System.Windows.Forms.TextBox();
			this.labelLogin = new System.Windows.Forms.Label();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.labelPassword = new System.Windows.Forms.Label();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.bCheckConnection = new System.Windows.Forms.Button();
			this.bMakeBackup = new System.Windows.Forms.Button();
			this.lServer = new System.Windows.Forms.Label();
			this.tbServer = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// BaseName
			// 
			this.BaseName.FormattingEnabled = true;
			this.BaseName.Items.AddRange(new object[] {
									"buh_promservis",
									"hrm_promservis",
									"bp_promservis"});
			this.BaseName.Location = new System.Drawing.Point(176, 16);
			this.BaseName.Name = "BaseName";
			this.BaseName.Size = new System.Drawing.Size(241, 21);
			this.BaseName.TabIndex = 0;
			this.BaseName.SelectedIndexChanged += new System.EventHandler(this.BaseName_SelectedIndexChanged);
			this.BaseName.TextUpdate += new System.EventHandler(this.BaseName_TextUpdate);
			// 
			// labelbase
			// 
			this.labelbase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelbase.Location = new System.Drawing.Point(16, 16);
			this.labelbase.Name = "labelbase";
			this.labelbase.Size = new System.Drawing.Size(100, 23);
			this.labelbase.TabIndex = 1;
			this.labelbase.Text = "Имя базы";
			// 
			// labelbackUpdestination
			// 
			this.labelbackUpdestination.Location = new System.Drawing.Point(16, 48);
			this.labelbackUpdestination.Name = "labelbackUpdestination";
			this.labelbackUpdestination.Size = new System.Drawing.Size(152, 23);
			this.labelbackUpdestination.TabIndex = 4;
			this.labelbackUpdestination.Text = "Место сохранения бэкапа";
			// 
			// tbBackupDestination
			// 
			this.tbBackupDestination.Location = new System.Drawing.Point(176, 48);
			this.tbBackupDestination.Name = "tbBackupDestination";
			this.tbBackupDestination.Size = new System.Drawing.Size(496, 20);
			this.tbBackupDestination.TabIndex = 5;
			// 
			// labelLogin
			// 
			this.labelLogin.Location = new System.Drawing.Point(24, 80);
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.Size = new System.Drawing.Size(100, 23);
			this.labelLogin.TabIndex = 6;
			this.labelLogin.Text = "Логин";
			// 
			// tbLogin
			// 
			this.tbLogin.Location = new System.Drawing.Point(136, 80);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(152, 20);
			this.tbLogin.TabIndex = 7;
			// 
			// labelPassword
			// 
			this.labelPassword.Location = new System.Drawing.Point(304, 80);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(100, 23);
			this.labelPassword.TabIndex = 8;
			this.labelPassword.Text = "Пароль";
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(416, 80);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(256, 20);
			this.tbPassword.TabIndex = 9;
			// 
			// bCheckConnection
			// 
			this.bCheckConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bCheckConnection.Location = new System.Drawing.Point(480, 120);
			this.bCheckConnection.Name = "bCheckConnection";
			this.bCheckConnection.Size = new System.Drawing.Size(200, 32);
			this.bCheckConnection.TabIndex = 10;
			this.bCheckConnection.Text = "Проверить подключение";
			this.bCheckConnection.UseVisualStyleBackColor = true;
			this.bCheckConnection.Click += new System.EventHandler(this.BCheckConnection_Click);
			// 
			// bMakeBackup
			// 
			this.bMakeBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bMakeBackup.Location = new System.Drawing.Point(48, 120);
			this.bMakeBackup.Name = "bMakeBackup";
			this.bMakeBackup.Size = new System.Drawing.Size(232, 31);
			this.bMakeBackup.TabIndex = 11;
			this.bMakeBackup.Text = "Сделать бэкап";
			this.bMakeBackup.UseVisualStyleBackColor = true;
			this.bMakeBackup.Click += new System.EventHandler(this.BMakeBackup_Click);
			// 
			// lServer
			// 
			this.lServer.Location = new System.Drawing.Point(434, 16);
			this.lServer.Name = "lServer";
			this.lServer.Size = new System.Drawing.Size(100, 23);
			this.lServer.TabIndex = 12;
			this.lServer.Text = "Сервер";
			// 
			// tbServer
			// 
			this.tbServer.Location = new System.Drawing.Point(498, 17);
			this.tbServer.Name = "tbServer";
			this.tbServer.Size = new System.Drawing.Size(174, 20);
			this.tbServer.TabIndex = 13;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(690, 170);
			this.Controls.Add(this.tbServer);
			this.Controls.Add(this.lServer);
			this.Controls.Add(this.bMakeBackup);
			this.Controls.Add(this.bCheckConnection);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.tbLogin);
			this.Controls.Add(this.labelLogin);
			this.Controls.Add(this.tbBackupDestination);
			this.Controls.Add(this.labelbackUpdestination);
			this.Controls.Add(this.labelbase);
			this.Controls.Add(this.BaseName);
			this.Name = "MainForm";
			this.Text = "SQL Backup";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button bMakeBackup;
		private System.Windows.Forms.Button bCheckConnection;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.Label labelLogin;
		private System.Windows.Forms.TextBox tbBackupDestination;
		private System.Windows.Forms.Label labelbackUpdestination;
		private System.Windows.Forms.Label labelbase;
		private System.Windows.Forms.ComboBox BaseName;
		private System.Windows.Forms.Label lServer;
		private System.Windows.Forms.TextBox tbServer;
	}
}
