using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KindergartenAPI.Migrations
{
    public partial class migrationv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_children",
                table: "children");

            migrationBuilder.RenameTable(
                name: "children",
                newName: "Children");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Children",
                table: "Children",
                column: "ChildId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Children",
                table: "Children");

            migrationBuilder.RenameTable(
                name: "Children",
                newName: "children");

            migrationBuilder.AddPrimaryKey(
                name: "PK_children",
                table: "children",
                column: "ChildId");
        }
    }
}
