using System;
using System.Collections.Generic;

namespace Hazhbz.Models
{
    public partial class ProductImage
    {
        public int ProductImageId { get; set; }
        public int? ProductId { get; set; }
        public string ImageExtension { get; set; }
        public bool? CoverPic { get; set; }
    }
}
