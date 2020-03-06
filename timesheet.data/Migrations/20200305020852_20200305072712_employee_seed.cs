using Microsoft.EntityFrameworkCore.Migrations;

namespace timesheet.data.Migrations
{
    public partial class _20200305072712_employee_seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpId",
                table: "Tasks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_EmpId",
                table: "Tasks",
                column: "EmpId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Employees_EmpId",
                table: "Tasks",
                column: "EmpId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Employees_EmpId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_EmpId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "EmpId",
                table: "Tasks");
        }
    }
}
