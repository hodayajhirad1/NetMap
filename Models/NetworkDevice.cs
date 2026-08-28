using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace NetMap.Models
{
    [Serializable]
    public abstract class NetworkDevice
    {
        private string name;
        private string ipAddress;
        private int positionX;
        private int positionY;
        private bool isOnline;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string IpAddress
        {
            get { return ipAddress; }
            set { ipAddress = value; }
        }

        public int PositionX
        {
            get { return positionX; }
            set { positionX = value; }
        }

        public int PositionY
        {
            get { return positionY; }
            set { positionY = value; }
        }

        public bool IsOnline
        {
            get { return isOnline; }
            set { isOnline = value; }
        }

        // Constructor with clear and renamed parameters
        public NetworkDevice(string devName, string devIp, int posX, int posY, bool onlineStatus)
        {
            this.name = devName;
            this.ipAddress = devIp;
            this.positionX = posX;
            this.positionY = posY;
            this.isOnline = onlineStatus;
        }

        // Returns the specific device type
        public abstract string GetDeviceType();

        // Draws the device on the graphic canvas
        public abstract void Draw(Graphics g);

        // Checks if mouse coordinates are inside the device boundaries
        public abstract bool IsInside(int xP, int yP);

        // Returns basic details of the device as a string
        public virtual string GetDetails()
        {
            return $"Name: {name}, IP: {ipAddress}, Online: {isOnline}";
        }

        // Returns string description of the device
        public override string ToString()
        {
            return $"Name: {name}, Device type: {GetDeviceType()} ";
        }
    }
}