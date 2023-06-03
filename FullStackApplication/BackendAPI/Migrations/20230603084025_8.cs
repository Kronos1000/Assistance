using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendAPI.Migrations
{
    public partial class _8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Food_Vendor_VendorID",
                table: "Food");

            migrationBuilder.DropIndex(
                name: "IX_Food_VendorID",
                table: "Food");
        }
    }
}
