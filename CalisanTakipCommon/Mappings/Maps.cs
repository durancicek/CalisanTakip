using AutoMapper;
using CalisanTakipEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanTakipCommon.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<IzinTipi, IzinTipiVM>().ReverseMap();
            CreateMap<IzinTalep, IzinTalepVM>().ReverseMap();
            CreateMap<IzinTanim, IzinTanimVM>().ReverseMap();
            CreateMap<Calisan, CalisanVM>().ReverseMap();

        }
    }
}
