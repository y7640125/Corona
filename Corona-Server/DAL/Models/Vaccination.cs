using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Vaccination
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public DateTime ReceivedDate { get; set; }
        public int ManufacturerId { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
        public virtual Member Member { get; set; }
    }
}
