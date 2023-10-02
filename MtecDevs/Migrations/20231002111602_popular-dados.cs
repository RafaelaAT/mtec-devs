using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MtecDevs.Migrations
{
    public partial class populardados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7153112c-3371-42c1-8c28-a23ccb087c4d", "06350a25-5173-4670-aadf-be836ecc75b8", "Moderador", "MODERADOR" },
                    { "7dd8f4d0-dac8-4061-960d-d2ca6794ae45", "dad120e9-fc27-464b-b861-592e7e3a5072", "Administrador", "ADMINISTRADOR" },
                    { "ef412db8-4f73-43ff-88c2-d49abe7990cd", "01c025cb-df72-4b1d-929d-4de3d0c7cb08", "Usuário", "USUÁRIO" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "de39463b-3682-4b4b-9e2e-5d7955df8029", 0, "29ddf305-079b-4a8a-8795-f3cedb033ac9", "rafaelaalessandratorelli@gmail.com", true, false, null, "RAFAELAALESSANDRATORELLI@GMAIL.COM", "JULIARAFAELA", "AQAAAAEAACcQAAAAEIsTbWV/2OJWgICQX7LyisMsEGKCWdPURHyHkF5WMqTInR2BSFKYP2O+f5Yie83/jQ==", "14991686274", true, "a9385e54-c9db-459d-a2c1-8a64b1e30d43", false, "JuliaRafaela" });

            migrationBuilder.InsertData(
                table: "TipoDev",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "FullStack" },
                    { 2, "FrontEnd" },
                    { 3, "BackEnd" },
                    { 4, "Design" },
                    { 5, "Jogos" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7dd8f4d0-dac8-4061-960d-d2ca6794ae45", "de39463b-3682-4b4b-9e2e-5d7955df8029" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UserId", "DataNascimento", "Foto", "Nome", "TipoDevId" },
                values: new object[] { "de39463b-3682-4b4b-9e2e-5d7955df8029", new DateTime(2006, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "/img/usuarios/avatar.jpg", "Julia Alessandra Delfino Torelli", 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7153112c-3371-42c1-8c28-a23ccb087c4d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef412db8-4f73-43ff-88c2-d49abe7990cd");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7dd8f4d0-dac8-4061-960d-d2ca6794ae45", "de39463b-3682-4b4b-9e2e-5d7955df8029" });

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UserId",
                keyValue: "de39463b-3682-4b4b-9e2e-5d7955df8029");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7dd8f4d0-dac8-4061-960d-d2ca6794ae45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de39463b-3682-4b4b-9e2e-5d7955df8029");

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
