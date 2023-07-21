using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesss.Migrations
{
    /// <inheritdoc />
    public partial class initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Users_UpdatedBy",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Universities_Users_UpdatedBy",
                table: "Universities");

            migrationBuilder.DropIndex(
                name: "IX_Universities_UpdatedBy",
                table: "Universities");

            migrationBuilder.DropIndex(
                name: "IX_Students_UpdatedBy",
                table: "Students");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Universities",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateIndex(
                name: "IX_Universities_CreatedBy",
                table: "Universities",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CreatedBy",
                table: "Students",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Users_CreatedBy",
                table: "Students",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Universities_Users_CreatedBy",
                table: "Universities",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Users_CreatedBy",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Universities_Users_CreatedBy",
                table: "Universities");

            migrationBuilder.DropIndex(
                name: "IX_Universities_CreatedBy",
                table: "Universities");

            migrationBuilder.DropIndex(
                name: "IX_Students_CreatedBy",
                table: "Students");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Universities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Universities_UpdatedBy",
                table: "Universities",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UpdatedBy",
                table: "Students",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Users_UpdatedBy",
                table: "Students",
                column: "UpdatedBy",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Universities_Users_UpdatedBy",
                table: "Universities",
                column: "UpdatedBy",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
