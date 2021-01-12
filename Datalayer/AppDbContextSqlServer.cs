using System.Data.Entity;
using SerialPortApp.Models;


namespace SerialPortApp.Datalayer
{
    public class AppDbContextSqlServer : DbContext
    {

        public AppDbContextSqlServer()
            : base(Properties.Resources.CONNECTION_STRING_SQLSERVER)
        {
        }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Batchs> Batchs { get; set; }
    }
}
