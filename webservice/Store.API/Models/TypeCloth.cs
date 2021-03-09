using System.Collections.Generic;

namespace Store.API.Models
{
    public class TypeCloth
    {
        public int id {get; set;}
        public string Name {get; set;}

        public virtual ICollection<TypeClothPrefered> CategoryPrefereds{get;set;}

        public virtual ICollection<Cloth> Clothes {get; set;}

    }
}