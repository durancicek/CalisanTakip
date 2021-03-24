using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanTakipEntity
{
    public class IzinTalep:BaseEntity
    {
        //Talepde bulunan kullanıcı bilgileri
        public string TalepEdenCalisanId { get; set; }

        [ForeignKey("TalepEdenCalisanId")]
        public Calisan TalepEdenCalisan { get; set; }


        //Onaylayan kullanıcı bilgileri
        public string OnaylayanId { get; set; }

        [ForeignKey("OnaylayanId")]
        public Calisan Onaylayan { get; set; }

        public int IzinTipiId { get; set; }

        [ForeignKey("IzinTipiId")]
        public IzinTipi IzinTipi { get; set; }

        //---------------------------------------------------//

        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public DateTime TalepTarihi { get; set; }
        public string TalepNot { get; set; }
        public bool? OnayDurumu { get; set; } // Talep edilen izin onaylandı mı? onaylanmadı mı?
        public bool IzinDurumu { get; set; } // İzin Tamamlandımı? tamamlanmadımı?


    }
}
