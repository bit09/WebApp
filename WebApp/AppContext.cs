using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp.Controllers;
using WebApp.Models;

namespace WebApp
{
    public class AppContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public AppContext()
            : base("DefaultConnection")
        {

        }
    }
}