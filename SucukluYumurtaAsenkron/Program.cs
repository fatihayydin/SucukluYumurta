using Metotlar;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SucukluYumurtaAsenkron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Başlangıç zamanı: { DateTime.Now}");

            SenkronMetotlar.SucukDogra();
            SenkronMetotlar.OcagiHazirla();
            var tavaBeklemeTaski = AsenkronMetotlar.TavaBekleAsync();
            SenkronMetotlar.KabiHazırla();
            Task.WaitAll(tavaBeklemeTaski);
            SenkronMetotlar.SucuklariDiz();
            SenkronMetotlar.KizarmasiniBekle(1);
            SenkronMetotlar.TersCevir();
            SenkronMetotlar.KizarmasiniBekle(2);
            SenkronMetotlar.KabiDok();
            var pismesiniBeklemeTaski = AsenkronMetotlar.PismesiniBekleAsync();
            SenkronMetotlar.MasaHazırla();

            Task.WaitAll(pismesiniBeklemeTaski);
            Console.WriteLine($"Afiyet olsun. Bitiş zamanı: { DateTime.Now}");

            Console.ReadLine();
        }
    }
}
