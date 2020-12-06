using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Metotlar
{
    public class AsenkronMetotlar
    {
        public static async Task PismesiniBekleAsync()
        {
            Console.WriteLine("Sucuklu yumurtanın pişmesi bekleniyor");
            await Task.Run(() => Thread.Sleep(120000));
            Console.WriteLine("Sucuklu yumurta pişti");
        }

        public static async Task TavaBekleAsync()
        {
            Console.WriteLine("Tavanın ısınması bekleniyor");
            await Task.Run(() => Thread.Sleep(60000));
            Console.WriteLine("Tava ısındı");
        }
    }
}
