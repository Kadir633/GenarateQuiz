﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace GenerateQuiz.DAL.Migrations
{
    public partial class header : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Header",
                table: "Question",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Header",
                table: "Question");
        }
    }
}
