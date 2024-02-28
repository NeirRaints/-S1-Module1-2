using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicBigBoarsWeb.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hospitalization",
                columns: table => new
                {
                    HospitalizationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    HospitalizationCode = table.Column<int>(type: "int", nullable: false),
                    AppointedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    HospitalizationObj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conditions = table.Column<string>(type: "int", nullable: true),
                    DeadlineDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Additionally = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitalization", x => x.HospitalizationId);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PassportNumSerial = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Birthday = table.Column<DateTime>(type: "date", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedCardNum = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    MedCardDate = table.Column<DateTime>(type: "date", nullable: false),
                    LastVizitDate = table.Column<DateTime>(type: "date", nullable: false),
                    NextVizitDate = table.Column<DateTime>(type: "date", nullable: true),
                    PolisNum = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    PolisDate = table.Column<DateTime>(type: "date", nullable: false),
                    Diagnose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalHistory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.PatientId);
                });

            migrationBuilder.CreateTable(
                name: "TherapMeasures",
                columns: table => new
                {
                    MeasureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    EventDate = table.Column<DateTime>(type: "date", nullable: false),
                    Doctor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Event = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EventName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Results = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recomendations = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TherapMeasures", x => x.MeasureId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hospitalization");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "TherapMeasures");
        }
    }
}
