using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.API.Migrations
{
  public partial class Init : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "students",
          columns: table => new
          {
            Id = table.Column<int>(nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
            Name = table.Column<string>(nullable: true),
            Branch = table.Column<string>(nullable: true),
            Year = table.Column<string>(nullable: true),
            Section = table.Column<string>(nullable: true)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_students", x => x.Id);
          });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "students");
    }
  }
}
