using System;
using System.Collections.Generic;

namespace Pagination_filtering_and_sorting.Models
{
    public partial class DocumentAttachment
    {
        public int Id { get; set; }
        public string? FileExtension { get; set; }
        public string? FileName { get; set; }
        public string? FilePath { get; set; }
        public DateTime? DateUploaded { get; set; }
    }
}
