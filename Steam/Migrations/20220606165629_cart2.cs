using Microsoft.EntityFrameworkCore.Migrations;

namespace Steam.Migrations
{
    public partial class cart2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GamesCartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    GamesCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamesCartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GamesCartItem_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96a7c7be-0830-4ea9-91ce-67844677462c",
                column: "ConcurrencyStamp",
                value: "234c8d82-5b58-4a00-883b-d62bce92e864");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d96e88d9-2215-48f7-b437-5d70d5e5b6cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e74889c1-26ce-4d71-80ec-d66d223d98fe", "AQAAAAEAACcQAAAAEDnLPdahPEvPdhZkfW+vhC+uPiDO62UCUjAA7kKZB+3FZa0N/aiqqKVIgSYd5mUs5w==" });

            migrationBuilder.CreateIndex(
                name: "IX_GamesCartItem_GameId",
                table: "GamesCartItem",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GamesCartItem");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96a7c7be-0830-4ea9-91ce-67844677462c",
                column: "ConcurrencyStamp",
                value: "6f5143ff-e484-4feb-b815-496f2dead945");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d96e88d9-2215-48f7-b437-5d70d5e5b6cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c72ccc96-6028-4bcc-bd52-3680ec32e574", "AQAAAAEAACcQAAAAELwndwBleZ1alSVDdWTBc3ibKkHF8mehVTHVraIzhEucM1pm66q0DhUz/j869JSCCQ==" });
        }
    }
}
