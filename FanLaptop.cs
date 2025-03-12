using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal_MOD_04_103022300113
{
    internal class FanLaptop
    {
        public enum state { Quiet, Balance, Performance, Turbo};
        public state kondisi;

        public FanLaptop()
        {
            kondisi = state.Quiet;
            Console.WriteLine("Dalam Mode Quiet");
        }

        public void proses()
        {
            String com = Console.ReadLine();
            while (com != "STOP")
            {
                switch (kondisi)
                {
                    case state.Quiet:
                        if (com == "Turbo shortcut")
                        {
                            kondisi = state.Turbo;
                            Console.WriteLine("Fan Quiet berubah menjadi turbo");
                             com = Console.ReadLine();
                        }
                        else if (com == "Mode up")
                        {
                            kondisi = state.Balance;
                            Console.WriteLine("Fan quiet berubah menjadi balanced");
                             com = Console.ReadLine();
                        }
                        break;

                    case state.Balance:
                        if (com == "Mode Up")
                        {
                            kondisi = state.Performance;
                            Console.WriteLine("Fan balance berubah menjadi performance");
                             com = Console.ReadLine();
                        }
                        else if (com == "Mode down")
                        {
                            kondisi = state.Quiet;
                            Console.WriteLine("Fan balance berubah menjadi quiet");
                             com = Console.ReadLine();
                        }
                        break;

                    case state.Performance:
                        if (com == "Mode Up")
                        {
                            kondisi = state.Turbo;
                            Console.WriteLine("Fan balance berubah menjadi turbo");
                             com = Console.ReadLine();
                        }
                        else if (com == "Mode down")
                        {
                            kondisi = state.Balance;
                            Console.WriteLine("Fan balance berubah menjadi balance");
                            com = Console.ReadLine();
                        }
                        break;
                    case state.Turbo:
                        if (com == "Turbo Shortcut")
                        {
                            kondisi = state.Quiet;
                            Console.WriteLine("Fan balance berubah menjadi performance");
                            com = Console.ReadLine();
                        }
                        else if (com == "Mode down")
                        {
                            kondisi = state.Performance;
                            Console.WriteLine("Fan balance berubah menjadi performance");
                            com = Console.ReadLine();
                        }
                        break;
                }
            }
        }
    }
}
