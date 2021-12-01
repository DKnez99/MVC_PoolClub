using Microsoft.EntityFrameworkCore.Migrations;

namespace PoolClub.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "3c7102b9-b9db-4249-9662-dfd189c7c96e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d5c224l-3b0e-446f-86af-365d56fd0954",
                column: "ConcurrencyStamp",
                value: "f53b3fc1-6284-414e-9e2f-ae06c9734da4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f79ad8c-ad6c-49ba-a342-ce9660c7e7b4", "AQAAAAEAACcQAAAAEObVIGNBo/3kyqP0om1cgpnkKEu0JlBdVWo5voZZAH39q0JoO+AshJikPjj3GoLS/g==", "6023b1ca-c18e-429f-b34f-03b829106b0d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "4f361d81-dd1f-4c09-a49c-1d41a58585df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d5c224l-3b0e-446f-86af-365d56fd0954",
                column: "ConcurrencyStamp",
                value: "9339459d-3f5d-4e4f-9829-591059aa7c51");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c36ea6f6-242a-4cf1-9b6f-19168a86926f", "AQAAAAEAACcQAAAAEBC/agrm4++x2WUXvlq5QLVtjGaqXoKHH9lgd6Dm70H5T4IjbpmjKGcGxzIK+k2jlg==", "ea6fe1a1-a0c4-4a3c-9c75-6f908b777bc9" });
        }
    }
}
