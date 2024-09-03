using System;
using System.Collections.Generic;

namespace Pagination_filtering_and_sorting.Models
{
    public partial class ImgaeUpload
    {
        public int Id { get; set; }
        public string ImageName { get; set; } = null!;
        public int Price { get; set; }
        public string ImgaePath { get; set; } = null!;
    }
}
