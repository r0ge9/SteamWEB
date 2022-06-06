using Microsoft.EntityFrameworkCore.Migrations;

namespace Steam.Migrations
{
    public partial class cart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96a7c7be-0830-4ea9-91ce-67844677462c",
                column: "ConcurrencyStamp",
                value: "5d81bccd-6a5f-4c78-a073-9cd08d0c13d7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d96e88d9-2215-48f7-b437-5d70d5e5b6cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fdf251a6-0c4a-4df4-968f-676e604bcb84", "AQAAAAEAACcQAAAAEGg19s+hkrRvgKzeDHIi5yAsmLtpnex2lgs1ta/fEc8PPGOyJQ3qMQ1lAHHfIETqTw==" });
        }
    }
}
