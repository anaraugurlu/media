using StorageNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HddNamespace
{
    public class Hdd : Storage
    {
        public double Speed { get; set; }
        public double Size { get; set; }

        public override double Copy()
        {
            return (CapturedSize / Speed) / 3600;
        }

        public override double FreeMemory()
        {
            return Size - CapturedSize;
        }



        public override void PrintDeviceInfo()
        {
            Console.WriteLine($"Model{Model }");
            Console.WriteLine($"Name{Name }");
            Console.WriteLine($"DiskSpeed{Speed   }");
            Console.WriteLine($"size{Size   }");
            Console.WriteLine($"captured size{CapturedSize   }");
        }
    }
}