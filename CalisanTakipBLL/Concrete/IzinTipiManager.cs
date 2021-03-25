using CalisanTakipBLL.Abstract;
using CalisanTakipCommon.ConstantsModels;
using CalisanTakipCommon.ResultModels;
using CalisanTakipDAL.Abstract;
using CalisanTakipEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanTakipBLL.Concrete
{
    public class IzinTipiManager : IIzinTipiService
    {
        #region Variables
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region Constructor
        public IzinTipiManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        #endregion

        #region CostomMethots
        public Result<List<IzinTipi>> GetAllIzinTipi()
        {
            var data = _unitOfWork.izinTipiDal.GetAll().ToList(); //Tüm dataları getirmesi için kullanıldı

            if (data != null)
            {
                List<IzinTipi> returnData = new List<IzinTipi>();
                foreach (var item in data)
                {
                    returnData.Add(new IzinTipi()
                    {
                        Id = item.Id,
                        KayitTarihi = item.KayitTarihi,
                        VarsayilanGun = item.VarsayilanGun,
                        Ad = item.Ad
                    });
                }
                return new Result<List<IzinTipi>>(true, ResultConstant.RecordFound, returnData);

            }
            else
                return new Result<List<IzinTipi>>(false, ResultConstant.RecordNotFound);

        }
        #endregion
    }
}
