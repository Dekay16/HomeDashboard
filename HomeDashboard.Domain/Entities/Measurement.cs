using HomeDashboard.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeDashboard.Domain.Entities
{
    public class Measurement : BaseEntity
    {
        public int RoomId { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Value { get; set; }

        public string Unit { get; set; } = "in";

        public string? Description { get; set; }

        public string? Notes { get; set; }


        public Room Room { get; set; } = null!;
    }
}
