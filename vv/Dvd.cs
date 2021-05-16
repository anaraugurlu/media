using StorageNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvdNamespace
{
    public class Dvd : Storage
    {
        public double ReadWriteSpeed { get; set; }
        public string Type { get; set; }
        public override double Copy()
        {
            return (CapturedSize / ReadWriteSpeed) / 3600;
        }

        public override double FreeMemory()
        {
            if (Type == "birterefli")
            {
                return 4.7 - CapturedSize;
            }
            else if (Type == "ikiterefli")
            {
                return 9.0 - CapturedSize;
            }
            return 0;
        }



        public override void PrintDeviceInfo()
        {


            Console.WriteLine($"Model{Model }");
            Console.WriteLine($"Name{Name }");
            Console.WriteLine($"DiskSpeed{ReadWriteSpeed   }");
            Console.WriteLine($"type{Type   }");
            Console.WriteLine($"captured size{CapturedSize   }");
        }
    }
}