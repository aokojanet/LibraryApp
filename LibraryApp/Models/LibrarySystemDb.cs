using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
namespace LibraryApp.Models
{
    public class LibrarySystemDb(DbContextOptions<LibrarySystemDb> options) : DbContext(options)
    {
        
        public DbSet<Books> Books { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}



