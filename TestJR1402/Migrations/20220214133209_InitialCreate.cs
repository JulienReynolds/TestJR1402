using Microsoft.EntityFrameworkCore.Migrations;

namespace TestJR1402.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LesCours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LesCours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LesPersonnes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datedenaissance = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LesPersonnes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoursPersonne",
                columns: table => new
                {
                    LesCoursId = table.Column<int>(type: "int", nullable: false),
                    LesPersonnesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursPersonne", x => new { x.LesCoursId, x.LesPersonnesId });
                    table.ForeignKey(
                        name: "FK_CoursPersonne_LesCours_LesCoursId",
                        column: x => x.LesCoursId,
                        principalTable: "LesCours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursPersonne_LesPersonnes_LesPersonnesId",
                        column: x => x.LesPersonnesId,
                        principalTable: "LesPersonnes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoursPersonne_LesPersonnesId",
                table: "CoursPersonne",
                column: "LesPersonnesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoursPersonne");

            migrationBuilder.DropTable(
                name: "LesCours");

            migrationBuilder.DropTable(
                name: "LesPersonnes");
        }
    }
}
