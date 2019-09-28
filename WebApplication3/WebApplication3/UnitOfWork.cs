using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3
{
    public class UnitOfWork : IUnitOfWork
    {
        private XContext _xContext;

        public UnitOfWork(XContext xContext)
        {
            _xContext = xContext;
            UserRepository = new UserRepository(xContext);
        }
        public IUserRepository UserRepository { get; set; }

        public int Complete()
        {
           return _xContext.SaveChanges();
        }

        public void Dispose()
        {
            _xContext.Dispose();
        }
    }
}
