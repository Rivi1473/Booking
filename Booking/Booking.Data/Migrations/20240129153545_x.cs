using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Data.Migrations
{
    public partial class x : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Zimmers_zimmerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Zimmers_Renters_renterId",
                table: "Zimmers");

            migrationBuilder.RenameColumn(
                name: "renterId",
                table: "Zimmers",
                newName: "RenterId");

            migrationBuilder.RenameColumn(
                name: "renterCode",
                table: "Zimmers",
                newName: "RenterCode");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Zimmers",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Zimmers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Zimmers",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Zimmers",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Zimmers",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "zimmerId",
                table: "Zimmers",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Zimmers_renterId",
                table: "Zimmers",
                newName: "IX_Zimmers_RenterId");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Renters",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Renters",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "renterId",
                table: "Renters",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "zimmerId",
                table: "Orders",
                newName: "ZimmerId");

            migrationBuilder.RenameColumn(
                name: "tenantPhone",
                table: "Orders",
                newName: "TenantPhone");

            migrationBuilder.RenameColumn(
                name: "tenantName",
                table: "Orders",
                newName: "TenantName");

            migrationBuilder.RenameColumn(
                name: "orderDate",
                table: "Orders",
                newName: "OrderDate");

            migrationBuilder.RenameColumn(
                name: "departureDate",
                table: "Orders",
                newName: "DepartureDate");

            migrationBuilder.RenameColumn(
                name: "codeZimmer",
                table: "Orders",
                newName: "CodeZimmer");

            migrationBuilder.RenameColumn(
                name: "arrivalDate",
                table: "Orders",
                newName: "ArrivalDate");

            migrationBuilder.RenameColumn(
                name: "ordersId",
                table: "Orders",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_zimmerId",
                table: "Orders",
                newName: "IX_Orders_ZimmerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Zimmers_ZimmerId",
                table: "Orders",
                column: "ZimmerId",
                principalTable: "Zimmers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zimmers_Renters_RenterId",
                table: "Zimmers",
                column: "RenterId",
                principalTable: "Renters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Zimmers_ZimmerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Zimmers_Renters_RenterId",
                table: "Zimmers");

            migrationBuilder.RenameColumn(
                name: "RenterId",
                table: "Zimmers",
                newName: "renterId");

            migrationBuilder.RenameColumn(
                name: "RenterCode",
                table: "Zimmers",
                newName: "renterCode");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Zimmers",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Zimmers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Zimmers",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Zimmers",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Zimmers",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Zimmers",
                newName: "zimmerId");

            migrationBuilder.RenameIndex(
                name: "IX_Zimmers_RenterId",
                table: "Zimmers",
                newName: "IX_Zimmers_renterId");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Renters",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Renters",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Renters",
                newName: "renterId");

            migrationBuilder.RenameColumn(
                name: "ZimmerId",
                table: "Orders",
                newName: "zimmerId");

            migrationBuilder.RenameColumn(
                name: "TenantPhone",
                table: "Orders",
                newName: "tenantPhone");

            migrationBuilder.RenameColumn(
                name: "TenantName",
                table: "Orders",
                newName: "tenantName");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Orders",
                newName: "orderDate");

            migrationBuilder.RenameColumn(
                name: "DepartureDate",
                table: "Orders",
                newName: "departureDate");

            migrationBuilder.RenameColumn(
                name: "CodeZimmer",
                table: "Orders",
                newName: "codeZimmer");

            migrationBuilder.RenameColumn(
                name: "ArrivalDate",
                table: "Orders",
                newName: "arrivalDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "ordersId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ZimmerId",
                table: "Orders",
                newName: "IX_Orders_zimmerId");

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
    }
}
