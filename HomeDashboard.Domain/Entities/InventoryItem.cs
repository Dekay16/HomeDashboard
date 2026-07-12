using HomeDashboard.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeDashboard.Domain.Entities
{
    public class InventoryItem : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string? Category { get; set; }

        public string? Manufacturer { get; set; }

        public string? Model { get; set; }

        public string? SerialNumber { get; set; }

        public DateTime? PurchaseDate { get; set; }

        public decimal? PurchasePrice { get; set; }

        public decimal? CurrentValue { get; set; }

        public string? Location { get; set; }

        public DateTime? WarrantyExpiration { get; set; }

        public string? Condition { get; set; }

        public string? Notes { get; set; }
    }
}
