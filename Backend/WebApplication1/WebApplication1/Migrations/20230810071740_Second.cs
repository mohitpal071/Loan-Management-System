using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loan_Card_Master",
                columns: table => new
                {
                    loan_id = table.Column<string>(type: "varchar(6)", nullable: false),
                    loan_type = table.Column<string>(type: "varchar(15)", nullable: false),
                    duration_in_years = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loan_Card_Master", x => x.loan_id);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Card_Details",
                columns: table => new
                {
                    employee_id = table.Column<string>(type: "varchar(6)", nullable: false),
                    loan_Card_Masterloan_id = table.Column<string>(type: "varchar(6)", nullable: false),
                    card_issue_date = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Employee_Card_Details_Employees_employee_id",
                        column: x => x.employee_id,
                        principalTable: "Employees",
                        principalColumn: "employee_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Card_Details_Loan_Card_Master_loan_Card_Masterloan_id",
                        column: x => x.loan_Card_Masterloan_id,
                        principalTable: "Loan_Card_Master",
                        principalColumn: "loan_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Card_Details_employee_id",
                table: "Employee_Card_Details",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Card_Details_loan_Card_Masterloan_id",
                table: "Employee_Card_Details",
                column: "loan_Card_Masterloan_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee_Card_Details");

            migrationBuilder.DropTable(
                name: "Loan_Card_Master");
        }
    }
}
