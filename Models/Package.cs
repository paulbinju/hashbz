using System;
using System.Collections.Generic;

namespace Hazhbz.Models
{
    public partial class Package
    {
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public int? DurationMonths { get; set; }
        public int? TotalProducts { get; set; }
        public bool Logo { get; set; }
        public bool Header { get; set; }
    }
}
