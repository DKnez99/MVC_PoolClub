using Microsoft.EntityFrameworkCore.Migrations;

namespace PoolClub.Migrations
{
    public partial class SeedingIdentityData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "aea07ade-3cb2-4f54-b46b-46b1ca4c4447");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d5c224l-3b0e-446f-86af-365d56fd0954",
                column: "ConcurrencyStamp",
                value: "91abe103-7065-40d4-b655-9d47e2c5d065");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "969b5ebb-8c51-46b3-92e8-6a6d5b5f7412", "AQAAAAEAACcQAAAAEDNqDueywcFVBSDO9IyYRqdp+765pbwBuqELR6i8pOnB35zgya2ky70RdejiD2kadQ==", "f53411d6-7b9b-458f-920e-4cd1b7f1f302" });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TableId", "Floor" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "8ae8cc37-4b75-4fee-9f5f-e0a464f05353");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d5c224l-3b0e-446f-86af-365d56fd0954",
                column: "ConcurrencyStamp",
                value: "d4c3aa7b-20d7-4c12-96e6-17a65b4b6550");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36359376-cf06-4b2c-840e-1ce259453015", "AQAAAAEAACcQAAAAEBxOghtLUB2VjJ7n82Hvw+7rJLsH+OQ3AqqZ3b5IJJpiM3RGiQnGkcKG/JKMMHe4eg==", "2414e8b5-a808-415c-a550-e1d3c15db9cf" });
        }
    }
}
