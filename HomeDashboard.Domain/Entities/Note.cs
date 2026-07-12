using HomeDashboard.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeDashboard.Domain.Entities
{
    public class Note : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public string? Category { get; set; }

        public string Content { get; set; } = string.Empty;
    }
}
