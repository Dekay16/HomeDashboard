using HomeDashboard.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeDashboard.Domain.Entities
{
    public class VehicleMaintenance : BaseEntity
    {
        public int VehicleId { get; set; }

        public string ServiceType { get; set; } = string.Empty;

        public DateTime ServiceDate { get; set; }

        public int Mileage { get; set; }

        public decimal Cost { get; set; }

        public string? PerformedBy { get; set; }

        public string? Location { get; set; }

        public string? Notes { get; set; }


        public Vehicle Vehicle { get; set; } = null!;
    }
}
