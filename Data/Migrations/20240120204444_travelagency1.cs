using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class travelagency1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "VISITOR_ID", "3a62eba9-e84c-405f-aa58-4d786c7c5245" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ADMIN_ID", "b101d692-1ef7-4148-b112-54d66e7f3a23" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a62eba9-e84c-405f-aa58-4d786c7c5245");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b101d692-1ef7-4148-b112-54d66e7f3a23");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "131332ea-49f8-4550-b991-de2042887070", 0, "376643b6-ce9d-49e3-b7a0-15b522f8d97f", "visitor@wsei.edu.pl", true, false, null, "VISITOR@WSEI.EDU.PL", "VISITOR", "AQAAAAEAACcQAAAAEBkjUAFSYa4hCBReWDfFt7ncm7RhfX0+67Divgkjxym1X/zLgGm/clXJXFyumFq83g==", null, false, "cd3d7f12-0d01-4be1-ba5d-2acd025de017", false, "visitor" },
                    { "4e0f3e2d-8f9c-456c-b7d6-20d539ec8f8f", 0, "4274cfc2-551f-4b25-a124-a39c68e04c47", "admin@wsei.edu.pl", true, false, null, "ADMIN@WSEI.EDU.PL", "ADMIN", "AQAAAAEAACcQAAAAEMZhOqHeMctcD+niMT/qqPKtzBR651AREbPgfHJl3EFUJzksTmLayLxGrZFYo3/n9g==", null, false, "37aad8d7-84a9-435f-85bd-2a012c6eafcb", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "VISITOR_ID", "131332ea-49f8-4550-b991-de2042887070" },
                    { "ADMIN_ID", "4e0f3e2d-8f9c-456c-b7d6-20d539ec8f8f" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "VISITOR_ID", "131332ea-49f8-4550-b991-de2042887070" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ADMIN_ID", "4e0f3e2d-8f9c-456c-b7d6-20d539ec8f8f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "131332ea-49f8-4550-b991-de2042887070");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e0f3e2d-8f9c-456c-b7d6-20d539ec8f8f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3a62eba9-e84c-405f-aa58-4d786c7c5245", 0, "e43e6da3-0f92-4144-acfb-57103eae08ad", "visitor@wsei.edu.pl", true, false, null, "VISITOR@WSEI.EDU.PL", "VISITOR", "AQAAAAEAACcQAAAAEIBANDe8IogDboKtujxKsRlkrXewTnU+X6pTGlBimrMOhDdYHJ0tpndnXk2Zi4naxw==", null, false, "5607a672-ed38-4ebf-bfbe-129e742172b8", false, "visitor" },
                    { "b101d692-1ef7-4148-b112-54d66e7f3a23", 0, "343b8958-4ad1-471e-a2b3-4e86efa705c6", "admin@wsei.edu.pl", true, false, null, "ADMIN@WSEI.EDU.PL", "ADMIN", "AQAAAAEAACcQAAAAEIxT9E8QuFEpXZbqpKSCZjDkQQc32Hp0npZCIsg+c9JrEgIMpJdb718omONkKBWvdQ==", null, false, "76f4a936-915f-4e1a-879f-5ed53329a39b", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "VISITOR_ID", "3a62eba9-e84c-405f-aa58-4d786c7c5245" },
                    { "ADMIN_ID", "b101d692-1ef7-4148-b112-54d66e7f3a23" }
                });
        }
    }
}
