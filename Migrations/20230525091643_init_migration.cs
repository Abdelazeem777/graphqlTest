using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace graphqlTest.Migrations
{
    /// <inheritdoc />
    public partial class init_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Superheroes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Height = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superheroes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Instructor = table.Column<string>(type: "text", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SuperheroId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Superheroes_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Superpowers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SuperPower = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SuperheroId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superpowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Superpowers_Superheroes_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("0e9d8571-55fb-40d3-a394-49a6b62de5ab"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" },
                    { new Guid("12ec9478-2907-4527-83b8-b080054ad31e"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" },
                    { new Guid("6ad8b88e-8b42-4d21-89e0-739c333c0303"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("362ebcc8-ae31-4015-a662-8b2103f8016d"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6ad8b88e-8b42-4d21-89e0-739c333c0303"), "Black Widow" },
                    { new Guid("5f7ae64f-8795-4796-bc5b-fd9cc4e8be93"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("12ec9478-2907-4527-83b8-b080054ad31e"), "The Dark Knight" },
                    { new Guid("6e35edd2-c7bc-467e-a7c8-fe45ca0462a5"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0e9d8571-55fb-40d3-a394-49a6b62de5ab"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("98977991-b414-441b-8c23-7184386a4dcf"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("12ec9478-2907-4527-83b8-b080054ad31e"), "Batman Begins" },
                    { new Guid("a0a3aed8-fc88-4b12-8058-fe7b8c1ca2cc"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("12ec9478-2907-4527-83b8-b080054ad31e"), "The Dark Knight Rises" },
                    { new Guid("b49e631f-881d-4966-b44b-c455bd3de1f4"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0e9d8571-55fb-40d3-a394-49a6b62de5ab"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("bcfb7318-3180-457c-8019-3276b4cc3346"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0e9d8571-55fb-40d3-a394-49a6b62de5ab"), "Star Wars: Episode V – The Empire Strikes Back" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("0ba352f5-e5e6-4f97-9369-037c211f4b8c"), "He's always a step ahead.", "Intellect.", new Guid("12ec9478-2907-4527-83b8-b080054ad31e") },
                    { new Guid("0f894ed0-ae63-4d1b-ac8c-403abf2e342d"), "He got a lot of money", "Wealth.", new Guid("12ec9478-2907-4527-83b8-b080054ad31e") },
                    { new Guid("4319d482-68b6-44aa-8f57-22dea7f41e44"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("6ad8b88e-8b42-4d21-89e0-739c333c0303") },
                    { new Guid("6896eca2-6ed5-427d-8e6d-415667aeddfc"), "Sublime fighting skills.", "Fighting", new Guid("12ec9478-2907-4527-83b8-b080054ad31e") },
                    { new Guid("d4cdaf66-a963-43cb-9fd0-ded4508acc44"), "She's good at spying at people.", "Espionage", new Guid("6ad8b88e-8b42-4d21-89e0-739c333c0303") },
                    { new Guid("ddb66d01-e2a9-4940-8e8f-7538abda7927"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("6ad8b88e-8b42-4d21-89e0-739c333c0303") },
                    { new Guid("e24b7426-4824-470d-be6c-352d3a69fe89"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("0e9d8571-55fb-40d3-a394-49a6b62de5ab") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_SuperheroId",
                table: "Movies",
                column: "SuperheroId");

            migrationBuilder.CreateIndex(
                name: "IX_Superpowers_SuperheroId",
                table: "Superpowers",
                column: "SuperheroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Superpowers");

            migrationBuilder.DropTable(
                name: "Superheroes");
        }
    }
}
