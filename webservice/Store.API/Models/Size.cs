using System.Collections.Generic;

namespace Store.API.Models
{
    public class Size
    {
        public int id{get; set;}
        public string Name{get; set;}

        public virtual ICollection<SizePrefered> SizePrefereds {get; set;}

        public virtual ICollection<Cloth> Clothes {get; set;}
    }
}