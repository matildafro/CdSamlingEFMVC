using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CdSamling.Migrations
{
    /// <inheritdoc />
    public partial class NewModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistCollection");

            migrationBuilder.DropColumn(
                name: "ArtistName",
                table: "Collection");

            migrationBuilder.RenameColumn(
                name: "RentName",
                table: "Rent",
                newName: "RentByName");

            migrationBuilder.AddColumn<int>(
                name: "CollectionId",
                table: "Rent",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CollectionId1",
                table: "Rent",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArtistId",
                table: "Collection",
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

            migrationBuilder.CreateIndex(
                name: "IX_Collection_ArtistId",
                table: "Collection",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Collection_Artist_ArtistId",
                table: "Collection",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_Collection_CollectionId1",
                table: "Rent",
                column: "CollectionId1",
                principalTable: "Collection",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collection_Artist_ArtistId",
                table: "Collection");

            migrationBuilder.DropForeignKey(
                name: "FK_Rent_Collection_CollectionId1",
                table: "Rent");

            migrationBuilder.DropIndex(
                name: "IX_Rent_CollectionId1",
                table: "Rent");

            migrationBuilder.DropIndex(
                name: "IX_Collection_ArtistId",
                table: "Collection");

            migrationBuilder.DropColumn(
                name: "CollectionId",
                table: "Rent");

            migrationBuilder.DropColumn(
                name: "CollectionId1",
                table: "Rent");

            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "Collection");

            migrationBuilder.DropColumn(
                name: "RentId",
                table: "Collection");

            migrationBuilder.RenameColumn(
                name: "RentByName",
                table: "Rent",
                newName: "RentName");

            migrationBuilder.AddColumn<string>(
                name: "ArtistName",
                table: "Collection",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ArtistCollection",
                columns: table => new
                {
                    ArtistCollectionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArtistId = table.Column<int>(type: "INTEGER", nullable: false),
                    CollectionId = table.Column<int>(type: "INTEGER", nullable: true),
                    CollectiontId = table.Column<int>(type: "INTEGER", nullable: false),
                    RentId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistCollection", x => x.ArtistCollectionId);
                    table.ForeignKey(
                        name: "FK_ArtistCollection_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistCollection_Collection_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ArtistCollection_Rent_RentId",
                        column: x => x.RentId,
                        principalTable: "Rent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistCollection_ArtistId",
                table: "ArtistCollection",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistCollection_CollectionId",
                table: "ArtistCollection",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistCollection_RentId",
                table: "ArtistCollection",
                column: "RentId");
        }
    }
}
