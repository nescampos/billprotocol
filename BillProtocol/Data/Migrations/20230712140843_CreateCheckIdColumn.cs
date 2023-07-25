using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillProtocol.Data.Migrations
{
    public partial class CreateCheckIdColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CheckId",
                table: "Invoices",
                type: "nvarchar(256)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckId",
                table: "Invoices");
        }
    }
}
