using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rakna_API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddParkTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParkName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ParkLocation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ParkImage = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PublicIntID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
