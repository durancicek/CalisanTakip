using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanTakipEntity
{
    public class IzinTanim : BaseEntity
    {
        public int GunSayisi { get; set; }
        public DateTime KayitTarihi { get; set; }
        public int Periyot { get; set; }

        public string CalisanId { get; set; } //IdentityUser'da ıd alanı nvarchar olduğundan dolayı calisanıd prop. string tanımlandı.

        [ForeignKey("CalisanId")]
        public Calisan Calisan { get; set; }

        public int IzinTipiId { get; set; }

        
        [ForeignKey("IzinTipiId")]
        public IzinTipi IzinTipi { get; set; }


    }
}
