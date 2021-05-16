using StorageNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashNamespace
{
    public class Flash : Storage
    {
        public double DiskSpeed { get; set; }
        public double Memory { get; set; }
        public override double Copy()
        {
            return (CapturedSize / DiskSpeed) / 3600;
        }

        public override double FreeMemory()
        {
            return Memory - CapturedSize;
        }





        public override void PrintDeviceInfo()
        {
            Console.WriteLine($"Model{Model }");
            Console.WriteLine($"Name{Name }");
            Console.WriteLine($"DiskSpeed{DiskSpeed  }");
            Console.WriteLine($"memory{Memory  }");
            Console.WriteLine($"captured size{CapturedSize   }");



        }
    }
}
