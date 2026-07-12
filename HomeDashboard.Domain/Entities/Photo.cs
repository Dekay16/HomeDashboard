using HomeDashboard.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeDashboard.Domain.Entities
{
    public class Photo : BaseEntity
    {
        public string Caption { get; set; } = string.Empty;

        public string FileName { get; set; } = string.Empty;

        public string FilePath { get; set; } = string.Empty;

        public DateTime? TakenDate { get; set; }

        public string? Notes { get; set; }
    }
}
