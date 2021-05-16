using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageNamespace
{
    public abstract class Storage
    {

        public string Name { get; set; }
        public string Model { get; set; }
        public double CapturedSize { get; set; }

        public abstract double Copy();
        public abstract double FreeMemory();
        public abstract void PrintDeviceInfo();
    }
}