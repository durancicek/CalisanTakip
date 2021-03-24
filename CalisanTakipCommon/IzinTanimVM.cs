using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanTakipCommon
{
   public class IzinTanimVM
    {
        public int GunSayisi { get; set; }
        public DateTime KayitTarihi { get; set; }
        public int Periyot { get; set; }

        public string CalisanId { get; set; } //IdentityUser'da ıd alanı nvarchar olduğundan dolayı calisanıd prop. string tanımlandı.
        public CalisanVM CalisanVm { get; set; }

        public int IzinTipiId { get; set; }
        public IzinTipiVM IzinTipiVm { get; set; }

    }
}
