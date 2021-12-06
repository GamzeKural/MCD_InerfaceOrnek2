using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_InerfaceOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //BLL -> Business Logic Layer
            //Manager olarak tanımlamamızın sebebi N-Tier Katmanlı Mimari dersine
            //şimden alışkanlık kazandırmaktır.

            ToplamaIslemYonetimi ToplamaManager = new ToplamaIslemYonetimi();
            CıkarmaIslemYonetimi CikarmaManager = new CıkarmaIslemYonetimi();
            BolmeIslemYonetimi BolmeManager = new BolmeIslemYonetimi();

            //interfaceleri tip olarak kullanabiliyoruz.
            IIslem[] Islemler = new IIslem[] { ToplamaManager, CikarmaManager, BolmeManager };

            foreach (var item in Islemler)
            {
                item.IslemAdınıGetir();
            }

            Console.WriteLine("\n");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim==(int)IslemTuru.Toplama)
            {
                ToplamaManager.IslemYap();
            }

            else if (secim==(int)IslemTuru.Cıkarma)
            {
                CikarmaManager.IslemYap();
            }

            else if (secim==(int)IslemTuru.Bolme)
            {
                BolmeManager.IslemYap();
            }
            else
            {
                Console.WriteLine("Hatalı giriş yapıldı.");
            }

            Console.ReadKey();
        }
    }
}
