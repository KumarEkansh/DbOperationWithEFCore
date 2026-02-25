using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbOperationWithEFCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class RemovedTableColoumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Books");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Country",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
