using DawProjectAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DawProjectAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; } 


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(a => a.Id);
                entity.Property(a => a.City)
                    .IsRequired();

                entity.HasOne(a => a.Student)
                    .WithOne(s => s.Address)
                    .HasForeignKey<Address>(a => a.StudentID)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(a => a.Id);
                entity.Property(a => a.Name)
                    .IsRequired();

                entity.HasOne(s => s.Address)
                    .WithOne(a => a.Student)
                    .HasForeignKey<Student>(s => s.AddressId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasKey(a => a.Id);
                entity.Property(a => a.Name)
                    .IsRequired();
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(a => a.Id);
                entity.Property(a => a.Title)
                    .IsRequired();

                entity.HasOne(b => b.Subject)
                    .WithMany(s => s.Books) 
                    .HasForeignKey(b => b.SubjectId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<StudentSubject>(entity =>
            {
                entity.HasKey(ss => new { ss.StudentId, ss.SubjectId});

                entity.HasOne(ss => ss.Subject)
                    .WithMany(s => s.StudentSubjects)
                    .HasForeignKey(ss => ss.SubjectId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(ss => ss.Student)
                    .WithMany(s => s.StudentSubjects)
                    .HasForeignKey(ss => ss.StudentId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
