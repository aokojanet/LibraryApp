using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;
namespace LibraryApp.Models
{
    public class LibrarySystemDb(DbContextOptions<LibrarySystemDb> options) : DbContext(options)
	{
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Authors>()
				.HasMany( b => b.Books)
				.WithOne(b => b.Authors)
				.HasForeignKey(b => b.Id);
				
			   
				
		}

		public DbSet<Books> Books { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Users> Users { get; set; }

	}
 
}



