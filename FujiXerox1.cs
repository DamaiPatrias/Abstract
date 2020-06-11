using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class FujiXerox1 : Mesin_Fotokopi
    {
        public override void Menduplikasi()
        {
            Console.WriteLine("Full Color");
            Console.WriteLine("Tunggu proses fotokopi selesai...");
        }
    }
}
