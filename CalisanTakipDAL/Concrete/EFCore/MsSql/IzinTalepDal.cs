using CalisanTakipDAL.Abstract;
using CalisanTakipEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanTakipDAL.Concrete.EFCore.MsSql
{
    public class IzinTalepDal : Repository<IzinTalep>, IIzinTalepDal
    {
        private readonly SqlServerDbContext _ctx;
        public IzinTalepDal(SqlServerDbContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }
    }
}
