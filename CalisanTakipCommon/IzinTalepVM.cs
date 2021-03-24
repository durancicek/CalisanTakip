using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanTakipCommon
{
    public class IzinTalepVM:BaseVM
    {
        //Talepde bulunan kullanıcı bilgileri
        public string TalepEdenCalisanId { get; set; }
        public CalisanVM TalepEdenCalisan { get; set; }

        //Onaylayan kullanıcı bilgileri
        public string OnaylayanId { get; set; }
        public CalisanVM Onaylayan { get; set; }

        public int IzinTipiId { get; set; }
        public IzinTipiVM IzinTipi { get; set; }

        //---------------------------------------------------//

        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public DateTime TalepTarihi { get; set; }
        
        
        [MaxLength(300,ErrorMessage ="300 karakterden fazla girilemez")]
        public string TalepNot { get; set; }
        public bool? OnayDurumu { get; set; } // Talep edilen izin onaylandı mı? onaylanmadı mı?
        public bool IzinDurumu { get; set; } // İzin Tamamlandımı? tamamlanmadımı?

    }
}
