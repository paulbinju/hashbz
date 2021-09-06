using System;
using System.Collections.Generic;

namespace Hazhbz.Models
{
    public partial class Users
    {
        public Users()
        {
            StoreUser = new HashSet<StoreUser>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<StoreUser> StoreUser { get; set; }
    }
}
