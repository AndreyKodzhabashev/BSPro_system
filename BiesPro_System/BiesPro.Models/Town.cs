namespace BiesPro.Models

{
    using System.Collections.Generic;

    public class Town
    {
        public Town()
        {
            this.Addresses = new List<Address>();
        }

        public int TownId { get; set; }

        public string Name { get; set; }

        //navigation properties
        public int MunicipalityId { get; set; }
        public Municipality Municipality { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}