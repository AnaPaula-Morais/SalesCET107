using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesCet107.Web.Migrations
{
    /// <inheritdoc />
    public partial class ModifyProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastPurchase",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSale",
                table: "Products",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastPurchase",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LastSale",
                table: "Products");
        }
    }
}
