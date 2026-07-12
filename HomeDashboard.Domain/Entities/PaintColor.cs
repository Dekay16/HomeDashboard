using HomeDashboard.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeDashboard.Domain.Entities
{
    public class PaintColor : BaseEntity
    {
        public int RoomId { get; set; }

        public string Brand { get; set; } = string.Empty;

        public string? ProductLine { get; set; }

        public string ColorName { get; set; } = string.Empty;

        public string? ColorCode { get; set; }

        public string? Finish { get; set; }

        public string? Sheen { get; set; }

        public DateTime? PurchaseDate { get; set; }

        public string? PurchaseLocation { get; set; }

        public decimal? QuantityRemaining { get; set; }

        public string? Notes { get; set; }


        public Room Room { get; set; } = null!;
    }
}
