using System;
using System.Collections.Generic;

namespace Pagination_filtering_and_sorting.Models
{
    public partial class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
