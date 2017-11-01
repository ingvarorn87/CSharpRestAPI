﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VideoManagerDAL.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Video Video { get; set; }

    }
}
