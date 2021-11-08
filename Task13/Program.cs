using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building();
            Console.WriteLine("Введите адрес: ");
            building.Address = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Задайте длину здания: ");
            building.Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Задайте ширину здания: ");
            building.Width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Задайтe высоту здания: ");
            building.Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Задайте этажность");
            MultiBuilding multiBuilding = new MultiBuilding(building.Address, building.Length, building.Width, building.Height, Convert.ToByte(Console.ReadLine()));
            multiBuilding.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        string address;
        double length;
        double width;
        double height;
        public void building(string address, double length, double width, double height)
        {
            this.address = address;
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public double Length
        {
            set
            {
                if (value > 0)
                {
                    this.length = value;
                }
                else
                {
                    Console.WriteLine("Неверное значение длины");
                }
            }
            get
            {
                return length;
            }
        }
        public double Width
        {
            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    Console.WriteLine("Неверное значение ширины");
                }
            }
            get
            {
                return width;
            }
        }
        public double Height
        {
            set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    Console.WriteLine("Неверное значение высоты");
                }
            }
            get
            {
                return height;
            }
        }
        public void Print()
        {
            Console.WriteLine("Информация о здании по адресу: {0}, длина - {1} м, ширина - {2} м, высота - {3} м", address, length, width, height);
        }
    }
    sealed class MultiBuilding : Building

    {
        byte floor;
        public MultiBuilding(string address, double length, double width, double height, byte floor)
        {
            this.floor = floor;
            base.Address = address;
            base.Length = length;
            base.Width = width;
            base.Height = height;
        }
        public byte Floor
        {
            set
            {
                if (value > 0)
                {
                    this.floor = value;
                }
                else
                {
                    Console.WriteLine("Неверное значение этажности");
                }
            }
            get
            {
                return floor;
            }
        }
        public new void Print()
        {
            Console.WriteLine("Информация о здании по адресу: {0}, длина - {1} м, ширина - {2} м, высота - {3} м, этажность - {4} этажа.", Address, Length, Width, Height, floor);
            Console.ReadKey();
        }
    }
}
