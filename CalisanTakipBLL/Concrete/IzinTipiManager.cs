using AutoMapper;
using CalisanTakipBLL.Abstract;
using CalisanTakipCommon;
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
        private readonly IMapper _mapper;


        #endregion

        #region Constructor
        public IzinTipiManager(IUnitOfWork unitOfWork , IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

      
        #endregion

        #region CostomMethots
        public Result<List<IzinTipiVM>>GetAllIzinTipi()
        {
            var data = _unitOfWork.izinTipiDal.GetAll().ToList(); //Tüm dataları getirmesi için kullanıldı

            #region 1.Yöntem

            //1.YÖNTEM
            //if (data != null)
            //{
            //    List<IzinTipi> returnData = new List<IzinTipi>();
            //    foreach (var item in data)
            //    {
            //        returnData.Add(new IzinTipi()
            //        {
            //            Id = item.Id,
            //            KayitTarihi = item.KayitTarihi,
            //            VarsayilanGun = item.VarsayilanGun,
            //            Ad = item.Ad
            //        });
            //    }
            //    return new Result<List<IzinTipi>>(true, ResultConstant.RecordFound, returnData);

            //}
            //else
            //  
            #endregion   return new Result<List<IzinTipi>>(false, ResultConstant.RecordNotFound);

            #region 2.Yöntem
            var izinTipi = _mapper.Map<List<IzinTipi>, List<IzinTipiVM>>(data);
            return new Result<List<IzinTipiVM>>(true, ResultConstant.RecordFound, izinTipi); 
            #endregion
        }

        #endregion
    }
}
