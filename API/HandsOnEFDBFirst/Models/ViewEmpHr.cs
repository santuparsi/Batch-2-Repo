using System;
using System.Collections.Generic;

namespace HandsOnEFDBFirst.Models
{
    public partial class ViewEmpHr
    {
        public int Eid { get; set; }
        public string Ename { get; set; } = null!;
        public decimal? Salary { get; set; }
        public string? Did { get; set; }
    }
}
