using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManufacturerDAL : IManufacturerDAL
    {
        CoronaContext _context = new CoronaContext();
        public List<Manufacturer> GetAllManufacturers()
        {
            try
            {
                return _context.Manufacturers.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Manufacturer getManufacturerById(int manufacturerId)
        {
            Manufacturer manufacturer = _context.Manufacturers.SingleOrDefault(x => x.Id.Equals(manufacturerId));
            return manufacturer;
        }
        public bool AddManufacturer(Manufacturer manufacturer)
        {
            try
            {
                _context.Manufacturers.Add(manufacturer);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteManufacturer(int id)
        {
            try
            {
                Manufacturer manufacturer = _context.Manufacturers.SingleOrDefault(x => x.Id == id);
                _context.Manufacturers.Remove(manufacturer);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateManufacturer(Manufacturer manufacturer, int id)
        {
            try
            {
                Manufacturer currentManufacturer = _context.Manufacturers.SingleOrDefault(x => x.Id == id);
                _context.Entry(currentManufacturer).CurrentValues.SetValues(manufacturer);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

