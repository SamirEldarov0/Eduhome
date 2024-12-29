using Microsoft.EntityFrameworkCore.Migrations;

namespace Eduhome.Migrations
{
    public partial class EventTableChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_CategoryEs_CategoryEId",
                table: "Events");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryEId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PadMar",
                table: "Courses",
                type: "bit",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_CategoryEs_CategoryEId",
                table: "Events",
                column: "CategoryEId",
                principalTable: "CategoryEs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_CategoryEs_CategoryEId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "PadMar",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryEId",
                table: "Events",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_CategoryEs_CategoryEId",
                table: "Events",
                column: "CategoryEId",
                principalTable: "CategoryEs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
