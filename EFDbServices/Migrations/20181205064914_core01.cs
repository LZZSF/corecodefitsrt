using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDbServices.Migrations
{
    public partial class core01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserManagements",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    InsertBy = table.Column<int>(nullable: false),
                    InsertDateTime = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<int>(nullable: false),
                    UpdateDateTime = table.Column<DateTime>(nullable: false),
                    DeleteBy = table.Column<int>(nullable: false),
                    DeleteDateTime = table.Column<DateTime>(nullable: false),
                    UserNmae = table.Column<string>(maxLength: 100, nullable: false),
                    UserLoginCode = table.Column<string>(maxLength: 20, nullable: false),
                    UserLoginPwd = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserManagements", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RoleManagements",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    InsertBy = table.Column<int>(nullable: false),
                    InsertDateTime = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<int>(nullable: false),
                    UpdateDateTime = table.Column<DateTime>(nullable: false),
                    DeleteBy = table.Column<int>(nullable: false),
                    DeleteDateTime = table.Column<DateTime>(nullable: false),
                    RoleCode = table.Column<string>(maxLength: 50, nullable: false),
                    RoleName = table.Column<string>(maxLength: 50, nullable: false),
                    UserManagementID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleManagements", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RoleManagements_UserManagements_UserManagementID",
                        column: x => x.UserManagementID,
                        principalTable: "UserManagements",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleManagements_UserManagementID",
                table: "RoleManagements",
                column: "UserManagementID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleManagements");

            migrationBuilder.DropTable(
                name: "UserManagements");
        }
    }
}
