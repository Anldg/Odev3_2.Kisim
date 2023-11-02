using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3_A
{
    internal class TasarrufHesabı : BankaHesabı
    {
        public double FaizHesapla(double anapara,double faiz)
        {
            return anapara += anapara * (faiz / 100);
        }
    }
}
