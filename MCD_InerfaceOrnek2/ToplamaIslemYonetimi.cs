using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_InerfaceOrnek2
{
    public class ToplamaIslemYonetimi : Islem, IIslem
    {

        public void IslemAdınıGetir()
        {
            Console.WriteLine(IslemTur + "-->" ); 
        }

        public void IslemYap()
        {
            KullanicidanSayiAlveTopla();
        }

        private void KullanicidanSayiAlveTopla()
        {
            Console.WriteLine("Sayı1: ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı2: ");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı3: ");
            int s3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sonuç: " + (s1 + s2 + s3).ToString());
        }

        public ToplamaIslemYonetimi()
        {
            this.IslemTur = IslemTuru.Toplama;
        }
    }
}
