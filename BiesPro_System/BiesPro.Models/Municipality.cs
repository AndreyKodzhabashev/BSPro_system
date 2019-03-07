using System.Collections.Generic;

namespace BiesPro.Models
{
    public class Municipality
    {
        public int MunicipalityId { get; set; }

        public string Name { get; set; }

        public ICollection<Town> Towns { get; set; }
    }
}