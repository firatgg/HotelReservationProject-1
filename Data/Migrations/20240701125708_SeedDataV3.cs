using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { "ahmet.yilmaz@example.com", "Ahmet", "Yılmaz", "0532-123-4567" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { "ayse.kara@example.com", "Ayşe", "Kara", "0543-987-6543" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 1,
                columns: new[] { "Address", "City", "Country", "Description", "Name" },
                values: new object[] { "İstiklal Caddesi No:123", "İstanbul", "Türkiye", "Şehrin merkezinde lüks bir otel.", "Büyük Otel" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 2,
                columns: new[] { "Address", "City", "Country", "Description", "Name" },
                values: new object[] { "Sahil Yolu No:456", "Antalya", "Türkiye", "Deniz manzaralı güzel bir otel.", "Deniz Manzaralı Otel" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 1,
                columns: new[] { "Amount", "PaymentMethod" },
                values: new object[] { 1000.00m, "Kredi Kartı" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 2,
                columns: new[] { "Amount", "PaymentMethod" },
                values: new object[] { 2000.00m, "Nakit" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "ReservationStatus", "TotalPrice" },
                values: new object[] { "Onaylandı", 1500.00m });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "ReservationStatus", "TotalPrice" },
                values: new object[] { "Onaylandı", 4000.00m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                columns: new[] { "Description", "Price", "Type" },
                values: new object[] { "Konforlu tek kişilik oda", 750.00m, "Tek Kişilik" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                columns: new[] { "Description", "Price", "Type" },
                values: new object[] { "Geniş çift kişilik oda", 1200.00m, "Çift Kişilik" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                columns: new[] { "Description", "Price", "Type" },
                values: new object[] { "Deniz manzaralı tek kişilik oda", 850.00m, "Tek Kişilik" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { "john.doe@example.com", "John", "Doe", "555-1234" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { "jane.smith@example.com", "Jane", "Smith", "555-5678" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 1,
                columns: new[] { "Address", "City", "Country", "Description", "Name" },
                values: new object[] { "123 Main St", "Springfield", "USA", "A luxurious hotel in the heart of the city.", "Grand Hotel" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 2,
                columns: new[] { "Address", "City", "Country", "Description", "Name" },
                values: new object[] { "456 Beach Ave", "Miami", "USA", "A beautiful hotel with a view of the ocean.", "Ocean View" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 1,
                columns: new[] { "Amount", "PaymentMethod" },
                values: new object[] { 100.00m, "Credit Card" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 2,
                columns: new[] { "Amount", "PaymentMethod" },
                values: new object[] { 200.00m, "Cash" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "ReservationStatus", "TotalPrice" },
                values: new object[] { "Confirmed", 150.00m });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "ReservationStatus", "TotalPrice" },
                values: new object[] { "Confirmed", 400.00m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1,
                columns: new[] { "Description", "Price", "Type" },
                values: new object[] { "Cozy single room", 75.50m, "Single" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                columns: new[] { "Description", "Price", "Type" },
                values: new object[] { "Spacious double room", 120.00m, "Double" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                columns: new[] { "Description", "Price", "Type" },
                values: new object[] { "Single room with a sea view", 85.00m, "Single" });
        }
    }
}
