using DvdNamespace;
using FlashNamespace;
using HddNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vv
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash flash = new Flash
            {


                CapturedSize = 4,
                DiskSpeed = 5,
                Memory = 32,
                Model = " 3.0",
                Name = "USB"

            };

            Dvd dvd = new Dvd
            {
                CapturedSize = 4,
                Type = "birterefli",
                Model = "dvd",
                Name = "dvd"

            };
            Hdd hdd = new Hdd
            {
                Name = "USB",
                Model = "2.0",
                Speed = 0.5,
                Size = 7,
                CapturedSize = 4
            };
            hdd.Copy();
            flash.Copy();
            Console.WriteLine("about media");
            Console.WriteLine("HDD");
            hdd.PrintDeviceInfo();
            Console.WriteLine("DVD");
            dvd.PrintDeviceInfo();
            Console.WriteLine("Flash");
            flash.PrintDeviceInfo();

        }
    }
}
