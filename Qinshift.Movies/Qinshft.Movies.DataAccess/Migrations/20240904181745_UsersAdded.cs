using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qinshft.Movies.DataAccess.Migrations
{
    public partial class UsersAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedOn", "FirstName", "LastName", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2639), "Viktor", "Mileski", "test123", "v_mileski" },
                    { 2, new DateTime(2024, 9, 4, 20, 17, 45, 492, DateTimeKind.Local).AddTicks(2644), "Slave", "Ivanovski", "test123", "s_ivanovski" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

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

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 27, 1, 56, 51, 324, DateTimeKind.Local).AddTicks(3382));
        }
    }
}
