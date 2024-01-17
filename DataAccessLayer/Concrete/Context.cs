
using EntityLayer.concerete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= DESKTOP-17KBFCT\\SQLEXPRESS;database=rezervasyonDb;integrated security=true;");


        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<About2> About2s { get; set; }
        public DbSet<contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<feature> features { get; set; }
        public DbSet<feature2> Feature2s { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }


    }
}
