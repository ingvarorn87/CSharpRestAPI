using System;
using System.Collections.Generic;
using System.Text;
using VideoManagerDAL.Context;
using VideoManagerDAL.Repositories;

namespace VideoManagerDAL.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
       
        public IVideoRepository VideoRepository { get; internal set; }
        public IOrderRepository OrderRepository { get; internal set; }

        private VideoAppContext context;

        public UnitOfWork()
        {
            context = new VideoAppContext();
           // context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            VideoRepository = new VideoRepositoryEFMemory(context);
            OrderRepository = new OrderRepository(context);
            
        }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
