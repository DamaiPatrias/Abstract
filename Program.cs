using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.AbstractClass;
using Abstraction.Interface;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Pilih Mesin fotokopi :");
            Console.WriteLine("1. Canon (HitamPutih)");
            Console.WriteLine("2. FujiXerox (Berwarna)\n");

            Console.Write("Pilih Nomer[1, 2] : ");
            int jeniskamr = Convert.ToInt32(Console.ReadLine());

            Mesin_Fotokopi fotokopi1;
            IMesin_Fotokopi fotokopi2;

            if (jeniskamr == 1)
            {
                Console.WriteLine("Menggunakan AbstractClass");
                fotokopi1 = new Canon1();
                fotokopi1.Menduplikasi();
                Console.WriteLine("\nMenggunakan Interface");
                fotokopi2 = new Canon2();
                fotokopi2.duplikasi();
            }  
            else if (jeniskamr == 2)
            {
                Console.WriteLine("Menggunakan AbstractClass");
                fotokopi1 = new FujiXerox1();
                fotokopi1.Menduplikasi();
                Console.WriteLine("\nMenggunakan Interface");
                fotokopi2 = new FujiXerox2();
                fotokopi2.duplikasi();
            }
            else
            {
                Console.WriteLine("Pilihan tidak ada..!");
            }
                Console.ReadKey();
        }
    }
}
