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

        public Server(string name, string ipAddress, int positionX, int positionY, bool isOnline, string operatingSystem, int ramGB, double storageTB, int uptimeDays) : base(name, ipAddress, positionX, positionY, isOnline, operatingSystem, ramGB)
        {
            this.storageTB = storageTB;
            this.uptimeDays = uptimeDays;
        }

        public override string GetDeviceType()
        {
            return "Server";
        }

        public override string GetDetails()
        {
            return $"{base.GetDetails()}, Storage TB: {storageTB}, Uptime days: {uptimeDays}";
        }

        public override string ToString()
        {
            return $"Name: {Name}, Device type: {GetDeviceType()}";
        }

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

        public override bool IsInside(int xP, int yP)
        {
            return (xP >= PositionX && xP <= PositionX + 40 && yP >= PositionY && yP <= PositionY + 60);
        }
    }
}