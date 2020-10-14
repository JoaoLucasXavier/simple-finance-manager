using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sfm.Infra.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "financialSystem",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    ClosingDay = table.Column<int>(nullable: false),
                    GenerateCopyExpenses = table.Column<bool>(nullable: false),
                    CopyMonth = table.Column<int>(nullable: false),
                    YearCopy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_financialSystem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "suggestion",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DescriptionSuggestion = table.Column<string>(nullable: true),
                    UserEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suggestion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SystemId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_category_financialSystem_SystemId",
                        column: x => x.SystemId,
                        principalTable: "financialSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "systemUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserEmail = table.Column<string>(nullable: true),
                    Administrator = table.Column<bool>(nullable: false),
                    CurrentSystem = table.Column<bool>(nullable: false),
                    SystemId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_systemUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_systemUser_financialSystem_SystemId",
                        column: x => x.SystemId,
                        principalTable: "financialSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "expense",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<decimal>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    ExpenseType = table.Column<int>(nullable: false),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    ChangeDate = table.Column<DateTime>(nullable: false),
                    DatePayment = table.Column<DateTime>(nullable: false),
                    DateExpiration = table.Column<DateTime>(nullable: false),
                    PaidOut = table.Column<bool>(nullable: false),
                    OverdueExpense = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_expense", x => x.Id);
                    table.ForeignKey(
                        name: "FK_expense_category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "purchase",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    ChangeDate = table.Column<DateTime>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_purchase_category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "purchaseItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<decimal>(nullable: false),
                    Purchased = table.Column<bool>(nullable: false),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    ChangeDate = table.Column<DateTime>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    PurchaseId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchaseItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_purchaseItem_purchase_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "purchase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_category_SystemId",
                table: "category",
                column: "SystemId");

            migrationBuilder.CreateIndex(
                name: "IX_expense_CategoryId",
                table: "expense",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_CategoryId",
                table: "purchase",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseItem_PurchaseId",
                table: "purchaseItem",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_systemUser_SystemId",
                table: "systemUser",
                column: "SystemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "expense");

            migrationBuilder.DropTable(
                name: "purchaseItem");

            migrationBuilder.DropTable(
                name: "suggestion");

            migrationBuilder.DropTable(
                name: "systemUser");

            migrationBuilder.DropTable(
                name: "purchase");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "financialSystem");
        }
    }
}
