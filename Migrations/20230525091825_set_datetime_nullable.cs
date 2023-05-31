using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace graphqlTest.Migrations
{
    /// <inheritdoc />
    public partial class set_datetime_nullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("362ebcc8-ae31-4015-a662-8b2103f8016d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5f7ae64f-8795-4796-bc5b-fd9cc4e8be93"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6e35edd2-c7bc-467e-a7c8-fe45ca0462a5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("98977991-b414-441b-8c23-7184386a4dcf"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a0a3aed8-fc88-4b12-8058-fe7b8c1ca2cc"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b49e631f-881d-4966-b44b-c455bd3de1f4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bcfb7318-3180-457c-8019-3276b4cc3346"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("0ba352f5-e5e6-4f97-9369-037c211f4b8c"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("0f894ed0-ae63-4d1b-ac8c-403abf2e342d"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("4319d482-68b6-44aa-8f57-22dea7f41e44"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("6896eca2-6ed5-427d-8e6d-415667aeddfc"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("d4cdaf66-a963-43cb-9fd0-ded4508acc44"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("ddb66d01-e2a9-4940-8e8f-7538abda7927"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("e24b7426-4824-470d-be6c-352d3a69fe89"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("0e9d8571-55fb-40d3-a394-49a6b62de5ab"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("12ec9478-2907-4527-83b8-b080054ad31e"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("6ad8b88e-8b42-4d21-89e0-739c333c0303"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movies",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("39953d09-330b-4350-b2ad-822f399d2b5f"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" },
                    { new Guid("cb77a4c1-c339-43e0-bb3f-a546a0100483"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" },
                    { new Guid("f7739add-70e8-40fa-9798-2563ba8c4019"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("32c799af-2b24-4d0d-b43c-d84dd4aa263e"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cb77a4c1-c339-43e0-bb3f-a546a0100483"), "The Dark Knight" },
                    { new Guid("34709dd0-02b5-486e-81b4-1d0c4e92c962"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f7739add-70e8-40fa-9798-2563ba8c4019"), "Black Widow" },
                    { new Guid("6987b981-0330-4308-9889-bd546b5c5a24"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("39953d09-330b-4350-b2ad-822f399d2b5f"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("a171a28f-fbe7-49d3-b64f-049eddeedeaa"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cb77a4c1-c339-43e0-bb3f-a546a0100483"), "Batman Begins" },
                    { new Guid("b084ed77-d23b-416e-8b72-74a00b572b8c"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cb77a4c1-c339-43e0-bb3f-a546a0100483"), "The Dark Knight Rises" },
                    { new Guid("db923049-d6cf-45ce-9a08-60215ee509ed"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("39953d09-330b-4350-b2ad-822f399d2b5f"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("f21d5497-e262-49ea-ae01-b9847ce0079e"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("39953d09-330b-4350-b2ad-822f399d2b5f"), "Star Wars: Episode IV – A New Hope" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("259559e4-a2f1-4a25-b536-a840e9e22fdc"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("f7739add-70e8-40fa-9798-2563ba8c4019") },
                    { new Guid("693dec43-5432-43c5-973f-72b3fb3ddc08"), "She's good at spying at people.", "Espionage", new Guid("f7739add-70e8-40fa-9798-2563ba8c4019") },
                    { new Guid("6f8d2ce3-2e30-484f-bd49-7a16608e354e"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("f7739add-70e8-40fa-9798-2563ba8c4019") },
                    { new Guid("8254e632-63be-4274-8662-16296763f430"), "He got a lot of money", "Wealth.", new Guid("cb77a4c1-c339-43e0-bb3f-a546a0100483") },
                    { new Guid("948dce43-0e1d-4b54-8db7-22b301cbfbbb"), "He's always a step ahead.", "Intellect.", new Guid("cb77a4c1-c339-43e0-bb3f-a546a0100483") },
                    { new Guid("df5bb4d2-2211-41f8-affe-0e2df5b4a680"), "Sublime fighting skills.", "Fighting", new Guid("cb77a4c1-c339-43e0-bb3f-a546a0100483") },
                    { new Guid("fe57df87-be27-4657-a2b4-abd3537caee9"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("39953d09-330b-4350-b2ad-822f399d2b5f") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("32c799af-2b24-4d0d-b43c-d84dd4aa263e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("34709dd0-02b5-486e-81b4-1d0c4e92c962"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6987b981-0330-4308-9889-bd546b5c5a24"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a171a28f-fbe7-49d3-b64f-049eddeedeaa"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b084ed77-d23b-416e-8b72-74a00b572b8c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("db923049-d6cf-45ce-9a08-60215ee509ed"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f21d5497-e262-49ea-ae01-b9847ce0079e"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("259559e4-a2f1-4a25-b536-a840e9e22fdc"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("693dec43-5432-43c5-973f-72b3fb3ddc08"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("6f8d2ce3-2e30-484f-bd49-7a16608e354e"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("8254e632-63be-4274-8662-16296763f430"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("948dce43-0e1d-4b54-8db7-22b301cbfbbb"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("df5bb4d2-2211-41f8-affe-0e2df5b4a680"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("fe57df87-be27-4657-a2b4-abd3537caee9"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("39953d09-330b-4350-b2ad-822f399d2b5f"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("cb77a4c1-c339-43e0-bb3f-a546a0100483"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("f7739add-70e8-40fa-9798-2563ba8c4019"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

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
        }
    }
}
