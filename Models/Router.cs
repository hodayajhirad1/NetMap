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

        public Router(string name, string ipAddress, int positionX, int positionY, bool isOnline, int numberOfPorts, int speedMbps) : base(name, ipAddress, positionX, positionY, isOnline)
        {
            this.numberOfPorts = numberOfPorts;
            this.speedMbps = speedMbps;
        }

        public override string GetDetails()
        {
            return $"{base.GetDetails()}, Number of ports: {numberOfPorts}, Speed in Mbps: {speedMbps}";
        }

        public override string GetDeviceType()
        {
            return "Router";
        }

        public override string ToString()
        {
            return $"Name: {Name}, Device type: {GetDeviceType()}";
        }

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

        public override bool IsInside(int xP, int yP)
        {
            return (xP >= PositionX && xP <= PositionX + 50 && yP >= PositionY && yP <= PositionY + 50);
        }
    }
}
