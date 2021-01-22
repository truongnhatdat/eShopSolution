using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class seedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 22, 23, 21, 25, 258, DateTimeKind.Local).AddTicks(2567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 1, 22, 22, 58, 6, 598, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("a1a776fa-b744-4a53-b867-0d997c8a09ae"), "eb1a50b3-4b2a-4f55-87e1-7f7f36bdb720", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("c5455c90-9e61-49ee-9e43-fad1cd3c512c"), new Guid("a1a776fa-b744-4a53-b867-0d997c8a09ae") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("c5455c90-9e61-49ee-9e43-fad1cd3c512c"), 0, "d8b12351-d9eb-45b8-89ed-db24f1d2ca3b", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "tedu.international@gmail.com", true, "Toan", "Bach", false, null, "tedu.international@gmail.com", "admin", "AQAAAAEAACcQAAAAEG0eKFgSvSLvIWQ22u6nZwEJYA725S/bod0QfpZPT5BPxjjv5kQKPZ6yHmusAtRNag==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 1, 22, 23, 21, 25, 309, DateTimeKind.Local).AddTicks(6893));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("a1a776fa-b744-4a53-b867-0d997c8a09ae"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("c5455c90-9e61-49ee-9e43-fad1cd3c512c"), new Guid("a1a776fa-b744-4a53-b867-0d997c8a09ae") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c5455c90-9e61-49ee-9e43-fad1cd3c512c"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 22, 22, 58, 6, 598, DateTimeKind.Local).AddTicks(8639),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 1, 22, 23, 21, 25, 258, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 1, 22, 22, 58, 6, 639, DateTimeKind.Local).AddTicks(2310));
        }
    }
}
