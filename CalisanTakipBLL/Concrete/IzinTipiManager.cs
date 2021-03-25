using CalisanTakipBLL.Abstract;
using CalisanTakipDAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanTakipBLL.Concrete
{
   public class IzinTipiManager : IIzinTipiService
    {
        private readonly IUnitOfWork _unitOfWork;
        public IzinTipiManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            
        }

    }
}
