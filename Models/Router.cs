using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace NetMap.Models
{
    [Serializable]
    public class Router : NetworkDevice
    {
        private int numberOfPorts;
        private int speedMbps;

        public int NumberOfPorts
        {
            get { return numberOfPorts; }
            set { numberOfPorts = value; }
        }

        public int SpeedMbps
        {
            get { return speedMbps; }
            set { speedMbps = value; }
        }

        // Constructor passing parameters up to base class and setting router fields cleanly
        public Router(string devName, string devIp, int posX, int posY, bool onlineStatus, int portsCount, int speed)
            : base(devName, devIp, posX, posY, onlineStatus)
        {
            this.numberOfPorts = portsCount;
            this.speedMbps = speed;
        }

        // Returns details including ports count and speed information
        public override string GetDetails()
        {
            return $"{base.GetDetails()}, Number of ports: {numberOfPorts}, Speed in Mbps: {speedMbps}";
        }

        // Returns the device type as Router
        public override string GetDeviceType()
        {
            return "Router";
        }

        // Returns string description of the router
        public override string ToString()
        {
            return $"Name: {Name}, Device type: {GetDeviceType()}";
        }

        // Draws the router graphical representation (orange circle) on the canvas
        public override void Draw(Graphics g)
        {
            using (Pen statusPen = new Pen(IsOnline ? Color.Green : Color.Red, 4))
            {
                g.DrawEllipse(statusPen, PositionX - 3, PositionY - 3, 56, 56);
            }
            using (Brush brush = new SolidBrush(Color.Orange))
            {
                g.FillEllipse(brush, PositionX, PositionY, 50, 50);
            }
            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.DrawEllipse(pen, PositionX, PositionY, 50, 50);
            }
            g.DrawString(Name, SystemFonts.DefaultFont, Brushes.Black, PositionX, PositionY + 55);
        }

        // Checks if mouse click coordinates hit the router shape boundaries
        public override bool IsInside(int xP, int yP)
        {
            return (xP >= PositionX && xP <= PositionX + 50 && yP >= PositionY && yP <= PositionY + 50);
        }
    }
}