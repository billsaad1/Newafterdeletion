using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HumanitarianProjectManagement.Migrations
{
    public partial class ImplementFullBudgetHierarchyFKs_NoCascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailedBudgetLine_BudgetSubCategory_BudgetSubCategoryID",
                table: "DetailedBudgetLine");

            migrationBuilder.AddColumn<Guid>(
                name: "ParentDetailedBudgetLineID",
                table: "BudgetSubCategory",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$Dro5.Y/eC0YLClfhDhqu8eHN0IclJrQs/.BAU8w.LCYTGpfpokL7C");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetSubCategory_ParentDetailedBudgetLineID",
                table: "BudgetSubCategory",
                column: "ParentDetailedBudgetLineID");

            migrationBuilder.AddForeignKey(
                name: "FK_BudgetSubCategory_DetailedBudgetLine_ParentDetailedBudgetLineID",
                table: "BudgetSubCategory",
                column: "ParentDetailedBudgetLineID",
                principalTable: "DetailedBudgetLine",
                principalColumn: "DetailedBudgetLineID");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailedBudgetLine_BudgetSubCategory_BudgetSubCategoryID",
                table: "DetailedBudgetLine",
                column: "BudgetSubCategoryID",
                principalTable: "BudgetSubCategory",
                principalColumn: "BudgetSubCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BudgetSubCategory_DetailedBudgetLine_ParentDetailedBudgetLineID",
                table: "BudgetSubCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailedBudgetLine_BudgetSubCategory_BudgetSubCategoryID",
                table: "DetailedBudgetLine");

            migrationBuilder.DropIndex(
                name: "IX_BudgetSubCategory_ParentDetailedBudgetLineID",
                table: "BudgetSubCategory");

            migrationBuilder.DropColumn(
                name: "ParentDetailedBudgetLineID",
                table: "BudgetSubCategory");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$ZdZy/J2iepo74134hxjJZObWtvnziJJZENQ7MORDIQfcx5fcpic7e");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailedBudgetLine_BudgetSubCategory_BudgetSubCategoryID",
                table: "DetailedBudgetLine",
                column: "BudgetSubCategoryID",
                principalTable: "BudgetSubCategory",
                principalColumn: "BudgetSubCategoryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
