﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Training.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    upby = table.Column<string>(type: "text", nullable: false),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_departments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "designations",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    upby = table.Column<string>(type: "text", nullable: false),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_designations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    address = table.Column<string>(type: "text", nullable: false),
                    city = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    deptid = table.Column<string>(type: "text", nullable: false),
                    desigid = table.Column<string>(type: "text", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false),
                    upby = table.Column<string>(type: "text", nullable: false),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_employees", x => x.id);
                    table.ForeignKey(
                        name: "fk_employees_departments_deptid",
                        column: x => x.deptid,
                        principalTable: "departments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_employees_designations_desigid",
                        column: x => x.desigid,
                        principalTable: "designations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_employees_deptid",
                table: "employees",
                column: "deptid");

            migrationBuilder.CreateIndex(
                name: "ix_employees_desigid",
                table: "employees",
                column: "desigid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "designations");
        }
    }
}
