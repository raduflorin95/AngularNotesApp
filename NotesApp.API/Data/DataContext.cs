using Microsoft.EntityFrameworkCore;
using NotesApp.API.Models;

namespace NotesApp.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}        
        public DbSet<Value> Values { get; set; }
    }
}