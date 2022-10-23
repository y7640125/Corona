using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<MemberDTO, Member>();
            CreateMap<Member, MemberDTO>();
            CreateMap<ManufacturerDTO, Manufacturer>();
            CreateMap<Manufacturer, ManufacturerDTO>();
            CreateMap<VaccinationDTO, Vaccination>();
            CreateMap<Vaccination, VaccinationDTO>();
        }
    }
}