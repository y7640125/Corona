using BL.Interfaces;
using DTO;
using Microsoft.AspNetCore.Mvc;

namespace Corona.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccinationController : ControllerBase
    {

        private IVaccinationBL _vaccinationBL;

        public VaccinationController(IVaccinationBL vaccination)
        {
            _vaccinationBL = vaccination;
        }

        [HttpGet]
        [Route("Vaccinations")]
        public IActionResult GetAllVaccinations()
        {
            try
            {
                return Ok(_vaccinationBL.GetAllVaccinations());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("Vaccinations/{id}")]
        public IActionResult GetVaccinationsByMember(int id)
        {
            try
            {
                return Ok(_vaccinationBL.GetVaccinationsByMember(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("VaccinationById/{id}")]
        public IActionResult getVaccinationById(int id)
        {
            try
            {
                return Ok(_vaccinationBL.getVaccinationById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("add")]
        public bool AddVaccination([FromBody] VaccinationDTO vaccination)
        {
            var x = _vaccinationBL.AddVaccination(vaccination);
            return x;
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeleteVaccination(int id)
        {
            return _vaccinationBL.DeleteVaccination(id);
        }

        [HttpPut]
        [Route("update/{id}")]
        public bool UpdateVaccination([FromBody] VaccinationDTO vaccination, int id)
        {
            return _vaccinationBL.UpdateVaccination(vaccination, id);
        }
    }
}
