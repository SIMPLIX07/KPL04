// See https://aka.ms/new-console-template for more information
using Jurnal_MOD_04_103022300113;

Console.WriteLine($"Kode barang:  {KodeProduk.getBarang(KodeProduk.Barang.Laptop)}");

FanLaptop fanLaptop = new FanLaptop();
fanLaptop.proses();
//Console.WriteLine("Fan Lapto")
//Console.WriteLine($"Mode: {fanLaptop.proses(fanLaptop.kondisi.Quiet)}");