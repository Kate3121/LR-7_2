using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_7_2
{
    internal class hard_drive
    {
        // Поля класу
        public string Manufacturer { get; set; }//виробник жорсткого диска
        public string Model { get; set; }//модель жорсткого диска
        public double CapacityGB { get; set; }//обсяг жорсткого диска у гігабайтах.
        public string Interfacetype { get; set; }//тип інтерфейсу
        public int Rpm { get; set; }//кількість обертів за хвилину
        public double Price { get; set; }//ціна
        public bool IsSSD { get; set; }// чи є жорсткий диск SSD

        public hard_drive() { }

        public hard_drive(string manufacturer, string model, double capacityGB,
            string interfacetype, int rpm, double price, bool isSSD)
        {
            // Поля класу
            Manufacturer = manufacturer;//виробник жорсткого диска
            Model = model;//модель жорсткого диска
            CapacityGB = capacityGB;//обсяг жорсткого диска у гігабайтах.
            Interfacetype = interfacetype;//тип інтерфейсу
            Rpm = rpm;//кількість обертів за хвилину
            Price = price;//ціна
            IsSSD = isSSD;// чи є жорсткий диск SSD
        }
    }  
}

