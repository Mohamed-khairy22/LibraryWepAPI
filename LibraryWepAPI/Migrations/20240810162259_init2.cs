﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryWepAPI.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boooks_Patrons_PatronId",
                table: "Boooks");

            migrationBuilder.AlterColumn<int>(
                name: "PatronId",
                table: "Boooks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Boooks_Patrons_PatronId",
                table: "Boooks",
                column: "PatronId",
                principalTable: "Patrons",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boooks_Patrons_PatronId",
                table: "Boooks");

            migrationBuilder.AlterColumn<int>(
                name: "PatronId",
                table: "Boooks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Boooks_Patrons_PatronId",
                table: "Boooks",
                column: "PatronId",
                principalTable: "Patrons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
