using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Canon2 : IMesin_Fotokopi
    {
        public void duplikasi()
        {
            Console.WriteLine("Black and White");
            Console.WriteLine("Tunggu hingga proses fotokopi selesai...");
        }
    }
}
