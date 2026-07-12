using HomeDashboard.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeDashboard.Domain.Entities
{
    public class Reminder : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public DateTime DueDate { get; set; }

        public int Priority { get; set; }

        public bool Completed { get; set; }

        public DateTime? CompletedDate { get; set; }

        public string? Notes { get; set; }
    }
}
