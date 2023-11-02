using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3_A
{
    internal class VadesizHesap : BankaHesabı
    {
        public void KrediKartı(string hesapAdi,string hesapId)
        {
            Console.WriteLine("Hesap adı:{0}",hesapAdi);
            Console.WriteLine("Hesap Id:{0}",hesapId);
        }
    }
}
