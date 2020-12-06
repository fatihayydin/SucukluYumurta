using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Metotlar
{
    public class SenkronMetotlar
    {
        public static void MasaHazırla()
        {
            Console.WriteLine("Masaya ekmek, peçete, çatal, bıçak koyuluyor");
            Thread.Sleep(45000);
            Console.WriteLine("Masaya ekmek, peçete, çatal, bıçak koyuldu");
        }

        public static void SucukDogra()
        {
            Console.WriteLine("Sucuklar doğranıyor");
            Thread.Sleep(45000);
            Console.WriteLine("Sucuklar doğrandı");
        }

        public static void KabiHazırla()
        {
            Console.WriteLine("Yumurtular kırılıyor, çırpılıyor, tuz ekleniyor");
            Thread.Sleep(45000);
            Console.WriteLine("Yumurtular kırıldı, çırpıldı, tuz eklendi");
        }

        public static void OcagiHazirla()
        {
            Console.WriteLine("Ocak yakılıyor, tava koyuluyor");
            Thread.Sleep(5000);
            Console.WriteLine("Ocak yakıldı, tava koyuldu");
        }
        public static void TavaBekle()
        {
            Console.WriteLine("Tavanın ısınması bekleniyor");
            Thread.Sleep(60000);
            Console.WriteLine("Tava ısındı");
        }
        public static void SucuklariDiz()
        {
            Console.WriteLine("Sucuklar diziliyor");
            Thread.Sleep(15000);
            Console.WriteLine("Sucuklar dizildi");
        }
        public static void KizarmasiniBekle(short yuz)
        {
            Console.WriteLine($"Sucukların {yuz}. yüzünün kızarması bekleniyor");
            Thread.Sleep(45000);
            Console.WriteLine($"Sucukların {yuz}. yüzü kızardı");
        }
        public static void TersCevir()
        {
            Console.WriteLine("Sucuklar ters çevriliyor");
            Thread.Sleep(15000);
            Console.WriteLine("Sucuklar ters çevrildi");
        }
        public static void KabiDok()
        {
            Console.WriteLine("Kap tavaya dökülüyor");
            Thread.Sleep(5000);
            Console.WriteLine("Kap tavaya döküldü");
        }
        public static void PismesiniBekle()
        {
            Console.WriteLine("Sucuklu yumurtanın pişmesi bekleniyor");
            Thread.Sleep(120000);
            Console.WriteLine("Sucuklu yumurta pişti");
        }
    }
}
