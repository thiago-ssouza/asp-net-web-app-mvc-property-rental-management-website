using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ASPNetWebAppMvcPRMWebsite.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using ASP.NETCorePRMWebsite.Models;

namespace ASPNetWebAppMvcPRMWebsite.DAL
{
    public class PRMContext : DbContext
    {
        public PRMContext() : base("PRMContext")
        {
        }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<PropertyManager> PropertyManagers { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ScheduleAppointment> ScheduleAppointments { get; set; }
        public DbSet<ReportEvent> ReportEvents { get; set; }

        //If you want to generate the table names in singular form, uncomment the
        //following code
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        // modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}