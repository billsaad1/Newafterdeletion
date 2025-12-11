using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HumanitarianProjectManagement.Migrations
{
    public partial class ImplementLineOnlyHierarchy_V4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailedBudgetLine_BudgetSubCategory_BudgetSubCategoryID",
                table: "DetailedBudgetLine");

            migrationBuilder.DropTable(
                name: "BudgetSubCategory");

            migrationBuilder.DropIndex(
                name: "IX_DetailedBudgetLine_BudgetSubCategoryID",
                table: "DetailedBudgetLine");

            migrationBuilder.DropColumn(
                name: "BudgetSubCategoryID",
                table: "DetailedBudgetLine");

            migrationBuilder.AddColumn<Guid>(
                name: "ParentDetailedBudgetLineID",
                table: "DetailedBudgetLine",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$SUozKuQonRnbaEsZ8kDlcOXLiumaLspRn6W7d.p6nGcb8cYaLn5WK");

            migrationBuilder.CreateIndex(
                name: "IX_DetailedBudgetLine_ParentDetailedBudgetLineID",
                table: "DetailedBudgetLine",
                column: "ParentDetailedBudgetLineID");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailedBudgetLine_DetailedBudgetLine_ParentDetailedBudgetLineID",
                table: "DetailedBudgetLine",
                column: "ParentDetailedBudgetLineID",
                principalTable: "DetailedBudgetLine",
                principalColumn: "DetailedBudgetLineID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailedBudgetLine_DetailedBudgetLine_ParentDetailedBudgetLineID",
                table: "DetailedBudgetLine");

            migrationBuilder.DropIndex(
                name: "IX_DetailedBudgetLine_ParentDetailedBudgetLineID",
                table: "DetailedBudgetLine");

            migrationBuilder.DropColumn(
                name: "ParentDetailedBudgetLineID",
                table: "DetailedBudgetLine");

            migrationBuilder.AddColumn<Guid>(
                name: "BudgetSubCategoryID",
                table: "DetailedBudgetLine",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "BudgetSubCategory",
                columns: table => new
                {
                    BudgetSubCategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MainCategory = table.Column<int>(type: "int", nullable: false),
                    ParentDetailedBudgetLineID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    SubCategoryCodeSuffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetSubCategory", x => x.BudgetSubCategoryID);
                    table.ForeignKey(
                        name: "FK_BudgetSubCategory_DetailedBudgetLine_ParentDetailedBudgetLineID",
                        column: x => x.ParentDetailedBudgetLineID,
                        principalTable: "DetailedBudgetLine",
                        principalColumn: "DetailedBudgetLineID");
                    table.ForeignKey(
                        name: "FK_BudgetSubCategory_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$Dro5.Y/eC0YLClfhDhqu8eHN0IclJrQs/.BAU8w.LCYTGpfpokL7C");

            migrationBuilder.CreateIndex(
                name: "IX_DetailedBudgetLine_BudgetSubCategoryID",
                table: "DetailedBudgetLine",
                column: "BudgetSubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetSubCategory_ParentDetailedBudgetLineID",
                table: "BudgetSubCategory",
                column: "ParentDetailedBudgetLineID");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetSubCategory_ProjectId",
                table: "BudgetSubCategory",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailedBudgetLine_BudgetSubCategory_BudgetSubCategoryID",
                table: "DetailedBudgetLine",
                column: "BudgetSubCategoryID",
                principalTable: "BudgetSubCategory",
                principalColumn: "BudgetSubCategoryID");
        }
    }
}
