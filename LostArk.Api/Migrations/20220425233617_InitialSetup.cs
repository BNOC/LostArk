using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LostArk.Api.Migrations
{
    public partial class InitialSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterTaskTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterTaskTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    Period = table.Column<int>(type: "int", nullable: false),
                    CharacterTaskTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterTasks_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterTasks_CharacterTaskTypes_CharacterTaskTypeId",
                        column: x => x.CharacterTaskTypeId,
                        principalTable: "CharacterTaskTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CharacterTaskTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Chaos Dungeon" },
                    { 2, "Guardian Raid" },
                    { 3, "Una's Daily" },
                    { 4, "Event" },
                    { 5, "Rapport" },
                    { 6, "Guild" },
                    { 7, "Una's Weekly" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "BNOC" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "Bnoc", 1 },
                    { 2, "Skex", 1 },
                    { 3, "Bnocx", 1 },
                    { 4, "Bnocy", 1 },
                    { 5, "Bnocz", 1 }
                });

            migrationBuilder.InsertData(
                table: "CharacterTasks",
                columns: new[] { "Id", "CharacterId", "CharacterTaskTypeId", "IsCompleted", "Period" },
                values: new object[,]
                {
                    { 1, 1, 1, false, 0 },
                    { 2, 1, 1, false, 0 },
                    { 3, 1, 2, false, 0 },
                    { 4, 1, 2, false, 0 },
                    { 5, 1, 3, false, 0 },
                    { 6, 1, 3, false, 0 },
                    { 7, 1, 3, false, 0 },
                    { 8, 1, 4, false, 0 },
                    { 9, 1, 5, false, 0 },
                    { 10, 1, 6, false, 0 },
                    { 11, 1, 7, false, 1 },
                    { 12, 2, 1, false, 0 },
                    { 13, 2, 1, false, 0 },
                    { 14, 2, 2, false, 0 },
                    { 15, 2, 2, false, 0 },
                    { 16, 2, 3, false, 0 },
                    { 17, 2, 3, false, 0 },
                    { 18, 2, 3, false, 0 },
                    { 19, 2, 4, false, 0 },
                    { 20, 2, 5, false, 0 },
                    { 21, 2, 6, false, 0 },
                    { 22, 2, 7, false, 1 },
                    { 23, 3, 1, false, 0 },
                    { 24, 3, 1, false, 0 },
                    { 25, 3, 2, false, 0 },
                    { 26, 3, 2, false, 0 },
                    { 27, 3, 3, false, 0 },
                    { 28, 3, 3, false, 0 },
                    { 29, 3, 3, false, 0 },
                    { 30, 3, 4, false, 0 },
                    { 31, 3, 5, false, 0 },
                    { 32, 3, 6, false, 0 },
                    { 33, 3, 7, false, 1 },
                    { 34, 4, 1, false, 0 },
                    { 35, 4, 1, false, 0 },
                    { 36, 4, 2, false, 0 },
                    { 37, 4, 2, false, 0 },
                    { 38, 4, 3, false, 0 },
                    { 39, 4, 3, false, 0 },
                    { 40, 4, 3, false, 0 },
                    { 41, 4, 4, false, 0 },
                    { 42, 4, 5, false, 0 }
                });

            migrationBuilder.InsertData(
                table: "CharacterTasks",
                columns: new[] { "Id", "CharacterId", "CharacterTaskTypeId", "IsCompleted", "Period" },
                values: new object[,]
                {
                    { 43, 4, 6, false, 0 },
                    { 44, 4, 7, false, 1 },
                    { 45, 5, 1, false, 0 },
                    { 46, 5, 1, false, 0 },
                    { 47, 5, 2, false, 0 },
                    { 48, 5, 2, false, 0 },
                    { 49, 5, 3, false, 0 },
                    { 50, 5, 3, false, 0 },
                    { 51, 5, 3, false, 0 },
                    { 52, 5, 4, false, 0 },
                    { 53, 5, 5, false, 0 },
                    { 54, 5, 6, false, 0 },
                    { 55, 5, 7, false, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId",
                table: "Characters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterTasks_CharacterId",
                table: "CharacterTasks",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterTasks_CharacterTaskTypeId",
                table: "CharacterTasks",
                column: "CharacterTaskTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterTasks");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "CharacterTaskTypes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
