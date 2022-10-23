using BL.Interfaces;
using DTO;
using Microsoft.AspNetCore.Mvc;

namespace Corona.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {

        private IMemberBL _memberBL;

        public MemberController(IMemberBL Member)
        {
            _memberBL = Member;
        }
        [HttpGet]
        [Route("Members")]
        public IActionResult GetAllMembers()
        {
            try
            {
                return Ok(_memberBL.GetAllMembers());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("MemberById/{id}")]
        public IActionResult getMemberById(int id)
        {
            try
            {
                return Ok(_memberBL.getMemberById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("MemberByTz/{tz}")]
        public IActionResult getMemberByTz(string tz)
        {
            try
            {
                return Ok(_memberBL.getMemberByTz(tz));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("UnvaccinatedMembers")]
        public ActionResult<int> GetUnvaccinatedMembers()
        {
            try
            {
                return Ok(_memberBL.GetUnvaccinatedMembers());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("SicksPerMonth/{month}")]
        public ActionResult<int> GetSicksPerMonth(int month)
        {
            try
            {
                return Ok(_memberBL.GetSicksPerMonth(month));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("add")]
        public bool AddMember([FromBody] MemberDTO member)
        {
            var x = _memberBL.AddMember(member);
            return x;
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeleteMember(int id)
        {
            return _memberBL.DeleteMember(id);
        }

        [HttpPut]
        [Route("update/{id}")]
        public bool UpdateMember([FromBody] MemberDTO Member, int id)
        {
            return _memberBL.UpdateMember(Member, id);
        }
    }
}
