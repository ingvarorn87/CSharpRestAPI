using System;
using System.Collections.Generic;
using System.Text;
using VideoManagerBLL.BusinessObjects;

namespace VideoManagerBLL
{
   public interface IOrderService
    {
        //C
        OrderBO Create(OrderBO vid);
        //R
        List<OrderBO> GetAll();
        OrderBO Get(int Id);
        //U
        OrderBO Update(OrderBO vid);
        //D
        OrderBO Delete(int Id);
    }
}
