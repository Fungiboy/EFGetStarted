using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFGetStarted.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Blogs_BlogId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_UserID",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UserID",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "Posts",
                newName: "BlogID");

            migrationBuilder.RenameColumn(
                name: "PublishedOn",
                table: "Posts",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_BlogId",
                table: "Posts",
                newName: "IX_Posts_BlogID");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Blogs",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Content",
                table: "Posts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Blogs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_UserID",
                table: "Blogs",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Users_UserID",
                table: "Blogs",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Blogs_BlogID",
                table: "Posts",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Users_UserID",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Blogs_BlogID",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_UserID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "BlogID",
                table: "Posts",
                newName: "BlogId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Posts",
                newName: "PublishedOn");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_BlogID",
                table: "Posts",
                newName: "IX_Posts_BlogId");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Blogs",
                newName: "Url");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Posts",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Posts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Posts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Blogs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserID",
                table: "Posts",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Blogs_BlogId",
                table: "Posts",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserID",
                table: "Posts",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
