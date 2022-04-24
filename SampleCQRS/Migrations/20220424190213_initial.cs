using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SampleCQRS.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[,]
                {
                    { 1, "The Rise of Skywalker", "Episode 1" },
                    { 2, "Attack of the Clones", "Episode 2" },
                    { 3, "Revenge of the Sith", "Episode 3" },
                    { 4, "A New Hope", "Episode 4" },
                    { 5, "The Empire Strikes Back", "Episode 5" },
                    { 6, "Revenge of the Sith", "Episode 6" },
                    { 7, "The Force Awakens", "Episode 7" },
                    { 8, "The Last Jedi", "Episode 8" },
                    { 9, "The Rise of Skywalker", "Episode 9" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
