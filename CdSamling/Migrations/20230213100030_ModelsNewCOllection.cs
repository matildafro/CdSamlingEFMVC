using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CdSamling.Migrations
{
    /// <inheritdoc />
    public partial class ModelsNewCOllection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rent_Collection_CollectionId1",
                table: "Rent");

            migrationBuilder.DropIndex(
                name: "IX_Rent_CollectionId1",
                table: "Rent");

            migrationBuilder.DropColumn(
                name: "CollectionId1",
                table: "Rent");

            migrationBuilder.DropColumn(
                name: "RentId",
                table: "Collection");

            migrationBuilder.CreateIndex(
                name: "IX_Rent_CollectionId",
                table: "Rent",
                column: "CollectionId");

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

            migrationBuilder.DropIndex(
                name: "IX_Rent_CollectionId",
                table: "Rent");

            migrationBuilder.AddColumn<int>(
                name: "CollectionId1",
                table: "Rent",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RentId",
                table: "Collection",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rent_CollectionId1",
                table: "Rent",
                column: "CollectionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_Collection_CollectionId1",
                table: "Rent",
                column: "CollectionId1",
                principalTable: "Collection",
                principalColumn: "Id");
        }
    }
}
