using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace graphqlTest.Migrations
{
    /// <inheritdoc />
    public partial class reset_datetime_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("19c53429-c78b-4efb-a65e-5987f481b90f"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" },
                    { new Guid("754317c6-8e0f-419c-839e-3e8be9ff2714"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" },
                    { new Guid("946edc4f-77a5-4e40-812d-3ef10b3f36e6"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("178862bd-a661-490b-ade9-30d94f2bfe2f"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("946edc4f-77a5-4e40-812d-3ef10b3f36e6"), "The Dark Knight Rises" },
                    { new Guid("25516528-bd79-4403-ac1a-f2c3590ed305"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("946edc4f-77a5-4e40-812d-3ef10b3f36e6"), "Batman Begins" },
                    { new Guid("43802fd6-5018-4d89-80cb-388a7daf59da"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("19c53429-c78b-4efb-a65e-5987f481b90f"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("7fe2f2b5-5378-4a5f-87db-ffaf40463354"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("754317c6-8e0f-419c-839e-3e8be9ff2714"), "Black Widow" },
                    { new Guid("d6ff4866-8daa-4250-93d7-0d90ce1fef79"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("19c53429-c78b-4efb-a65e-5987f481b90f"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("db322341-379c-4d25-b743-cc771ef38270"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("19c53429-c78b-4efb-a65e-5987f481b90f"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("fc24c3a8-c4f0-43e0-9773-fa1dd8ea4ead"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("946edc4f-77a5-4e40-812d-3ef10b3f36e6"), "The Dark Knight" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("7e60495a-0ce6-4408-adf7-a646175b19e8"), "He got a lot of money", "Wealth.", new Guid("946edc4f-77a5-4e40-812d-3ef10b3f36e6") },
                    { new Guid("8fd29d5d-c843-4b09-bfe3-8a607da13804"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("754317c6-8e0f-419c-839e-3e8be9ff2714") },
                    { new Guid("9059ebe6-9696-46b9-a55e-1a05c3f17cc2"), "He's always a step ahead.", "Intellect.", new Guid("946edc4f-77a5-4e40-812d-3ef10b3f36e6") },
                    { new Guid("9173ab29-8d8e-4bc7-8e01-b9088f9b9508"), "She's good at spying at people.", "Espionage", new Guid("754317c6-8e0f-419c-839e-3e8be9ff2714") },
                    { new Guid("b94d283f-2eba-4735-8f69-d765d48946b5"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("754317c6-8e0f-419c-839e-3e8be9ff2714") },
                    { new Guid("c2549825-a789-4d33-9ef7-3b702dd6484f"), "Sublime fighting skills.", "Fighting", new Guid("946edc4f-77a5-4e40-812d-3ef10b3f36e6") },
                    { new Guid("da2710f0-3e63-40f0-8b6d-18d164cce8d3"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("19c53429-c78b-4efb-a65e-5987f481b90f") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("178862bd-a661-490b-ade9-30d94f2bfe2f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("25516528-bd79-4403-ac1a-f2c3590ed305"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("43802fd6-5018-4d89-80cb-388a7daf59da"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7fe2f2b5-5378-4a5f-87db-ffaf40463354"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d6ff4866-8daa-4250-93d7-0d90ce1fef79"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("db322341-379c-4d25-b743-cc771ef38270"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fc24c3a8-c4f0-43e0-9773-fa1dd8ea4ead"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("7e60495a-0ce6-4408-adf7-a646175b19e8"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("8fd29d5d-c843-4b09-bfe3-8a607da13804"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("9059ebe6-9696-46b9-a55e-1a05c3f17cc2"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("9173ab29-8d8e-4bc7-8e01-b9088f9b9508"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("b94d283f-2eba-4735-8f69-d765d48946b5"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("c2549825-a789-4d33-9ef7-3b702dd6484f"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("da2710f0-3e63-40f0-8b6d-18d164cce8d3"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("19c53429-c78b-4efb-a65e-5987f481b90f"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("754317c6-8e0f-419c-839e-3e8be9ff2714"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("946edc4f-77a5-4e40-812d-3ef10b3f36e6"));

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
    }
}
