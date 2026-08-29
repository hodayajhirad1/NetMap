using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace NetMap.Models
{
    [Serializable]
    public class Laptop : Computer
    {
        private int batteryLevel;

        public int BatteryLevel
        {
            get { return batteryLevel; }
            set
            {
                if (value < 0)
                    batteryLevel = 0;
                else if (value > 100)
                    batteryLevel = 100;
                else
                    batteryLevel = value;
            }
        }

        // Constructor passing parameters up to base classes with clear and renamed parameters
        public Laptop(string devName, string devIp, int posX, int posY, bool onlineStatus, string osName, int memoryRam, int battery)
            : base(devName, devIp, posX, posY, onlineStatus, osName, memoryRam)
        {
            this.batteryLevel = battery;
        }

        // Returns the device type as Laptop
        public override string GetDeviceType()
        {
            return "Laptop";
        }

        // Returns details including battery percentage information
        public override string GetDetails()
        {
            return $"{base.GetDetails()}, Battery: {batteryLevel}%";
        }

        // Returns string description of the laptop
        public override string ToString()
        {
            return $"Name: {Name}, Device type: {GetDeviceType()}";
        }

        // Draws the laptop graphical representation on the form canvas
        public override void Draw(Graphics g)
        {
            using (Pen statusPen = new Pen(IsOnline ? Color.Green : Color.Red, 4))
            {
                g.DrawRectangle(statusPen, PositionX - 3, PositionY - 38, 66, 81);
            }
            using (Brush brush = new SolidBrush(Color.Gray))
            {
                g.FillRectangle(brush, PositionX, PositionY, 60, 40);
                g.FillRectangle(brush, PositionX, PositionY - 35, 60, 30);
            }
            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.DrawRectangle(pen, PositionX, PositionY, 60, 40);
                g.DrawRectangle(pen, PositionX, PositionY - 35, 60, 30);
            }
            g.DrawString(Name, SystemFonts.DefaultFont, Brushes.Black, PositionX, PositionY + 45);
        }

        // Checks if mouse click coordinates hit the laptop shape boundaries
        public override bool IsInside(int xP, int yP)
        {
            return (xP >= PositionX && xP <= PositionX + 60 && yP >= PositionY - 35 && yP <= PositionY + 40);
        }
    }
}