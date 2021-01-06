using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Udemy_NetCore.Migrations
{
    public partial class FinalSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, new byte[] { 97, 203, 207, 109, 201, 246, 48, 199, 78, 18, 229, 196, 179, 41, 23, 107, 47, 77, 205, 152, 210, 135, 40, 0, 10, 116, 48, 83, 84, 241, 135, 52, 35, 74, 4, 203, 143, 116, 45, 209, 142, 145, 201, 34, 3, 170, 130, 80, 221, 0, 174, 3, 223, 45, 18, 44, 190, 239, 171, 174, 59, 244, 92, 222 }, new byte[] { 209, 112, 155, 188, 112, 219, 39, 242, 124, 159, 32, 31, 20, 210, 8, 89, 69, 158, 76, 120, 40, 15, 23, 188, 173, 73, 43, 97, 37, 130, 155, 152, 32, 225, 114, 67, 45, 31, 165, 0, 237, 188, 75, 69, 155, 26, 49, 86, 72, 190, 56, 4, 71, 141, 145, 168, 202, 230, 182, 178, 98, 20, 1, 88, 93, 255, 51, 129, 244, 135, 239, 154, 103, 131, 181, 155, 34, 228, 34, 99, 92, 211, 126, 50, 107, 168, 194, 209, 97, 125, 37, 29, 65, 172, 131, 208, 11, 139, 17, 102, 163, 44, 217, 228, 97, 35, 233, 134, 82, 232, 94, 160, 201, 114, 244, 212, 204, 74, 4, 114, 48, 250, 70, 250, 201, 174, 157, 229 }, "User1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 2, new byte[] { 97, 203, 207, 109, 201, 246, 48, 199, 78, 18, 229, 196, 179, 41, 23, 107, 47, 77, 205, 152, 210, 135, 40, 0, 10, 116, 48, 83, 84, 241, 135, 52, 35, 74, 4, 203, 143, 116, 45, 209, 142, 145, 201, 34, 3, 170, 130, 80, 221, 0, 174, 3, 223, 45, 18, 44, 190, 239, 171, 174, 59, 244, 92, 222 }, new byte[] { 209, 112, 155, 188, 112, 219, 39, 242, 124, 159, 32, 31, 20, 210, 8, 89, 69, 158, 76, 120, 40, 15, 23, 188, 173, 73, 43, 97, 37, 130, 155, 152, 32, 225, 114, 67, 45, 31, 165, 0, 237, 188, 75, 69, 155, 26, 49, 86, 72, 190, 56, 4, 71, 141, 145, 168, 202, 230, 182, 178, 98, 20, 1, 88, 93, 255, 51, 129, 244, 135, 239, 154, 103, 131, 181, 155, 34, 228, 34, 99, 92, 211, 126, 50, 107, 168, 194, 209, 97, 125, 37, 29, 65, 172, 131, 208, 11, 139, 17, 102, 163, 44, 217, 228, 97, 35, 233, 134, 82, 232, 94, 160, 201, 114, 244, 212, 204, 74, 4, 114, 48, 250, 70, 250, 201, 174, 157, 229 }, "User2" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 3, new byte[] { 97, 203, 207, 109, 201, 246, 48, 199, 78, 18, 229, 196, 179, 41, 23, 107, 47, 77, 205, 152, 210, 135, 40, 0, 10, 116, 48, 83, 84, 241, 135, 52, 35, 74, 4, 203, 143, 116, 45, 209, 142, 145, 201, 34, 3, 170, 130, 80, 221, 0, 174, 3, 223, 45, 18, 44, 190, 239, 171, 174, 59, 244, 92, 222 }, new byte[] { 209, 112, 155, 188, 112, 219, 39, 242, 124, 159, 32, 31, 20, 210, 8, 89, 69, 158, 76, 120, 40, 15, 23, 188, 173, 73, 43, 97, 37, 130, 155, 152, 32, 225, 114, 67, 45, 31, 165, 0, 237, 188, 75, 69, 155, 26, 49, 86, 72, 190, 56, 4, 71, 141, 145, 168, 202, 230, 182, 178, 98, 20, 1, 88, 93, 255, 51, 129, 244, 135, 239, 154, 103, 131, 181, 155, 34, 228, 34, 99, 92, 211, 126, 50, 107, 168, 194, 209, 97, 125, 37, 29, 65, 172, 131, 208, 11, 139, 17, 102, 163, 44, 217, 228, 97, 35, 233, 134, 82, 232, 94, 160, 201, 114, 244, 212, 204, 74, 4, 114, 48, 250, 70, 250, 201, 174, 157, 229 }, "User3" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 1, 1, 0, 10, 0, 100, 10, "Frodo", 15, 1, 0 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 2, 2, 0, 5, 0, 100, 20, "Raistlin", 5, 2, 0 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[] { 1, 1, 20, "The Master Sword" });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[] { 2, 2, 5, "Crystal Wand" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
