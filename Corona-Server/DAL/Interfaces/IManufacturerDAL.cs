using DAL.Models;

namespace DAL.Interfaces
{
    public interface IManufacturerDAL
    {
        bool AddManufacturer(Manufacturer manufacturer);
        bool DeleteManufacturer(int id);
        List<Manufacturer> GetAllManufacturers();
        Manufacturer getManufacturerById(int manufacturerId);
        bool UpdateManufacturer(Manufacturer manufacturer, int id);
    }
}