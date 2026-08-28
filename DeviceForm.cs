using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetMap.Models;

namespace NetMap
{
    public partial class DeviceForm : Form
    {
        private NetworkDevice device;

        public DeviceForm(NetworkDevice device)
        {
            InitializeComponent();
            this.device = device;
            txtName.Text = device.Name;
            txtIP.Text = device.IpAddress;
            chkOnline.Checked = device.IsOnline;

            lblOS.Visible = false;
            txtOS.Visible = false;
            lblRamGB.Visible = false;
            txtRamGB.Visible = false;
            lblBattery.Visible = false;
            txtBattery.Visible = false;
            lblStorage.Visible = false;
            txtStorage.Visible = false;
            lblUptime.Visible = false;
            txtUptime.Visible = false;
            lblPorts.Visible = false;
            txtPorts.Visible = false;
            lblSpeed.Visible = false;
            txtSpeed.Visible = false;

            if (device is Laptop lap)
            {
                lblOS.Visible = true;
                txtOS.Visible = true;
                lblRamGB.Visible = true;
                txtRamGB.Visible = true;
                lblBattery.Visible = true;
                txtBattery.Visible = true;

                txtOS.Text = lap.OperatingSystem;
                txtRamGB.Text = lap.RamGB.ToString();
                txtBattery.Text = lap.BatteryLevel.ToString();
            }

            else if (device is Server ser)
            {
                lblOS.Visible = true;
                txtOS.Visible = true;
                lblRamGB.Visible = true;
                txtRamGB.Visible = true;
                lblStorage.Visible = true;
                txtStorage.Visible = true;
                lblUptime.Visible = true;
                txtUptime.Visible = true;

                txtOS.Text = ser.OperatingSystem;
                txtRamGB.Text = ser.RamGB.ToString();
                txtStorage.Text = ser.StorageTB.ToString();
                txtUptime.Text = ser.UptimeDays.ToString();
            }

            else if (device is Router r)
            {
                lblPorts.Visible = true;
                txtPorts.Visible = true;
                lblSpeed.Visible = true;
                txtSpeed.Visible = true;

                txtPorts.Text = r.NumberOfPorts.ToString();
                txtSpeed.Text = r.SpeedMbps.ToString();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            device.Name = txtName.Text;
            device.IpAddress = txtIP.Text;
            device.IsOnline = chkOnline.Checked;

            if (device is Laptop lap)
            {
                lap.OperatingSystem = txtOS.Text;
                lap.RamGB = int.Parse(txtRamGB.Text);
                lap.BatteryLevel = int.Parse(txtBattery.Text);
            }
            else if (device is Server ser)
            {
                ser.OperatingSystem = txtOS.Text;
                ser.RamGB = int.Parse(txtRamGB.Text);
                ser.StorageTB = double.Parse(txtStorage.Text);
                ser.UptimeDays = int.Parse(txtUptime.Text);
            }
            else if (device is Router r)
            {
                r.NumberOfPorts = int.Parse(txtPorts.Text);
                r.SpeedMbps = int.Parse(txtSpeed.Text);
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
