using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alten.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerVehicles",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false),
                    VehicleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerVehicles", x => new { x.CustomerId, x.VehicleId });
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VehicleId = table.Column<string>(nullable: true),
                    RegistrationNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CustomerVehicles",
                columns: new[] { "CustomerId", "VehicleId" },
                values: new object[,]
                {
                    { 3, 6 },
                    { 3, 7 },
                    { 2, 5 },
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[,]
                {
                    { 1, "Cementvägen 8, 111 11 Södertälje", "Kalles Grustransporter AB" },
                    { 2, "Balkvägen 12, 222 22 Stockholm", "Johans Bulk AB" },
                    { 3, "Budgetvägen 1, 333 33 Uppsala", "Haralds Värdetransporter AB" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "RegistrationNo", "VehicleId" },
                values: new object[,]
                {
                    { 6, "PQR678", "VLUR4X20009048066" },
                    { 1, "ABC123", "YS2R4X20005399401" },
                    { 2, "DEF456", "VLUR4X20009093588" },
                    { 3, "GHI789", "VLUR4X20009048066" },
                    { 4, "JKL012", "YS2R4X20005388011" },
                    { 5, "MNO345", "YS2R4X20005387949" },
                    { 7, "STU901", "YS2R4X20005387055" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "CustomerVehicles");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
