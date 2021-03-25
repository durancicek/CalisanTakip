using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanTakipDAL.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        public IIzinTanimDal izinTanimDal { get; }
        public IIzinTipiDal izinTipiDal { get; }
        public IIzinTalepDal izinTalepDal { get; }
        void Save();
    }
}
