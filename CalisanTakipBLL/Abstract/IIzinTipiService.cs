using CalisanTakipCommon;
using CalisanTakipCommon.ResultModels;
using CalisanTakipEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanTakipBLL.Abstract
{
    public interface IIzinTipiService
    {
        Result<List<IzinTipiVM>> GetAllIzinTipi();

        /// <summary>
        /// Yeni izin tipi kayıt metotdu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Result<IzinTipiVM> CreateIzinTipi(IzinTipiVM model);


        /// <summary>
        /// İzin Tipi Edit methodu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Result<IzinTipiVM> GetByIdIzinTipi(int id);

        Result<IzinTipiVM> EditGetByIdIzinTipi(IzinTipiVM model);

        Result<IzinTipiVM> RemoveIzinTipi(int id);




    }
}
