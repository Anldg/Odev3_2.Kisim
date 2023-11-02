using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VadesizHesap vadesizHesap = new VadesizHesap();
            TasarrufHesabı tasarrufHesabı = new TasarrufHesabı();            
            Console.Write("Hesap Adını giriniz:");
            string hesapAdi = Console.ReadLine();
            Console.Write("Hesap Adresini giriniz:");
            string hesapId = Convert.ToString(Console.ReadLine());
            vadesizHesap.KrediKartı(hesapAdi,hesapId);
            Console.Write("Ana Parayı giriniz:");
            double anapara = Convert.ToDouble(Console.ReadLine());
            Console.Write("Yüzdelik faiz oranı giriniz:");
            double faiz = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Brüt getiri:{0}", tasarrufHesabı.FaizHesapla(anapara, faiz));


        }
    }
}
