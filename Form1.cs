using NetMap.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace NetMap
{
    public partial class Form1 : Form
    {
        DeviceCollection devices;
        int selectedIndex = -1;
        bool isDragging = false;
        int futureKind = 0;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            devices = new DeviceCollection();
            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "NetMap files (*.nmp)|*.nmp";

            if(sfd.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, devices);
                fs.Close();
                this.Text = "NetMap - " + Path.GetFileName(sfd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "NetMap files (*.nmp)|*.nmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                devices = (DeviceCollection)bf.Deserialize(fs);
                fs.Close();
                pictureBox1.Invalidate();
                UpdateStatus();
                this.Text = "NetMap - " + Path.GetFileName(ofd.FileName);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            futureKind = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            futureKind = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            futureKind = 2;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            devices.DrawAll(e.Graphics);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int index = devices.GetDeviceAt(e.X, e.Y);

            if (e.Button == MouseButtons.Right && index != -1)
            {
                devices.Remove(index);
                selectedIndex = -1;
                pictureBox1.Invalidate();
                UpdateStatus();
            }

            else if(e.Button==MouseButtons.Left)
            {
                if (index != -1)
                {
                    selectedIndex = index;
                    isDragging = true;
                    lblStatus.Text = devices[selectedIndex].GetDetails();
                }

                else
                {
                    switch (futureKind)
                    {
                        case 0:
                            devices.Add(new Laptop("Device" + devices.NextIndex, rnd.Next(1, 255) + "." + rnd.Next(1, 255) + "." + rnd.Next(1, 255) + "." + rnd.Next(1, 255), e.X, e.Y, rnd.Next(2) == 1, "Windows", 8, 100));
                            pictureBox1.Invalidate();
                            UpdateStatus();
                            break;

                        case 1:
                            devices.Add(new Server("Device" + devices.NextIndex, rnd.Next(1, 255) + "." + rnd.Next(1, 255) + "." + rnd.Next(1, 255) + "." + rnd.Next(1, 255), e.X, e.Y, rnd.Next(2) == 1, "Linux", 16, 1.0, 0));
                            pictureBox1.Invalidate();
                            UpdateStatus();
                            break;

                        case 2:
                            devices.Add(new Router("Device" + devices.NextIndex, rnd.Next(1, 255) + "." + rnd.Next(1, 255) + "." + rnd.Next(1, 255) + "." + rnd.Next(1, 255), e.X, e.Y, rnd.Next(2) == 1, 4, 100));
                            pictureBox1.Invalidate();
                            UpdateStatus();
                            break;
                    }
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                devices[selectedIndex].PositionX = e.X;
                devices[selectedIndex].PositionY = e.Y;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void UpdateStatus()
        {
            lblStatus.Text = "Devices: " + devices.NextIndex;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && selectedIndex != -1)
            {
                devices.Remove(selectedIndex);
                selectedIndex = -1;
                pictureBox1.Invalidate();
                UpdateStatus();
            }
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = devices.GetDeviceAt(e.X, e.Y);
            if (index != -1)
            {
                DeviceForm df = new DeviceForm(devices[index]);
                df.ShowDialog();
                pictureBox1.Invalidate();
            }
        }
    }
}
