using System;
using System.Collections.Generic;

namespace Testing.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Details { get; set; } = null!;
    }
}
