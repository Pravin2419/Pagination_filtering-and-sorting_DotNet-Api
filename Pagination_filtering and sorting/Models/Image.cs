using System;
using System.Collections.Generic;

namespace Pagination_filtering_and_sorting.Models
{
    public partial class Image
    {
        public int Id { get; set; }
        public string ImageName { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
    }
}
