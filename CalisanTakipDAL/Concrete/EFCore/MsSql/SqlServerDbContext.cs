using CalisanTakipEntity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanTakipDAL.Concrete.EFCore.MsSql
{
    public class SqlServerDbContext : IdentityDbContext
    {
        public SqlServerDbContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Calisan> Calisans { get; set; }
        public DbSet<IzinTalep> IzinTaleps { get; set; }
        public DbSet<IzinTanim> IzinTanims { get; set; }
        public DbSet<IzinTipi> IzinTipis { get; set; }


    }
}
