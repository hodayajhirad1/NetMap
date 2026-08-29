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

        // Constructor initializes the sorted list for storing devices
        public DeviceCollection()
        {
            devices = new SortedList();
        }

        // Returns the total count of devices in the collection
        public int NextIndex
        {
            get { return devices.Count; }
        }

        // Indexer to get or set a device by its index position
        public NetworkDevice this[int index]
        {
            get { return (NetworkDevice)devices.GetByIndex(index); }
            set { devices.SetByIndex(index, value); }
        }

        // Adds a new network device to the collection using a unique key
        public void Add(NetworkDevice device)
        {
            devices.Add(nextKey, device);
            nextKey++;
        }

        // Removes a device from the collection at a specific index
        public void Remove(int index)
        {
            devices.RemoveAt(index);
        }

        // Draws all network devices and the connection lines between them polymorphically
        public void DrawAll(Graphics g)
        {
            // Draw connection lines between consecutive devices
            using (Pen linePen = new Pen(Color.DarkGray, 2))
            {
                for (int i = 0; i < devices.Count - 1; i++)
                {
                    NetworkDevice d1 = (NetworkDevice)devices.GetByIndex(i);
                    NetworkDevice d2 = (NetworkDevice)devices.GetByIndex(i + 1);
                    g.DrawLine(linePen, d1.PositionX, d1.PositionY, d2.PositionX, d2.PositionY);
                }
            }

            // Draw each individual device using polymorphic Draw method
            for (int i = 0; i < devices.Count; i++)
            {
                NetworkDevice device = (NetworkDevice)devices.GetByIndex(i);
                device.Draw(g);
            }
        }

        // Finds and returns the index of a device clicked by mouse coordinates, or -1 if not found
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