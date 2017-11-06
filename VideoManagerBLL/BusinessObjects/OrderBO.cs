using System;
using System.Collections.Generic;
using System.Text;

namespace VideoManagerBLL.BusinessObjects
{
    public class OrderBO
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int VideoId { get; set; }
        public VideoBO Video { get; set; }
    }
}
