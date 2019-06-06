namespace BiesPro.Models
{
    using System.Collections.Generic;

    public class Town : BaseModel
    {
        public Town()
        {
            this.Addresses = new HashSet<Address>();
        }

        public string Name { get; set; }

        //navigation properties
        public uint MunicipalityId { get; set; }
        public Municipality Municipality { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}