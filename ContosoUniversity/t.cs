using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Migrations1
{
    public partial class InitialCreate : Migration {
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new {
                    CourseID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Credits = table.Column<int>(nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_Course", x => x.CourseID);
                });
            // Additional code not shown
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(name: "Enrollment");
            migrationBuilder.DropTable(name: "Course");
            migrationBuilder.DropTable(name: "Student");
            //Additional code not shown
        }
    }

    
}
