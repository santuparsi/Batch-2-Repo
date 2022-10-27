using System;
using System.Collections.Generic;

namespace HandsOnEFDBFirst.Models
{
    public partial class ViewEmpDept
    {
        public int Eid { get; set; }
        public string Ename { get; set; } = null!;
        public string Dname { get; set; } = null!;
    }
}
