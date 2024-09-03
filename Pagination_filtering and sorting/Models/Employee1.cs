using System;
using System.Collections.Generic;

namespace Pagination_filtering_and_sorting.Models
{
    public partial class Employee1
    {
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Department { get; set; }
        public DateTime? JoiningDate { get; set; }
        public decimal? Salary { get; set; }
        public string? Email { get; set; }
    }
}
