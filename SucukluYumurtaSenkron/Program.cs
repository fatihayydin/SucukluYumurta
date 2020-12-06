using Metotlar;
using System;
using System.Threading;

namespace SucukluYumurtaSenkron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Başlangıç zamanı: { DateTime.Now}");

            SenkronMetotlar.MasaHazırla();
            SenkronMetotlar.SucukDogra();
            SenkronMetotlar.KabiHazırla();
            SenkronMetotlar.OcagiHazirla();
            SenkronMetotlar.TavaBekle();
            SenkronMetotlar.SucuklariDiz();
            SenkronMetotlar.KizarmasiniBekle(1);
            SenkronMetotlar.TersCevir();
            SenkronMetotlar.KizarmasiniBekle(2);
            SenkronMetotlar.KabiDok();
            SenkronMetotlar.PismesiniBekle();

            Console.WriteLine($"Afiyet olsun. Bitiş zamanı: { DateTime.Now}");

            Console.ReadLine();
        }
    }
}
