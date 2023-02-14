using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CdSamling.Migrations
{
    /// <inheritdoc />
    public partial class NewFKPKModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ArtistName",
                table: "Artist",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Artist",
                newName: "ArtistName");
        }
    }
}
