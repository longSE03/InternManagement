using System;
using System.Collections.Generic;

namespace InternManagement.DataAccess.Entities
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
            Claims = new HashSet<Claim>();
        }

        public int RoleId { get; set; }
        public string? RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<Claim> Claims { get; set; }
    }
}
