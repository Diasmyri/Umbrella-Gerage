using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Umbrella_gerage.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDamagedModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Damaged_Clients_ClientId",
                table: "Damaged");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Damaged",
                table: "Damaged");

            migrationBuilder.DropColumn(
                name: "DamagedId",
                table: "Damaged");

            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "Damaged");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Damaged",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Damaged",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "PlateNumber",
                table: "Damaged",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CarType",
                table: "Damaged",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ServiceType",
                table: "Damaged",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Clients",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Damaged",
                table: "Damaged",
                column: "PlateNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Damaged_Clients_ClientId",
                table: "Damaged",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Damaged_Clients_ClientId",
                table: "Damaged");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Damaged",
                table: "Damaged");

            migrationBuilder.DropColumn(
                name: "PlateNumber",
                table: "Damaged");

            migrationBuilder.DropColumn(
                name: "CarType",
                table: "Damaged");

            migrationBuilder.DropColumn(
                name: "ServiceType",
                table: "Damaged");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Clients");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Damaged",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Damaged",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DamagedId",
                table: "Damaged",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "Damaged",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Damaged",
                table: "Damaged",
                column: "DamagedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Damaged_Clients_ClientId",
                table: "Damaged",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
