using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoManagerBLL.BusinessObjects;
using VideoManagerBLL.Converters;
using VideoManagerDAL;

namespace VideoManagerBLL.Services
{
    class OrderService : IOrderService
    {
        OrderConverter conv = new OrderConverter();

        DALFacade _facade;
        public OrderService(DALFacade facade)
        {
            _facade = facade;
        }
        public OrderBO Create(OrderBO order)
        {
            using (var uow = _facade.UnitOfWork)
            {
                var orderEntity = uow.OrderRepository.Create(conv.Convert(order));
                uow.Complete();
                return conv.Convert(orderEntity);
            }
        }

        public OrderBO Delete(int Id)
        {
            using (var uow = _facade.UnitOfWork)
            {
                var orderEntity = uow.OrderRepository.Delete(Id);
                uow.Complete();
                return conv.Convert(orderEntity);
            }
        }

        public OrderBO Get(int Id)
        {
            using (var uow = _facade.UnitOfWork)
            {
                var orderEntity = uow.OrderRepository.Get(Id);
                orderEntity.Video = uow.VideoRepository.Get(orderEntity.VideoId);
                return conv.Convert(orderEntity);
            }
        }

        public List<OrderBO> GetAll()
        {
            using (var uow = _facade.UnitOfWork)
            {
               return uow.OrderRepository.GetAll().Select(conv.Convert).ToList();
            }
        }

        public OrderBO Update(OrderBO order)
        {
            using (var uow = _facade.UnitOfWork)
            {
                var orderEntity = uow.OrderRepository.Get(order.Id);
                if (orderEntity == null)
                {
                    throw new InvalidOperationException("Order not found");
                }
                orderEntity.DeliveryDate = order.DeliveryDate;
                orderEntity.OrderDate = order.OrderDate;
                orderEntity.VideoId = order.VideoId;

                uow.Complete();

                orderEntity.Video = uow.VideoRepository.Get(orderEntity.VideoId);
                return conv.Convert(orderEntity);
            }
        }
    }
}
