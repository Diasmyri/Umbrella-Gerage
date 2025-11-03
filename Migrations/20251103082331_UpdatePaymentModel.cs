using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Umbrella_gerage.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePaymentModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Payments");

            migrationBuilder.AlterColumn<string>(
                name: "Method",
                table: "Payments",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "PlatNumber",
                table: "Payments",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Payments",
                type: "numeric(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReportDate",
                table: "Damaged",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PlatNumber",
                table: "Payments",
                column: "PlatNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Damaged_PlatNumber",
                table: "Payments",
                column: "PlatNumber",
                principalTable: "Damaged",
                principalColumn: "PlateNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Damaged_PlatNumber",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_PlatNumber",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PlatNumber",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Payments");

            migrationBuilder.AlterColumn<string>(
                name: "Method",
                table: "Payments",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "Payments",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReportDate",
                table: "Damaged",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");
        }
    }
}
