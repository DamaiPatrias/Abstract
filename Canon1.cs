using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Canon1 : Mesin_Fotokopi
    {
        public override void Menduplikasi()
        {
            Console.WriteLine("Black and White");
            Console.WriteLine("Tunggu hingga proses fotokopi selesai...");
        }
    }
}
