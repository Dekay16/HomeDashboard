using HomeDashboard.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeDashboard.Domain.Entities
{
    public class Room : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string? Floor { get; set; }

        public string? Description { get; set; }

        public decimal? Length { get; set; }

        public decimal? Width { get; set; }

        public decimal? CeilingHeight { get; set; }

        public string? Flooring { get; set; }

        public string? Notes { get; set; }


        public ICollection<PaintColor> PaintColors { get; set; } = [];

        public ICollection<Appliance> Appliances { get; set; } = [];

        public ICollection<Measurement> Measurements { get; set; } = [];
    }
}
