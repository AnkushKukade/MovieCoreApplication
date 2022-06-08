using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp.Data.Migrations
{
    public partial class migrationname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movieModel",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieModel", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "theatreModel",
                columns: table => new
                {
                    TheatreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TheatreName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TheatreLocation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_theatreModel", x => x.TheatreId);
                });

            migrationBuilder.CreateTable(
                name: "userModel",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userModel", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "movieShowTimeModel",
                columns: table => new
                {
                    ShowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    TheatreId = table.Column<int>(type: "int", nullable: false),
                    ShowTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieShowTimeModel", x => x.ShowId);
                    table.ForeignKey(
                        name: "FK_movieShowTimeModel_movieModel_MovieId",
                        column: x => x.MovieId,
                        principalTable: "movieModel",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movieShowTimeModel_theatreModel_TheatreId",
                        column: x => x.TheatreId,
                        principalTable: "theatreModel",
                        principalColumn: "TheatreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bookingModel",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<int>(type: "int", nullable: false),
                    MId = table.Column<int>(type: "int", nullable: false),
                    TId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookingModel", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_bookingModel_movieModel_MId",
                        column: x => x.MId,
                        principalTable: "movieModel",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookingModel_theatreModel_TId",
                        column: x => x.TId,
                        principalTable: "theatreModel",
                        principalColumn: "TheatreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookingModel_userModel_UId",
                        column: x => x.UId,
                        principalTable: "userModel",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookingModel_MId",
                table: "bookingModel",
                column: "MId");

            migrationBuilder.CreateIndex(
                name: "IX_bookingModel_TId",
                table: "bookingModel",
                column: "TId");

            migrationBuilder.CreateIndex(
                name: "IX_bookingModel_UId",
                table: "bookingModel",
                column: "UId");

            migrationBuilder.CreateIndex(
                name: "IX_movieShowTimeModel_MovieId",
                table: "movieShowTimeModel",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_movieShowTimeModel_TheatreId",
                table: "movieShowTimeModel",
                column: "TheatreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookingModel");

            migrationBuilder.DropTable(
                name: "movieShowTimeModel");

            migrationBuilder.DropTable(
                name: "userModel");

            migrationBuilder.DropTable(
                name: "movieModel");

            migrationBuilder.DropTable(
                name: "theatreModel");
        }
    }
}
