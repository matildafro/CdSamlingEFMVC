using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CdSamling.Migrations
{
    /// <inheritdoc />
    public partial class Rentsnotworking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rent_Collection_CollectionId",
                table: "Rent");

            migrationBuilder.AlterColumn<int>(
                name: "CollectionId",
                table: "Rent",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_Collection_CollectionId",
                table: "Rent",
                column: "CollectionId",
                principalTable: "Collection",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rent_Collection_CollectionId",
                table: "Rent");

            migrationBuilder.AlterColumn<int>(
                name: "CollectionId",
                table: "Rent",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_Collection_CollectionId",
                table: "Rent",
                column: "CollectionId",
                principalTable: "Collection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
