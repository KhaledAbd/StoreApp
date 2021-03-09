using System.Collections.Generic;

namespace Store.API.Models
{
    public class Category
    {
        public int id{get; set;}
        public string Name{get; set;}

        public virtual ICollection<CategoryPrefered> CategoryPrefereds{get;set;}

        public virtual ICollection<Cloth> Clothes {get; set;}

    }
}