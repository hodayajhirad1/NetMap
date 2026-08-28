namespace NetMap
{
    partial class DeviceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.chkOnline = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblOS = new System.Windows.Forms.Label();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.lblRamGB = new System.Windows.Forms.Label();
            this.txtRamGB = new System.Windows.Forms.TextBox();
            this.lblBattery = new System.Windows.Forms.Label();
            this.lblStorage = new System.Windows.Forms.Label();
            this.lblUptime = new System.Windows.Forms.Label();
            this.lblPorts = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.txtBattery = new System.Windows.Forms.TextBox();
            this.txtStorage = new System.Windows.Forms.TextBox();
            this.txtUptime = new System.Windows.Forms.TextBox();
            this.txtPorts = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 26);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP Address:\n";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(110, 52);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(154, 26);
            this.txtIP.TabIndex = 3;
            // 
            // chkOnline
            // 
            this.chkOnline.AutoSize = true;
            this.chkOnline.Location = new System.Drawing.Point(17, 94);
            this.chkOnline.Name = "chkOnline";
            this.chkOnline.Size = new System.Drawing.Size(80, 24);
            this.chkOnline.TabIndex = 4;
            this.chkOnline.Text = "Online";
            this.chkOnline.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 431);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(110, 431);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 31);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Location = new System.Drawing.Point(13, 131);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(36, 20);
            this.lblOS.TabIndex = 7;
            this.lblOS.Text = "OS:";
            // 
            // txtOS
            // 
            this.txtOS.Location = new System.Drawing.Point(55, 128);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(181, 26);
            this.txtOS.TabIndex = 8;
            // 
            // lblRamGB
            // 
            this.lblRamGB.AutoSize = true;
            this.lblRamGB.Location = new System.Drawing.Point(13, 174);
            this.lblRamGB.Name = "lblRamGB";
            this.lblRamGB.Size = new System.Drawing.Size(87, 20);
            this.lblRamGB.TabIndex = 9;
            this.lblRamGB.Text = "RAM (GB):";
            // 
            // txtRamGB
            // 
            this.txtRamGB.Location = new System.Drawing.Point(106, 171);
            this.txtRamGB.Name = "txtRamGB";
            this.txtRamGB.Size = new System.Drawing.Size(130, 26);
            this.txtRamGB.TabIndex = 10;
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.Location = new System.Drawing.Point(13, 217);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(92, 20);
            this.lblBattery.TabIndex = 11;
            this.lblBattery.Text = "Battery (%):";
            // 
            // lblStorage
            // 
            this.lblStorage.AutoSize = true;
            this.lblStorage.Location = new System.Drawing.Point(13, 260);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Size = new System.Drawing.Size(104, 20);
            this.lblStorage.TabIndex = 12;
            this.lblStorage.Text = "Storage (TB):";
            // 
            // lblUptime
            // 
            this.lblUptime.AutoSize = true;
            this.lblUptime.Location = new System.Drawing.Point(13, 299);
            this.lblUptime.Name = "lblUptime";
            this.lblUptime.Size = new System.Drawing.Size(114, 20);
            this.lblUptime.TabIndex = 13;
            this.lblUptime.Text = "Uptime (Days):";
            // 
            // lblPorts
            // 
            this.lblPorts.AutoSize = true;
            this.lblPorts.Location = new System.Drawing.Point(12, 339);
            this.lblPorts.Name = "lblPorts";
            this.lblPorts.Size = new System.Drawing.Size(50, 20);
            this.lblPorts.TabIndex = 14;
            this.lblPorts.Text = "Ports:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(12, 378);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(113, 20);
            this.lblSpeed.TabIndex = 15;
            this.lblSpeed.Text = "Speed (Mbps):";
            // 
            // txtBattery
            // 
            this.txtBattery.Location = new System.Drawing.Point(110, 214);
            this.txtBattery.Name = "txtBattery";
            this.txtBattery.Size = new System.Drawing.Size(126, 26);
            this.txtBattery.TabIndex = 16;
            // 
            // txtStorage
            // 
            this.txtStorage.Location = new System.Drawing.Point(123, 257);
            this.txtStorage.Name = "txtStorage";
            this.txtStorage.Size = new System.Drawing.Size(113, 26);
            this.txtStorage.TabIndex = 17;
            // 
            // txtUptime
            // 
            this.txtUptime.Location = new System.Drawing.Point(133, 296);
            this.txtUptime.Name = "txtUptime";
            this.txtUptime.Size = new System.Drawing.Size(103, 26);
            this.txtUptime.TabIndex = 18;
            // 
            // txtPorts
            // 
            this.txtPorts.Location = new System.Drawing.Point(68, 336);
            this.txtPorts.Name = "txtPorts";
            this.txtPorts.Size = new System.Drawing.Size(168, 26);
            this.txtPorts.TabIndex = 19;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(131, 375);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(105, 26);
            this.txtSpeed.TabIndex = 20;
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 474);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtPorts);
            this.Controls.Add(this.txtUptime);
            this.Controls.Add(this.txtStorage);
            this.Controls.Add(this.txtBattery);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblPorts);
            this.Controls.Add(this.lblUptime);
            this.Controls.Add(this.lblStorage);
            this.Controls.Add(this.lblBattery);
            this.Controls.Add(this.txtRamGB);
            this.Controls.Add(this.lblRamGB);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.lblOS);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkOnline);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "DeviceForm";
            this.Text = "DeviceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.CheckBox chkOnline;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Label lblRamGB;
        private System.Windows.Forms.TextBox txtRamGB;
        private System.Windows.Forms.Label lblBattery;
        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.Label lblUptime;
        private System.Windows.Forms.Label lblPorts;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TextBox txtBattery;
        private System.Windows.Forms.TextBox txtStorage;
        private System.Windows.Forms.TextBox txtUptime;
        private System.Windows.Forms.TextBox txtPorts;
        private System.Windows.Forms.TextBox txtSpeed;
    }
}