using System;
using System.Collections.Generic;
using System.Text;
using VideoManagerDAL.Entities;

namespace VideoManagerDAL
{
   public interface IOrderRepository
    {
        //C
        Order Create(Order vid);
        //R
        List<Order> GetAll();
        // no U!
        Order Get(int Id);
        //D
        Order Delete(int Id);
    }
}
