using Microsoft.EntityFrameworkCore.Migrations;

namespace GenerateQuiz.DAL.Migrations
{
    public partial class Inıtıail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    userName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Link = table.Column<string>(nullable: true),
                    Selection1 = table.Column<string>(nullable: true),
                    A1 = table.Column<string>(nullable: true),
                    B1 = table.Column<string>(nullable: true),
                    C1 = table.Column<string>(nullable: true),
                    D1 = table.Column<string>(nullable: true),
                    CorrectAnswer1 = table.Column<string>(nullable: true),
                    Selection2 = table.Column<string>(nullable: true),
                    A2 = table.Column<string>(nullable: true),
                    B2 = table.Column<string>(nullable: true),
                    C2 = table.Column<string>(nullable: true),
                    D2 = table.Column<string>(nullable: true),
                    CorrectAnswer2 = table.Column<string>(nullable: true),
                    Selection3 = table.Column<string>(nullable: true),
                    A3 = table.Column<string>(nullable: true),
                    B3 = table.Column<string>(nullable: true),
                    C3 = table.Column<string>(nullable: true),
                    D3 = table.Column<string>(nullable: true),
                    CorrectAnswer3 = table.Column<string>(nullable: true),
                    Selection4 = table.Column<string>(nullable: true),
                    A4 = table.Column<string>(nullable: true),
                    B4 = table.Column<string>(nullable: true),
                    C4 = table.Column<string>(nullable: true),
                    D4 = table.Column<string>(nullable: true),
                    CorrectAnswer4 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Question");
        }
    }
}
