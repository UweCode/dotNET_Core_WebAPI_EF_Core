using Microsoft.EntityFrameworkCore;
using Udemy_NetCore.Models;

namespace Udemy_NetCore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        // always: representation of Model in db, you have to add a database set of this model 
        public DbSet<Character> Characters { get; set; }
    }
}