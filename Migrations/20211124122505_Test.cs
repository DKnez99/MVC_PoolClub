using Microsoft.EntityFrameworkCore.Migrations;

namespace PoolClub.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Roles_Name",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46f1f174-6f60-4f83-b9f7-04667966faca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e140e3b-bd7b-49e4-b7f5-d81eec7847e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da30e529-111d-48dc-ad33-ab1902f40da6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eca67f19-d706-4cbf-a5e9-444b841424ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1383ba8-ce25-4715-8a9c-f95980d8d02d");

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

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Name" },
                values: new object[,]
                {
                    { 1, "Staff" },
                    { 2, "Visitor" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RoleId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f1383ba8-ce25-4715-8a9c-f95980d8d02d", 0, "c4ff3e90-5ea4-47dd-8477-653f76d37c14", "johndoe@poolclub.com", false, "John", "Doe", false, null, null, null, "johndoe123", null, "0781235645", false, 1, "8fdc780a-67d0-41f3-94f4-ee8f4ecc4bca", false, null },
                    { "7e140e3b-bd7b-49e4-b7f5-d81eec7847e4", 0, "c78847ee-435a-4d45-b5c7-b91a5577d2d3", "maryann@poolclub.com", false, "Mary", "Ann", false, null, null, null, "maryann123", null, "0763214543", false, 1, "19ee94c0-ceca-4875-af92-9e08129e0deb", false, null },
                    { "da30e529-111d-48dc-ad33-ab1902f40da6", 0, "13da1ddf-97d1-493c-a76c-a2066ffd8cc7", "markspencer@poolclub.com", false, "Mark", "Spencer", false, null, null, null, "markspencer123", null, "0762253312", false, 1, "02b4fb78-f230-437d-ad5a-dafbc3b516c1", false, null },
                    { "eca67f19-d706-4cbf-a5e9-444b841424ba", 0, "4ebaef81-4ab3-4d00-acce-8559641c9212", "bobmarly@yahoo.com", false, "Bob", "Marly", false, null, null, null, "bobmarly123", null, "0712516674", false, 2, "7392e060-c4eb-4309-af8d-08789f5868c4", false, null },
                    { "46f1f174-6f60-4f83-b9f7-04667966faca", 0, "e28348a5-f466-414b-bb0d-dc9821d9c529", "janejameson@gmail.com", false, "Jane", "Jameson", false, null, null, null, "janejameson213", null, "0711194203", false, 2, "1100def2-ea45-4e8a-95b4-5d6b39de599f", false, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Name",
                table: "Roles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }
    }
}
