using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qinshft.Movies.DataAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedOn", "Description", "Genre", "Title", "Year" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 26, 19, 41, 0, 247, DateTimeKind.Local).AddTicks(6207), "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster.", 3, "Inception", 2010 },
                    { 2, new DateTime(2024, 8, 26, 19, 41, 0, 247, DateTimeKind.Local).AddTicks(6242), "Teddy Daniels and Chuck Aule, two US marshals, are sent to an asylum on a remote island in order to investigate the disappearance of a patient, where Teddy uncovers a shocking truth about the place.", 4, "Shutter Island", 2010 },
                    { 3, new DateTime(2024, 8, 26, 19, 41, 0, 247, DateTimeKind.Local).AddTicks(6245), "An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang in South Boston.", 5, "The Departed", 2006 },
                    { 4, new DateTime(2024, 8, 26, 19, 41, 0, 247, DateTimeKind.Local).AddTicks(6247), "An astronaut becomes stranded on Mars after his team assume him dead, and must rely on his ingenuity to find a way to signal to Earth that he is alive and can survive until a potential rescue.", 2, "The Martian", 2015 },
                    { 5, new DateTime(2024, 8, 26, 19, 41, 0, 247, DateTimeKind.Local).AddTicks(6249), "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.", 1, "The Dark Knight", 2008 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
