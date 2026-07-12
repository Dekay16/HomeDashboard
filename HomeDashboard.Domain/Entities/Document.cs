using HomeDashboard.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeDashboard.Domain.Entities
{
    public class Document : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public string FileName { get; set; } = string.Empty;

        public string FilePath { get; set; } = string.Empty;

        public string? ContentType { get; set; }

        public long FileSize { get; set; }

        public string? Description { get; set; }

        public string? Notes { get; set; }
    }
}
