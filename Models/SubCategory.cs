using System;
using System.Collections.Generic;

namespace Hazhbz.Models
{
    public partial class SubCategory
    {
        public SubCategory()
        {
            Products = new HashSet<Products>();
        }

        public int SubCategoryId { get; set; }
        public Guid? StoreId { get; set; }
        public int? CategoryId { get; set; }
        public string SubCategory1 { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}
