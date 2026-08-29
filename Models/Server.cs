using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace NetMap.Models
{
    [Serializable]
    public class Server : Computer
    {
        private double storageTB;
        private int uptimeDays;

        public double StorageTB
        {
            get { return storageTB; }
            set { storageTB = value; }
        }

        public int UptimeDays
        {
            get { return uptimeDays; }
            set { uptimeDays = value; }
        }

        // Constructor passing parameters up to Computer/NetworkDevice base classes and setting server fields cleanly
        public Server(string devName, string devIp, int posX, int posY, bool onlineStatus, string osName, int memoryRam, double storage, int uptime)
            : base(devName, devIp, posX, posY, onlineStatus, osName, memoryRam)
        {
            this.storageTB = storage;
            this.uptimeDays = uptime;
        }

        // Returns the device type as Server
        public override string GetDeviceType()
        {
            return "Server";
        }

        // Returns details including storage capacity and uptime days information
        public override string GetDetails()
        {
            return $"{base.GetDetails()}, Storage TB: {storageTB}, Uptime days: {uptimeDays}";
        }

        // Returns string description of the server
        public override string ToString()
        {
            return $"Name: {Name}, Device type: {GetDeviceType()}";
        }

        // Draws the server graphical representation (steel blue rectangle) on the canvas
        public override void Draw(Graphics g)
        {
            using (Pen statusPen = new Pen(IsOnline ? Color.Green : Color.Red, 4))
            {
                g.DrawRectangle(statusPen, PositionX - 3, PositionY - 3, 46, 66);
            }
            using (Brush brush = new SolidBrush(Color.SteelBlue))
            {
                g.FillRectangle(brush, PositionX, PositionY, 40, 60);
            }
            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.DrawRectangle(pen, PositionX, PositionY, 40, 60);
            }
            g.DrawString(Name, SystemFonts.DefaultFont, Brushes.Black, PositionX, PositionY + 65);
        }

        // Checks if mouse click coordinates hit the server shape boundaries
        public override bool IsInside(int xP, int yP)
        {
            return (xP >= PositionX && xP <= PositionX + 40 && yP >= PositionY && yP <= PositionY + 60);
        }
    }
}