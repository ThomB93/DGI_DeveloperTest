using Microsoft.EntityFrameworkCore.Migrations;

namespace DeveloperTest.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DistinctTexts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    DistinctWordCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistinctTexts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WatchWords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Word = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchWords", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "WatchWords",
                columns: new[] { "Id", "Word" },
                values: new object[] { 1, "cat" });

            migrationBuilder.InsertData(
                table: "WatchWords",
                columns: new[] { "Id", "Word" },
                values: new object[] { 2, "dog" });

            migrationBuilder.InsertData(
                table: "WatchWords",
                columns: new[] { "Id", "Word" },
                values: new object[] { 3, "rabbit" });

            migrationBuilder.InsertData(
                table: "WatchWords",
                columns: new[] { "Id", "Word" },
                values: new object[] { 4, "mouse" });

            migrationBuilder.InsertData(
                table: "WatchWords",
                columns: new[] { "Id", "Word" },
                values: new object[] { 5, "horse" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DistinctTexts");

            migrationBuilder.DropTable(
                name: "WatchWords");
        }
    }
}
