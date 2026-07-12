using System;
using System.Collections.Generic;
using System.Text;

namespace HomeDashboard.Domain.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? ModifiedDate { get; set; }
    }
}
