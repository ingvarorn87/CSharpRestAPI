using System;
using System.Collections.Generic;
using System.Text;
using VideoManagerDAL.Repositories;
using VideoManagerDAL.UOW;

namespace VideoManagerDAL
{
    public class DALFacade
    { 
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return new UnitOfWork();
            }
        }
    }
}
