using Microsoft.EntityFrameworkCore.Migrations;

namespace Eduhome.Migrations
{
    public partial class _4tablescreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NoticeBoards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Subtitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoticeBoards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupportPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HeaderLogo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FooterLogo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FooterTitle = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Site = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ChooseTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ChooseDesc = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    ChooseSub = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ChooseBtn = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ChooseBgImage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TestImg = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TestTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TestName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TestPosition = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    AboutTitle = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    AboutSubtitle = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    Desc1 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Desc2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AboutBtn = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    AboutImg = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    AboutVideoLink = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Subtitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    BtnTxt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BgImg = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "NoticeBoards");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
