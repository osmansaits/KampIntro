﻿using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type safety - Tip güvenliği
            //Do not repeat yourself - Kendini tekrar etme
            //Değer tutucu = Alias

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayısı = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
           
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }
            

            
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);
        






        }
    }
}
