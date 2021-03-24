using Microsoft.AspNetCore.Identity;
using System;

namespace CalisanTakipEntity
{
    public class Calisan:IdentityUser
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string  VergiNo { get; set; }
        public DateTime DogumTarihi { get; set; }
    }
}
