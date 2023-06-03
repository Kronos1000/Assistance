using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendAPI.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Food_Vendor_VendorID",
                table: "Food");

            migrationBuilder.DropIndex(
                name: "IX_Food_VendorID",
                table: "Food");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Food_VendorID",
                table: "Food",
                column: "VendorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Food_Vendor_VendorID",
                table: "Food",
                column: "VendorID",
                principalTable: "Vendor",
                principalColumn: "VendorID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
