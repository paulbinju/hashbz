using System;
using System.Collections.Generic;

namespace Hazhbz.Models
{
    public partial class StoreUser
    {
        public int StoreUserId { get; set; }
        public Guid? StoreId { get; set; }
        public int? UserId { get; set; }

        public virtual Store Store { get; set; }
        public virtual Users User { get; set; }
    }
}
