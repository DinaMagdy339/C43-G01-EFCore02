using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class Relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Students_Dept_Id",
                table: "Students",
                column: "Dept_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Course_InstsTable_inst_ID",
                table: "Course_InstsTable",
                column: "inst_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_InstsTable_Courses_Course_ID",
                table: "Course_InstsTable",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_InstsTable_Instructors_inst_ID",
                table: "Course_InstsTable",
                column: "inst_ID",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_Dept_Id",
                table: "Students",
                column: "Dept_Id",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_InstsTable_Courses_Course_ID",
                table: "Course_InstsTable");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_InstsTable_Instructors_inst_ID",
                table: "Course_InstsTable");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_Dept_Id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Dept_Id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Course_InstsTable_inst_ID",
                table: "Course_InstsTable");
        }
    }
}
