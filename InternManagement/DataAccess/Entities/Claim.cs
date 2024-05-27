using System;
using System.Collections.Generic;

namespace InternManagement.DataAccess.Entities
{
    public partial class Claim
    {
        public Claim()
        {
            Roles = new HashSet<Role>();
        }

        public int ClaimId { get; set; }
        public string? ClaimName { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
