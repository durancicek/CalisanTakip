using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanTakipCommon.ResultModels
{
    public class Result<T> : IResult
    {
        public bool IsSuccess { get; set; }
        public string Mesaj { get; set; }
        public T Data { get; set; }
        public int ToplamMiktar { get; set; }

        public Result(bool isSuccess, string mesaj)
            : this(isSuccess, mesaj, default(T))
        {

        }
        public Result(bool isSuccess, string mesaj, T data)
           : this(isSuccess, mesaj, data, 0)
        {

        }

        public Result(bool isSuccess, string mesaj, T data,int toplamMiktar)
        {
            IsSuccess = isSuccess;
            Mesaj = mesaj;
            Data = data;
            ToplamMiktar = toplamMiktar;
        }





    }
}
