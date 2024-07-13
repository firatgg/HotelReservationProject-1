using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { 2, "jane.smith@example.com", "Jane", "Smith", "555-5678" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "Address", "City", "Country", "Description", "Name", "Rating" },
                values: new object[] { 2, "456 Beach Ave", "Miami", "USA", "A beautiful hotel with a view of the ocean.", "Ocean View", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 1,
                column: "Amount",
                value: 100.00m);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "TotalPrice",
                value: 150.00m);

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "Description", "HotelId", "IsAvailable", "Price", "RoomNumber", "Type" },
                values: new object[,]
                {
                    { 2, "Spacious double room", 1, true, 120.00m, "102", "Double" },
                    { 3, "Single room with a sea view", 2, true, 85.00m, "201", "Single" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "CheckInDate", "CheckOutDate", "CustomerId", "ReservationStatus", "RoomId", "TotalPrice" },
                values: new object[] { 2, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Confirmed", 3, 400.00m });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentId", "Amount", "PaymentDate", "PaymentMethod", "ReservationId" },
                values: new object[] { 2, 200.00m, new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cash", 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 1,
                column: "Amount",
                value: 10000m);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "TotalPrice",
                value: 500m);
        }
    }
}
