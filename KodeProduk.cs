using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal_MOD_04_103022300113
{
    internal class KodeProduk
    {
        public enum Barang {Laptop, Smartphone, Tablet, Headset, Keyboard,
                Mouse, Printer, Monitor, Smartwatch, Kamera};
        

        public static string[] kode = { "E100", "E101", "E102", "E103",
            "E104", "E105", "E106", "E107", "E108", "E109" };

        public static string getBarang(Barang bar)
        {
            return kode[(int)bar];
        }

    }
}
