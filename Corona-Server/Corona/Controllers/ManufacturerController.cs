using BL.Interfaces;
using DTO;
using Microsoft.AspNetCore.Mvc;

namespace Corona.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {

        private IManufacturerBL _manufacturerBL;

        public ManufacturerController(IManufacturerBL manufacturer)
        {
            _manufacturerBL = manufacturer;
        }

        [HttpGet]
        [Route("Manufacturers")]
        public IActionResult GetAllManufacturers()
        {
            try
            {
                return Ok(_manufacturerBL.GetAllManufacturers());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("ManufacturerById/{id}")]
        public IActionResult getManufacturerById(int id)
        {
            try
            {
                return Ok(_manufacturerBL.getManufacturerById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("add")]
        public bool AddManufacturer([FromBody] ManufacturerDTO manufacturer)
        {
            var x = _manufacturerBL.AddManufacturer(manufacturer);
            return x;
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeleteManufacturer(int id)
        {
            return _manufacturerBL.DeleteManufacturer(id);
        }

        [HttpPut]
        [Route("update/{id}")]
        public bool UpdateManufacturer([FromBody] ManufacturerDTO manufacturer, int id)
        {
            return _manufacturerBL.UpdateManufacturer(manufacturer, id);
        }
    }
}
