using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Vaccinations = new HashSet<Vaccination>();
        }

        public int Id { get; set; }
        public string ManufacturerName { get; set; }

        public virtual ICollection<Vaccination> Vaccinations { get; set; }
    }
}
