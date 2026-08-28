using System;
using System.Collections;
using System.Drawing;
using NetMap.Models;

namespace NetMap
{
    [Serializable]
    public class DeviceCollection
    {
        private SortedList devices;
        private int nextKey;

        public DeviceCollection()
        {
            devices = new SortedList();
        }

        public int NextIndex
        {
            get { return devices.Count; }
        }

        public NetworkDevice this[int index]
        {
            get { return (NetworkDevice)devices.GetByIndex(index); }
            set { devices.SetByIndex(index, value); }
        }

        public void Add(NetworkDevice device)
        {
            devices.Add(nextKey, device);
            nextKey++;
            //devices.Add(NextIndex, device);
        }

        public void Remove(int index)
        {
            devices.RemoveAt(index);
        }

        public void DrawAll(Graphics g)
        {
            using (Pen linePen = new Pen(Color.DarkGray, 2))
            {
                for (int i = 0; i < devices.Count - 1; i++)
                {
                    NetworkDevice d1 = (NetworkDevice)devices.GetByIndex(i);
                    NetworkDevice d2 = (NetworkDevice)devices.GetByIndex(i + 1);
                    g.DrawLine(linePen, d1.PositionX, d1.PositionY, d2.PositionX, d2.PositionY);
                }
            }
            for (int i = 0; i < devices.Count; i++)
            {
                NetworkDevice device = (NetworkDevice)devices.GetByIndex(i);
                device.Draw(g);
            }
        }

        public int GetDeviceAt(int x, int y)
        {
            for (int i = 0; i < devices.Count; i++)
            {
                NetworkDevice device = (NetworkDevice)devices.GetByIndex(i);
                if (device.IsInside(x, y))
                    return i;
            }
            return -1;
        }
    }
}
