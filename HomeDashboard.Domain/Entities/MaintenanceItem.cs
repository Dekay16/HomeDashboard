using HomeDashboard.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeDashboard.Domain.Entities
{
    public class MaintenanceItem : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string? Category { get; set; }

        public int FrequencyDays { get; set; }

        public DateTime? LastCompleted { get; set; }

        public DateTime NextDue { get; set; }

        public decimal? EstimatedCost { get; set; }

        public string? Notes { get; set; }
    }
}
