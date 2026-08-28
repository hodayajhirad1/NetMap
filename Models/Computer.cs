using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace NetMap.Models
{
    [Serializable]
    public abstract class Computer : NetworkDevice
    {
        private string operatingSystem;
        private int ramGB;

        public string OperatingSystem
        {
            get { return operatingSystem; }
            set { operatingSystem = value; }
        }

        public int RamGB
        {
            get { return ramGB; }
            set { ramGB = value; }
        }

        public Computer(string name, string ipAddress, int positionX, int positionY, bool isOnline, string operatingSystem, int ramGB):base(name, ipAddress, positionX, positionY, isOnline)
        {
            this.operatingSystem = operatingSystem;
            this.ramGB = ramGB;
        }

        public override string GetDeviceType()
        {
            return "Computer";
        }

        public override string GetDetails()
        {
            return $"{base.GetDetails()}, OS: {operatingSystem}, RAM GB: {ramGB}";
        }

        public override string ToString()
        {
            return $"Name: {Name}, Device type: {GetDeviceType()}";
        }
    }
}