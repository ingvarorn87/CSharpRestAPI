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
            return new Order()
            {
                Id = order.Id,
                DeliveryDate = order.DeliveryDate,
                OrderDate = order.OrderDate,
                Video = new VideoConverter().Convert(order.Video)

            };
        }
        internal OrderBO Convert(Order order)
        {
            return new OrderBO()
            {
                Id = order.Id,
                DeliveryDate = order.DeliveryDate,
                OrderDate = order.OrderDate
            };
        }
    }
}
