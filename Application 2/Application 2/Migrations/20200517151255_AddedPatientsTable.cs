using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Application_2.Migrations
{
    public partial class AddedPatientsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "IdPatient", "Birthdate", "FirstName", "LastName" },
                values: new object[] { 1, new DateTime(1990, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kajetan", "Kajetanowicz" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "IdPatient", "Birthdate", "FirstName", "LastName" },
                values: new object[] { 2, new DateTime(1994, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aleksandra", "Iksinska" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2);
        }
    }
}
