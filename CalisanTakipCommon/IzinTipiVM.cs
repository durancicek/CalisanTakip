using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanTakipCommon
{
    public class IzinTipiVM:BaseVM
    {
        [Required]
        public string Ad { get; set; }
        public int VarsayilanGun { get; set; }
        public DateTime KayitTarihi { get; set; }
        public bool IsActive { get; set; }

    }
}
