using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanTakipEntity
{
    public class IzinTipi :BaseEntity
    {
        public string Ad { get; set; }
        public int VarsayilanGun { get; set; }
        public DateTime KayitTarihi { get; set; }
    }
}
