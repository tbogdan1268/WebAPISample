using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPISample.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airplanes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordedFlightHours = table.Column<int>(type: "int", nullable: false),
                    EstimatedPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airplanes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Airplanes",
                columns: new[] { "Id", "Manufacturer", "RecordedFlightHours", "EstimatedPrice" },
                values: new object[,]
                {
                        { 1, "Boeing", "2500", "25000000" },
                        { 2, "Airbus", "3000", "30000000"}
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airplanes");
        }
    }
}
