using CalisanTakipDAL.Abstract;
using CalisanTakipEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanTakipDAL.Concrete.EFCore.MsSql
{
   public class IzinTanimDal : Repository<IzinTanim>,IIzinTanimDal
    {
        private readonly SqlServerDbContext _ctx;
        public IzinTanimDal(SqlServerDbContext ctx):base(ctx)
        {
            _ctx = ctx;
        }
    }
}
