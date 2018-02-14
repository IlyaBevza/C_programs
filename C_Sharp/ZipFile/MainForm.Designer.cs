
namespace ZipFile
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
			this.labelTarget = new System.Windows.Forms.Label();
			this.tbTarget = new System.Windows.Forms.TextBox();
			this.bnSelectFile = new System.Windows.Forms.Button();
			this.bnZip = new System.Windows.Forms.Button();
			this.labelDest = new System.Windows.Forms.Label();
			this.tbDestination = new System.Windows.Forms.TextBox();
			this.bnSelectdestination = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelTarget
			// 
			this.labelTarget.Location = new System.Drawing.Point(0, 8);
			this.labelTarget.Name = "labelTarget";
			this.labelTarget.Size = new System.Drawing.Size(48, 24);
			this.labelTarget.TabIndex = 0;
			this.labelTarget.Text = "Папка";
			// 
			// tbTarget
			// 
			this.tbTarget.Location = new System.Drawing.Point(48, 8);
			this.tbTarget.Name = "tbTarget";
			this.tbTarget.Size = new System.Drawing.Size(392, 20);
			this.tbTarget.TabIndex = 1;
			this.tbTarget.TextChanged += new System.EventHandler(this.TbTarget_TextChanged);
			// 
			// bnSelectFile
			// 
			this.bnSelectFile.Location = new System.Drawing.Point(440, 8);
			this.bnSelectFile.Name = "bnSelectFile";
			this.bnSelectFile.Size = new System.Drawing.Size(24, 23);
			this.bnSelectFile.TabIndex = 2;
			this.bnSelectFile.Tag = "Выбрать файл";
			this.bnSelectFile.Text = "...";
			this.bnSelectFile.UseVisualStyleBackColor = true;
			this.bnSelectFile.Click += new System.EventHandler(this.BnSelectFile_Click);
			// 
			// bnZip
			// 
			this.bnZip.Location = new System.Drawing.Point(368, 72);
			this.bnZip.Name = "bnZip";
			this.bnZip.Size = new System.Drawing.Size(96, 23);
			this.bnZip.TabIndex = 3;
			this.bnZip.Text = "Архивировать";
			this.bnZip.UseVisualStyleBackColor = true;
			this.bnZip.Click += new System.EventHandler(this.BnZip_Click);
			// 
			// labelDest
			// 
			this.labelDest.Location = new System.Drawing.Point(0, 40);
			this.labelDest.Name = "labelDest";
			this.labelDest.Size = new System.Drawing.Size(48, 23);
			this.labelDest.TabIndex = 4;
			this.labelDest.Tag = "Место сохранения";
			this.labelDest.Text = "Dest";
			// 
			// tbDestination
			// 
			this.tbDestination.Location = new System.Drawing.Point(48, 40);
			this.tbDestination.Name = "tbDestination";
			this.tbDestination.Size = new System.Drawing.Size(392, 20);
			this.tbDestination.TabIndex = 5;
			// 
			// bnSelectdestination
			// 
			this.bnSelectdestination.Location = new System.Drawing.Point(440, 40);
			this.bnSelectdestination.Name = "bnSelectdestination";
			this.bnSelectdestination.Size = new System.Drawing.Size(24, 24);
			this.bnSelectdestination.TabIndex = 6;
			this.bnSelectdestination.Tag = "Выбрать место архивирования";
			this.bnSelectdestination.Text = "...";
			this.bnSelectdestination.UseVisualStyleBackColor = true;
			this.bnSelectdestination.Click += new System.EventHandler(this.BnSelectdestination_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 116);
			this.Controls.Add(this.bnSelectdestination);
			this.Controls.Add(this.tbDestination);
			this.Controls.Add(this.labelDest);
			this.Controls.Add(this.bnZip);
			this.Controls.Add(this.bnSelectFile);
			this.Controls.Add(this.tbTarget);
			this.Controls.Add(this.labelTarget);
			this.Name = "MainForm";
			this.Text = "ZipFile";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button bnSelectdestination;
		private System.Windows.Forms.TextBox tbDestination;
		private System.Windows.Forms.Label labelDest;
		private System.Windows.Forms.Button bnZip;
		private System.Windows.Forms.Button bnSelectFile;
		private System.Windows.Forms.TextBox tbTarget;
		private System.Windows.Forms.Label labelTarget;
	}
}
