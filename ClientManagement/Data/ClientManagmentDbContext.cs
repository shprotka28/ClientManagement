using Microsoft.EntityFrameworkCore;
using ClientManagement.Models;

namespace ClientManagement.Data
{
    public class ClientManagmentDbContext : DbContext
    {
        public ClientManagmentDbContext(DbContextOptions<ClientManagmentDbContext> options)
            : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Address> Addresses { get; set; }

    }
}
