using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MovieId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    SeatNo = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false),
                    price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DateAndTime = table.Column<DateTime>(nullable: false),
                    Pictures = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookingTables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SeatNo = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    time = table.Column<DateTime>(nullable: false),
                    MovieId = table.Column<int>(nullable: false),
                    price = table.Column<int>(nullable: false),
                    MovieDetailsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingTables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingTables_MovieDetails_MovieDetailsId",
                        column: x => x.MovieDetailsId,
                        principalTable: "MovieDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingTables_MovieDetailsId",
                table: "BookingTables",
                column: "MovieDetailsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingTables");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "MovieDetails");
        }
    }
}
