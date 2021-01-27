using System;

namespace Metotlar
{
    class Program
    {  //Do not repeat yourself - DRY
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Kayısı";
            urun3.Fiyati = 20;
            urun3.Aciklama = "Malatya Kayısısı";

            Urun[] urunler = new Urun[] {urun1, urun2, urun3};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
            }
            Console.WriteLine("Metotlar......................");
            //İnstance - örnek
            //encapsulation - Kapsülleme
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
           
            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 10, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 80, 8);

        }
    }
}
