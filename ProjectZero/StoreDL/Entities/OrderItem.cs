﻿using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
    }
}
