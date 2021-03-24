using CalisanTakipDAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanTakipDAL.Concrete.EFCore.MsSql
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SqlServerDbContext _ctx;

        public UnitOfWork(SqlServerDbContext ctx)
        {
            _ctx = ctx;
            izinTanimDal = new IzinTanimDal(_ctx);
            izinTipiDal = new IzinTipiDal(_ctx);
            izinTalepDal = new IzinTalepDal(_ctx);
           
        }

        public IIzinTanimDal izinTanimDal { get; private set; }
        public IIzinTipiDal izinTipiDal { get; private set; }
        public IIzinTalepDal izinTalepDal { get; private set; }

        public void Dispose()
        {
            _ctx.Dispose();
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }
    }
}
