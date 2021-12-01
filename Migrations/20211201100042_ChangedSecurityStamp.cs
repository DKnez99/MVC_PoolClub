using Microsoft.EntityFrameworkCore.Migrations;

namespace PoolClub.Migrations
{
    public partial class ChangedSecurityStamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "80efd431-0c78-44e6-9b41-3ed4236dc2cb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d5c224l-3b0e-446f-86af-365d56fd0954",
                column: "ConcurrencyStamp",
                value: "072943b5-ccab-4b4c-9eb6-23458cc1c5e5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c17f4791-6432-4aa5-af2e-7a0c989ec1f4", "AQAAAAEAACcQAAAAEKZg6230qh44oboYkZqqOorsIusMHWhXjz1aX0ElVK8YLzLvhWIizO1HZLzlNENuCQ==", "a5d25df3-e03c-4741-8758-43ffa8ac3e38" });
        }
    }
}
