using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeratoLetsepe_ContosoUniversity.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Illnesses",
                columns: table => new
                {
                    IllnessId = table.Column<Guid>(nullable: false),
                    IllnessName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Illnesses", x => x.IllnessId);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    IdNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ContactNo = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    ClientId = table.Column<Guid>(nullable: true),
                    PersonId1 = table.Column<Guid>(nullable: true),
                    IllnessId = table.Column<Guid>(nullable: true),
                    DoctordId = table.Column<Guid>(nullable: true),
                    Doctor_PersonId1 = table.Column<Guid>(nullable: true),
                    Specialist = table.Column<string>(nullable: true),
                    API = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_People_People_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_People_People_Doctor_PersonId1",
                        column: x => x.Doctor_PersonId1,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    VisitsId = table.Column<Guid>(nullable: false),
                    DoctorIdPersonId = table.Column<Guid>(nullable: true),
                    ClientIdPersonId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.VisitsId);
                    table.ForeignKey(
                        name: "FK_Visits_People_ClientIdPersonId",
                        column: x => x.ClientIdPersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Visits_People_DoctorIdPersonId",
                        column: x => x.DoctorIdPersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_People_PersonId1",
                table: "People",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_People_Doctor_PersonId1",
                table: "People",
                column: "Doctor_PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_ClientIdPersonId",
                table: "Visits",
                column: "ClientIdPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_DoctorIdPersonId",
                table: "Visits",
                column: "DoctorIdPersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Illnesses");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
