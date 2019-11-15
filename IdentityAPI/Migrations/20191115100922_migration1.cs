using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityAPI.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusInfo",
                columns: table => new
                {
                    BusInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FromLocation = table.Column<string>(nullable: false),
                    ToLocation = table.Column<string>(nullable: false),
                    TravelDate = table.Column<DateTime>(nullable: false),
                    BusType = table.Column<string>(nullable: false),
                    CompanyName = table.Column<string>(nullable: false),
                    BusFare = table.Column<double>(nullable: false),
                    TicketsCount = table.Column<int>(nullable: false),
                    BusArrivalTime = table.Column<string>(nullable: true),
                    BusDepartureTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusInfo", x => x.BusInfoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusInfo");
        }
    }
}
