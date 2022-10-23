using DTO;

namespace BL.Interfaces
{
    public interface IManufacturerBL
    {
        bool AddManufacturer(ManufacturerDTO manufacturer);
        bool DeleteManufacturer(int id);
        List<ManufacturerDTO> GetAllManufacturers();
        ManufacturerDTO getManufacturerById(int manufacturerId);
        bool UpdateManufacturer(ManufacturerDTO manufacturer, int id);
    }
}