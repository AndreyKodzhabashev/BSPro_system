namespace BiesPro.Models
{
    using System.Collections.Generic;

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