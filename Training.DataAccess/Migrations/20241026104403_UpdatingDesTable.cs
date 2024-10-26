using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Training.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingDesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "desigid",
                table: "employees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "ix_employees_desigid",
                table: "employees",
                column: "desigid");

            migrationBuilder.AddForeignKey(
                name: "fk_employees_designations_desigid",
                table: "employees",
                column: "desigid",
                principalTable: "designations",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_employees_designations_desigid",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "ix_employees_desigid",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "desigid",
                table: "employees");
        }
    }
}
