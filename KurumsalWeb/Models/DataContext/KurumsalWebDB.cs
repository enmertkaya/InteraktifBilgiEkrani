using KurumsalWeb.Models.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KurumsalWeb.Models.DataContext
{
    public class KurumsalWebDB : DbContext
    {
        public KurumsalWebDB():base("KurumsalWebDB")
        {

        }
        public DbSet <Department>Deparments { get; set; }
        public DbSet <Faculty>Faculties { get; set; }
        public DbSet <New>News { get; set; }
        public DbSet <Role>Roles { get; set; }
        public DbSet <Tv>Tvs { get; set; }
        public DbSet <User>Users { get; set; }
    }
}