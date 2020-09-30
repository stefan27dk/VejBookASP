using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VejBookASP.Database.Migrations.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BCalendars",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BCalendars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    LastName = table.Column<string>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.LastName);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    LastName = table.Column<string>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.LastName);
                });

            migrationBuilder.CreateTable(
                name: "Timeslots",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timeslots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Holds",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BCalendarId = table.Column<Guid>(nullable: true),
                    StudentLastName = table.Column<string>(nullable: true),
                    TeacherLastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Holds_BCalendars_BCalendarId",
                        column: x => x.BCalendarId,
                        principalTable: "BCalendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Holds_Students_StudentLastName",
                        column: x => x.StudentLastName,
                        principalTable: "Students",
                        principalColumn: "LastName",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Holds_Teachers_TeacherLastName",
                        column: x => x.TeacherLastName,
                        principalTable: "Teachers",
                        principalColumn: "LastName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Holds_BCalendarId",
                table: "Holds",
                column: "BCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_Holds_StudentLastName",
                table: "Holds",
                column: "StudentLastName");

            migrationBuilder.CreateIndex(
                name: "IX_Holds_TeacherLastName",
                table: "Holds",
                column: "TeacherLastName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Holds");

            migrationBuilder.DropTable(
                name: "Timeslots");

            migrationBuilder.DropTable(
                name: "BCalendars");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
