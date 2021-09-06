using System;
using System.Collections.Generic;

namespace Hazhbz.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Products>();
            SubCategory = new HashSet<SubCategory>();
        }

        public int CategoryId { get; set; }
        public string Category1 { get; set; }

        public virtual ICollection<Products> Products { get; set; }
        public virtual ICollection<SubCategory> SubCategory { get; set; }
    }
}
