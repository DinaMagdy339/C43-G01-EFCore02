using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class addrelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Stud_Courses_Course_ID",
                table: "Stud_Courses",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors",
                column: "Dept_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors",
                column: "Dept_ID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Courses_Course_ID",
                table: "Stud_Courses",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Students_Stud_ID",
                table: "Stud_Courses",
                column: "Stud_ID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Courses_Course_ID",
                table: "Stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Students_Stud_ID",
                table: "Stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Courses_Course_ID",
                table: "Stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors");
        }
    }
}
