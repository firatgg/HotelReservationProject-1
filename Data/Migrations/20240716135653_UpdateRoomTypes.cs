using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRoomTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                columns: new[] { "Description", "HotelId", "Price", "RoomNumber", "Type" },
                values: new object[] { "Geniş aile odası", 1, 1200.00m, "102", "Aile Odask" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "Description", "HotelId", "IsAvailable", "PictureUrl", "Price", "RoomNumber", "Type" },
                values: new object[,]
                {
                    { 4, "Lüks süit oda.", 1, true, "", 850.00m, "201", "Süit" },
                    { 5, "Deniz manzaralı tek kişilik oda", 2, true, "", 850.00m, "201", "Tek kişilik" },
                    { 6, "Geniş çift kişilik oda", 2, true, "", 850.00m, "201", "Çift Kişik" },
                    { 7, "Geniş aile odası", 2, true, "", 850.00m, "201", "Aile Odask" },
                    { 8, "Lüks süit oda.", 2, true, "", 850.00m, "201", "Süit" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3,
                columns: new[] { "Description", "HotelId", "Price", "RoomNumber", "Type" },
                values: new object[] { "Deniz manzaralı tek kişilik oda", 2, 850.00m, "201", "Tek Kişilik" });
        }
    }
}
