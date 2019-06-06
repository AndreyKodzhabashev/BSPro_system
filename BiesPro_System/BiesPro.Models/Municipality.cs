using System.Collections.Generic;

namespace BiesPro.Models
{
    public class Municipality : BaseModel
    {
        public Municipality()
        {
            this.Towns = new HashSet<Town>();
        }

        public string Name { get; set; }

        public ICollection<Town> Towns { get; set; }
    }
}