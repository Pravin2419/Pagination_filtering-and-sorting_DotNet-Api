using System;
using System.Collections.Generic;

namespace Pagination_filtering_and_sorting.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal? Gpa { get; set; }
    }
}
