using DAL.Models;

namespace DAL.Interfaces
{
    public interface IVaccinationDAL
    {
        bool AddVaccination(Vaccination vaccination);
        List<Vaccination> GetVaccinationsByMember(int id);
        bool DeleteVaccination(int id);
        List<Vaccination> GetAllVaccinations();
        Vaccination getVaccinationById(int vaccinationId);
        bool UpdateVaccination(Vaccination vaccination, int id);

       
    }
}