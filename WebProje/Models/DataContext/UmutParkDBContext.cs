using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebProje.Models.Model;

namespace WebProje.Models.DataContext
{
    public class UmutParkDBContext:DbContext
    {
        public UmutParkDBContext():base("UmutParkDB")
        {
            
        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Hakkimizda> Hakkimizda { get; set; }
        public DbSet<Hizmet> Hizmet { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Kimlik> Kimlik { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<Slider> Slider { get; set; }
    }
}