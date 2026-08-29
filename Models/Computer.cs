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

        // Constructor passing parameters up to base class and setting computer fields
        public Computer(string devName, string devIp, int posX, int posY, bool onlineStatus, string osName, int memoryRam)
            : base(devName, devIp, posX, posY, onlineStatus)
        {
            this.operatingSystem = osName;
            this.ramGB = memoryRam;
        }

        // Returns the device type as Computer
        public override string GetDeviceType()
        {
            return "Computer";
        }

        // Returns details including OS and RAM information
        public override string GetDetails()
        {
            return $"{base.GetDetails()}, OS: {operatingSystem}, RAM GB: {ramGB}";
        }

        // Returns string representation of the computer
        public override string ToString()
        {
            return $"Name: {Name}, Device type: {GetDeviceType()}";
        }
    }
}