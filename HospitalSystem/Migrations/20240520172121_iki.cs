using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalSystem.Migrations
{
    /// <inheritdoc />
    public partial class iki : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Hospital_HospitalId",
                table: "Appointment");

            migrationBuilder.AlterColumn<int>(
                name: "HospitalId",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Hospital_HospitalId",
                table: "Appointment",
                column: "HospitalId",
                principalTable: "Hospital",
                principalColumn: "HospitalId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Hospital_HospitalId",
                table: "Appointment");

            migrationBuilder.AlterColumn<int>(
                name: "HospitalId",
                table: "Appointment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Hospital_HospitalId",
                table: "Appointment",
                column: "HospitalId",
                principalTable: "Hospital",
                principalColumn: "HospitalId");
        }
    }
}
