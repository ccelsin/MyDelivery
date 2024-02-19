using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyDelivery.Models;

namespace MyDelivery.Data
{
    public class MyDeliveryContext : DbContext
    {
        public MyDeliveryContext (DbContextOptions<MyDeliveryContext> options)
            : base(options)
        {
        }

        public DbSet<MyDelivery.Models.Order> Order { get; set; } = default!;

        public DbSet<MyDelivery.Models.Customer>? Customer { get; set; }
    }
}
