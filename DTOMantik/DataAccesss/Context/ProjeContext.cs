using DataAccesss.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesss.Context
{
    public class ProjeContext:DbContext
    {

        public DbSet<University> Universities { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<User> Users { get; set; }  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PBFD0LU;  database=DTOMantik; integrated security=true; TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Student>(entity =>//herzaman çokluu üzerinden ilrle
            {
                entity.HasOne(x => x.University).WithMany(x => x.students).HasForeignKey(x => x.UniversityID);
                entity.HasOne(x => x.User).WithMany(x => x.Students).HasForeignKey(x => x.CreatedBy);
                //entity.HasOne(x => x.User).WithMany(x => x.Students).HasForeignKey(x => x.UpdatedBy);

            });

          

            modelBuilder.Entity<University>(entity =>// entity hangisi verilmişse onun içindeki varklar gelir
            {
                entity.HasOne(x => x.User).WithMany(x => x.Universities).HasForeignKey(x => x.CreatedBy);
                //entity.HasOne(x => x.User).WithMany(x => x.Universities).HasForeignKey(x => x.UpdatedBy); // güncelleştirme yapan kişiyi yapmak olmadı 
            });

            base.OnModelCreating(modelBuilder);
        }


        
    }
}
