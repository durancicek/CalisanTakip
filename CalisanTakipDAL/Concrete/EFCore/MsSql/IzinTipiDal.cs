using CalisanTakipDAL.Abstract;
using CalisanTakipEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanTakipDAL.Concrete.EFCore.MsSql
{
    public class IzinTipiDal : Repository<IzinTipi>, IIzinTipiDal
    {
        private readonly SqlServerDbContext _ctx;
        public IzinTipiDal(SqlServerDbContext ctx):base(ctx)
        {
            _ctx = ctx;
        }

    }
}
