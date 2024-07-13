using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PictureUrl",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 1,
                column: "PictureUrl",
                value: "/images/hotel-1.jpg");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 2,
                column: "PictureUrl",
                value: "/images/hotel-2.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureUrl",
                table: "Hotels");
        }
    }
}
