using System;
using System.Collections.Generic;

namespace Hazhbz.Models
{
    public partial class ProductImageVideo
    {
        public int ProductId { get; set; }
        public Guid? StoreId { get; set; }
        public int? CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int? Packing { get; set; }
        public int? UserId { get; set; }
        public int? DisplayOrder { get; set; }
        public int? VideoId { get; set; }
        public string YoutubeUrl { get; set; }
        public int? ProductImageId { get; set; }
        public string ImageExtension { get; set; }
        public bool? CoverPic { get; set; }
        public bool Active { get; set; }
        public string ProductUrl { get; set; }
    }
}
