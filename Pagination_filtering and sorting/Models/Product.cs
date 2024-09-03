using System;
using System.Collections.Generic;

namespace Pagination_filtering_and_sorting.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int Price { get; set; }
        public int Qty { get; set; }
    }
}
