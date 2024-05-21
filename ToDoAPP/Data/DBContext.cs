using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Text;
using ToDoApp.Entity;

namespace ToDoApp.Data
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
        : base(options)
        { }

        public DbSet<Notes> notes { get; set; }
    


    }
}
