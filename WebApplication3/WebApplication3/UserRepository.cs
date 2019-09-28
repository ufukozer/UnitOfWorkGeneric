using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private XContext _xContext;

        public UserRepository(XContext xContext) : base(xContext)
        {
            _xContext = xContext;
        }
    }
}
