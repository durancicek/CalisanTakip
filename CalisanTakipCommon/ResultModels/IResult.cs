using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanTakipCommon.ResultModels
{
    public interface IResult
    {
         bool IsSuccess { get; set; }
         string Mesaj { get; set; }
    }
}
