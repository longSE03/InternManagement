﻿using System;
using System.Collections.Generic;

namespace InternManagement.DataAccess.Entities
{
    public partial class AttachedFile
    {
        public int AttachedFileId { get; set; }
        public string FileName { get; set; } = null!;
        public byte[]? FileDate { get; set; }
        public int SubmissionId { get; set; }

        public virtual Submission Submission { get; set; } = null!;
    }
}
