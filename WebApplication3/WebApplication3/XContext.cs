using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3
{
    public class XContext : DbContext
    {
        public XContext(DbContextOptions<XContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
