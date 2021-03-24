using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanTakipCommon
{
    public class CalisanVM
    {
        public string Id { get; set; }

        [Display(Name= "Kullanıcı Adı")]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string VergiNo { get; set; }
        public DateTime DogumTarihi { get; set; }
    }
}
