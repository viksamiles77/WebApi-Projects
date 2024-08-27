using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qinshft.Movies.DataAccess.Migrations
{
    public partial class AddMoreMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedOn", "Description", "Genre", "Title", "Year" },
                values: new object[,]
                {
                    { 6, new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3342), "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", 3, "Interstellar", 2014 },
                    { 7, new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3345), "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.", 1, "Gladiator", 2000 },
                    { 8, new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3348), "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", 5, "The Shawshank Redemption", 1994 },
                    { 9, new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3350), "The lives of two mob hitmen, a boxer, a gangster, and his wife intertwine in four tales of violence and redemption.", 1, "Pulp Fiction", 1994 },
                    { 10, new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3354), "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", 5, "Fight Club", 1999 },
                    { 11, new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3357), "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal, and other historical events unfold from the perspective of an Alabama man with an IQ of 75.", 5, "Forrest Gump", 1994 },
                    { 12, new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3360), "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.", 3, "The Matrix", 1999 },
                    { 13, new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3362), "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", 3, "The Lord of the Rings: The Return of the King", 2003 },
                    { 14, new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3365), "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", 4, "The Godfather", 1972 },
                    { 15, new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3367), "In German-occupied Poland during World War II, Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", 5, "Schindler's List", 1993 },
                    { 16, new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3370), "In Nazi-occupied France during World War II, a plan to assassinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same.", 1, "Inglourious Basterds", 2009 },
                    { 17, new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3373), "A young FBI cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.", 4, "The Silence of the Lambs", 1991 },
                    { 18, new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3376), "Following the Normandy Landings, a group of U.S. soldiers go behind enemy lines to retrieve a paratrooper whose brothers have been killed in action.", 5, "Saving Private Ryan", 1998 },
                    { 19, new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3379), "Scottish warrior William Wallace leads his countrymen in a rebellion to free his homeland from the tyranny of King Edward I of England.", 1, "Braveheart", 1995 },
                    { 20, new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3382), "Based on the true story of Jordan Belfort, from his rise to a wealthy stock-broker living the high life to his fall involving crime, corruption, and the federal government.", 5, "The Wolf of Wall Street", 2013 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 41, 0, 247, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 41, 0, 247, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 41, 0, 247, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 41, 0, 247, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 26, 19, 41, 0, 247, DateTimeKind.Local).AddTicks(6249));
        }
    }
}
