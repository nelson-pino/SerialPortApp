using System.Data.Entity;
using SerialPortApp.Models;


namespace SerialPortApp.Datalayer
{
    public class AppDbContextSqlServer : DbContext
    {

        public AppDbContextSqlServer()
            : base("name=LocalDbContext")
        {
        }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Batchs> Batchs { get; set; }
    }
}
