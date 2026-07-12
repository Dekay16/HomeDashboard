using HomeDashboard.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeDashboard.Domain.Entities
{
    public class Appliance : BaseEntity
    {
        public int RoomId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Category { get; set; }

        public string? Manufacturer { get; set; }

        public string? Model { get; set; }

        public string? SerialNumber { get; set; }

        public DateTime? PurchaseDate { get; set; }

        public DateTime? InstallDate { get; set; }

        public DateTime? WarrantyExpiration { get; set; }

        public string? FilterSize { get; set; }

        public string? PowerSource { get; set; }

        public string? ManualUrl { get; set; }

        public string? Notes { get; set; }


        public Room Room { get; set; } = null!;
    }
}
