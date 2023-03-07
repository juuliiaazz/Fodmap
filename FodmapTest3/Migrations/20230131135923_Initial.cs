using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FodmapTest3.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    GTIN = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PictureURL = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Hyllkantstext = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ingrediensforteckning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Varumarke = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RedFodmap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YellowFodmap = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.GTIN);
                });

            migrationBuilder.CreateTable(
               name: "RedFodmap",
               columns: table => new
               {
                   Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                   RedFodmapList = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Id", x => x.Id);
               });

            migrationBuilder.CreateTable(
               name: "YellowFodmap",
               columns: table => new
               {
                   Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                   YellowFodmapList = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Id", x => x.Id);
               });

           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");
            migrationBuilder.DropTable(
                name: "RedFodmap");
            migrationBuilder.DropTable(
                name: "YellowFodmap");
           
        }
    }
}
