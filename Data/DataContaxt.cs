using Microsoft.EntityFrameworkCore;
using Udemy_NetCore.Models;

namespace Udemy_NetCore.Data
{
    public class DataContaxt : DbContext
    {
        public DataContaxt(DbContextOptions<DataContaxt> options) : base(options)
        {
            
        }

        // always: representation of Model in db, you have to add a database set of this model 
        public DbSet<Character> Characters { get; set; }
    }
}