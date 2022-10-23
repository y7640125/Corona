using DTO;

namespace BL.Interfaces
{
    public interface IVaccinationBL
    {
        bool AddVaccination(VaccinationDTO vaccination);
        List<VaccinationDTO> GetVaccinationsByMember(int id);
        bool DeleteVaccination(int id);
        List<VaccinationDTO> GetAllVaccinations();
        VaccinationDTO getVaccinationById(int vaccinationId);
        bool UpdateVaccination(VaccinationDTO Vaccination, int id);
    }
}