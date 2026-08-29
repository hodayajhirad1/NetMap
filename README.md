# NetMap - Network Topology Visualizer & Management System

A desktop management tool developed in **C#** and **.NET (WinForms)** for designing, mapping, and managing network devices in an interactive graphical environment.

---

## Key Features

* **Interactive Canvas:** Place, drag, and organize network devices across a visual topology workspace.
* **Device Hierarchy:** Supports multiple device types with tailored properties (Routers, Switches, Servers, Computers, Laptops).
* **State Management & Persistence:** Implements object serialization (`DeviceCollection`) to save, load, and manage network states efficiently.
* **OOP Architecture:** Built with core Object-Oriented Programming principles including inheritance, polymorphism, and modular class design.

---

## Tech Stack

* **Language:** C# (.NET Framework / .NET Core)
* **GUI Framework:** Windows Forms (WinForms)
* **Version Control:** Git & GitHub

---

## Project Structure

* `Models/` – Core domain entities (`NetworkDevice`, `Router`, `Server`, `Computer`, `Laptop`, `DeviceCollection`).
* `Forms/` / Root – Graphical interface forms (`Form1`, `DeviceForm`).
* `Program.cs` – Application entry point.

---

## How to Run

1. Clone the repository:
   ```bash
   git clone [https://github.com/hodayajhirad1/NetMap.git](https://github.com/hodayajhirad1/NetMap.git)