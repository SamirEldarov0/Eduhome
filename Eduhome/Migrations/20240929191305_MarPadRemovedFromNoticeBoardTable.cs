﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Eduhome.Migrations
{
    public partial class MarPadRemovedFromNoticeBoardTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MarPad",
                table: "NoticeBoards");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MarPad",
                table: "NoticeBoards",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);
        }
    }
}
