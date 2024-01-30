using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Data.Migrations
{
    public partial class @try : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "renterId",
                table: "Zimmers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "zimmerId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Zimmers_renterId",
                table: "Zimmers",
                column: "renterId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_zimmerId",
                table: "Orders",
                column: "zimmerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Zimmers_zimmerId",
                table: "Orders",
                column: "zimmerId",
                principalTable: "Zimmers",
                principalColumn: "zimmerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zimmers_Renters_renterId",
                table: "Zimmers",
                column: "renterId",
                principalTable: "Renters",
                principalColumn: "renterId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Zimmers_zimmerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Zimmers_Renters_renterId",
                table: "Zimmers");

            migrationBuilder.DropIndex(
                name: "IX_Zimmers_renterId",
                table: "Zimmers");

            migrationBuilder.DropIndex(
                name: "IX_Orders_zimmerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "renterId",
                table: "Zimmers");

            migrationBuilder.DropColumn(
                name: "zimmerId",
                table: "Orders");
        }
    }
}
