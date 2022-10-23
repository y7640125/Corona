using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VaccinationDTO
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public DateTime ReceivedDate { get; set; }
        public int ManufacturerId { get; set; }
    }
}
