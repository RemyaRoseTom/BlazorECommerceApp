using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorECommerceApp.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Large Abstract Flower Oil Painting On Canvas,White 3D Floral Painting,Flower Acrylic Painting,Heavy Textured Flower Art,Floral Wall Decor", "C:\\\\Remya\\\\C#Samples\\\\BlazorECommerceApp\\\\Server\\\\Images\\\\FlowerArt.JPG", 120.99m, "The Flower Art" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", 9.99m, "The Hitchhiker's Guide To The Galaxy" });
        }
    }
}
