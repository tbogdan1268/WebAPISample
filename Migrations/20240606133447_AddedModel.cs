using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPISample.Migrations
{
    /// <inheritdoc />
    public partial class AddedModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Model",
                table: "Airplanes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Airplanes",
                columns: new[] { "Id", "Manufacturer", "Model", "RecordedFlightHours", "EstimatedPrice"},
                values: new object[,]
    {
            { 1, "Boeing", "737", "2500", "250000" },
            { 2, "Airbus", "320", "3500", "350000" }
        // Add more airplanes as needed
    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Model",
                table: "Airplanes");
        }
    }
}
