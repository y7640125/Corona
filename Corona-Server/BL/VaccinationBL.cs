using AutoMapper;
using BL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class VaccinationBL : IVaccinationBL
    {
        IVaccinationDAL _vaccinationDAL;
        IMapper mapper;

        public VaccinationBL(IVaccinationDAL vaccinationDAL)
        {

            _vaccinationDAL = vaccinationDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }

        public List<VaccinationDTO> GetAllVaccinations()
        {

            List<Vaccination> Vaccinations = _vaccinationDAL.GetAllVaccinations();

            return mapper.Map<List<Vaccination>, List<VaccinationDTO>>(Vaccinations);

        }
        public List<VaccinationDTO> GetVaccinationsByMember(int id)
        {

            List<Vaccination> Vaccinations = _vaccinationDAL.GetVaccinationsByMember(id);

            return mapper.Map<List<Vaccination>, List<VaccinationDTO>>(Vaccinations);

        }
        public VaccinationDTO getVaccinationById(int vaccinationId)
        {

            Vaccination Vaccination = _vaccinationDAL.getVaccinationById(vaccinationId);

            return mapper.Map<Vaccination, VaccinationDTO>(Vaccination);

        }
        public bool AddVaccination(VaccinationDTO vaccination)
        {
            return _vaccinationDAL.AddVaccination(mapper.Map<VaccinationDTO, Vaccination>(vaccination));
        }

        public bool DeleteVaccination(int id)
        {
            return _vaccinationDAL.DeleteVaccination(id);
        }

        public bool UpdateVaccination(VaccinationDTO Vaccination, int id)
        {
            return _vaccinationDAL.UpdateVaccination(mapper.Map<VaccinationDTO, Vaccination>(Vaccination), id);
        }
    }
}

