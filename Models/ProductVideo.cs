using System;
using System.Collections.Generic;

namespace Hazhbz.Models
{
    public partial class ProductVideo
    {
        public int VideoId { get; set; }
        public int? ProductId { get; set; }
        public string YoutubeUrl { get; set; }
    }
}
