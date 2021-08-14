using BookingTrip.Domin;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTrip.Persistence
{
    class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<ReservationTable> reservations { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<TripDetails> tripDetails { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Customer>()
        //    .Property(f => f.CustomerId)
        //    .ValueGeneratedOnAdd();

        //    modelBuilder.Entity<ReservationTable>()
        //    .Property(f => f.Id)
        //    .ValueGeneratedOnAdd();

        //    modelBuilder.Entity<TripDetails>()
        //    .Property(f => f.TripId)
        //    .ValueGeneratedOnAdd();

        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = 1,
                CustomerName = "Ahmed Hassan",
                Email = "ahmedHassan@gmail.com",
                Password = "012345-ABcd"
            });
            modelBuilder.Entity<TripDetails>().HasData(new TripDetails
            {
                CityName = "Cairo",
                Content = " Some Content",
                CreationDate = new DateTime(2011, 6, 10),
                ImageUrl = "skxksxskx ",
                Price = 1000,
                TripId = 1,
                TripName = "Cairo museum"
            });

            modelBuilder.Entity<ReservationTable>().HasData(new ReservationTable
            {
                Id = 1,
                CustomerName = "Ahmed Hassan",
                CreationDate = new DateTime(2011, 6, 10),
                ReservationDate = new DateTime(2011, 6, 15),
                ResreverdByCustomerId = 1,
                TripId = 1,
                Note = "mxmacmcffewp"

            });
        }

    }
}