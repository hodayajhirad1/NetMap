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

        public NetworkDevice(string name, string ipAddress, int positionX, int positionY, bool isOnline)
        {
            this.name = name;
            this.ipAddress = ipAddress;
            this.positionX = positionX;
            this.positionY = positionY;
            this.isOnline = isOnline;
        }

        public abstract string GetDeviceType();

        public abstract void Draw(Graphics g);

        public abstract bool IsInside(int xP, int yP);

        public virtual string GetDetails()
        {
            return $"Name: {name}, IP: {ipAddress}, Online: {isOnline}";
        }

        public override string ToString()
        {
            return $"Name: {name}, Device type: {GetDeviceType()} ";
        }
    }
}