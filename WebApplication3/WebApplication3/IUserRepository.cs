using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
