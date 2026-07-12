using HomeDashboard.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeDashboard.Domain.Entities
{
    public class Vehicle : BaseEntity
    {
        public string Nickname { get; set; } = string.Empty;

        public int Year { get; set; }

        public string Make { get; set; } = string.Empty;

        public string Model { get; set; } = string.Empty;

        public string? Trim { get; set; }

        public string? VIN { get; set; }

        public string? LicensePlate { get; set; }

        public string? Color { get; set; }

        public DateTime? PurchaseDate { get; set; }

        public decimal? PurchasePrice { get; set; }

        public int CurrentMileage { get; set; }

        public string? OilType { get; set; }

        public string? TireSize { get; set; }

        public string? BatteryType { get; set; }

        public string? InsuranceCompany { get; set; }

        public string? PolicyNumber { get; set; }

        public DateTime? RegistrationExpiration { get; set; }

        public string? Notes { get; set; }


        public ICollection<VehicleMaintenance> MaintenanceRecords { get; set; } = [];
    }
}
