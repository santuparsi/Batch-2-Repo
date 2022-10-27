using System;
using System.Collections.Generic;

namespace HandsOnEFDBFirst.Models
{
    public partial class EmpView
    {
        public int Eid { get; set; }
        public string Ename { get; set; } = null!;
        public decimal? Salary { get; set; }
    }
}
