using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDataAccess.Migrations
{
    public partial class intialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Account = table.Column<int>(nullable: false),
                    MiddleName = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Values",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Values", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StreetAddress = table.Column<int>(nullable: false),
                    City = table.Column<int>(nullable: false),
                    Street = table.Column<string>(nullable: true),
                    Zipcode = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmailsAddress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmailAddress = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailsAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailsAddress_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "001" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "002" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "002" });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PersonId",
                table: "Addresses",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailsAddress_PersonId",
                table: "EmailsAddress",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "EmailsAddress");

            migrationBuilder.DropTable(
                name: "Values");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
