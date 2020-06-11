using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class FujiXerox2 : IMesin_Fotokopi
    {
        public void duplikasi()
        {
            Console.WriteLine("Full Color");
            Console.WriteLine("Tunggu proses fotokopi selesai...");
        }
    }
}
