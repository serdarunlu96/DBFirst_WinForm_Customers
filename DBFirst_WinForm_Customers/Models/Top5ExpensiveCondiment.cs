using System;
using System.Collections.Generic;

namespace DBFirst_WinForm_Customers.Models
{
    public partial class Top5ExpensiveCondiment
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string SupplierName { get; set; } = null!;
    }
}
