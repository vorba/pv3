using System.Configuration;
using Microsoft.Ajax.Utilities;
using Purevision.Web.Helpers;
using Purevision.Web.Models;

namespace Purevision.Web.DataContexts
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PurevisionDb : DbContext
    {
        public PurevisionDb()
            : base("name=DefaultLocalDev")
        {
            Database.Connection.ConnectionString = ConnectionStringHelpers.GetHostBasedConnectionString();
        }

        //public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        //public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        //public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        //public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

        //public virtual DbSet<Business> Businesses { get; set; }
        //public virtual DbSet<BusinessProfile> BusinessProfiles { get; set; }
        //public virtual DbSet<ClientProfile> ClientProfiles { get; set; }
        //public virtual DbSet<Client> Clients { get; set; }
        //public virtual DbSet<Company> Companies { get; set; }
        //public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<MeetingAttendee> MeetingAttendees { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<Person> People { get; set; }
        //public virtual DbSet<ProfileProperty> ProfileProperties { get; set; }
        //public virtual DbSet<Task> Tasks { get; set; }
        //public virtual DbSet<UserProfile> UserProfiles { get; set; }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<AspNetRole>()
            //    .HasMany(e => e.AspNetUsers)
            //    .WithMany(e => e.AspNetRoles)
            //    .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            //modelBuilder.Entity<AspNetUser>()
            //    .HasMany(e => e.AspNetUserClaims)
            //    .WithRequired(e => e.AspNetUser)
            //    .HasForeignKey(e => e.UserId);

            //modelBuilder.Entity<AspNetUser>()
            //    .HasMany(e => e.AspNetUserLogins)
            //    .WithRequired(e => e.AspNetUser)
            //    .HasForeignKey(e => e.UserId);

            //modelBuilder.Entity<Business>()
            //    .Property(e => e.Number)
            //    .IsFixedLength();

            //modelBuilder.Entity<BusinessProfile>()
            //    .Property(e => e.ExtendedVisibility)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ClientProfile>()
            //    .Property(e => e.ExtendedVisibility)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Client>()
            //    .Property(e => e.Name)
            //    .IsFixedLength();

            //modelBuilder.Entity<Meeting>()
            //    .HasMany(e => e.MeetingAttendees)
            //    .WithRequired(e => e.Meeting)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Meeting>()
            //    .HasMany(e => e.Meetings1)
            //    .WithOptional(e => e.Meeting1)
            //    .HasForeignKey(e => e.RecurrenceID);

            //modelBuilder.Entity<Person>()
            //    .Property(e => e.FirstName)
            //    .IsFixedLength();

            //modelBuilder.Entity<Person>()
            //    .Property(e => e.LastName)
            //    .IsFixedLength();

            //modelBuilder.Entity<ProfileProperty>()
            //    .HasMany(e => e.BusinessProfiles)
            //    .WithRequired(e => e.ProfileProperty)
            //    .HasForeignKey(e => e.PropertyId);

            //modelBuilder.Entity<ProfileProperty>()
            //    .HasMany(e => e.ClientProfiles)
            //    .WithRequired(e => e.ProfileProperty)
            //    .HasForeignKey(e => e.PropertyId);

            //modelBuilder.Entity<ProfileProperty>()
            //    .HasMany(e => e.UserProfiles)
            //    .WithRequired(e => e.ProfileProperty)
            //    .HasForeignKey(e => e.PropertyId);

            //modelBuilder.Entity<UserProfile>()
            //    .Property(e => e.ExtendedVisibility)
            //    .IsUnicode(false);
        }
    }
}
