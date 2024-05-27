﻿using System;
using System.Collections.Generic;

namespace InternManagement.DataAccess.Entities
{
    public partial class RefreshToken
    {
        public int RefreshTokenId { get; set; }
        public int RefreshTokenString { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
