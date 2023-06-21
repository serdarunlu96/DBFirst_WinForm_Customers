using System;
using System.Collections.Generic;

namespace DBFirst_WinForm_Customers.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
