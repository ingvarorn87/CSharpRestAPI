using System;
using System.Collections.Generic;
using System.Text;
using VideoManagerBLL.BusinessObjects;
using VideoManagerDAL.Entities;

namespace VideoManagerBLL.Converters
{
    class OrderConverter
    {
        internal Order Convert(OrderBO order)
        {
            if (order == null) { return null; }
            return new Order()
            {
                Id = order.Id,
                DeliveryDate = order.DeliveryDate,
                OrderDate = order.OrderDate,
                VideoId = order.VideoId

            };
        }
        internal OrderBO Convert(Order order)
        {
            if (order == null) { return null; }
            return new OrderBO()
            {
                Id = order.Id,
                DeliveryDate = order.DeliveryDate,
                OrderDate = order.OrderDate,
                Video = new VideoConverter().Convert(order.Video),
                VideoId = order.VideoId
            };
        }
    }
}
