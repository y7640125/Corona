using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VaccinationDAL : IVaccinationDAL
    {
        CoronaContext _context = new CoronaContext();
        public List<Vaccination> GetAllVaccinations()
        {
            try
            {
                return _context.Vaccinations.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Vaccination> GetVaccinationsByMember(int id)
        {
            try
            {
                return _context.Vaccinations.Where<Vaccination>(x=>x.MemberId.Equals(id)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Vaccination getVaccinationById(int vaccinationId)
        {
            Vaccination vaccination = _context.Vaccinations.SingleOrDefault(x => x.Id.Equals(vaccinationId));
            return vaccination;
        }
        public bool AddVaccination(Vaccination vaccination)
        {
            try
            {
                _context.Vaccinations.Add(vaccination);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteVaccination(int id)
        {
            try
            {
                Vaccination vaccination = _context.Vaccinations.SingleOrDefault(x => x.Id == id);
                _context.Vaccinations.Remove(vaccination);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateVaccination(Vaccination vaccination, int id)
        {
            try
            {
                Vaccination currentVaccination = _context.Vaccinations.SingleOrDefault(x => x.Id == id);
                _context.Entry(currentVaccination).CurrentValues.SetValues(vaccination);
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

