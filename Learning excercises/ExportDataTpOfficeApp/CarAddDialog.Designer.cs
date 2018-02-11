namespace ExportDataTpOfficeApp
{
    partial class CarAddDialog
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
            this.cbCarType = new System.Windows.Forms.ComboBox();
            this.tbCarName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaxSpeed = new System.Windows.Forms.TextBox();
            this.tbCurrentSpeed = new System.Windows.Forms.TextBox();
            this.bmAddCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbCarType
            // 
            this.cbCarType.FormattingEnabled = true;
            this.cbCarType.Location = new System.Drawing.Point(33, 12);
            this.cbCarType.Name = "cbCarType";
            this.cbCarType.Size = new System.Drawing.Size(233, 21);
            this.cbCarType.TabIndex = 0;
            // 
            // tbCarName
            // 
            this.tbCarName.Location = new System.Drawing.Point(109, 39);
            this.tbCarName.Name = "tbCarName";
            this.tbCarName.Size = new System.Drawing.Size(157, 20);
            this.tbCarName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя машины";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Макс. скорость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Текущая скорость";
            // 
            // tbMaxSpeed
            // 
            this.tbMaxSpeed.Location = new System.Drawing.Point(140, 61);
            this.tbMaxSpeed.Name = "tbMaxSpeed";
            this.tbMaxSpeed.Size = new System.Drawing.Size(126, 20);
            this.tbMaxSpeed.TabIndex = 5;
            // 
            // tbCurrentSpeed
            // 
            this.tbCurrentSpeed.Location = new System.Drawing.Point(140, 87);
            this.tbCurrentSpeed.Name = "tbCurrentSpeed";
            this.tbCurrentSpeed.Size = new System.Drawing.Size(126, 20);
            this.tbCurrentSpeed.TabIndex = 6;
            // 
            // bmAddCar
            // 
            this.bmAddCar.Location = new System.Drawing.Point(140, 119);
            this.bmAddCar.Name = "bmAddCar";
            this.bmAddCar.Size = new System.Drawing.Size(126, 23);
            this.bmAddCar.TabIndex = 7;
            this.bmAddCar.Text = "Add car";
            this.bmAddCar.UseVisualStyleBackColor = true;
            this.bmAddCar.Click += new System.EventHandler(this.bmAddCar_Click);
            // 
            // CarAddDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 154);
            this.Controls.Add(this.bmAddCar);
            this.Controls.Add(this.tbCurrentSpeed);
            this.Controls.Add(this.tbMaxSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCarName);
            this.Controls.Add(this.cbCarType);
            this.Name = "CarAddDialog";
            this.Text = "CarAddDialog";
            this.Load += new System.EventHandler(this.CarAddDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCarType;
        private System.Windows.Forms.TextBox tbCarName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaxSpeed;
        private System.Windows.Forms.TextBox tbCurrentSpeed;
        private System.Windows.Forms.Button bmAddCar;
    }
}