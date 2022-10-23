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
    public class ManufacturerBL : IManufacturerBL
    {
        IManufacturerDAL _manufacturerDAL;
        IMapper mapper;

        public ManufacturerBL(IManufacturerDAL manufacturerDAL)
        {

            _manufacturerDAL = manufacturerDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }

        public List<ManufacturerDTO> GetAllManufacturers()
        {

            List<Manufacturer> manufacturers = _manufacturerDAL.GetAllManufacturers();

            return mapper.Map<List<Manufacturer>, List<ManufacturerDTO>>(manufacturers);

        }
        public ManufacturerDTO getManufacturerById(int manufacturerId)
        {

            Manufacturer manufacturer = _manufacturerDAL.getManufacturerById(manufacturerId);

            return mapper.Map<Manufacturer, ManufacturerDTO>(manufacturer);

        }
        public bool AddManufacturer(ManufacturerDTO manufacturer)
        {
            return _manufacturerDAL.AddManufacturer(mapper.Map<ManufacturerDTO, Manufacturer>(manufacturer));
        }

        public bool DeleteManufacturer(int id)
        {
            return _manufacturerDAL.DeleteManufacturer(id);
        }

        public bool UpdateManufacturer(ManufacturerDTO manufacturer, int id)
        {
            return _manufacturerDAL.UpdateManufacturer(mapper.Map<ManufacturerDTO, Manufacturer>(manufacturer), id);
        }
    }
}

