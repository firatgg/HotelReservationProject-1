using Data.Identity;
using Entity.Entites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data.Contexts
{
    public class HotelDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options) { }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define relationships
            modelBuilder.Entity<Hotel>()
                .HasMany(h => h.Rooms)
                .WithOne(r => r.Hotel)
                .HasForeignKey(r => r.HotelId);

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Reservations)
                .WithOne(r => r.Customer)
                .HasForeignKey(r => r.CustomerId);

            modelBuilder.Entity<Room>()
                .HasMany(r => r.Reservations)
                .WithOne(res => res.Room)
                .HasForeignKey(res => res.RoomId);

            modelBuilder.Entity<Reservation>()
                .HasMany(res => res.Payments)
                .WithOne(p => p.Reservation)
                .HasForeignKey(p => p.ReservationId);
           
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Reservation)
                .WithMany(r => r.Payments)
                .HasForeignKey(p => p.ReservationId);


            // Seed data
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    HotelId = 1,
                    Name = "Büyük Otel",
                    Address = "İstiklal Caddesi No:123",
                    City = "İstanbul",
                    Country = "Türkiye",
                    Description = "Şehrin merkezinde lüks bir otel.",
                    Rating = 4.5,
                    PictureUrl="/images/hotel-1.jpg"
                    
					//PictureUrl = "/images/7.jpg"
				},
                new Hotel
                {
                    HotelId = 2,
                    Name = "Deniz Manzaralı Otel",
                    Address = "Sahil Yolu No:456",
                    City = "Antalya",
                    Country = "Türkiye",
                    Description = "Deniz manzaralı güzel bir otel.",
                    Rating = 4.7,
					PictureUrl = "/images/hotel-2.jpg"
				}
            );

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = 1,
                    RoomNumber = "101",
                    Type = "Tek Kişilik",
                    Price = 750.00m, // TL cinsinden
                    Description = "Konforlu tek kişilik oda",
                    IsAvailable = true,
                    HotelId = 1
                },
                new Room
                {
                    RoomId = 2,
                    RoomNumber = "102",
                    Type = "Çift Kişilik",
                    Price = 1200.00m, // TL cinsinden
                    Description = "Geniş çift kişilik oda",
                    IsAvailable = true,
                    HotelId = 1
                },
                new Room
                {
                    RoomId = 3,
                    RoomNumber = "201",
                    Type = "Tek Kişilik",
                    Price = 850.00m, // TL cinsinden
                    Description = "Deniz manzaralı tek kişilik oda",
                    IsAvailable = true,
                    HotelId = 2
                }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    FirstName = "Ahmet",
                    LastName = "Yılmaz",
                    Email = "ahmet.yilmaz@example.com",
                    Phone = "0532-123-4567",
                    IdentityUserId = "1"
                },
                new Customer
                {
                    CustomerId = 2,
                    FirstName = "Ayşe",
                    LastName = "Kara",
                    Email = "ayse.kara@example.com",
                    Phone = "0543-987-6543",
                    IdentityUserId = "2"
                }
            );

            modelBuilder.Entity<Payment>().HasData(
                new Payment
                {
                    PaymentId = 1,
                    PaymentDate = new DateTime(2024, 6, 28),
                    Amount = 1000.00m, // TL cinsinden
                    PaymentMethod = "Kredi Kartı",
                    ReservationId = 1
                },
                new Payment
                {
                    PaymentId = 2,
                    PaymentDate = new DateTime(2024, 6, 29),
                    Amount = 2000.00m, // TL cinsinden
                    PaymentMethod = "Nakit",
                    ReservationId = 2
                }
            );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation
                {
                    ReservationId = 1,
                    CheckInDate = new DateTime(2024, 6, 28),
                    CheckOutDate = new DateTime(2024, 6, 30),
                    TotalPrice = 1500.00m, // TL cinsinden
                    ReservationStatus = "Onaylandı",
                    CustomerId = 1,
                    RoomId = 1
                },
                new Reservation
                {
                    ReservationId = 2,
                    CheckInDate = new DateTime(2024, 7, 1),
                    CheckOutDate = new DateTime(2024, 7, 5),
                    TotalPrice = 4000.00m, // TL cinsinden
                    ReservationStatus = "Onaylandı",
                    CustomerId = 2,
                    RoomId = 3
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
