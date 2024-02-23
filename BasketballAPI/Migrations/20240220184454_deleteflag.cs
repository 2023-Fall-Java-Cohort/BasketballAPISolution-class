using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasketballAPI.Migrations
{
    /// <inheritdoc />
    public partial class deleteflag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Teams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Positions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Players",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Coaches",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 422, DateTimeKind.Utc).AddTicks(6244), false, "Alfredo Gerhold", new DateTime(2024, 2, 20, 18, 44, 52, 422, DateTimeKind.Utc).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 423, DateTimeKind.Utc).AddTicks(8830), false, "Roman Gleason", new DateTime(2024, 2, 20, 18, 44, 52, 423, DateTimeKind.Utc).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 424, DateTimeKind.Utc).AddTicks(2530), false, "Glenda Roob", new DateTime(2024, 2, 20, 18, 44, 52, 424, DateTimeKind.Utc).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 424, DateTimeKind.Utc).AddTicks(3837), false, "Katherine Quigley", new DateTime(2024, 2, 20, 18, 44, 52, 424, DateTimeKind.Utc).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 424, DateTimeKind.Utc).AddTicks(4986), false, "Cassandra Greenfelder", new DateTime(2024, 2, 20, 18, 44, 52, 424, DateTimeKind.Utc).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 424, DateTimeKind.Utc).AddTicks(6768), false, "Manuel Hegmann", new DateTime(2024, 2, 20, 18, 44, 52, 424, DateTimeKind.Utc).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 424, DateTimeKind.Utc).AddTicks(8382), false, "Julia Pollich", new DateTime(2024, 2, 20, 18, 44, 52, 424, DateTimeKind.Utc).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 424, DateTimeKind.Utc).AddTicks(9424), false, "Armando Hamill", new DateTime(2024, 2, 20, 18, 44, 52, 424, DateTimeKind.Utc).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 425, DateTimeKind.Utc).AddTicks(445), false, "Mario Huel", new DateTime(2024, 2, 20, 18, 44, 52, 425, DateTimeKind.Utc).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 425, DateTimeKind.Utc).AddTicks(1517), false, "Kayla Mills", new DateTime(2024, 2, 20, 18, 44, 52, 425, DateTimeKind.Utc).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 425, DateTimeKind.Utc).AddTicks(2411), false, "Juan Walter", new DateTime(2024, 2, 20, 18, 44, 52, 425, DateTimeKind.Utc).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 425, DateTimeKind.Utc).AddTicks(3347), false, "Bernice Roberts", new DateTime(2024, 2, 20, 18, 44, 52, 425, DateTimeKind.Utc).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 426, DateTimeKind.Utc).AddTicks(7715), false, "Vivian Rowe", new DateTime(2024, 2, 20, 18, 44, 52, 426, DateTimeKind.Utc).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 426, DateTimeKind.Utc).AddTicks(9957), false, "Eugene Beer", new DateTime(2024, 2, 20, 18, 44, 52, 426, DateTimeKind.Utc).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 427, DateTimeKind.Utc).AddTicks(1624), false, "Kristen McGlynn", new DateTime(2024, 2, 20, 18, 44, 52, 427, DateTimeKind.Utc).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 427, DateTimeKind.Utc).AddTicks(3201), false, "Harvey Abernathy", new DateTime(2024, 2, 20, 18, 44, 52, 427, DateTimeKind.Utc).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 427, DateTimeKind.Utc).AddTicks(4430), false, "Rosemarie Von", new DateTime(2024, 2, 20, 18, 44, 52, 427, DateTimeKind.Utc).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 427, DateTimeKind.Utc).AddTicks(5560), false, "Sheldon Hoppe", new DateTime(2024, 2, 20, 18, 44, 52, 427, DateTimeKind.Utc).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 427, DateTimeKind.Utc).AddTicks(6978), false, "Wendy Ullrich", new DateTime(2024, 2, 20, 18, 44, 52, 427, DateTimeKind.Utc).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 428, DateTimeKind.Utc).AddTicks(1384), false, "Anne Dooley", new DateTime(2024, 2, 20, 18, 44, 52, 428, DateTimeKind.Utc).AddTicks(1382) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 428, DateTimeKind.Utc).AddTicks(3802), false, "Beth Beahan", new DateTime(2024, 2, 20, 18, 44, 52, 428, DateTimeKind.Utc).AddTicks(3801) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 428, DateTimeKind.Utc).AddTicks(5167), false, "Christian Murphy", new DateTime(2024, 2, 20, 18, 44, 52, 428, DateTimeKind.Utc).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 428, DateTimeKind.Utc).AddTicks(6506), false, "Regina VonRueden", new DateTime(2024, 2, 20, 18, 44, 52, 428, DateTimeKind.Utc).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 428, DateTimeKind.Utc).AddTicks(9319), false, "Fernando Hilll", new DateTime(2024, 2, 20, 18, 44, 52, 428, DateTimeKind.Utc).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "IsDeleted", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 429, DateTimeKind.Utc).AddTicks(5817), false, "April Windler", new DateTime(2024, 2, 20, 18, 44, 52, 429, DateTimeKind.Utc).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1996, 5, 1, 16, 31, 51, 142, DateTimeKind.Local).AddTicks(8598), new DateTime(2024, 2, 20, 18, 44, 52, 366, DateTimeKind.Utc).AddTicks(2632), false, "Theresa Marks", 13, 1, 398638.363617523630000m, new DateTime(2024, 2, 20, 18, 44, 52, 366, DateTimeKind.Utc).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 4, 4, 22, 23, 42, 669, DateTimeKind.Local).AddTicks(7191), new DateTime(2024, 2, 20, 18, 44, 52, 366, DateTimeKind.Utc).AddTicks(9496), false, "Melba Marvin", 83, 5, 281214.308434503070000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 366, DateTimeKind.Utc).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 7, 18, 6, 34, 6, 442, DateTimeKind.Local).AddTicks(8565), new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(1466), false, "Mathew Langosh", 70, 5, 91710.764553540070000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1968, 8, 1, 3, 21, 38, 108, DateTimeKind.Local).AddTicks(9890), new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(2499), false, "Hannah Glover", 4, 45713.1764196631840000m, new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 4, 10, 23, 23, 53, 731, DateTimeKind.Local).AddTicks(5156), new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(3399), false, "Javier Sawayn", 46, 4, 128362.772858263570000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1960, 1, 22, 13, 44, 29, 964, DateTimeKind.Local).AddTicks(4704), new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(4163), false, "Juan Rau", 83, 1, 383175.906038288080000m, new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 8, 4, 22, 52, 56, 857, DateTimeKind.Local).AddTicks(3532), new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(4746), false, "Ricky Cormier", 47, 5, 177578.952281171470000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 9, 24, 7, 59, 49, 81, DateTimeKind.Local).AddTicks(207), new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(5361), false, "Georgia Hilll", 82, 1, 314427.423136288270000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 10, 28, 16, 48, 47, 509, DateTimeKind.Local).AddTicks(281), new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(6011), false, "Aaron Mann", 94, 2, 240569.204699968420000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1980, 6, 19, 17, 20, 52, 11, DateTimeKind.Local).AddTicks(6246), new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(6559), false, "Chelsea Pfannerstill", 21, 5, 163544.189601844990000m, new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 6, 27, 12, 53, 6, 406, DateTimeKind.Local).AddTicks(6866), new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(7203), false, "Kevin Schuppe", 51, 2, 183654.142158568240000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 12, 13, 10, 59, 51, 783, DateTimeKind.Local).AddTicks(5645), new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(7818), false, "Marian Wolf", 88, 4, 248306.497119657070000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 7, 25, 12, 2, 25, 623, DateTimeKind.Local).AddTicks(9528), new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(8381), false, "Chelsea Fahey", 2, 1, 314713.274400103270000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 6, 13, 0, 26, 32, 312, DateTimeKind.Local).AddTicks(2293), new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(9041), false, "Alberto Marvin", 5, 118785.917624083960000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 11, 11, 18, 58, 14, 549, DateTimeKind.Local).AddTicks(2042), new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(9635), false, "Leigh Pollich", 93, 3, 92640.727572701740000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 367, DateTimeKind.Utc).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 2, 23, 2, 17, 2, 388, DateTimeKind.Local).AddTicks(1011), new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(578), false, "Johnnie Bernhard", 100, 334349.915351661940000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 1, 29, 22, 17, 21, 138, DateTimeKind.Local).AddTicks(3789), new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(1386), false, "Judy Robel", 19, 2, 123257.565233838610000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 8, 4, 14, 5, 42, 75, DateTimeKind.Local).AddTicks(5706), new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(2050), false, "Sally Rodriguez", 78, 369256.953944074420000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 2, 22, 9, 53, 33, 27, DateTimeKind.Local).AddTicks(3018), new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(2670), false, "Luis Orn", 2, 5, 281479.91953509310000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 7, 31, 21, 56, 41, 963, DateTimeKind.Local).AddTicks(8891), new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(3276), false, "Johnny Franecki", 11, 2, 322651.97762090110000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1997, 8, 8, 12, 17, 18, 624, DateTimeKind.Local).AddTicks(6473), new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(3904), false, "Ella McGlynn", 76, 4, 268940.86565574760000m, new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 7, 23, 18, 55, 18, 12, DateTimeKind.Local).AddTicks(4180), new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(4480), false, "Calvin O'Connell", 31, 46065.1338306315160000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 3, 3, 5, 57, 12, 373, DateTimeKind.Local).AddTicks(3847), new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(5170), false, "Bobby Kuhn", 46, 3, 322612.670949345520000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 3, 27, 3, 49, 26, 645, DateTimeKind.Local).AddTicks(1642), new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(5759), false, "Arthur Stiedemann", 80, 4, 229712.763895009060000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 1, 5, 19, 30, 5, 111, DateTimeKind.Local).AddTicks(6810), new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(6420), false, "Grace Oberbrunner", 15, 3, 224449.2098426860000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1982, 11, 9, 8, 8, 44, 906, DateTimeKind.Local).AddTicks(4048), new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(7034), false, "Hannah Kozey", 96, 324229.710937708930000m, new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 4, 16, 23, 46, 32, 322, DateTimeKind.Local).AddTicks(9131), new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(7589), false, "Lynn Conn", 36, 1, 345544.494849504460000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 11, 11, 18, 26, 32, 305, DateTimeKind.Local).AddTicks(6674), new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(8524), false, "Frank Okuneva", 100, 3, 56402.687944016560000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 11, 19, 14, 5, 3, 880, DateTimeKind.Local).AddTicks(9356), new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(9390), false, "Marco Gibson", 8, 5, 394586.286423892930000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 368, DateTimeKind.Utc).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 11, 3, 22, 56, 29, 594, DateTimeKind.Local).AddTicks(4254), new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(67), false, "Johnnie Glover", 45, 4, 230290.443216242620000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 4, 27, 22, 39, 26, 417, DateTimeKind.Local).AddTicks(2345), new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(751), false, "Dallas Weimann", 99, 369334.813355012950000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2000, 6, 20, 21, 32, 38, 134, DateTimeKind.Local).AddTicks(5303), new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(2030), false, "Nettie Renner", 79, 3, 150093.69629899540000m, new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 5, 21, 2, 35, 55, 659, DateTimeKind.Local).AddTicks(8773), new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(2762), false, "Clayton Bednar", 40, 2, 127489.430015486230000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 4, 27, 12, 36, 26, 152, DateTimeKind.Local).AddTicks(4316), new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(3363), false, "Elbert Keebler", 90, 1, 316558.373767870510000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 6, 12, 8, 30, 12, 204, DateTimeKind.Local).AddTicks(7315), new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(3989), false, "Desiree Watsica", 76, 5, 306252.36074158270000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 10, 18, 7, 44, 48, 870, DateTimeKind.Local).AddTicks(6392), new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(4617), false, "Leland Brown", 44, 5, 240178.369326631960000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1994, 12, 29, 18, 10, 57, 846, DateTimeKind.Local).AddTicks(9907), new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(5185), false, "Walter Ziemann", 71, 2, 11466.7467311838640000m, new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1997, 2, 28, 23, 52, 0, 683, DateTimeKind.Local).AddTicks(7197), new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(5823), false, "Gabriel Gleichner", 38, 1, 277345.042758091090000m, new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 1, 20, 12, 3, 5, 594, DateTimeKind.Local).AddTicks(5096), new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(6985), false, "Garrett Hermiston", 59, 109490.353902840550000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1999, 9, 2, 18, 21, 8, 364, DateTimeKind.Local).AddTicks(9657), new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(7731), false, "Bobby Langworth", 74, 2, 83547.430776167530000m, new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 4, 4, 7, 12, 25, 985, DateTimeKind.Local).AddTicks(3310), new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(8357), false, "Daisy Feeney", 74, 2, 178648.683573247150000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1983, 12, 27, 9, 19, 19, 633, DateTimeKind.Local).AddTicks(8993), new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(9066), false, "Lois Hills", 57, 4, 204557.276936221420000m, new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 3, 10, 7, 31, 34, 793, DateTimeKind.Local).AddTicks(5547), new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(9722), false, "Tanya Stamm", 28, 5, 278524.501292516950000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 369, DateTimeKind.Utc).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1985, 1, 9, 20, 20, 37, 437, DateTimeKind.Local).AddTicks(1235), new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(359), false, "Shawn Moore", 72, 2, 120110.152615682830000m, new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 7, 8, 5, 32, 44, 162, DateTimeKind.Local).AddTicks(7322), new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(1091), false, "Clayton Schinner", 79, 5, 245506.149881825680000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 3, 27, 10, 42, 0, 234, DateTimeKind.Local).AddTicks(4203), new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(1925), false, "Clint Collins", 3, 5, 398487.553513802470000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 4, 1, 13, 23, 58, 663, DateTimeKind.Local).AddTicks(9613), new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(2669), false, "Tami Muller", 10, 4, 333140.440112937460000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 3, 6, 15, 5, 59, 900, DateTimeKind.Local).AddTicks(2857), new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(3327), false, "Abraham Quigley", 38, 3, 17642.8500129664930000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1993, 11, 29, 7, 47, 51, 15, DateTimeKind.Local).AddTicks(230), new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(4421), false, "Eleanor Glover", 28, 4, 57499.461183430750000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 7, 23, 17, 14, 11, 948, DateTimeKind.Local).AddTicks(1259), new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(5393), false, "Allen Wyman", 35, 1, 324874.827804450550000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 4, 14, 16, 58, 21, 507, DateTimeKind.Local).AddTicks(5434), new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(6013), false, "Christine Bernhard", 65, 5, 323282.898715588750000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1961, 6, 16, 17, 44, 12, 647, DateTimeKind.Local).AddTicks(6100), new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(6656), false, "Dale Medhurst", 68, 33937.8558408996760000m, new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 4, 23, 11, 17, 31, 360, DateTimeKind.Local).AddTicks(9798), new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(7313), false, "Jane Fahey", 90, 3, 343948.894830674110000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 5, 9, 7, 5, 42, 163, DateTimeKind.Local).AddTicks(4444), new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(7894), false, "Hattie Considine", 18, 3, 258026.218380537220000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1967, 8, 2, 8, 47, 58, 221, DateTimeKind.Local).AddTicks(300), new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(8527), false, "Stephanie Kulas", 24, 237038.09816578150000m, new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 4, 16, 20, 49, 41, 404, DateTimeKind.Local).AddTicks(9103), new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(9153), false, "Pam Barton", 29, 5, 126778.908715736410000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1991, 8, 21, 3, 55, 56, 447, DateTimeKind.Local).AddTicks(6712), new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(9726), false, "Glenn Howell", 65, 5, 188106.666932479870000m, new DateTime(2024, 2, 20, 18, 44, 52, 370, DateTimeKind.Utc).AddTicks(9726) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 1, 9, 1, 39, 12, 137, DateTimeKind.Local).AddTicks(734), new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(317), false, "Elmer Bernhard", 76, 380470.782340848280000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 4, 30, 4, 58, 49, 771, DateTimeKind.Local).AddTicks(4783), new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(968), false, "Tammy Walker", 99, 1, 27291.3229504961920000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 9, 5, 4, 12, 11, 750, DateTimeKind.Local).AddTicks(9903), new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(1508), false, "Priscilla Schiller", 99, 2, 178702.758555993610000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 2, 23, 16, 13, 41, 267, DateTimeKind.Local).AddTicks(2306), new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(2558), false, "Henrietta Green", 11, 2, 383549.608554103540000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 1, 28, 18, 35, 19, 498, DateTimeKind.Local).AddTicks(7408), new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(3336), false, "Salvador Howell", 18, 5, 273086.473578059950000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 4, 19, 11, 22, 37, 951, DateTimeKind.Local).AddTicks(9305), new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(3953), false, "Courtney Abshire", 59, 2, 216710.506748358730000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 11, 12, 18, 21, 0, 257, DateTimeKind.Local).AddTicks(5044), new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(4566), false, "Sergio Nikolaus", 85, 3, 111896.247013683070000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 3, 12, 14, 51, 22, 785, DateTimeKind.Local).AddTicks(7475), new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(5200), false, "Jake Simonis", 26, 172875.359493349750000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1987, 4, 9, 22, 37, 30, 21, DateTimeKind.Local).AddTicks(2439), new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(5804), false, "Levi Rippin", 78, 1, 265431.347635318660000m, new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 9, 7, 14, 58, 5, 701, DateTimeKind.Local).AddTicks(8837), new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(6413), false, "Joe Will", 78, 2, 391705.763056140640000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 12, 2, 9, 51, 17, 356, DateTimeKind.Local).AddTicks(762), new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(6988), false, "Rochelle Cole", 51, 4, 132644.108891351710000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 12, 15, 8, 14, 18, 32, DateTimeKind.Local).AddTicks(4697), new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(7536), false, "Harriet Jaskolski", 29, 3, 39129.9125434331950000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 1, 25, 5, 13, 8, 405, DateTimeKind.Local).AddTicks(7685), new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(8157), false, "Sherry Swift", 94, 2, 205992.528169834240000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 4, 11, 1, 30, 40, 200, DateTimeKind.Local).AddTicks(1822), new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(8795), false, "Terry Runolfsdottir", 64, 367384.481910317680000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1983, 2, 5, 12, 58, 33, 752, DateTimeKind.Local).AddTicks(3950), new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(9434), false, "Lydia Bradtke", 34, 2, 163689.158120455750000m, new DateTime(2024, 2, 20, 18, 44, 52, 371, DateTimeKind.Utc).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1991, 11, 19, 8, 46, 5, 818, DateTimeKind.Local).AddTicks(7068), new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(401), false, "Becky Glover", 2, 348774.98882107660000m, new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1964, 11, 24, 8, 16, 38, 747, DateTimeKind.Local).AddTicks(6554), new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(1223), false, "Phil Kovacek", 99, 3, 352300.729966588120000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 10, 11, 14, 14, 41, 792, DateTimeKind.Local).AddTicks(1677), new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(1905), false, "Sabrina Walker", 91, 1, 339727.571633568550000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 6, 24, 5, 42, 44, 656, DateTimeKind.Local).AddTicks(258), new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(2485), false, "Rosemary Howe", 60, 265862.177099852050000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 12, 17, 17, 12, 30, 569, DateTimeKind.Local).AddTicks(3547), new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(3094), false, "Horace Thompson", 14, 4, 118400.382837598540000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 6, 7, 20, 46, 6, 870, DateTimeKind.Local).AddTicks(1678), new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(3752), false, "Woodrow Roob", 9, 5, 122887.727885045620000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(3752) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 1, 20, 12, 20, 22, 795, DateTimeKind.Local).AddTicks(9728), new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(4340), false, "Lauren Dibbert", 47, 30457.8308840917570000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 5, 12, 1, 48, 10, 508, DateTimeKind.Local).AddTicks(3153), new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(4892), false, "Robyn Bins", 54, 4, 191966.092545384940000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1954, 11, 25, 2, 3, 22, 254, DateTimeKind.Local).AddTicks(1872), new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(5485), false, "Gina Smitham", 35, 4, 338705.341380615160000m, new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(5484) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1959, 4, 13, 8, 53, 27, 831, DateTimeKind.Local).AddTicks(805), new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(6047), false, "Roderick Reilly", 99, 4, 369827.136461000260000m, new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 6, 21, 12, 4, 12, 959, DateTimeKind.Local).AddTicks(7342), new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(6764), false, "Jose Ortiz", 13, 3, 370697.889179444050000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 12, 29, 5, 23, 4, 747, DateTimeKind.Local).AddTicks(9947), new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(7376), false, "Jeremiah Pagac", 34, 1, 322078.071954689950000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 9, 18, 5, 35, 41, 802, DateTimeKind.Local).AddTicks(9452), new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(8368), false, "Audrey Reichel", 21, 3, 268243.565602042540000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 7, 3, 3, 55, 11, 427, DateTimeKind.Local).AddTicks(5476), new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(9157), false, "Cedric Huel", 82, 2, 184621.210115192620000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 8, 25, 19, 46, 0, 76, DateTimeKind.Local).AddTicks(8395), new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(9750), false, "Dora Mitchell", 51, 383025.755612273140000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 372, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 4, 6, 8, 43, 3, 122, DateTimeKind.Local).AddTicks(270), new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(443), false, "Kelly Stark", 62, 320026.173788814340000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 12, 27, 8, 42, 23, 413, DateTimeKind.Local).AddTicks(3179), new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(1089), false, "Herbert Hegmann", 48, 1, 130066.083349145830000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(1089) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1989, 9, 15, 11, 27, 19, 838, DateTimeKind.Local).AddTicks(403), new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(1659), false, "Bryant Metz", 10, 3, 342229.306692631660000m, new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 12, 20, 8, 35, 49, 246, DateTimeKind.Local).AddTicks(4612), new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(2268), false, "Joel Predovic", 46, 1, 208960.585626777520000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 2, 3, 5, 29, 29, 683, DateTimeKind.Local).AddTicks(1519), new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(2876), false, "Meredith Veum", 16, 1, 370420.989127104880000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 2, 11, 17, 28, 34, 867, DateTimeKind.Local).AddTicks(3208), new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(3442), false, "Krystal Cruickshank", 46, 3, 111719.833033440310000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 8, 5, 22, 24, 55, 585, DateTimeKind.Local).AddTicks(2826), new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(4137), false, "Megan Gerlach", 91, 4, 184819.714538499940000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(4136) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 12, 8, 21, 59, 30, 458, DateTimeKind.Local).AddTicks(6775), new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(4692), false, "Fredrick Ferry", 56, 4, 193509.523351835590000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 10, 16, 10, 29, 53, 938, DateTimeKind.Local).AddTicks(1569), new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(5302), false, "Darryl Cassin", 67, 160460.677677161020000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 7, 28, 19, 9, 0, 230, DateTimeKind.Local).AddTicks(5288), new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(6172), false, "Ervin Simonis", 3, 2, 256326.12367134460000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 11, 4, 21, 9, 8, 216, DateTimeKind.Local).AddTicks(9417), new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(6970), false, "Emily Orn", 10, 1, 387267.826280135440000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 3, 31, 2, 41, 36, 32, DateTimeKind.Local).AddTicks(4318), new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(7575), false, "Jeff Macejkovic", 66, 100671.054501539980000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1997, 10, 27, 12, 28, 1, 997, DateTimeKind.Local).AddTicks(4584), new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(8101), false, "Maureen Hammes", 17, 5, 141896.232677104090000m, new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 12, 17, 3, 44, 35, 808, DateTimeKind.Local).AddTicks(2750), new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(8729), false, "Hattie Conn", 27, 3, 165110.101512056470000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1963, 8, 1, 13, 45, 43, 742, DateTimeKind.Local).AddTicks(743), new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(9355), false, "Agnes Rodriguez", 80, 5, 34095.6285071135140000m, new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 11, 27, 15, 21, 54, 926, DateTimeKind.Local).AddTicks(6298), new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(9920), false, "Fred Hane", 77, 68090.014239068890000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 373, DateTimeKind.Utc).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 6, 27, 14, 16, 33, 869, DateTimeKind.Local).AddTicks(4137), new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(502), false, "Pat Greenfelder", 54, 178332.036394824640000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 5, 6, 14, 55, 20, 594, DateTimeKind.Local).AddTicks(2499), new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(1114), false, "Darin Little", 65, 375038.80138600810000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 8, 6, 10, 13, 42, 432, DateTimeKind.Local).AddTicks(4081), new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(1725), false, "Chris Mann", 18, 4, 226229.024509855240000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 7, 22, 4, 59, 19, 227, DateTimeKind.Local).AddTicks(1002), new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(2272), false, "Margaret Wunsch", 88, 1, 192731.607557447650000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 2, 16, 21, 4, 57, 445, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(2917), false, "Raul Vandervort", 18, 3, 195939.046808430760000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1988, 5, 7, 16, 2, 40, 272, DateTimeKind.Local).AddTicks(4508), new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(3531), false, "Nettie White", 83, 2, 257218.650038269780000m, new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 11, 12, 7, 23, 6, 149, DateTimeKind.Local).AddTicks(549), new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(4536), false, "Deborah Gibson", 4, 4, 370541.460440655520000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 5, 4, 1, 46, 21, 326, DateTimeKind.Local).AddTicks(232), new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(5262), false, "Bert Padberg", 95, 4, 53180.736417775450000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 1, 13, 12, 23, 25, 701, DateTimeKind.Local).AddTicks(6795), new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(5850), false, "Sherry Vandervort", 60, 5, 216139.444147166920000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 6, 18, 2, 31, 47, 116, DateTimeKind.Local).AddTicks(4915), new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(6481), false, "Jessie Franecki", 22, 2, 321525.186036553840000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 11, 28, 21, 31, 51, 885, DateTimeKind.Local).AddTicks(1919), new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(7045), false, "Claudia Schultz", 21, 5, 317470.184346733720000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(7044) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 2, 14, 11, 33, 3, 942, DateTimeKind.Local).AddTicks(2483), new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(7629), false, "Stacey Kub", 72, 99520.494523264480000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 5, 31, 16, 18, 27, 81, DateTimeKind.Local).AddTicks(6272), new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(8214), false, "Frank Howe", 86, 4, 22996.7738803668610000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 6, 24, 1, 42, 32, 950, DateTimeKind.Local).AddTicks(2324), new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(8763), false, "Willis Smitham", 74, 2, 329364.310618055170000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1976, 11, 19, 1, 39, 27, 544, DateTimeKind.Local).AddTicks(8981), new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(9347), false, "Guillermo Deckow", 36, 2, 243269.986011418720000m, new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 11, 21, 2, 3, 42, 178, DateTimeKind.Local).AddTicks(6223), new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(9965), false, "Clark Lemke", 91, 1, 356786.04747317050000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 374, DateTimeKind.Utc).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 4, 10, 9, 28, 23, 915, DateTimeKind.Local).AddTicks(2936), new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(517), false, "Dana Rohan", 89, 5, 24824.8582630683340000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 6, 18, 9, 9, 26, 591, DateTimeKind.Local).AddTicks(6331), new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(1118), false, "Randal Will", 4, 1, 370819.2680592370000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1993, 5, 7, 18, 13, 28, 541, DateTimeKind.Local).AddTicks(5893), new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(1716), false, "Daryl Nicolas", 14, 202565.220264065740000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1962, 9, 9, 2, 46, 10, 844, DateTimeKind.Local).AddTicks(954), new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(2851), false, "Miriam Wintheiser", 78, 3, 193128.399419608240000m, new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 11, 13, 2, 46, 21, 372, DateTimeKind.Local).AddTicks(8521), new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(3616), false, "Lynda Goodwin", 37, 2, 391513.764385259740000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1993, 3, 30, 13, 56, 4, 398, DateTimeKind.Local).AddTicks(8535), new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(4204), false, "Lee Bayer", 58, 4, 196415.650661131060000m, new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 2, 26, 2, 54, 32, 730, DateTimeKind.Local).AddTicks(8322), new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(4804), false, "Ray Hintz", 23, 2, 223100.217435357070000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 8, 20, 2, 31, 1, 494, DateTimeKind.Local).AddTicks(2621), new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(5381), false, "Jimmie Carter", 88, 69321.681982888780000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 10, 28, 6, 7, 9, 57, DateTimeKind.Local).AddTicks(2575), new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(6000), false, "Christie Rath", 9, 3, 269522.101516842580000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 3, 26, 11, 53, 8, 649, DateTimeKind.Local).AddTicks(1047), new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(6586), false, "Tiffany D'Amore", 28, 3, 161950.636641191830000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(6586) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 12, 8, 11, 33, 10, 718, DateTimeKind.Local).AddTicks(5610), new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(7275), false, "Nicholas Fadel", 28, 3, 380119.05849683830000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 1, 19, 19, 31, 45, 995, DateTimeKind.Local).AddTicks(254), new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(7842), false, "Alexis Baumbach", 45, 207701.487268399270000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1996, 5, 14, 3, 20, 28, 822, DateTimeKind.Local).AddTicks(7101), new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(8476), false, "Christian Wilderman", 3, 5, 212573.70257761390000m, new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 4, 29, 21, 50, 32, 49, DateTimeKind.Local).AddTicks(3238), new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(9127), false, "May Pacocha", 47, 396281.012670519850000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 9, 15, 5, 51, 48, 246, DateTimeKind.Local).AddTicks(3416), new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(9955), false, "Stewart Lehner", 2, 139301.193073360750000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 375, DateTimeKind.Utc).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 8, 28, 14, 39, 26, 741, DateTimeKind.Local).AddTicks(4424), new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(910), false, "Tabitha Steuber", 83, 3, 155506.349210702350000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 10, 1, 9, 39, 35, 373, DateTimeKind.Local).AddTicks(8327), new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(1538), false, "Renee Bayer", 51, 1, 329724.189410792920000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1988, 11, 28, 20, 20, 34, 339, DateTimeKind.Local).AddTicks(2897), new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(2195), false, "John Conroy", 71, 3, 217881.56047294090000m, new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 1, 13, 14, 2, 22, 606, DateTimeKind.Local).AddTicks(8180), new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(2770), false, "Glen Wisozk", 31, 160155.336353668750000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 9, 5, 14, 36, 43, 895, DateTimeKind.Local).AddTicks(8006), new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(3374), false, "Dennis Considine", 42, 2, 334233.709520743360000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1998, 9, 15, 22, 58, 58, 984, DateTimeKind.Local).AddTicks(4824), new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(4080), false, "Audrey Haley", 40, 28302.187756503430000m, new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(4079) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 7, 10, 12, 57, 28, 321, DateTimeKind.Local).AddTicks(3586), new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(4668), false, "Wayne Erdman", 29, 68920.75302517690000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 1, 23, 19, 50, 32, 780, DateTimeKind.Local).AddTicks(5120), new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(5236), false, "Stephen Murray", 100, 1, 162197.307851474470000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 8, 20, 18, 20, 43, 711, DateTimeKind.Local).AddTicks(4105), new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(5908), false, "Alejandro Lockman", 15, 5, 175036.924627770520000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 10, 12, 11, 19, 27, 120, DateTimeKind.Local).AddTicks(9938), new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(6605), false, "Dallas Cartwright", 77, 1, 100541.454949001680000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 4, 7, 10, 24, 47, 279, DateTimeKind.Local).AddTicks(8918), new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(7215), false, "Johnnie Erdman", 44, 2, 310497.85412770240000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 9, 10, 19, 43, 43, 756, DateTimeKind.Local).AddTicks(4152), new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(8070), false, "Lauren Christiansen", 92, 3, 175488.665251891930000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 1, 24, 4, 56, 23, 197, DateTimeKind.Local).AddTicks(8992), new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(9027), false, "Travis O'Hara", 97, 4, 309098.353251558250000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 9, 21, 5, 53, 53, 232, DateTimeKind.Local).AddTicks(5151), new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(9739), false, "Claude O'Hara", 66, 4, 342686.912156898910000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 376, DateTimeKind.Utc).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 7, 30, 20, 47, 7, 292, DateTimeKind.Local).AddTicks(1846), new DateTime(2024, 2, 20, 18, 44, 52, 377, DateTimeKind.Utc).AddTicks(317), false, "Daisy Harris", 34, 5, 261049.534250219770000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 377, DateTimeKind.Utc).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1990, 5, 3, 22, 39, 12, 9, DateTimeKind.Local).AddTicks(2292), new DateTime(2024, 2, 20, 18, 44, 52, 377, DateTimeKind.Utc).AddTicks(952), false, "Arlene Lakin", 92, 213425.518495711330000m, new DateTime(2024, 2, 20, 18, 44, 52, 377, DateTimeKind.Utc).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 3, 20, 20, 22, 26, 942, DateTimeKind.Local).AddTicks(7224), new DateTime(2024, 2, 20, 18, 44, 52, 377, DateTimeKind.Utc).AddTicks(1614), false, "Courtney Hane", 81, 3, 390835.892511819550000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 377, DateTimeKind.Utc).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 7, 2, 6, 41, 3, 962, DateTimeKind.Local).AddTicks(5695), new DateTime(2024, 2, 20, 18, 44, 52, 377, DateTimeKind.Utc).AddTicks(2607), false, "Renee Mohr", 4, 338818.359104993290000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 377, DateTimeKind.Utc).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 7, 10, 23, 59, 49, 533, DateTimeKind.Local).AddTicks(8756), new DateTime(2024, 2, 20, 18, 44, 52, 377, DateTimeKind.Utc).AddTicks(3891), false, "Krista Rath", 96, 335313.491028620770000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 377, DateTimeKind.Utc).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 1, 2, 19, 41, 15, 142, DateTimeKind.Local).AddTicks(3154), new DateTime(2024, 2, 20, 18, 44, 52, 377, DateTimeKind.Utc).AddTicks(6684), false, "Peter Goyette", 51, 44297.0364040422430000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 377, DateTimeKind.Utc).AddTicks(6683) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 4, 28, 5, 33, 15, 937, DateTimeKind.Local).AddTicks(6536), new DateTime(2024, 2, 20, 18, 44, 52, 377, DateTimeKind.Utc).AddTicks(9384), false, "Jessie Daugherty", 73, 4, 27542.1972046122490000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 377, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 5, 12, 0, 56, 17, 574, DateTimeKind.Local).AddTicks(1835), new DateTime(2024, 2, 20, 18, 44, 52, 378, DateTimeKind.Utc).AddTicks(598), false, "Bryan Stroman", 47, 4, 197652.145023812950000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 378, DateTimeKind.Utc).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 10, 22, 13, 57, 50, 865, DateTimeKind.Local).AddTicks(4198), new DateTime(2024, 2, 20, 18, 44, 52, 378, DateTimeKind.Utc).AddTicks(1863), false, "Dianna Olson", 9, 4, 218304.806512464220000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 378, DateTimeKind.Utc).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 3, 19, 1, 15, 2, 648, DateTimeKind.Local).AddTicks(308), new DateTime(2024, 2, 20, 18, 44, 52, 378, DateTimeKind.Utc).AddTicks(4368), false, "Maurice Spinka", 50, 3, 302649.770884136770000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 378, DateTimeKind.Utc).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 4, 30, 16, 41, 43, 15, DateTimeKind.Local).AddTicks(2913), new DateTime(2024, 2, 20, 18, 44, 52, 378, DateTimeKind.Utc).AddTicks(6548), false, "Rita Cruickshank", 58, 140530.153604701630000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 378, DateTimeKind.Utc).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1954, 7, 23, 2, 14, 44, 709, DateTimeKind.Local).AddTicks(1094), new DateTime(2024, 2, 20, 18, 44, 52, 378, DateTimeKind.Utc).AddTicks(7616), false, "Lucille Johns", 32, 4, 364481.125814638420000m, new DateTime(2024, 2, 20, 18, 44, 52, 378, DateTimeKind.Utc).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 2, 12, 18, 50, 31, 921, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 2, 20, 18, 44, 52, 378, DateTimeKind.Utc).AddTicks(8353), false, "Trevor Kunde", 64, 24571.8005072958760000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 378, DateTimeKind.Utc).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 3, 26, 1, 30, 13, 859, DateTimeKind.Local).AddTicks(8943), new DateTime(2024, 2, 20, 18, 44, 52, 378, DateTimeKind.Utc).AddTicks(9041), false, "Josephine Luettgen", 73, 4, 58293.777935997880000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 378, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 3, 7, 14, 59, 17, 603, DateTimeKind.Local).AddTicks(8006), new DateTime(2024, 2, 20, 18, 44, 52, 378, DateTimeKind.Utc).AddTicks(9623), false, "Gerald Ledner", 38, 1, 388605.586694082670000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 378, DateTimeKind.Utc).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 6, 8, 2, 28, 17, 757, DateTimeKind.Local).AddTicks(4456), new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(227), false, "Jeanette McDermott", 15, 4, 39681.3009776589280000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 9, 6, 4, 27, 16, 721, DateTimeKind.Local).AddTicks(5939), new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(922), false, "Gregory McClure", 69, 4, 359475.102715240060000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 12, 29, 12, 49, 55, 385, DateTimeKind.Local).AddTicks(6282), new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(1548), false, "Amanda Daugherty", 26, 21723.8173387992670000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1981, 12, 22, 16, 53, 53, 244, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(2555), false, "Helen Klein", 68, 3, 214256.005885279660000m, new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 7, 5, 21, 38, 15, 347, DateTimeKind.Local).AddTicks(2196), new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(3358), false, "Marian Hahn", 34, 2, 77875.698622058470000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1995, 4, 22, 13, 59, 23, 790, DateTimeKind.Local).AddTicks(377), new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(4057), false, "Martha Bechtelar", 83, 3, 154008.578932705240000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 10, 29, 5, 57, 9, 451, DateTimeKind.Local).AddTicks(8244), new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(4604), false, "Barbara Schoen", 56, 5, 168720.692207094550000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 9, 24, 16, 14, 20, 485, DateTimeKind.Local).AddTicks(3332), new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(5201), false, "Irving Howell", 94, 5, 118992.057903418690000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 6, 20, 17, 46, 34, 981, DateTimeKind.Local).AddTicks(3767), new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(5856), false, "Casey Treutel", 87, 123908.325750071710000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 10, 27, 6, 13, 22, 294, DateTimeKind.Local).AddTicks(539), new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(6444), false, "Jose Gleason", 69, 359808.38786390770000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 12, 13, 8, 13, 15, 446, DateTimeKind.Local).AddTicks(3103), new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(7132), false, "Tricia Hartmann", 15, 32789.4259427614780000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 10, 21, 10, 55, 32, 537, DateTimeKind.Local).AddTicks(4126), new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(7990), false, "Christian Swift", 84, 3, 175563.174899068960000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 3, 20, 3, 9, 20, 480, DateTimeKind.Local).AddTicks(9828), new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(8598), false, "Blanca Smitham", 79, 1, 61927.149248056810000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 9, 28, 18, 30, 35, 830, DateTimeKind.Local).AddTicks(4478), new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(9199), false, "Willard Wolf", 80, 2, 178430.029546750660000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 1, 14, 23, 5, 56, 355, DateTimeKind.Local).AddTicks(7009), new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(9931), false, "Sonia Davis", 72, 3, 82428.201896755510000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 379, DateTimeKind.Utc).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 9, 26, 18, 48, 10, 532, DateTimeKind.Local).AddTicks(6897), new DateTime(2024, 2, 20, 18, 44, 52, 380, DateTimeKind.Utc).AddTicks(947), false, "Delbert Abbott", 79, 2, 139609.262343208960000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 380, DateTimeKind.Utc).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 11, 27, 4, 58, 57, 50, DateTimeKind.Local).AddTicks(1107), new DateTime(2024, 2, 20, 18, 44, 52, 380, DateTimeKind.Utc).AddTicks(1638), false, "Joyce Donnelly", 84, 4, 183105.506423207020000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 380, DateTimeKind.Utc).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 8, 20, 21, 45, 25, 538, DateTimeKind.Local).AddTicks(6860), new DateTime(2024, 2, 20, 18, 44, 52, 380, DateTimeKind.Utc).AddTicks(2273), false, "Raquel Dickens", 44, 4, 225938.831701489780000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 380, DateTimeKind.Utc).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 6, 15, 11, 5, 51, 698, DateTimeKind.Local).AddTicks(4535), new DateTime(2024, 2, 20, 18, 44, 52, 380, DateTimeKind.Utc).AddTicks(2895), false, "Lora Stoltenberg", 53, 2, 145276.362296843170000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 380, DateTimeKind.Utc).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 9, 29, 20, 25, 39, 685, DateTimeKind.Local).AddTicks(6359), new DateTime(2024, 2, 20, 18, 44, 52, 380, DateTimeKind.Utc).AddTicks(3529), false, "Pam Ruecker", 17, 3, 145968.751935577990000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 380, DateTimeKind.Utc).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 2, 2, 4, 55, 3, 345, DateTimeKind.Local).AddTicks(7026), new DateTime(2024, 2, 20, 18, 44, 52, 380, DateTimeKind.Utc).AddTicks(4501), false, "Alfonso Altenwerth", 46, 2, 326775.658674238270000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 380, DateTimeKind.Utc).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 6, 17, 17, 7, 1, 632, DateTimeKind.Local).AddTicks(1183), new DateTime(2024, 2, 20, 18, 44, 52, 380, DateTimeKind.Utc).AddTicks(5614), false, "Nettie Miller", 34, 4, 121766.537476354150000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 380, DateTimeKind.Utc).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1984, 10, 3, 8, 22, 40, 86, DateTimeKind.Local).AddTicks(3319), new DateTime(2024, 2, 20, 18, 44, 52, 380, DateTimeKind.Utc).AddTicks(6682), false, "Nancy Wintheiser", 51, 1, 308010.169921945390000m, new DateTime(2024, 2, 20, 18, 44, 52, 380, DateTimeKind.Utc).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2003, 6, 4, 18, 14, 46, 173, DateTimeKind.Local).AddTicks(4136), new DateTime(2024, 2, 20, 18, 44, 52, 380, DateTimeKind.Utc).AddTicks(7643), false, "Shirley Hessel", 25, 5, 50181.275038744060000m, new DateTime(2024, 2, 20, 18, 44, 52, 380, DateTimeKind.Utc).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1964, 10, 30, 14, 33, 1, 988, DateTimeKind.Local).AddTicks(5030), new DateTime(2024, 2, 20, 18, 44, 52, 380, DateTimeKind.Utc).AddTicks(9381), false, "Emilio Hackett", 81, 5, 384142.876321114030000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 380, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 5, 5, 12, 21, 28, 494, DateTimeKind.Local).AddTicks(7134), new DateTime(2024, 2, 20, 18, 44, 52, 381, DateTimeKind.Utc).AddTicks(1338), false, "Krystal Thiel", 43, 3, 258164.378863652680000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 381, DateTimeKind.Utc).AddTicks(1338) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1992, 5, 24, 20, 2, 27, 552, DateTimeKind.Local).AddTicks(6735), new DateTime(2024, 2, 20, 18, 44, 52, 381, DateTimeKind.Utc).AddTicks(3470), false, "Dallas Runolfsdottir", 73, 1, 269925.330095352610000m, new DateTime(2024, 2, 20, 18, 44, 52, 381, DateTimeKind.Utc).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 12, 10, 12, 12, 13, 104, DateTimeKind.Local).AddTicks(6991), new DateTime(2024, 2, 20, 18, 44, 52, 381, DateTimeKind.Utc).AddTicks(5241), false, "Sonja Rath", 10, 2, 144348.732266481460000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 381, DateTimeKind.Utc).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 8, 29, 2, 12, 44, 545, DateTimeKind.Local).AddTicks(3205), new DateTime(2024, 2, 20, 18, 44, 52, 382, DateTimeKind.Utc).AddTicks(240), false, "Luther Shanahan", 21, 5, 49388.525617988560000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 382, DateTimeKind.Utc).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 5, 26, 2, 46, 58, 606, DateTimeKind.Local).AddTicks(8577), new DateTime(2024, 2, 20, 18, 44, 52, 382, DateTimeKind.Utc).AddTicks(6536), false, "Brendan Kautzer", 53, 136148.921113297030000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 382, DateTimeKind.Utc).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1971, 7, 26, 18, 56, 25, 488, DateTimeKind.Local).AddTicks(2058), new DateTime(2024, 2, 20, 18, 44, 52, 383, DateTimeKind.Utc).AddTicks(17), false, "Sonja Ankunding", 87, 53040.745297882930000m, new DateTime(2024, 2, 20, 18, 44, 52, 383, DateTimeKind.Utc).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 8, 1, 8, 12, 42, 988, DateTimeKind.Local).AddTicks(914), new DateTime(2024, 2, 20, 18, 44, 52, 383, DateTimeKind.Utc).AddTicks(3749), false, "Peter Lubowitz", 80, 5, 79947.481872306610000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 383, DateTimeKind.Utc).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 6, 3, 8, 13, 30, 243, DateTimeKind.Local).AddTicks(647), new DateTime(2024, 2, 20, 18, 44, 52, 383, DateTimeKind.Utc).AddTicks(4995), false, "Bobby Hansen", 79, 3, 299790.936463741960000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 383, DateTimeKind.Utc).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 7, 17, 4, 46, 34, 488, DateTimeKind.Local).AddTicks(8308), new DateTime(2024, 2, 20, 18, 44, 52, 383, DateTimeKind.Utc).AddTicks(5765), false, "William Grady", 64, 2, 341341.841536418050000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 383, DateTimeKind.Utc).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 1, 26, 23, 20, 20, 258, DateTimeKind.Local).AddTicks(1320), new DateTime(2024, 2, 20, 18, 44, 52, 383, DateTimeKind.Utc).AddTicks(6389), false, "Christina Bins", 49, 5, 232618.856622614920000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 383, DateTimeKind.Utc).AddTicks(6388) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 1, 17, 13, 57, 48, 745, DateTimeKind.Local).AddTicks(4620), new DateTime(2024, 2, 20, 18, 44, 52, 383, DateTimeKind.Utc).AddTicks(7004), false, "Phil Heaney", 51, 197579.100485570170000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 383, DateTimeKind.Utc).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 6, 24, 5, 7, 42, 355, DateTimeKind.Local).AddTicks(1181), new DateTime(2024, 2, 20, 18, 44, 52, 383, DateTimeKind.Utc).AddTicks(7593), false, "Kelly Hane", 47, 190246.265945627440000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 383, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 7, 16, 3, 35, 37, 601, DateTimeKind.Local).AddTicks(5845), new DateTime(2024, 2, 20, 18, 44, 52, 383, DateTimeKind.Utc).AddTicks(8185), false, "Brendan Rosenbaum", 76, 128943.789232236670000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 383, DateTimeKind.Utc).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 5, 28, 6, 52, 38, 267, DateTimeKind.Local).AddTicks(2585), new DateTime(2024, 2, 20, 18, 44, 52, 383, DateTimeKind.Utc).AddTicks(8741), false, "Lorraine Crist", 75, 2, 141995.95974319690000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 383, DateTimeKind.Utc).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 2, 27, 0, 32, 49, 290, DateTimeKind.Local).AddTicks(5991), new DateTime(2024, 2, 20, 18, 44, 52, 384, DateTimeKind.Utc).AddTicks(2193), false, "Delbert Bogisich", 19, 3, 96282.420595467460000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 384, DateTimeKind.Utc).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 11, 11, 21, 20, 10, 526, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 20, 18, 44, 52, 384, DateTimeKind.Utc).AddTicks(6418), false, "Keith Reichert", 8, 89709.989352584890000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 384, DateTimeKind.Utc).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 7, 5, 2, 49, 46, 309, DateTimeKind.Local).AddTicks(5535), new DateTime(2024, 2, 20, 18, 44, 52, 385, DateTimeKind.Utc).AddTicks(911), false, "Rene Heathcote", 17, 5, 268761.654105116110000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 385, DateTimeKind.Utc).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 4, 10, 2, 41, 7, 896, DateTimeKind.Local).AddTicks(2463), new DateTime(2024, 2, 20, 18, 44, 52, 385, DateTimeKind.Utc).AddTicks(3816), false, "Virginia Spencer", 36, 5, 377531.227329225310000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 385, DateTimeKind.Utc).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 9, 13, 20, 27, 38, 751, DateTimeKind.Local).AddTicks(9937), new DateTime(2024, 2, 20, 18, 44, 52, 385, DateTimeKind.Utc).AddTicks(6744), false, "Bryant Tremblay", 3, 5, 173633.706367544530000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 385, DateTimeKind.Utc).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1956, 5, 29, 7, 44, 3, 2, DateTimeKind.Local).AddTicks(9984), new DateTime(2024, 2, 20, 18, 44, 52, 385, DateTimeKind.Utc).AddTicks(9078), false, "Terrence Champlin", 19, 5, 215458.606046627440000m, new DateTime(2024, 2, 20, 18, 44, 52, 385, DateTimeKind.Utc).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 3, 27, 19, 13, 52, 934, DateTimeKind.Local).AddTicks(2107), new DateTime(2024, 2, 20, 18, 44, 52, 385, DateTimeKind.Utc).AddTicks(9899), false, "Alison Langosh", 82, 4, 387111.399673443370000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 385, DateTimeKind.Utc).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 7, 16, 11, 24, 41, 100, DateTimeKind.Local).AddTicks(8984), new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(588), false, "Ramiro Borer", 60, 4, 108628.120008780310000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 12, 4, 4, 58, 53, 216, DateTimeKind.Local).AddTicks(3192), new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(1220), false, "Warren Wiza", 18, 1, 308790.994070677420000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 3, 4, 7, 33, 36, 555, DateTimeKind.Local).AddTicks(2149), new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(1812), false, "Neal Schneider", 15, 2, 381196.802360700940000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 9, 18, 1, 41, 55, 853, DateTimeKind.Local).AddTicks(9543), new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(2384), false, "Ken Halvorson", 47, 4, 395558.59674695740000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1984, 7, 21, 2, 12, 49, 348, DateTimeKind.Local).AddTicks(4855), new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(2985), false, "Brittany Beier", 67, 172497.257139351550000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 11, 29, 23, 38, 18, 343, DateTimeKind.Local).AddTicks(5371), new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(3610), false, "Felicia Mante", 28, 3, 21700.2915784858090000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1995, 6, 10, 7, 44, 15, 928, DateTimeKind.Local).AddTicks(6452), new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(4726), false, "Christina Balistreri", 84, 5, 77676.329095996660000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1960, 9, 2, 7, 43, 45, 154, DateTimeKind.Local).AddTicks(9014), new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(5420), false, "Stephen Lueilwitz", 31, 280776.877314849880000m, new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 3, 1, 21, 26, 4, 30, DateTimeKind.Local).AddTicks(9036), new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(6051), false, "Maryann Steuber", 92, 5, 42227.2179129307810000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1995, 10, 4, 11, 53, 56, 867, DateTimeKind.Local).AddTicks(5391), new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(6669), false, "Alexandra Spencer", 8, 4, 165253.592448880510000m, new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 8, 31, 3, 6, 57, 394, DateTimeKind.Local).AddTicks(1730), new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(7354), false, "Johanna Huels", 43, 2, 120482.18327805880000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 9, 23, 12, 55, 41, 395, DateTimeKind.Local).AddTicks(7503), new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(8037), false, "Antonia O'Hara", 48, 1, 208145.658604523110000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 2, 19, 1, 35, 33, 11, DateTimeKind.Local).AddTicks(6081), new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(8649), false, "Grace Hane", 10, 1, 398392.445121112120000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 8, 11, 9, 1, 42, 339, DateTimeKind.Local).AddTicks(2811), new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(9271), false, "Toni Langworth", 91, 198925.059460121530000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 2, 25, 11, 20, 15, 858, DateTimeKind.Local).AddTicks(9990), new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(9911), false, "Randolph Williamson", 25, 223867.500423383560000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 386, DateTimeKind.Utc).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 1, 4, 0, 5, 29, 645, DateTimeKind.Local).AddTicks(6680), new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(603), false, "Oliver Hoeger", 40, 3, 173992.896959768890000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 5, 6, 7, 55, 10, 611, DateTimeKind.Local).AddTicks(3770), new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(1286), false, "Lauren Rutherford", 89, 5, 119780.297361015580000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 2, 28, 4, 56, 2, 796, DateTimeKind.Local).AddTicks(6444), new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(2402), false, "Melinda Donnelly", 99, 2, 399970.470482079760000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 9, 2, 21, 42, 34, 438, DateTimeKind.Local).AddTicks(2413), new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(3395), false, "Shaun Barton", 100, 208473.849566223010000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 11, 6, 23, 9, 48, 364, DateTimeKind.Local).AddTicks(1682), new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(4091), false, "Kristen Jaskolski", 47, 2, 376897.845915030820000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 7, 7, 10, 12, 16, 601, DateTimeKind.Local).AddTicks(7248), new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(4738), false, "Angel Will", 2, 19743.3764954893510000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 10, 29, 12, 10, 58, 898, DateTimeKind.Local).AddTicks(6996), new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(5383), false, "Henrietta Kuvalis", 16, 1, 282922.860891496660000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 4, 27, 12, 16, 48, 855, DateTimeKind.Local).AddTicks(3981), new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(6015), false, "Jim Mosciski", 59, 3, 179319.969091363480000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 6, 17, 16, 43, 50, 927, DateTimeKind.Local).AddTicks(4065), new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(6685), false, "Roberto Grady", 77, 1, 95784.724886907280000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 3, 22, 19, 13, 26, 419, DateTimeKind.Local).AddTicks(1526), new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(7361), false, "Kerry Stark", 73, 3, 379691.819794962730000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 12, 17, 4, 27, 46, 952, DateTimeKind.Local).AddTicks(8426), new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(8024), false, "Roberta Nitzsche", 7, 4, 122332.958057949070000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 1, 14, 13, 39, 41, 311, DateTimeKind.Local).AddTicks(2957), new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(8991), false, "Sheri Reichel", 18, 3, 306556.396152349060000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 387, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 7, 21, 4, 10, 39, 232, DateTimeKind.Local).AddTicks(117), new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(72), false, "Rosa Rempel", 89, 3, 324376.527388630330000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 2, 7, 18, 30, 56, 530, DateTimeKind.Local).AddTicks(9189), new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(1532), false, "Belinda Roob", 18, 2, 92341.228666760440000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 2, 10, 10, 33, 10, 769, DateTimeKind.Local).AddTicks(6224), new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(2482), false, "Kelly Mann", 84, 30464.6156682852820000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 5, 21, 13, 59, 1, 65, DateTimeKind.Local).AddTicks(1698), new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(3348), false, "Margaret Wehner", 19, 5, 157605.342683734390000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(3348) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 1, 11, 23, 14, 22, 648, DateTimeKind.Local).AddTicks(9013), new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(4120), false, "Leon Konopelski", 86, 5, 34002.228542484790000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 9, 7, 18, 52, 44, 747, DateTimeKind.Local).AddTicks(3880), new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(4845), false, "Cynthia Rosenbaum", 71, 288343.125182440240000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 8, 9, 14, 45, 18, 100, DateTimeKind.Local).AddTicks(3284), new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(5605), false, "Donna Williamson", 77, 10604.95345064333920000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1984, 12, 5, 19, 4, 28, 53, DateTimeKind.Local).AddTicks(262), new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(6348), false, "Dave Hills", 88, 1, 50711.717185895860000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 3, 6, 13, 38, 47, 854, DateTimeKind.Local).AddTicks(653), new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(6971), false, "Randall Wiza", 61, 4, 238368.792413835970000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 8, 16, 8, 49, 48, 603, DateTimeKind.Local).AddTicks(7642), new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(7591), false, "Terry Parker", 59, 5, 164866.899765726070000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 1, 27, 0, 49, 14, 688, DateTimeKind.Local).AddTicks(8393), new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(8503), false, "Roberto Tremblay", 52, 3, 185442.586559766760000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 3, 25, 6, 41, 17, 756, DateTimeKind.Local).AddTicks(3868), new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(9447), false, "Malcolm Collins", 96, 3, 23996.6244919428070000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 388, DateTimeKind.Utc).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 7, 8, 0, 23, 49, 693, DateTimeKind.Local).AddTicks(549), new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(116), false, "Jonathon Steuber", 44, 4, 44469.8634508430020000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1962, 6, 10, 3, 50, 56, 241, DateTimeKind.Local).AddTicks(5947), new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(816), false, "Winston Vandervort", 93, 287174.55691233880000m, new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 10, 12, 9, 57, 25, 922, DateTimeKind.Local).AddTicks(5384), new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(1544), false, "Travis Powlowski", 58, 5, 122257.198503670480000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 4, 13, 10, 13, 56, 692, DateTimeKind.Local).AddTicks(9536), new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(2585), false, "Claudia DuBuque", 80, 3, 186448.420730228920000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 7, 10, 19, 6, 7, 360, DateTimeKind.Local).AddTicks(2402), new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(3465), false, "Rosemarie Toy", 77, 2, 336674.572022669260000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 7, 31, 8, 18, 42, 231, DateTimeKind.Local).AddTicks(4245), new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(4103), false, "Armando Kemmer", 19, 230896.694701432360000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1969, 9, 8, 20, 7, 38, 769, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(4633), false, "Mindy Baumbach", 90, 349415.712308235550000m, new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 1, 20, 5, 42, 25, 171, DateTimeKind.Local).AddTicks(4792), new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(5236), false, "Dewey Cole", 18, 1, 213095.279535006040000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 8, 23, 1, 18, 7, 713, DateTimeKind.Local).AddTicks(7007), new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(5833), false, "Doris Walsh", 68, 3, 279473.146779740410000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 10, 20, 8, 55, 17, 787, DateTimeKind.Local).AddTicks(1782), new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(6660), false, "Eunice Herman", 79, 1, 251565.586848783730000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 8, 31, 12, 12, 42, 543, DateTimeKind.Local).AddTicks(7420), new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(7457), false, "Norma Mitchell", 96, 4, 237824.076494484340000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1995, 5, 10, 6, 20, 30, 990, DateTimeKind.Local).AddTicks(4136), new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(8137), false, "Phil Daugherty", 16, 5, 366604.704672073390000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1986, 2, 14, 12, 50, 57, 710, DateTimeKind.Local).AddTicks(6669), new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(8773), false, "Jo Schultz", 40, 1, 290410.173063171190000m, new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 3, 5, 18, 11, 9, 354, DateTimeKind.Local).AddTicks(2119), new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(9380), false, "Leslie Tremblay", 54, 5, 219349.455158473240000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 389, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 9, 20, 10, 14, 15, 902, DateTimeKind.Local).AddTicks(4315), new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(39), false, "Eloise Nader", 93, 5, 340264.517843338780000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 7, 17, 11, 49, 43, 872, DateTimeKind.Local).AddTicks(5599), new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(652), false, "Bobby Lubowitz", 30, 2, 289541.845337565850000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 2, 19, 18, 1, 32, 637, DateTimeKind.Local).AddTicks(1065), new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(1341), false, "Ramiro Heathcote", 58, 238266.346253129860000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 12, 28, 23, 0, 44, 274, DateTimeKind.Local).AddTicks(3035), new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(2017), false, "Joshua Harvey", 38, 4, 34569.1659046410850000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 3, 15, 16, 58, 8, 173, DateTimeKind.Local).AddTicks(4005), new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(2665), false, "Annette Lang", 51, 1, 331640.639815777360000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1980, 2, 10, 1, 24, 50, 30, DateTimeKind.Local).AddTicks(2949), new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(3237), false, "Samantha Grant", 42, 3, 275220.611348894890000m, new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1982, 11, 28, 7, 41, 56, 724, DateTimeKind.Local).AddTicks(4132), new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(3845), false, "Carrie Kshlerin", 56, 4, 95621.968301456080000m, new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 5, 26, 10, 35, 29, 87, DateTimeKind.Local).AddTicks(6447), new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(4382), false, "Luke Dickinson", 63, 2, 247262.029043485420000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 3, 2, 17, 0, 17, 734, DateTimeKind.Local).AddTicks(9042), new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(5487), false, "Olga Hilpert", 26, 205324.944668306440000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(5487) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1978, 3, 7, 18, 36, 25, 3, DateTimeKind.Local).AddTicks(7110), new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(6169), false, "Marco Lebsack", 38, 2, 109620.488225690380000m, new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1986, 3, 5, 20, 21, 48, 226, DateTimeKind.Local).AddTicks(2548), new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(6806), false, "Dixie O'Keefe", 39, 1, 42057.7852418275270000m, new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2003, 6, 4, 22, 45, 57, 163, DateTimeKind.Local).AddTicks(2145), new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(7461), false, "Lindsay Treutel", 44, 2, 105429.109476413830000m, new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1965, 8, 27, 10, 19, 36, 75, DateTimeKind.Local).AddTicks(3923), new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(8082), false, "Charlene O'Conner", 14, 5, 286730.965536690340000m, new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 3, 3, 15, 13, 34, 288, DateTimeKind.Local).AddTicks(4562), new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(8732), false, "Kristina Schroeder", 45, 3, 229491.618795539740000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 10, 17, 15, 14, 52, 199, DateTimeKind.Local).AddTicks(9688), new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(9329), false, "Danielle Klocko", 3, 370935.116890572640000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1990, 6, 23, 12, 36, 58, 258, DateTimeKind.Local).AddTicks(9754), new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(9953), false, "Drew Grant", 11, 4, 325558.083343428250000m, new DateTime(2024, 2, 20, 18, 44, 52, 390, DateTimeKind.Utc).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 4, 22, 12, 20, 22, 191, DateTimeKind.Local).AddTicks(7443), new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(536), false, "Elijah Doyle", 67, 5, 89398.755119059090000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 1, 14, 20, 16, 37, 75, DateTimeKind.Local).AddTicks(5869), new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(1189), false, "Roland Bernhard", 22, 4, 288080.20158260290000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 3, 20, 0, 46, 53, 74, DateTimeKind.Local).AddTicks(1104), new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(1747), false, "Dawn Mosciski", 31, 4, 228081.897417105280000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 3, 27, 1, 57, 22, 782, DateTimeKind.Local).AddTicks(3730), new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(2343), false, "Christie Block", 46, 4, 360867.621100826050000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1989, 10, 11, 6, 47, 8, 814, DateTimeKind.Local).AddTicks(1640), new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(3419), false, "Andres Bernier", 92, 5, 344068.370959341460000m, new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 11, 20, 7, 43, 34, 885, DateTimeKind.Local).AddTicks(2392), new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(4139), false, "Kathy Beier", 11, 2, 347747.67309023650000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 4, 24, 16, 29, 22, 774, DateTimeKind.Local).AddTicks(7088), new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(4833), false, "Jenna Harvey", 13, 1, 16622.5252743211510000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 1, 6, 15, 41, 45, 353, DateTimeKind.Local).AddTicks(372), new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(5487), false, "Forrest Kirlin", 39, 3, 46913.3558426128210000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(5487) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 5, 11, 1, 54, 11, 288, DateTimeKind.Local).AddTicks(4959), new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(6215), false, "Becky Shanahan", 43, 288694.872879942220000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 2, 2, 17, 17, 19, 6, DateTimeKind.Local).AddTicks(139), new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(6880), false, "Josephine Bradtke", 35, 5, 343160.398759567210000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 2, 27, 6, 25, 1, 316, DateTimeKind.Local).AddTicks(5590), new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(7598), false, "Norma Skiles", 8, 237607.738557677530000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 10, 31, 3, 33, 10, 678, DateTimeKind.Local).AddTicks(129), new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(8305), false, "Alonzo Wuckert", 20, 5, 390651.914746798240000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 2, 20, 15, 11, 17, 306, DateTimeKind.Local).AddTicks(935), new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(8857), false, "Melba D'Amore", 63, 2, 122981.880929632780000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 1, 19, 1, 19, 58, 742, DateTimeKind.Local).AddTicks(297), new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(9524), false, "Felipe Schoen", 2, 1, 291242.350971821590000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 391, DateTimeKind.Utc).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 12, 15, 22, 11, 32, 936, DateTimeKind.Local).AddTicks(2896), new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(70), false, "Marta Hills", 61, 4, 35750.8187507816440000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1968, 11, 28, 1, 59, 27, 208, DateTimeKind.Local).AddTicks(5065), new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(677), false, "Jimmie Bradtke", 21, 2, 55508.695101755860000m, new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 1, 1, 23, 45, 38, 205, DateTimeKind.Local).AddTicks(7005), new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(1621), false, "Luis Anderson", 60, 3, 373324.365903165160000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 10, 8, 5, 49, 51, 49, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(2453), false, "Julia Tromp", 22, 313937.970585713230000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 3, 3, 6, 9, 5, 414, DateTimeKind.Local).AddTicks(1465), new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(3034), false, "Roman Prohaska", 51, 339050.235646730260000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1975, 9, 1, 14, 20, 7, 769, DateTimeKind.Local).AddTicks(5717), new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(3635), false, "Cecilia Bradtke", 64, 1, 87460.473581869690000m, new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 9, 20, 0, 16, 12, 545, DateTimeKind.Local).AddTicks(1079), new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(4276), false, "Ignacio Hammes", 51, 5, 90560.961856273210000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1957, 5, 9, 13, 45, 19, 827, DateTimeKind.Local).AddTicks(3163), new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(4835), false, "Wesley Johnson", 95, 1, 311983.753723792270000m, new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 4, 27, 0, 7, 2, 888, DateTimeKind.Local).AddTicks(6638), new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(5474), false, "Abel Labadie", 55, 126179.072263815730000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 6, 20, 17, 25, 28, 541, DateTimeKind.Local).AddTicks(1665), new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(6094), false, "Kristie Lind", 33, 5, 132666.985169811550000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 3, 2, 10, 22, 42, 881, DateTimeKind.Local).AddTicks(7227), new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(6631), false, "Anita Botsford", 82, 1, 332267.555884250470000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 5, 4, 11, 42, 8, 884, DateTimeKind.Local).AddTicks(3994), new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(7263), false, "Eunice Rosenbaum", 86, 3, 398498.311020291940000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 5, 19, 17, 40, 34, 686, DateTimeKind.Local).AddTicks(4684), new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(7898), false, "Marty Mayer", 60, 3, 334035.719033039260000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 3, 4, 9, 55, 36, 176, DateTimeKind.Local).AddTicks(1276), new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(8448), false, "Wade Kerluke", 13, 1, 168242.840133790750000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 12, 11, 16, 19, 15, 196, DateTimeKind.Local).AddTicks(8690), new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(9154), false, "Sophie Purdy", 53, 1, 149383.277218815760000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 392, DateTimeKind.Utc).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 4, 1, 15, 25, 41, 432, DateTimeKind.Local).AddTicks(7562), new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(303), false, "Sean Swaniawski", 42, 293090.092361642020000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 10, 26, 17, 18, 49, 580, DateTimeKind.Local).AddTicks(19), new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(1079), false, "Carmen Bogisich", 29, 292968.92668013710000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 1, 29, 23, 9, 28, 162, DateTimeKind.Local).AddTicks(5814), new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(1723), false, "Roderick Ankunding", 40, 339597.913624950880000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 9, 6, 16, 41, 43, 757, DateTimeKind.Local).AddTicks(3470), new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(2490), false, "Jan Wilkinson", 56, 4, 168068.930115402280000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 1, 12, 4, 28, 58, 987, DateTimeKind.Local).AddTicks(6894), new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(3190), false, "Alonzo Bartoletti", 41, 88599.577902227590000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 5, 18, 9, 4, 3, 558, DateTimeKind.Local).AddTicks(8142), new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(3874), false, "Delia Langosh", 3, 1, 236231.12654027080000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1960, 9, 26, 2, 11, 39, 900, DateTimeKind.Local).AddTicks(4911), new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(4553), false, "Jay Kuhlman", 67, 181457.095986817420000m, new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(4552) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1979, 4, 16, 13, 38, 43, 224, DateTimeKind.Local).AddTicks(1053), new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(5257), false, "Rolando Schumm", 14, 1, 118262.998862966740000m, new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 4, 2, 7, 17, 22, 912, DateTimeKind.Local).AddTicks(8648), new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(5914), false, "Jennie Langosh", 3, 147019.698633942670000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 3, 21, 3, 40, 8, 722, DateTimeKind.Local).AddTicks(5991), new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(6463), false, "Pearl Waters", 70, 2, 99678.725779695910000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 8, 14, 13, 30, 59, 822, DateTimeKind.Local).AddTicks(5307), new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(7089), false, "Lance Hammes", 88, 5, 381135.154386151090000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1965, 2, 26, 15, 54, 41, 233, DateTimeKind.Local).AddTicks(7490), new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(7739), false, "Shannon Spencer", 69, 4, 244196.159443722580000m, new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 12, 3, 23, 33, 52, 257, DateTimeKind.Local).AddTicks(4290), new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(8781), false, "Erin McDermott", 74, 5, 339404.637963437140000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 1, 31, 15, 15, 0, 877, DateTimeKind.Local).AddTicks(8186), new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(9437), false, "Stewart Friesen", 41, 4, 275343.070473127270000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 393, DateTimeKind.Utc).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1980, 5, 8, 11, 55, 57, 268, DateTimeKind.Local).AddTicks(1099), new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(99), false, "Benjamin Rempel", 48, 1, 310730.073177040390000m, new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 4, 1, 0, 15, 42, 647, DateTimeKind.Local).AddTicks(3589), new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(799), false, "Thomas Ziemann", 79, 3, 221976.807263520130000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(799) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 12, 5, 9, 44, 34, 963, DateTimeKind.Local).AddTicks(7436), new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(1420), false, "Rebecca Conn", 48, 4, 100918.411398442810000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(1419) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 12, 31, 20, 52, 27, 445, DateTimeKind.Local).AddTicks(8692), new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(1962), false, "Christie Friesen", 61, 3, 322244.162859111340000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1979, 1, 3, 3, 59, 28, 205, DateTimeKind.Local).AddTicks(7384), new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(2653), false, "Cathy Kuphal", 1, 387400.23543484990000m, new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 7, 18, 5, 5, 3, 555, DateTimeKind.Local).AddTicks(3505), new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(3311), false, "Luis Wiegand", 16, 371571.307192755010000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 9, 2, 6, 51, 40, 1, DateTimeKind.Local).AddTicks(3743), new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(3887), false, "Dominick Harber", 20, 87449.306938297060000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 10, 28, 1, 6, 28, 630, DateTimeKind.Local).AddTicks(8899), new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(4521), false, "Francis Hoppe", 71, 1, 187892.271798273760000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 8, 8, 9, 13, 59, 844, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(5094), false, "Anna Auer", 69, 3, 366067.3269726430000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 2, 27, 17, 49, 57, 667, DateTimeKind.Local).AddTicks(7837), new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(5740), false, "Wesley Moen", 89, 4, 315138.679727730160000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1975, 11, 25, 15, 28, 16, 527, DateTimeKind.Local).AddTicks(515), new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(6849), false, "Sam Ruecker", 17, 2, 319610.847451997260000m, new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 2, 12, 11, 53, 1, 98, DateTimeKind.Local).AddTicks(7170), new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(7625), false, "Lisa Wiza", 26, 4, 295343.969441392030000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 4, 27, 3, 21, 31, 997, DateTimeKind.Local).AddTicks(5579), new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(8305), false, "Wendell Jenkins", 10, 3, 399632.680878891970000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1997, 11, 27, 14, 47, 6, 988, DateTimeKind.Local).AddTicks(309), new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(9060), false, "Marilyn Heidenreich", 64, 3, 155502.399777581860000m, new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 3, 10, 23, 9, 55, 532, DateTimeKind.Local).AddTicks(1753), new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(9775), false, "Jennie Stracke", 62, 5, 127709.599929899770000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 394, DateTimeKind.Utc).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 1, 31, 7, 7, 47, 344, DateTimeKind.Local).AddTicks(9757), new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(355), false, "Kristie Borer", 56, 5, 307260.954074854120000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 11, 15, 4, 38, 8, 770, DateTimeKind.Local).AddTicks(317), new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(1039), false, "Erma Kuhn", 45, 258181.502854159030000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 7, 31, 23, 53, 7, 341, DateTimeKind.Local).AddTicks(5670), new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(1676), false, "Blanca Durgan", 18, 3, 62445.519130537390000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 8, 12, 20, 58, 39, 736, DateTimeKind.Local).AddTicks(7683), new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(2279), false, "Wallace Stanton", 56, 2, 399266.688880851340000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 7, 28, 0, 12, 46, 109, DateTimeKind.Local).AddTicks(8661), new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(2855), false, "Tracy Ruecker", 56, 285343.163931613960000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 6, 30, 23, 22, 46, 842, DateTimeKind.Local).AddTicks(2051), new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(3462), false, "Olivia Farrell", 43, 46332.8963431887310000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 6, 11, 11, 13, 46, 420, DateTimeKind.Local).AddTicks(9825), new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(4124), false, "Douglas Bergstrom", 16, 90254.943374095750000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 11, 7, 5, 45, 54, 979, DateTimeKind.Local).AddTicks(1867), new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(5157), false, "Alyssa Homenick", 66, 3, 297954.856991289670000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 1, 22, 19, 58, 39, 344, DateTimeKind.Local).AddTicks(8916), new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(5852), false, "Shannon Gutmann", 87, 3, 366603.109632800680000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 12, 18, 21, 3, 29, 440, DateTimeKind.Local).AddTicks(836), new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(6471), false, "Jeremiah Crist", 41, 4, 189990.435858552280000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 3, 28, 10, 33, 19, 966, DateTimeKind.Local).AddTicks(2514), new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(7133), false, "Santos Towne", 14, 17541.9499058693530000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 2, 18, 8, 10, 44, 628, DateTimeKind.Local).AddTicks(1414), new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(7759), false, "Amy Kshlerin", 11, 2, 11127.25025007378940000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 9, 12, 23, 56, 32, 155, DateTimeKind.Local).AddTicks(8116), new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(8321), false, "Neil Quitzon", 63, 5, 391309.586301139990000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 11, 23, 6, 10, 5, 909, DateTimeKind.Local).AddTicks(7937), new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(8921), false, "Penny White", 2, 364823.733905340310000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1997, 3, 9, 8, 37, 37, 149, DateTimeKind.Local).AddTicks(8502), new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(9611), false, "Clifton Smitham", 73, 45326.4491795041060000m, new DateTime(2024, 2, 20, 18, 44, 52, 395, DateTimeKind.Utc).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 4, 19, 13, 10, 25, 56, DateTimeKind.Local).AddTicks(4615), new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(284), false, "Glenda Botsford", 76, 4, 268054.899432157750000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1957, 5, 26, 22, 7, 56, 402, DateTimeKind.Local).AddTicks(3875), new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(891), false, "Kelly Emmerich", 39, 5, 381944.615037954790000m, new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 6, 9, 5, 30, 41, 877, DateTimeKind.Local).AddTicks(442), new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(1561), false, "Cora Stanton", 7, 5, 379072.888604681950000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 6, 13, 7, 51, 10, 526, DateTimeKind.Local).AddTicks(2508), new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(2188), false, "Karl Ortiz", 46, 2, 307560.16009431790000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 5, 19, 23, 58, 26, 584, DateTimeKind.Local).AddTicks(535), new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(3096), false, "Austin Mraz", 65, 2, 12844.60228210509130000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 1, 5, 20, 23, 40, 802, DateTimeKind.Local).AddTicks(4653), new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(4055), false, "Luis Hahn", 66, 93346.743374179480000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 8, 13, 6, 39, 19, 257, DateTimeKind.Local).AddTicks(9808), new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(4704), false, "Ada Schmitt", 67, 4, 25097.5492732456990000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 9, 28, 8, 27, 3, 113, DateTimeKind.Local).AddTicks(9299), new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(5367), false, "Tom Weber", 100, 5, 133655.834129193340000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 10, 29, 12, 13, 8, 488, DateTimeKind.Local).AddTicks(7678), new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(5980), false, "Todd Kuhn", 95, 4, 399722.108084437180000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1987, 5, 11, 10, 6, 3, 437, DateTimeKind.Local).AddTicks(1715), new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(6630), false, "Edna Mraz", 45, 2, 98746.896823526110000m, new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 7, 28, 16, 53, 42, 241, DateTimeKind.Local).AddTicks(8053), new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(7251), false, "Tricia Torphy", 45, 3, 248070.372186258430000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 3, 5, 0, 9, 53, 402, DateTimeKind.Local).AddTicks(2875), new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(7868), false, "Marco Gleichner", 61, 4, 68987.074951942930000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1986, 3, 14, 16, 57, 54, 95, DateTimeKind.Local).AddTicks(9676), new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(8555), false, "Noel Predovic", 61, 4, 93664.836215941630000m, new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1996, 9, 26, 16, 50, 34, 324, DateTimeKind.Local).AddTicks(4087), new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(9098), false, "Tami Hessel", 87, 2, 141667.030994000710000m, new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 8, 12, 3, 24, 9, 373, DateTimeKind.Local).AddTicks(5662), new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(9759), false, "Jacqueline McClure", 18, 5, 164320.75031712820000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 396, DateTimeKind.Utc).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 6, 29, 3, 46, 58, 642, DateTimeKind.Local).AddTicks(5148), new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(447), false, "Ellen Bauch", 45, 5, 78660.074110210570000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 8, 15, 2, 2, 11, 961, DateTimeKind.Local).AddTicks(9231), new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(1014), false, "Nathaniel Walsh", 17, 163327.108191669880000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 1, 1, 21, 30, 38, 804, DateTimeKind.Local).AddTicks(3132), new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(2050), false, "Kristie Wolff", 62, 2, 305022.335822882590000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 11, 30, 6, 11, 2, 639, DateTimeKind.Local).AddTicks(6456), new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(2879), false, "Debra Bartell", 4, 1, 240323.066020600540000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1993, 8, 6, 23, 42, 6, 564, DateTimeKind.Local).AddTicks(5683), new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(3455), false, "Terri Hansen", 98, 1, 367415.131527064390000m, new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1968, 1, 3, 1, 42, 38, 122, DateTimeKind.Local).AddTicks(4569), new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(4094), false, "Pearl Kuhlman", 38, 5, 143226.474054675820000m, new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 2, 8, 10, 55, 5, 248, DateTimeKind.Local).AddTicks(5835), new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(4693), false, "Tasha Reynolds", 23, 4, 243708.068568181870000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 2, 19, 18, 24, 30, 643, DateTimeKind.Local).AddTicks(4901), new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(5257), false, "Francisco Streich", 26, 1, 19059.4197033526810000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 1, 8, 6, 55, 52, 882, DateTimeKind.Local).AddTicks(6664), new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(5905), false, "Gustavo Kuhic", 29, 5, 381774.763719059740000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1995, 7, 21, 1, 43, 17, 220, DateTimeKind.Local).AddTicks(4745), new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(6505), false, "Guy Dickens", 43, 5, 239572.590879351850000m, new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1975, 10, 10, 10, 49, 40, 293, DateTimeKind.Local).AddTicks(4417), new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(7152), false, "Harriet Gaylord", 51, 4, 336216.581614813240000m, new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 12, 17, 19, 25, 46, 645, DateTimeKind.Local).AddTicks(5344), new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(7957), false, "Allan Koss", 27, 5, 111825.180076156420000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 4, 22, 6, 18, 27, 872, DateTimeKind.Local).AddTicks(9155), new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(8678), false, "Tracy Abbott", 94, 5, 81959.103559265650000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1975, 4, 27, 1, 27, 21, 42, DateTimeKind.Local).AddTicks(3788), new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(9348), false, "Milton Windler", 22, 324924.3334261180000m, new DateTime(2024, 2, 20, 18, 44, 52, 397, DateTimeKind.Utc).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 9, 18, 10, 23, 48, 111, DateTimeKind.Local).AddTicks(3512), new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(385), false, "Christine Kub", 9, 2, 392366.859960689890000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 9, 21, 20, 23, 43, 388, DateTimeKind.Local).AddTicks(3442), new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(1276), false, "Juana Metz", 94, 4, 369458.706225117460000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 9, 30, 15, 57, 20, 567, DateTimeKind.Local).AddTicks(1578), new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(1915), false, "Glenda O'Conner", 97, 335404.590633813340000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 6, 28, 4, 50, 27, 796, DateTimeKind.Local).AddTicks(7465), new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(2746), false, "Mercedes Cruickshank", 31, 149057.350010877220000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2001, 5, 8, 15, 40, 18, 162, DateTimeKind.Local).AddTicks(9630), new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(3503), false, "Al Morar", 9, 5, 267526.676299666930000m, new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 1, 25, 5, 23, 9, 551, DateTimeKind.Local).AddTicks(6270), new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(4124), false, "Vernon Mohr", 47, 4, 381415.337301236410000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 9, 7, 12, 29, 52, 656, DateTimeKind.Local).AddTicks(2246), new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(4818), false, "Hazel Lockman", 87, 5, 169756.398030379540000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 4, 19, 1, 7, 35, 569, DateTimeKind.Local).AddTicks(1855), new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(5417), false, "Sue Hammes", 27, 3, 396309.490306933180000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 10, 10, 5, 10, 54, 503, DateTimeKind.Local).AddTicks(8595), new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(6100), false, "Eddie Moore", 68, 2, 200245.98706715680000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1975, 7, 3, 18, 49, 56, 317, DateTimeKind.Local).AddTicks(449), new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(7030), false, "Tracey Morissette", 5, 5, 299507.511871203730000m, new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1967, 8, 8, 9, 56, 28, 853, DateTimeKind.Local).AddTicks(9878), new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(7889), false, "Lori Funk", 64, 1, 110432.438774431660000m, new DateTime(2024, 2, 20, 18, 44, 52, 398, DateTimeKind.Utc).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 1, 7, 22, 40, 43, 109, DateTimeKind.Local).AddTicks(5189), new DateTime(2024, 2, 20, 18, 44, 52, 399, DateTimeKind.Utc).AddTicks(1358), false, "Terrence Anderson", 25, 1, 70004.83759489570000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 399, DateTimeKind.Utc).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1997, 2, 26, 13, 19, 16, 471, DateTimeKind.Local).AddTicks(7625), new DateTime(2024, 2, 20, 18, 44, 52, 399, DateTimeKind.Utc).AddTicks(5332), false, "Spencer Bauch", 65, 5, 84266.700809897440000m, new DateTime(2024, 2, 20, 18, 44, 52, 399, DateTimeKind.Utc).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 11, 19, 21, 41, 13, 759, DateTimeKind.Local).AddTicks(9901), new DateTime(2024, 2, 20, 18, 44, 52, 399, DateTimeKind.Utc).AddTicks(8425), false, "Jeanette Erdman", 85, 4, 318976.548379222360000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 399, DateTimeKind.Utc).AddTicks(8424) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 3, 31, 2, 27, 2, 358, DateTimeKind.Local).AddTicks(4045), new DateTime(2024, 2, 20, 18, 44, 52, 400, DateTimeKind.Utc).AddTicks(1524), false, "Kristy Romaguera", 5, 3, 217347.58749865420000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 400, DateTimeKind.Utc).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 2, 3, 8, 56, 24, 276, DateTimeKind.Local).AddTicks(5625), new DateTime(2024, 2, 20, 18, 44, 52, 400, DateTimeKind.Utc).AddTicks(4431), false, "Josefina Kassulke", 83, 5, 20313.9837513325210000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 400, DateTimeKind.Utc).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1964, 4, 27, 6, 2, 22, 329, DateTimeKind.Local).AddTicks(9521), new DateTime(2024, 2, 20, 18, 44, 52, 400, DateTimeKind.Utc).AddTicks(7589), false, "Carrie Yost", 44, 2, 308257.243414239460000m, new DateTime(2024, 2, 20, 18, 44, 52, 400, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 8, 8, 7, 52, 44, 154, DateTimeKind.Local).AddTicks(709), new DateTime(2024, 2, 20, 18, 44, 52, 401, DateTimeKind.Utc).AddTicks(738), false, "Louise Kuvalis", 96, 1, 180549.475287288760000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 401, DateTimeKind.Utc).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 12, 12, 3, 30, 34, 766, DateTimeKind.Local).AddTicks(2771), new DateTime(2024, 2, 20, 18, 44, 52, 401, DateTimeKind.Utc).AddTicks(3800), false, "Kelly Barton", 88, 1, 329014.493660851690000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 401, DateTimeKind.Utc).AddTicks(3799) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1990, 10, 20, 12, 25, 52, 62, DateTimeKind.Local).AddTicks(9964), new DateTime(2024, 2, 20, 18, 44, 52, 401, DateTimeKind.Utc).AddTicks(7026), false, "Teri Runte", 80, 312046.411555853380000m, new DateTime(2024, 2, 20, 18, 44, 52, 401, DateTimeKind.Utc).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 9, 14, 14, 10, 47, 937, DateTimeKind.Local).AddTicks(8527), new DateTime(2024, 2, 20, 18, 44, 52, 402, DateTimeKind.Utc).AddTicks(338), false, "Theodore Donnelly", 58, 1, 124622.32069597660000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 402, DateTimeKind.Utc).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 3, 1, 3, 50, 34, 520, DateTimeKind.Local).AddTicks(3810), new DateTime(2024, 2, 20, 18, 44, 52, 402, DateTimeKind.Utc).AddTicks(4015), false, "Megan Balistreri", 3, 2, 210944.396361819760000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 402, DateTimeKind.Utc).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 3, 20, 5, 37, 32, 37, DateTimeKind.Local).AddTicks(8612), new DateTime(2024, 2, 20, 18, 44, 52, 403, DateTimeKind.Utc).AddTicks(151), false, "Patrick Carter", 94, 4, 236108.171878827940000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 403, DateTimeKind.Utc).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 6, 2, 5, 21, 56, 817, DateTimeKind.Local).AddTicks(3405), new DateTime(2024, 2, 20, 18, 44, 52, 404, DateTimeKind.Utc).AddTicks(1926), false, "Julie Huel", 38, 85638.148226532580000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 404, DateTimeKind.Utc).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 5, 26, 21, 8, 4, 422, DateTimeKind.Local).AddTicks(362), new DateTime(2024, 2, 20, 18, 44, 52, 404, DateTimeKind.Utc).AddTicks(3797), false, "Orville Luettgen", 92, 2, 41762.0624599574920000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 404, DateTimeKind.Utc).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1966, 6, 12, 0, 29, 55, 394, DateTimeKind.Local).AddTicks(6350), new DateTime(2024, 2, 20, 18, 44, 52, 404, DateTimeKind.Utc).AddTicks(4560), false, "Brittany Zemlak", 32, 281337.008856640480000m, new DateTime(2024, 2, 20, 18, 44, 52, 404, DateTimeKind.Utc).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 3, 16, 9, 24, 16, 110, DateTimeKind.Local).AddTicks(821), new DateTime(2024, 2, 20, 18, 44, 52, 404, DateTimeKind.Utc).AddTicks(5472), false, "Casey Waters", 73, 2, 234119.484785156740000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 404, DateTimeKind.Utc).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 5, 10, 17, 0, 17, 702, DateTimeKind.Local).AddTicks(6111), new DateTime(2024, 2, 20, 18, 44, 52, 404, DateTimeKind.Utc).AddTicks(6214), false, "Lucy Prosacco", 3, 2, 337367.137294868320000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 404, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 8, 9, 20, 47, 50, 811, DateTimeKind.Local).AddTicks(5459), new DateTime(2024, 2, 20, 18, 44, 52, 404, DateTimeKind.Utc).AddTicks(7645), false, "Kim Corkery", 23, 3, 277671.785464455190000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 404, DateTimeKind.Utc).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 11, 12, 11, 38, 2, 97, DateTimeKind.Local).AddTicks(9768), new DateTime(2024, 2, 20, 18, 44, 52, 404, DateTimeKind.Utc).AddTicks(8611), false, "Rudy Gislason", 56, 4, 67881.529600138660000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 404, DateTimeKind.Utc).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 11, 19, 22, 42, 25, 212, DateTimeKind.Local).AddTicks(8294), new DateTime(2024, 2, 20, 18, 44, 52, 404, DateTimeKind.Utc).AddTicks(9539), false, "Troy Auer", 31, 3, 258071.653048649170000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 404, DateTimeKind.Utc).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1958, 5, 4, 9, 20, 10, 87, DateTimeKind.Local).AddTicks(5152), new DateTime(2024, 2, 20, 18, 44, 52, 405, DateTimeKind.Utc).AddTicks(480), false, "Lester Schuppe", 66, 1, 53973.376092670960000m, new DateTime(2024, 2, 20, 18, 44, 52, 405, DateTimeKind.Utc).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1966, 10, 8, 16, 17, 5, 96, DateTimeKind.Local).AddTicks(8598), new DateTime(2024, 2, 20, 18, 44, 52, 405, DateTimeKind.Utc).AddTicks(1902), false, "Debra Corwin", 14, 4, 88150.618454040730000m, new DateTime(2024, 2, 20, 18, 44, 52, 405, DateTimeKind.Utc).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1967, 10, 21, 0, 36, 55, 802, DateTimeKind.Local).AddTicks(9909), new DateTime(2024, 2, 20, 18, 44, 52, 405, DateTimeKind.Utc).AddTicks(3132), false, "Wendy Macejkovic", 21, 289668.520099651540000m, new DateTime(2024, 2, 20, 18, 44, 52, 405, DateTimeKind.Utc).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1987, 8, 11, 22, 40, 22, 469, DateTimeKind.Local).AddTicks(924), new DateTime(2024, 2, 20, 18, 44, 52, 405, DateTimeKind.Utc).AddTicks(4405), false, "Michael Gleichner", 65, 5, 59031.680477128180000m, new DateTime(2024, 2, 20, 18, 44, 52, 405, DateTimeKind.Utc).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1964, 5, 21, 15, 15, 12, 817, DateTimeKind.Local).AddTicks(4970), new DateTime(2024, 2, 20, 18, 44, 52, 405, DateTimeKind.Utc).AddTicks(5892), false, "Kelley Stokes", 45, 5, 368474.826008212030000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 405, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 8, 16, 7, 32, 14, 956, DateTimeKind.Local).AddTicks(917), new DateTime(2024, 2, 20, 18, 44, 52, 405, DateTimeKind.Utc).AddTicks(6715), false, "Shelia Hilll", 17, 111454.507489590970000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 405, DateTimeKind.Utc).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 10, 28, 11, 8, 10, 452, DateTimeKind.Local).AddTicks(1220), new DateTime(2024, 2, 20, 18, 44, 52, 405, DateTimeKind.Utc).AddTicks(7448), false, "Sheryl Stamm", 14, 2, 147837.941082378160000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 405, DateTimeKind.Utc).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 5, 10, 15, 57, 9, 567, DateTimeKind.Local).AddTicks(5176), new DateTime(2024, 2, 20, 18, 44, 52, 405, DateTimeKind.Utc).AddTicks(8138), false, "Kurt Olson", 34, 73114.665566989270000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 405, DateTimeKind.Utc).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 7, 1, 12, 59, 55, 954, DateTimeKind.Local).AddTicks(2407), new DateTime(2024, 2, 20, 18, 44, 52, 405, DateTimeKind.Utc).AddTicks(8879), false, "Bernard Turner", 29, 4, 159176.944712420560000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 405, DateTimeKind.Utc).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1958, 3, 30, 22, 47, 15, 201, DateTimeKind.Local).AddTicks(2503), new DateTime(2024, 2, 20, 18, 44, 52, 405, DateTimeKind.Utc).AddTicks(9609), false, "Cora Tromp", 54, 3, 207766.642723053820000m, new DateTime(2024, 2, 20, 18, 44, 52, 405, DateTimeKind.Utc).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 1, 3, 10, 0, 10, 370, DateTimeKind.Local).AddTicks(5305), new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(380), false, "Laverne Windler", 90, 5, 294765.424965205990000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1972, 8, 27, 22, 55, 36, 860, DateTimeKind.Local).AddTicks(2642), new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(1045), false, "Susan Beer", 55, 4, 250610.731171863520000m, new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 12, 6, 9, 47, 44, 591, DateTimeKind.Local).AddTicks(5866), new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(1723), false, "Audrey Davis", 90, 5, 322481.766115157470000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 12, 9, 3, 39, 0, 52, DateTimeKind.Local).AddTicks(8151), new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(2621), false, "Bob Larson", 37, 3, 15140.5144036676950000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 8, 4, 0, 50, 59, 62, DateTimeKind.Local).AddTicks(840), new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(3732), false, "Amanda Batz", 5, 104672.931567265870000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(3731) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1993, 5, 6, 19, 22, 52, 809, DateTimeKind.Local).AddTicks(3699), new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(5273), false, "Wilbert Ondricka", 39, 376284.767419916020000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 11, 20, 20, 11, 28, 364, DateTimeKind.Local).AddTicks(6625), new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(6077), false, "Yvette Monahan", 75, 2, 49150.008421077970000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 9, 23, 9, 22, 5, 375, DateTimeKind.Local).AddTicks(836), new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(6818), false, "Marty Ryan", 16, 5, 54977.558796354730000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1970, 2, 15, 13, 17, 36, 569, DateTimeKind.Local).AddTicks(1114), new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(7447), false, "Victor Kerluke", 49, 11404.58382974605540000m, new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 4, 25, 8, 29, 36, 475, DateTimeKind.Local).AddTicks(4802), new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(8181), false, "Darrin O'Kon", 79, 4, 246829.961478310330000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1995, 5, 7, 18, 39, 23, 136, DateTimeKind.Local).AddTicks(3302), new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(8852), false, "Pat Buckridge", 54, 161166.000854074180000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 6, 19, 11, 4, 1, 35, DateTimeKind.Local).AddTicks(9025), new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(9564), false, "Natalie O'Reilly", 84, 5, 152216.988392629930000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 406, DateTimeKind.Utc).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 12, 29, 20, 57, 34, 746, DateTimeKind.Local).AddTicks(9618), new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(241), false, "Tamara Beier", 79, 4, 185553.458367550510000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 7, 19, 23, 26, 7, 241, DateTimeKind.Local).AddTicks(8481), new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(802), false, "Owen Nolan", 61, 116739.859388903650000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1993, 7, 11, 20, 55, 29, 506, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(1518), false, "Rickey Nicolas", 28, 190698.310330005520000m, new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2004, 1, 19, 7, 39, 24, 183, DateTimeKind.Local).AddTicks(541), new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(2853), false, "Christopher Schroeder", 57, 3, 205857.446033639650000m, new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1974, 2, 28, 19, 1, 2, 367, DateTimeKind.Local).AddTicks(4481), new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(3979), false, "Jacob Stroman", 20, 3, 248855.051297629780000m, new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 11, 4, 1, 35, 36, 905, DateTimeKind.Local).AddTicks(8910), new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(4639), false, "Erik Pfannerstill", 90, 4, 290688.03843210910000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1964, 1, 24, 8, 34, 17, 309, DateTimeKind.Local).AddTicks(3239), new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(5350), false, "Ray Quigley", 85, 1, 337471.88108863540000m, new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1959, 12, 29, 2, 2, 46, 747, DateTimeKind.Local).AddTicks(1579), new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(5970), false, "Christopher Dickens", 68, 5, 318775.282289107270000m, new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1989, 8, 20, 3, 40, 57, 399, DateTimeKind.Local).AddTicks(2387), new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(6687), false, "Eunice Schowalter", 77, 2, 156100.721417508520000m, new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 10, 14, 23, 51, 17, 178, DateTimeKind.Local).AddTicks(3053), new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(7484), false, "Marcia Stokes", 83, 122309.764439097550000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 9, 16, 7, 7, 36, 281, DateTimeKind.Local).AddTicks(8704), new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(8146), false, "Wade Marvin", 64, 1, 20269.1029283413480000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 12, 11, 0, 57, 1, 751, DateTimeKind.Local).AddTicks(4096), new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(8982), false, "Kristine Jast", 57, 4, 177251.382662312260000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 9, 3, 10, 45, 58, 828, DateTimeKind.Local).AddTicks(9919), new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(9824), false, "Evelyn Schaefer", 39, 180976.960819055950000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 407, DateTimeKind.Utc).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 3, 30, 15, 33, 57, 627, DateTimeKind.Local).AddTicks(247), new DateTime(2024, 2, 20, 18, 44, 52, 408, DateTimeKind.Utc).AddTicks(1694), false, "Annie O'Kon", 4, 1, 364845.068512297090000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 408, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 5, 19, 1, 8, 4, 196, DateTimeKind.Local).AddTicks(466), new DateTime(2024, 2, 20, 18, 44, 52, 408, DateTimeKind.Utc).AddTicks(3525), false, "Doug Ward", 51, 5, 280895.22579424630000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 408, DateTimeKind.Utc).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1965, 9, 10, 16, 20, 40, 966, DateTimeKind.Local).AddTicks(1712), new DateTime(2024, 2, 20, 18, 44, 52, 408, DateTimeKind.Utc).AddTicks(4454), false, "Dean Parker", 42, 3, 106004.672986107730000m, new DateTime(2024, 2, 20, 18, 44, 52, 408, DateTimeKind.Utc).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 3, 20, 14, 31, 19, 817, DateTimeKind.Local).AddTicks(1179), new DateTime(2024, 2, 20, 18, 44, 52, 408, DateTimeKind.Utc).AddTicks(5236), false, "Harriet Waters", 18, 183399.7797895480000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 408, DateTimeKind.Utc).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 10, 31, 17, 48, 38, 606, DateTimeKind.Local).AddTicks(8109), new DateTime(2024, 2, 20, 18, 44, 52, 408, DateTimeKind.Utc).AddTicks(6230), false, "Ruby Nader", 14, 4, 389438.691653465860000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 408, DateTimeKind.Utc).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 10, 5, 15, 25, 29, 131, DateTimeKind.Local).AddTicks(8803), new DateTime(2024, 2, 20, 18, 44, 52, 408, DateTimeKind.Utc).AddTicks(7070), false, "Joan Crooks", 72, 5, 395618.222963161240000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 408, DateTimeKind.Utc).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 2, 1, 19, 44, 12, 560, DateTimeKind.Local).AddTicks(1404), new DateTime(2024, 2, 20, 18, 44, 52, 408, DateTimeKind.Utc).AddTicks(8013), false, "Tonya Kassulke", 15, 1, 226011.210229318660000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 408, DateTimeKind.Utc).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 6, 12, 23, 0, 38, 368, DateTimeKind.Local).AddTicks(8832), new DateTime(2024, 2, 20, 18, 44, 52, 408, DateTimeKind.Utc).AddTicks(8919), false, "Eileen Lesch", 4, 5, 176201.09542587850000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 408, DateTimeKind.Utc).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 11, 14, 8, 46, 51, 667, DateTimeKind.Local).AddTicks(5842), new DateTime(2024, 2, 20, 18, 44, 52, 409, DateTimeKind.Utc).AddTicks(97), false, "Arlene Leuschke", 7, 2, 373296.370773613810000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 409, DateTimeKind.Utc).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 3, 7, 22, 21, 21, 127, DateTimeKind.Local).AddTicks(2920), new DateTime(2024, 2, 20, 18, 44, 52, 409, DateTimeKind.Utc).AddTicks(1385), false, "Damon Fay", 81, 2, 191980.668444768310000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 409, DateTimeKind.Utc).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 5, 31, 2, 9, 27, 132, DateTimeKind.Local).AddTicks(5047), new DateTime(2024, 2, 20, 18, 44, 52, 409, DateTimeKind.Utc).AddTicks(2158), false, "Carla Reinger", 89, 3, 373826.183822715250000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 409, DateTimeKind.Utc).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 1, 31, 0, 48, 23, 232, DateTimeKind.Local).AddTicks(2561), new DateTime(2024, 2, 20, 18, 44, 52, 409, DateTimeKind.Utc).AddTicks(3034), false, "Raymond Hodkiewicz", 68, 4, 92700.483014181760000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 409, DateTimeKind.Utc).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2003, 6, 11, 7, 34, 12, 321, DateTimeKind.Local).AddTicks(6620), new DateTime(2024, 2, 20, 18, 44, 52, 409, DateTimeKind.Utc).AddTicks(4163), false, "Bonnie Hayes", 51, 155806.294583458210000m, new DateTime(2024, 2, 20, 18, 44, 52, 409, DateTimeKind.Utc).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 7, 30, 13, 51, 13, 839, DateTimeKind.Local).AddTicks(9068), new DateTime(2024, 2, 20, 18, 44, 52, 409, DateTimeKind.Utc).AddTicks(5215), false, "Allison Thiel", 89, 4, 397093.301876754850000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 409, DateTimeKind.Utc).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 4, 5, 10, 32, 43, 165, DateTimeKind.Local).AddTicks(6601), new DateTime(2024, 2, 20, 18, 44, 52, 409, DateTimeKind.Utc).AddTicks(6179), false, "Helen Johnson", 14, 144342.652363167040000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 409, DateTimeKind.Utc).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 3, 16, 12, 43, 14, 160, DateTimeKind.Local).AddTicks(8095), new DateTime(2024, 2, 20, 18, 44, 52, 409, DateTimeKind.Utc).AddTicks(7285), false, "Kristy Cole", 1, 3, 328169.166274592230000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 409, DateTimeKind.Utc).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1960, 1, 29, 21, 10, 3, 827, DateTimeKind.Local).AddTicks(6040), new DateTime(2024, 2, 20, 18, 44, 52, 409, DateTimeKind.Utc).AddTicks(8831), false, "Tara Reynolds", 76, 5, 351691.350471051490000m, new DateTime(2024, 2, 20, 18, 44, 52, 409, DateTimeKind.Utc).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1981, 5, 19, 8, 56, 32, 720, DateTimeKind.Local).AddTicks(7780), new DateTime(2024, 2, 20, 18, 44, 52, 409, DateTimeKind.Utc).AddTicks(9844), false, "Stella Mohr", 4, 4, 244669.123519772110000m, new DateTime(2024, 2, 20, 18, 44, 52, 409, DateTimeKind.Utc).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2003, 6, 7, 3, 2, 55, 519, DateTimeKind.Local).AddTicks(56), new DateTime(2024, 2, 20, 18, 44, 52, 410, DateTimeKind.Utc).AddTicks(734), false, "Brooke Collier", 46, 4, 140180.227300517290000m, new DateTime(2024, 2, 20, 18, 44, 52, 410, DateTimeKind.Utc).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 2, 2, 3, 8, 48, 427, DateTimeKind.Local).AddTicks(6178), new DateTime(2024, 2, 20, 18, 44, 52, 410, DateTimeKind.Utc).AddTicks(3018), false, "Shane Dickinson", 61, 4, 37573.4885770018870000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 410, DateTimeKind.Utc).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 11, 23, 12, 28, 23, 832, DateTimeKind.Local).AddTicks(7238), new DateTime(2024, 2, 20, 18, 44, 52, 410, DateTimeKind.Utc).AddTicks(4437), false, "Tyrone Ward", 23, 3, 375144.527818165420000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 410, DateTimeKind.Utc).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1993, 10, 21, 12, 54, 49, 552, DateTimeKind.Local).AddTicks(1226), new DateTime(2024, 2, 20, 18, 44, 52, 410, DateTimeKind.Utc).AddTicks(5562), false, "Monique Mayer", 68, 3, 185971.026424256050000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 410, DateTimeKind.Utc).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 4, 13, 12, 50, 36, 258, DateTimeKind.Local).AddTicks(4290), new DateTime(2024, 2, 20, 18, 44, 52, 410, DateTimeKind.Utc).AddTicks(6825), false, "Lynne Satterfield", 3, 4, 36480.8999041214290000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 410, DateTimeKind.Utc).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 1, 8, 6, 26, 27, 90, DateTimeKind.Local).AddTicks(3768), new DateTime(2024, 2, 20, 18, 44, 52, 410, DateTimeKind.Utc).AddTicks(7842), false, "Tasha Erdman", 8, 4, 303654.798502305370000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 410, DateTimeKind.Utc).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 2, 15, 9, 24, 58, 905, DateTimeKind.Local).AddTicks(5525), new DateTime(2024, 2, 20, 18, 44, 52, 410, DateTimeKind.Utc).AddTicks(8611), false, "Nadine Altenwerth", 99, 3, 339115.718035735150000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 410, DateTimeKind.Utc).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 4, 10, 5, 18, 40, 127, DateTimeKind.Local).AddTicks(894), new DateTime(2024, 2, 20, 18, 44, 52, 410, DateTimeKind.Utc).AddTicks(9276), false, "Jennie Jerde", 1, 4, 228301.117209189430000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 410, DateTimeKind.Utc).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 11, 22, 13, 58, 10, 896, DateTimeKind.Local).AddTicks(1816), new DateTime(2024, 2, 20, 18, 44, 52, 410, DateTimeKind.Utc).AddTicks(9861), false, "Lance Jakubowski", 30, 2, 191688.680492123740000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 410, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 12, 14, 7, 19, 45, 342, DateTimeKind.Local).AddTicks(3477), new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(602), false, "Hugh McDermott", 6, 2, 216633.898359298540000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 1, 15, 13, 15, 44, 391, DateTimeKind.Local).AddTicks(7041), new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(1285), false, "Michelle Larkin", 95, 2, 55189.247433527080000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 4, 8, 17, 50, 50, 610, DateTimeKind.Local).AddTicks(9480), new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(1981), false, "Phil Kreiger", 17, 304921.349394565660000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 12, 24, 8, 41, 51, 60, DateTimeKind.Local).AddTicks(8070), new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(2688), false, "Irene Mayer", 50, 3, 95911.579541260720000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 6, 18, 8, 11, 40, 616, DateTimeKind.Local).AddTicks(4478), new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(3326), false, "Andres Schimmel", 87, 5, 87797.030451086440000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1984, 6, 25, 20, 46, 13, 584, DateTimeKind.Local).AddTicks(421), new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(4007), false, "Moses Robel", 72, 2, 67901.218261341910000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 10, 7, 4, 34, 13, 602, DateTimeKind.Local).AddTicks(578), new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(5344), false, "Lester Borer", 56, 390649.234932514210000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1957, 6, 27, 3, 58, 49, 860, DateTimeKind.Local).AddTicks(3558), new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(6299), false, "Raul Flatley", 73, 66081.846176277610000m, new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 6, 26, 20, 27, 25, 580, DateTimeKind.Local).AddTicks(1301), new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(7214), false, "Angel Swift", 82, 1, 68709.862403292880000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 12, 24, 2, 11, 14, 432, DateTimeKind.Local).AddTicks(8171), new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(7989), false, "Jaime Collins", 43, 3, 169507.071022638040000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 9, 27, 7, 43, 21, 792, DateTimeKind.Local).AddTicks(1391), new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(8713), false, "Don Parker", 95, 2, 27649.4546266514320000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 7, 8, 17, 17, 52, 314, DateTimeKind.Local).AddTicks(3880), new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(9307), false, "Delia Gulgowski", 46, 220730.949718431220000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 411, DateTimeKind.Utc).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2004, 2, 15, 15, 37, 36, 476, DateTimeKind.Local).AddTicks(1516), new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(15), false, "Gail Ankunding", 72, 354295.076014757920000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 12, 5, 6, 11, 41, 695, DateTimeKind.Local).AddTicks(1027), new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(648), false, "Violet Kunze", 24, 3, 217323.269561694520000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2000, 5, 18, 1, 47, 11, 700, DateTimeKind.Local).AddTicks(2165), new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(1310), false, "Donna Herzog", 52, 80096.328202160260000m, new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(1309) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 10, 4, 10, 12, 30, 182, DateTimeKind.Local).AddTicks(9020), new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(2161), false, "Lydia Yost", 80, 4, 277824.00618352210000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 6, 21, 2, 44, 20, 211, DateTimeKind.Local).AddTicks(3140), new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(3544), false, "Arlene Johnston", 77, 1, 128745.931308786730000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 2, 14, 1, 56, 1, 585, DateTimeKind.Local).AddTicks(9586), new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(4441), false, "Erik Hyatt", 57, 4, 84280.541507916250000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1969, 9, 6, 18, 24, 1, 630, DateTimeKind.Local).AddTicks(1966), new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(5231), false, "Rufus Strosin", 96, 4, 116740.265843119480000m, new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 6, 12, 10, 24, 43, 970, DateTimeKind.Local).AddTicks(6140), new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(5989), false, "Arthur Zieme", 88, 2, 54505.511098940320000m, 3, new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 8, 12, 3, 24, 53, 959, DateTimeKind.Local).AddTicks(8132), new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(6821), false, "Marshall Robel", 70, 3, 333031.356195422290000m, 2, new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2002, 11, 10, 21, 2, 0, 466, DateTimeKind.Local).AddTicks(8471), new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(7770), false, "Sonia Bailey", 10, 4, 222164.249296098580000m, new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 6, 3, 20, 25, 28, 561, DateTimeKind.Local).AddTicks(7674), new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(8783), false, "Woodrow Zieme", 3, 339148.347617922040000m, 5, new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1992, 11, 28, 10, 46, 4, 186, DateTimeKind.Local).AddTicks(3762), new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(9602), false, "Joan Klein", 54, 1, 47752.6334366623390000m, new DateTime(2024, 2, 20, 18, 44, 52, 412, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 12, 22, 18, 13, 2, 999, DateTimeKind.Local).AddTicks(3301), new DateTime(2024, 2, 20, 18, 44, 52, 413, DateTimeKind.Utc).AddTicks(416), false, "Rose Smitham", 85, 4, 124122.13394679760000m, 1, new DateTime(2024, 2, 20, 18, 44, 52, 413, DateTimeKind.Utc).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 1, 27, 6, 7, 32, 547, DateTimeKind.Local).AddTicks(5038), new DateTime(2024, 2, 20, 18, 44, 52, 413, DateTimeKind.Utc).AddTicks(1885), false, "Melba Prosacco", 5, 3, 268476.43736561920000m, 4, new DateTime(2024, 2, 20, 18, 44, 52, 413, DateTimeKind.Utc).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Birthdate", "CreateDate", "IsDeleted", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1987, 7, 26, 21, 10, 43, 546, DateTimeKind.Local).AddTicks(4069), new DateTime(2024, 2, 20, 18, 44, 52, 413, DateTimeKind.Utc).AddTicks(2799), false, "Lela Prosacco", 44, 2, 341523.18366965590000m, new DateTime(2024, 2, 20, 18, 44, 52, 413, DateTimeKind.Utc).AddTicks(2799) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "IsDeleted", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 363, DateTimeKind.Utc).AddTicks(5941), false, new DateTime(2024, 2, 20, 18, 44, 52, 363, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "IsDeleted", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 363, DateTimeKind.Utc).AddTicks(5943), false, new DateTime(2024, 2, 20, 18, 44, 52, 363, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "IsDeleted", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 363, DateTimeKind.Utc).AddTicks(5945), false, new DateTime(2024, 2, 20, 18, 44, 52, 363, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "IsDeleted", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 363, DateTimeKind.Utc).AddTicks(5947), false, new DateTime(2024, 2, 20, 18, 44, 52, 363, DateTimeKind.Utc).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "IsDeleted", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 363, DateTimeKind.Utc).AddTicks(5948), false, new DateTime(2024, 2, 20, 18, 44, 52, 363, DateTimeKind.Utc).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "IsDeleted", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 363, DateTimeKind.Utc).AddTicks(5710), false, new DateTime(2024, 2, 20, 18, 44, 52, 363, DateTimeKind.Utc).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "IsDeleted", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 363, DateTimeKind.Utc).AddTicks(5717), false, new DateTime(2024, 2, 20, 18, 44, 52, 363, DateTimeKind.Utc).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "IsDeleted", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 363, DateTimeKind.Utc).AddTicks(5719), false, new DateTime(2024, 2, 20, 18, 44, 52, 363, DateTimeKind.Utc).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "IsDeleted", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 363, DateTimeKind.Utc).AddTicks(5721), false, new DateTime(2024, 2, 20, 18, 44, 52, 363, DateTimeKind.Utc).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "IsDeleted", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 18, 44, 52, 363, DateTimeKind.Utc).AddTicks(5723), false, new DateTime(2024, 2, 20, 18, 44, 52, 363, DateTimeKind.Utc).AddTicks(5722) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Coaches");

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 870, DateTimeKind.Utc).AddTicks(4493), "Cathy Denesik", new DateTime(2024, 2, 20, 16, 12, 1, 870, DateTimeKind.Utc).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 872, DateTimeKind.Utc).AddTicks(534), "Catherine Bayer", new DateTime(2024, 2, 20, 16, 12, 1, 872, DateTimeKind.Utc).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 872, DateTimeKind.Utc).AddTicks(6126), "Marilyn Bailey", new DateTime(2024, 2, 20, 16, 12, 1, 872, DateTimeKind.Utc).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 872, DateTimeKind.Utc).AddTicks(7512), "Ralph Hodkiewicz", new DateTime(2024, 2, 20, 16, 12, 1, 872, DateTimeKind.Utc).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 872, DateTimeKind.Utc).AddTicks(8681), "Roberto Effertz", new DateTime(2024, 2, 20, 16, 12, 1, 872, DateTimeKind.Utc).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 872, DateTimeKind.Utc).AddTicks(9879), "Sonia Herzog", new DateTime(2024, 2, 20, 16, 12, 1, 872, DateTimeKind.Utc).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(1340), "Elbert Fisher", new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(3765), "Alton Kulas", new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(5356), "Aaron Prosacco", new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(6376), "Steven Crooks", new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(7218), "Delores Kemmer", new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(8005), "Francis Kulas", new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(8979), "Damon Bashirian", new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(9961), "Sara Swaniawski", new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 874, DateTimeKind.Utc).AddTicks(858), "Aubrey Glover", new DateTime(2024, 2, 20, 16, 12, 1, 874, DateTimeKind.Utc).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 874, DateTimeKind.Utc).AddTicks(1811), "Crystal Kiehn", new DateTime(2024, 2, 20, 16, 12, 1, 874, DateTimeKind.Utc).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 875, DateTimeKind.Utc).AddTicks(1804), "Julie Rolfson", new DateTime(2024, 2, 20, 16, 12, 1, 875, DateTimeKind.Utc).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 875, DateTimeKind.Utc).AddTicks(9575), "Cecil McDermott", new DateTime(2024, 2, 20, 16, 12, 1, 875, DateTimeKind.Utc).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 876, DateTimeKind.Utc).AddTicks(4944), "Jack Leannon", new DateTime(2024, 2, 20, 16, 12, 1, 876, DateTimeKind.Utc).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 877, DateTimeKind.Utc).AddTicks(529), "Rudolph Wintheiser", new DateTime(2024, 2, 20, 16, 12, 1, 877, DateTimeKind.Utc).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 877, DateTimeKind.Utc).AddTicks(4634), "Patti Smitham", new DateTime(2024, 2, 20, 16, 12, 1, 877, DateTimeKind.Utc).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 877, DateTimeKind.Utc).AddTicks(8900), "Joann Jerde", new DateTime(2024, 2, 20, 16, 12, 1, 877, DateTimeKind.Utc).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 878, DateTimeKind.Utc).AddTicks(512), "Dallas Mayer", new DateTime(2024, 2, 20, 16, 12, 1, 878, DateTimeKind.Utc).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 878, DateTimeKind.Utc).AddTicks(1446), "Melvin Kris", new DateTime(2024, 2, 20, 16, 12, 1, 878, DateTimeKind.Utc).AddTicks(1446) });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Name", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 878, DateTimeKind.Utc).AddTicks(2242), "Mindy Bins", new DateTime(2024, 2, 20, 16, 12, 1, 878, DateTimeKind.Utc).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1971, 9, 12, 23, 49, 20, 520, DateTimeKind.Local).AddTicks(350), new DateTime(2024, 2, 20, 16, 12, 1, 803, DateTimeKind.Utc).AddTicks(1551), "Gerald Kshlerin", 98, 2, 366980.829208168360000m, new DateTime(2024, 2, 20, 16, 12, 1, 803, DateTimeKind.Utc).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 10, 5, 2, 11, 12, 533, DateTimeKind.Local).AddTicks(5657), new DateTime(2024, 2, 20, 16, 12, 1, 803, DateTimeKind.Utc).AddTicks(8400), "Ora Kozey", 13, 3, 198697.473198494260000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 803, DateTimeKind.Utc).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 1, 4, 0, 44, 20, 959, DateTimeKind.Local).AddTicks(7954), new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(562), "Jesse Lakin", 40, 1, 211851.690017215420000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Birthdate", "CreateDate", "Name", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1965, 11, 4, 21, 12, 21, 694, DateTimeKind.Local).AddTicks(7101), new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(1586), "Rafael Lubowitz", 1, 261887.387117742610000m, new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 2, 3, 6, 48, 50, 508, DateTimeKind.Local).AddTicks(2371), new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(2577), "Kenneth Larson", 8, 1, 94888.625884640110000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1968, 5, 24, 23, 52, 5, 992, DateTimeKind.Local).AddTicks(9502), new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(3335), "Carlos Maggio", 80, 4, 295323.327333766150000m, new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 9, 23, 8, 22, 48, 847, DateTimeKind.Local).AddTicks(3818), new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(4145), "Marie Abshire", 95, 2, 92107.351989300430000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 2, 16, 6, 51, 10, 507, DateTimeKind.Local).AddTicks(299), new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(4926), "Woodrow Johnston", 43, 3, 106556.265262057510000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 7, 30, 12, 25, 16, 728, DateTimeKind.Local).AddTicks(7436), new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(6312), "Danielle Mraz", 40, 1, 299160.690865454980000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1983, 10, 25, 23, 56, 50, 104, DateTimeKind.Local).AddTicks(2866), new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(7660), "Wallace Stroman", 56, 4, 57316.563894290080000m, new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 1, 10, 15, 13, 55, 704, DateTimeKind.Local).AddTicks(1998), new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(8664), "Eula Nolan", 80, 5, 302831.471288807620000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 6, 24, 8, 30, 43, 673, DateTimeKind.Local).AddTicks(7593), new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(9487), "Dean Huels", 93, 1, 128579.872273845190000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 11, 3, 20, 37, 34, 778, DateTimeKind.Local).AddTicks(9346), new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(170), "Jennifer McDermott", 55, 2, 90846.020086645060000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Birthdate", "CreateDate", "Name", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 4, 29, 2, 24, 26, 202, DateTimeKind.Local).AddTicks(7667), new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(990), "Debbie Witting", 4, 48954.0155037739810000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 3, 21, 15, 26, 43, 663, DateTimeKind.Local).AddTicks(9608), new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(1764), "Constance Hayes", 10, 5, 305642.000985891040000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 1, 26, 3, 24, 42, 120, DateTimeKind.Local).AddTicks(7177), new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(2482), "Christopher Dare", 45, 310823.881813388830000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 10, 31, 19, 50, 41, 508, DateTimeKind.Local).AddTicks(3194), new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(3279), "Hazel Gusikowski", 36, 4, 263631.91945631020000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 10, 18, 21, 9, 47, 9, DateTimeKind.Local).AddTicks(4340), new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(3988), "Bob O'Conner", 69, 197899.253780069260000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 12, 16, 7, 46, 31, 289, DateTimeKind.Local).AddTicks(1874), new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(4752), "Nora Lind", 40, 4, 220478.133985115230000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1995, 1, 10, 22, 33, 18, 759, DateTimeKind.Local).AddTicks(7822), new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(5380), "Lillie Bogan", 95, 3, 33834.1435016357140000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1973, 4, 25, 6, 33, 47, 411, DateTimeKind.Local).AddTicks(3967), new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(6977), "Sue Bins", 69, 2, 323428.717864686190000m, new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 7, 16, 14, 46, 56, 480, DateTimeKind.Local).AddTicks(1898), new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(7856), "Candice Gaylord", 39, 176264.157377671210000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1964, 12, 7, 15, 38, 7, 838, DateTimeKind.Local).AddTicks(3766), new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(8625), "Annie Krajcik", 75, 2, 346913.126949671740000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1984, 10, 14, 19, 53, 32, 816, DateTimeKind.Local).AddTicks(1006), new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(9381), "Wesley Deckow", 1, 1, 290272.051404784270000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 11, 30, 6, 56, 30, 917, DateTimeKind.Local).AddTicks(7837), new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(127), "Ana Lang", 11, 1, 196982.192726028310000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1962, 6, 20, 10, 46, 28, 709, DateTimeKind.Local).AddTicks(4351), new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(854), "Fredrick Kub", 37, 217647.376340648530000m, new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(854) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 8, 15, 0, 3, 33, 467, DateTimeKind.Local).AddTicks(466), new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(1616), "Cristina Hahn", 64, 2, 396323.728184595760000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 5, 30, 19, 31, 21, 309, DateTimeKind.Local).AddTicks(1193), new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(2344), "Glenn Kohler", 20, 1, 256263.920571221410000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 9, 19, 2, 31, 35, 474, DateTimeKind.Local).AddTicks(9166), new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(3034), "Ernesto Schmeler", 9, 4, 160748.84263742290000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 6, 13, 18, 54, 39, 948, DateTimeKind.Local).AddTicks(6488), new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(3845), "Leland Schultz", 58, 2, 59509.044699118420000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 2, 23, 13, 10, 46, 567, DateTimeKind.Local).AddTicks(8040), new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(4586), "Josefina Koch", 59, 273821.424741798820000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1967, 4, 6, 7, 46, 4, 637, DateTimeKind.Local).AddTicks(325), new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(5848), "Kurt Walter", 100, 2, 324612.244785000760000m, new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 11, 19, 14, 29, 50, 653, DateTimeKind.Local).AddTicks(6352), new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(7201), "Brandy Carter", 89, 1, 236360.008117752730000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 11, 16, 13, 16, 26, 14, DateTimeKind.Local).AddTicks(4232), new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(8099), "Guillermo Reichel", 21, 3, 361719.090379218640000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 10, 6, 15, 50, 15, 176, DateTimeKind.Local).AddTicks(6971), new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(8836), "Nicole Becker", 27, 4, 239716.878717770080000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1993, 2, 17, 10, 44, 33, 296, DateTimeKind.Local).AddTicks(7490), new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(9584), "Juanita Cummerata", 20, 3, 46100.7740134835560000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1961, 4, 10, 1, 21, 48, 95, DateTimeKind.Local).AddTicks(7170), new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(390), "Michelle Kuhic", 87, 1, 322168.378067231140000m, new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2004, 2, 11, 5, 1, 14, 48, DateTimeKind.Local).AddTicks(6631), new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(1777), "Dewey Koss", 40, 2, 12202.32204499238230000m, new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 8, 26, 18, 1, 7, 973, DateTimeKind.Local).AddTicks(7749), new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(2679), "Roman Fritsch", 49, 213148.287247331530000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1994, 12, 1, 15, 21, 18, 126, DateTimeKind.Local).AddTicks(6771), new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(3418), "Edith Streich", 39, 1, 60933.194498627350000m, new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1984, 3, 26, 1, 38, 57, 709, DateTimeKind.Local).AddTicks(3035), new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(4193), "Clara Huel", 61, 5, 42583.7255081185510000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2003, 2, 1, 10, 55, 23, 326, DateTimeKind.Local).AddTicks(5614), new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(4865), "Russell Ward", 23, 5, 43933.5578761712260000m, new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 7, 8, 17, 23, 14, 133, DateTimeKind.Local).AddTicks(1231), new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(6534), "Brittany Kertzmann", 19, 2, 284912.032346702920000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1956, 6, 22, 19, 40, 20, 353, DateTimeKind.Local).AddTicks(5750), new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(7664), "Violet Paucek", 88, 5, 334789.721319089260000m, new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 1, 25, 12, 44, 30, 506, DateTimeKind.Local).AddTicks(1593), new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(8477), "Sonya Prohaska", 43, 3, 48588.8329153253680000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 8, 3, 7, 47, 49, 429, DateTimeKind.Local).AddTicks(2437), new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(9289), "Sean Jaskolski", 45, 3, 216426.87516407320000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 4, 7, 20, 55, 11, 211, DateTimeKind.Local).AddTicks(9552), new DateTime(2024, 2, 20, 16, 12, 1, 808, DateTimeKind.Utc).AddTicks(79), "Justin Swift", 86, 5, 187997.228331284830000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 808, DateTimeKind.Utc).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 3, 5, 14, 28, 45, 911, DateTimeKind.Local).AddTicks(8051), new DateTime(2024, 2, 20, 16, 12, 1, 808, DateTimeKind.Utc).AddTicks(869), "Frank Boyle", 17, 5, 394454.69561979610000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 808, DateTimeKind.Utc).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 1, 12, 10, 31, 20, 345, DateTimeKind.Local).AddTicks(5155), new DateTime(2024, 2, 20, 16, 12, 1, 808, DateTimeKind.Utc).AddTicks(1520), "Leslie D'Amore", 99, 1, 140445.22863983650000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 808, DateTimeKind.Utc).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 9, 6, 10, 34, 12, 84, DateTimeKind.Local).AddTicks(9026), new DateTime(2024, 2, 20, 16, 12, 1, 808, DateTimeKind.Utc).AddTicks(2437), "Sharon Feil", 11, 2, 321823.757940028360000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 808, DateTimeKind.Utc).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 2, 19, 0, 29, 17, 764, DateTimeKind.Local).AddTicks(4486), new DateTime(2024, 2, 20, 16, 12, 1, 808, DateTimeKind.Utc).AddTicks(3729), "John Schaefer", 60, 1, 127665.451804749160000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 808, DateTimeKind.Utc).AddTicks(3728) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1980, 7, 14, 7, 15, 32, 522, DateTimeKind.Local).AddTicks(595), new DateTime(2024, 2, 20, 16, 12, 1, 808, DateTimeKind.Utc).AddTicks(5209), "Shane Ledner", 24, 337099.840020520060000m, new DateTime(2024, 2, 20, 16, 12, 1, 808, DateTimeKind.Utc).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 8, 24, 14, 33, 27, 945, DateTimeKind.Local).AddTicks(3762), new DateTime(2024, 2, 20, 16, 12, 1, 808, DateTimeKind.Utc).AddTicks(8639), "Christina Roberts", 88, 4, 58235.443238658130000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 808, DateTimeKind.Utc).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 3, 26, 22, 3, 1, 196, DateTimeKind.Local).AddTicks(525), new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(353), "Angela Farrell", 88, 2, 325362.484087780090000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1955, 5, 6, 11, 18, 15, 961, DateTimeKind.Local).AddTicks(3239), new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(1619), "Michelle Weimann", 88, 344934.050436230440000m, new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 10, 5, 12, 50, 4, 242, DateTimeKind.Local).AddTicks(5569), new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(2401), "Holly Schimmel", 92, 2, 106148.716142189620000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1955, 4, 11, 5, 40, 1, 55, DateTimeKind.Local).AddTicks(2002), new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(3194), "Lester Heathcote", 49, 2, 241961.477481667180000m, new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2004, 1, 27, 5, 34, 51, 482, DateTimeKind.Local).AddTicks(3990), new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(4224), "Tommie Huel", 19, 301821.697140976210000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 5, 26, 12, 22, 16, 418, DateTimeKind.Local).AddTicks(879), new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(6925), "Tiffany Dare", 13, 5, 212689.012200695410000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 7, 19, 12, 50, 47, 757, DateTimeKind.Local).AddTicks(3581), new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(8634), "Mark Stamm", 76, 5, 265824.730948320430000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 7, 31, 5, 38, 55, 104, DateTimeKind.Local).AddTicks(8528), new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(9644), "Michelle Tremblay", 41, 5, 197043.758956803580000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 5, 25, 21, 11, 23, 832, DateTimeKind.Local).AddTicks(5359), new DateTime(2024, 2, 20, 16, 12, 1, 810, DateTimeKind.Utc).AddTicks(693), "Silvia Lesch", 43, 4, 345778.072497164050000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 810, DateTimeKind.Utc).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 8, 6, 13, 5, 40, 413, DateTimeKind.Local).AddTicks(5214), new DateTime(2024, 2, 20, 16, 12, 1, 810, DateTimeKind.Utc).AddTicks(1585), "Monique Bahringer", 12, 5, 399908.815941588580000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 810, DateTimeKind.Utc).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 8, 1, 21, 53, 25, 774, DateTimeKind.Local).AddTicks(677), new DateTime(2024, 2, 20, 16, 12, 1, 810, DateTimeKind.Utc).AddTicks(2475), "Lorraine Treutel", 78, 1, 304594.978716673960000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 810, DateTimeKind.Utc).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 3, 4, 13, 47, 56, 173, DateTimeKind.Local).AddTicks(4548), new DateTime(2024, 2, 20, 16, 12, 1, 810, DateTimeKind.Utc).AddTicks(3469), "Robyn McCullough", 16, 188330.553093135040000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 810, DateTimeKind.Utc).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1998, 7, 14, 0, 36, 47, 56, DateTimeKind.Local).AddTicks(9267), new DateTime(2024, 2, 20, 16, 12, 1, 810, DateTimeKind.Utc).AddTicks(5108), "Sonia Kling", 55, 4, 87650.537550574690000m, new DateTime(2024, 2, 20, 16, 12, 1, 810, DateTimeKind.Utc).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 2, 17, 6, 26, 33, 162, DateTimeKind.Local).AddTicks(2498), new DateTime(2024, 2, 20, 16, 12, 1, 810, DateTimeKind.Utc).AddTicks(7872), "Marcia Langosh", 91, 3, 369689.80581138670000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 810, DateTimeKind.Utc).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 11, 6, 1, 55, 8, 670, DateTimeKind.Local).AddTicks(5844), new DateTime(2024, 2, 20, 16, 12, 1, 810, DateTimeKind.Utc).AddTicks(9534), "Nelson Friesen", 56, 2, 40926.4814334328060000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 810, DateTimeKind.Utc).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1993, 4, 18, 19, 46, 38, 507, DateTimeKind.Local).AddTicks(4936), new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(502), "Jackie Swift", 3, 5, 86603.540791004890000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 9, 23, 13, 0, 34, 741, DateTimeKind.Local).AddTicks(9093), new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(1293), "Roxanne Bechtelar", 39, 5, 99143.11345729660000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 7, 4, 9, 24, 54, 905, DateTimeKind.Local).AddTicks(1670), new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(2755), "Dwayne Wyman", 69, 325048.654857543880000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1963, 7, 1, 6, 18, 53, 769, DateTimeKind.Local).AddTicks(5915), new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(3608), "Marcia McKenzie", 22, 5, 108723.301415987170000m, new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Birthdate", "CreateDate", "Name", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1972, 10, 17, 17, 18, 48, 557, DateTimeKind.Local).AddTicks(4606), new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(4430), "Sylvester Walsh", 3, 338577.705875923270000m, new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 8, 18, 13, 3, 57, 727, DateTimeKind.Local).AddTicks(4467), new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(5264), "Gayle Hartmann", 85, 4, 34429.4201886272590000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 3, 7, 17, 8, 1, 260, DateTimeKind.Local).AddTicks(8646), new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(6109), "Jaime Hickle", 67, 2, 192015.584413324480000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(6108) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 9, 5, 10, 3, 21, 483, DateTimeKind.Local).AddTicks(7063), new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(6838), "Janet Vandervort", 89, 161083.389116785450000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 8, 10, 12, 36, 30, 781, DateTimeKind.Local).AddTicks(8393), new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(7724), "Melanie Bartell", 61, 5, 140683.932323150440000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 3, 14, 22, 47, 33, 652, DateTimeKind.Local).AddTicks(4072), new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(8487), "Terry Emmerich", 62, 3, 395487.624679855360000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 1, 5, 0, 14, 1, 69, DateTimeKind.Local).AddTicks(9483), new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(9214), "Monica Mitchell", 58, 11680.98277117338880000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 7, 13, 17, 35, 27, 892, DateTimeKind.Local).AddTicks(5219), new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(29), "Emmett Schneider", 59, 1, 251140.124037518290000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1966, 10, 20, 16, 17, 6, 207, DateTimeKind.Local).AddTicks(9999), new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(1244), "Erma Balistreri", 6, 2, 357620.624374181080000m, new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2001, 2, 20, 9, 38, 37, 567, DateTimeKind.Local).AddTicks(7069), new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(2273), "Lucille Wehner", 81, 5, 154053.71062664140000m, new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 5, 26, 18, 11, 48, 495, DateTimeKind.Local).AddTicks(5142), new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(3065), "Hazel Johnson", 73, 4, 146410.638070838560000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 3, 7, 20, 3, 22, 186, DateTimeKind.Local).AddTicks(5949), new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(3844), "Tina MacGyver", 85, 3, 89940.698304020710000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 1, 5, 23, 19, 49, 17, DateTimeKind.Local).AddTicks(4880), new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(4593), "Noah Mitchell", 19, 4, 74342.355614772040000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 11, 22, 15, 1, 30, 26, DateTimeKind.Local).AddTicks(2772), new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(5304), "Clinton Brekke", 42, 5, 379674.629179440520000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 4, 4, 23, 9, 19, 281, DateTimeKind.Local).AddTicks(9215), new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(6186), "Ralph Lockman", 6, 102104.883298701130000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 12, 29, 22, 9, 38, 893, DateTimeKind.Local).AddTicks(7206), new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(7184), "Geraldine Jaskolski", 9, 266037.990666248440000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 5, 6, 23, 34, 27, 949, DateTimeKind.Local).AddTicks(7408), new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(7963), "Cody Bergnaum", 27, 2, 94241.831920326730000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2003, 7, 21, 23, 15, 42, 896, DateTimeKind.Local).AddTicks(9208), new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(8671), "Benny Mueller", 41, 2, 338589.677864072560000m, new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 10, 23, 18, 43, 42, 868, DateTimeKind.Local).AddTicks(6443), new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(9355), "Lynda MacGyver", 24, 4, 147559.747089566620000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 11, 28, 20, 5, 23, 728, DateTimeKind.Local).AddTicks(6695), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(655), "Joann Streich", 70, 3, 376016.137068625420000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 3, 13, 7, 53, 29, 724, DateTimeKind.Local).AddTicks(8287), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(1479), "Freda Bernier", 47, 2, 117226.48898600860000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 11, 15, 20, 5, 30, 916, DateTimeKind.Local).AddTicks(2327), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(2191), "Antonia Rau", 37, 5, 215979.333983360470000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1964, 1, 27, 14, 7, 10, 918, DateTimeKind.Local).AddTicks(7846), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(2939), "Sophia Rath", 99, 5, 39620.2740657078970000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 4, 13, 19, 13, 23, 143, DateTimeKind.Local).AddTicks(4771), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(3606), "Cristina Prosacco", 3, 24963.8152680748030000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 11, 21, 7, 15, 32, 525, DateTimeKind.Local).AddTicks(882), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(4377), "Alberto Macejkovic", 88, 5, 103200.559113546430000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 9, 4, 6, 36, 23, 323, DateTimeKind.Local).AddTicks(7502), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(5142), "Eddie Lockman", 20, 4, 30956.3345420202280000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 11, 23, 15, 47, 25, 159, DateTimeKind.Local).AddTicks(5292), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(5921), "Ivan Block", 56, 104104.538009769430000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1992, 10, 25, 13, 18, 48, 365, DateTimeKind.Local).AddTicks(6783), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(6640), "Terrance Wisozk", 22, 2, 358605.653401297240000m, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 3, 20, 4, 46, 18, 152, DateTimeKind.Local).AddTicks(6450), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(7350), "Mathew Ward", 40, 1, 92147.085902025040000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1963, 5, 2, 7, 12, 24, 667, DateTimeKind.Local).AddTicks(1421), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(8026), "Nelson Parker", 34, 3, 384967.495074504670000m, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 3, 6, 13, 0, 6, 702, DateTimeKind.Local).AddTicks(1012), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(9111), "Irvin Hoppe", 3, 189028.430241659440000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 11, 29, 20, 10, 40, 231, DateTimeKind.Local).AddTicks(4077), new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(155), "Glen Boehm", 51, 88397.731464355420000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 11, 19, 15, 11, 39, 940, DateTimeKind.Local).AddTicks(3591), new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(985), "Judith Shields", 32, 59217.836236417420000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 10, 19, 1, 40, 51, 48, DateTimeKind.Local).AddTicks(650), new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(1728), "Shelley Jast", 97, 5, 50116.138669653280000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 2, 2, 15, 32, 46, 125, DateTimeKind.Local).AddTicks(3536), new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(2489), "Gregory Kshlerin", 47, 3, 285854.769664245850000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 1, 26, 4, 26, 48, 831, DateTimeKind.Local).AddTicks(4416), new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(3228), "Ted Stamm", 32, 5, 114650.293195945510000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1994, 10, 27, 1, 9, 11, 838, DateTimeKind.Local).AddTicks(9059), new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(3879), "Moses Hane", 30, 4, 384316.445519264170000m, new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(3879) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1964, 6, 11, 11, 55, 15, 191, DateTimeKind.Local).AddTicks(1568), new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(4587), "Leland Ledner", 7, 5, 197540.015713871080000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 6, 15, 0, 34, 48, 709, DateTimeKind.Local).AddTicks(3967), new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(5332), "Eleanor Botsford", 32, 1, 87040.872204674560000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 10, 31, 4, 39, 8, 174, DateTimeKind.Local).AddTicks(6870), new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(6062), "Gene Kautzer", 37, 2, 211397.803558720210000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 11, 25, 17, 40, 31, 782, DateTimeKind.Local).AddTicks(7487), new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(6854), "Ramona Tremblay", 2, 3, 307346.64700431730000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 4, 8, 6, 39, 57, 247, DateTimeKind.Local).AddTicks(5423), new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(7930), "Alice Hauck", 33, 3, 339330.367755879490000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 1, 24, 8, 44, 27, 192, DateTimeKind.Local).AddTicks(1655), new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(8989), "Everett Carter", 42, 337976.073635887690000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 1, 10, 17, 3, 15, 179, DateTimeKind.Local).AddTicks(9703), new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(9717), "Veronica Turner", 85, 3, 99156.307981104910000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 3, 17, 1, 10, 23, 86, DateTimeKind.Local).AddTicks(6767), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(471), "Jimmy Hills", 34, 4, 396161.834165497780000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1989, 7, 2, 23, 13, 53, 326, DateTimeKind.Local).AddTicks(3351), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(1267), "Laura Grady", 46, 5, 50325.03842321110000m, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 11, 25, 12, 3, 35, 484, DateTimeKind.Local).AddTicks(2807), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(1975), "Bernard Greenfelder", 78, 3, 207306.742262052670000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 7, 27, 15, 46, 15, 57, DateTimeKind.Local).AddTicks(2621), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(2712), "Samantha Kshlerin", 14, 2, 304174.930593004630000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 10, 14, 2, 0, 39, 28, DateTimeKind.Local).AddTicks(2597), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(3525), "Leland Becker", 60, 2, 265801.648824639580000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 12, 14, 1, 58, 38, 70, DateTimeKind.Local).AddTicks(5568), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(4231), "Phil Rohan", 24, 151162.288386193750000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1960, 8, 3, 6, 35, 18, 70, DateTimeKind.Local).AddTicks(5082), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(4960), "Sammy Powlowski", 64, 4, 124640.733023844430000m, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 2, 15, 18, 31, 56, 136, DateTimeKind.Local).AddTicks(251), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(5696), "Mark Krajcik", 19, 1, 319351.228641463060000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1973, 10, 4, 8, 44, 26, 58, DateTimeKind.Local).AddTicks(6926), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(6359), "Sonia Wintheiser", 3, 2, 382640.914732840780000m, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 8, 10, 5, 24, 7, 948, DateTimeKind.Local).AddTicks(7313), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(7602), "Lois Kovacek", 3, 5, 274489.035080294440000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 11, 18, 7, 9, 44, 955, DateTimeKind.Local).AddTicks(6871), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(8405), "Penny Conroy", 32, 200869.385400370690000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 1, 15, 3, 10, 36, 688, DateTimeKind.Local).AddTicks(2348), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(9182), "Lorena Rohan", 44, 2, 67306.365844984750000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 5, 8, 22, 9, 10, 728, DateTimeKind.Local).AddTicks(8947), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(9993), "Philip Bauch", 75, 4, 16429.4063479697740000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 7, 19, 1, 10, 55, 711, DateTimeKind.Local).AddTicks(9772), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(658), "Peter Sanford", 64, 5, 278320.371542433730000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 2, 19, 7, 10, 5, 506, DateTimeKind.Local).AddTicks(3506), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(1321), "Lillian Bechtelar", 5, 27284.3770409742640000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1979, 1, 31, 23, 20, 55, 24, DateTimeKind.Local).AddTicks(4850), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(2077), "Jamie Connelly", 22, 1, 91200.369723978310000m, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 2, 9, 0, 21, 31, 634, DateTimeKind.Local).AddTicks(6046), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(2786), "Karl Carroll", 30, 109108.90068073150000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 7, 31, 0, 24, 7, 836, DateTimeKind.Local).AddTicks(8421), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(3508), "Eduardo Hills", 19, 240329.63531530420000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 6, 29, 12, 31, 7, 478, DateTimeKind.Local).AddTicks(794), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(4167), "Ross Krajcik", 66, 5, 231351.481417821040000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 8, 22, 23, 34, 17, 214, DateTimeKind.Local).AddTicks(2660), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(4844), "Anthony Gaylord", 20, 5, 176642.952465539680000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1986, 8, 1, 16, 15, 15, 345, DateTimeKind.Local).AddTicks(5599), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(5688), "Jeffery Deckow", 40, 1, 120134.849701088290000m, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 1, 3, 8, 38, 21, 462, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(6737), "Philip Hane", 74, 370258.491770360950000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 4, 22, 9, 53, 30, 183, DateTimeKind.Local).AddTicks(1632), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(7523), "Louise Dooley", 39, 5, 317613.34232185570000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1975, 3, 12, 0, 11, 21, 931, DateTimeKind.Local).AddTicks(9951), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(8284), "Krista Sawayn", 69, 274008.542079359740000m, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 4, 10, 15, 20, 54, 108, DateTimeKind.Local).AddTicks(3038), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(9065), "Shelia Sawayn", 5, 70838.331036351310000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 10, 16, 13, 21, 13, 371, DateTimeKind.Local).AddTicks(3640), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(9734), "Juana Ruecker", 66, 5, 39404.1927271594060000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 10, 24, 0, 37, 55, 169, DateTimeKind.Local).AddTicks(9538), new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(461), "Natasha Williamson", 24, 1, 316776.245034878320000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 3, 18, 18, 13, 28, 15, DateTimeKind.Local).AddTicks(7832), new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(1172), "Curtis Morissette", 98, 2, 144565.897747106020000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(1172) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 5, 4, 7, 39, 39, 734, DateTimeKind.Local).AddTicks(9097), new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(1890), "Rex Mayer", 6, 1, 282669.341179606540000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 3, 7, 6, 34, 45, 945, DateTimeKind.Local).AddTicks(6791), new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(2515), "Freda Marquardt", 82, 1, 262323.669450465730000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 10, 10, 20, 10, 33, 640, DateTimeKind.Local).AddTicks(6950), new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(3236), "Robin Kuvalis", 65, 1, 333486.409217633350000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 11, 3, 15, 19, 11, 541, DateTimeKind.Local).AddTicks(934), new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(3944), "Guillermo Collier", 79, 5, 136361.78078103970000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 12, 18, 2, 16, 11, 732, DateTimeKind.Local).AddTicks(1375), new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(4855), "Morris Leannon", 22, 3, 126051.754976555710000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1956, 5, 24, 4, 26, 42, 5, DateTimeKind.Local).AddTicks(4117), new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(6085), "Zachary Okuneva", 1, 88372.302467662450000m, new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 2, 4, 12, 33, 35, 452, DateTimeKind.Local).AddTicks(9040), new DateTime(2024, 2, 20, 16, 12, 1, 818, DateTimeKind.Utc).AddTicks(3479), "Orlando Bogisich", 57, 1, 170313.464888649670000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 818, DateTimeKind.Utc).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Birthdate", "CreateDate", "Name", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 12, 17, 13, 29, 36, 365, DateTimeKind.Local).AddTicks(4036), new DateTime(2024, 2, 20, 16, 12, 1, 819, DateTimeKind.Utc).AddTicks(4660), "Claudia Schultz", 3, 53836.45569631510000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 819, DateTimeKind.Utc).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 4, 20, 17, 8, 3, 551, DateTimeKind.Local).AddTicks(1487), new DateTime(2024, 2, 20, 16, 12, 1, 819, DateTimeKind.Utc).AddTicks(9415), "Lynn Douglas", 85, 43610.9341727151460000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 819, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 11, 14, 6, 37, 24, 520, DateTimeKind.Local).AddTicks(2669), new DateTime(2024, 2, 20, 16, 12, 1, 820, DateTimeKind.Utc).AddTicks(3728), "Conrad Bashirian", 63, 83868.015258786970000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 820, DateTimeKind.Utc).AddTicks(3723) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 1, 5, 16, 55, 59, 445, DateTimeKind.Local).AddTicks(1318), new DateTime(2024, 2, 20, 16, 12, 1, 820, DateTimeKind.Utc).AddTicks(8428), "Joan Schowalter", 65, 2, 371631.884460269410000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 820, DateTimeKind.Utc).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 11, 6, 8, 19, 12, 692, DateTimeKind.Local).AddTicks(3838), new DateTime(2024, 2, 20, 16, 12, 1, 821, DateTimeKind.Utc).AddTicks(2920), "Jerry Graham", 53, 3, 201391.418453241370000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 821, DateTimeKind.Utc).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 3, 4, 2, 4, 55, 153, DateTimeKind.Local).AddTicks(3327), new DateTime(2024, 2, 20, 16, 12, 1, 821, DateTimeKind.Utc).AddTicks(8415), "Rene Mueller", 52, 2, 381594.087026074510000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 821, DateTimeKind.Utc).AddTicks(8413) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 1, 26, 13, 47, 6, 9, DateTimeKind.Local).AddTicks(7418), new DateTime(2024, 2, 20, 16, 12, 1, 822, DateTimeKind.Utc).AddTicks(3334), "Elisa Hermiston", 83, 4, 251923.477418368720000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 822, DateTimeKind.Utc).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 2, 27, 7, 7, 9, 240, DateTimeKind.Local).AddTicks(127), new DateTime(2024, 2, 20, 16, 12, 1, 822, DateTimeKind.Utc).AddTicks(6785), "Raymond Hammes", 81, 191075.801346428950000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 822, DateTimeKind.Utc).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1990, 12, 1, 16, 53, 39, 73, DateTimeKind.Local).AddTicks(2760), new DateTime(2024, 2, 20, 16, 12, 1, 823, DateTimeKind.Utc).AddTicks(120), "Wm Schneider", 64, 3, 206249.736402164770000m, new DateTime(2024, 2, 20, 16, 12, 1, 823, DateTimeKind.Utc).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 1, 14, 10, 30, 8, 348, DateTimeKind.Local).AddTicks(4301), new DateTime(2024, 2, 20, 16, 12, 1, 823, DateTimeKind.Utc).AddTicks(4457), "Jasmine Bechtelar", 39, 124739.143061231260000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 823, DateTimeKind.Utc).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 3, 15, 6, 43, 12, 950, DateTimeKind.Local).AddTicks(1728), new DateTime(2024, 2, 20, 16, 12, 1, 823, DateTimeKind.Utc).AddTicks(7803), "Steven Mertz", 27, 2, 178963.255331148460000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 823, DateTimeKind.Utc).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 11, 23, 2, 1, 2, 668, DateTimeKind.Local).AddTicks(3349), new DateTime(2024, 2, 20, 16, 12, 1, 824, DateTimeKind.Utc).AddTicks(1569), "Sergio Jerde", 8, 4, 231835.351808177380000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 824, DateTimeKind.Utc).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 12, 1, 2, 41, 27, 140, DateTimeKind.Local).AddTicks(3230), new DateTime(2024, 2, 20, 16, 12, 1, 824, DateTimeKind.Utc).AddTicks(5276), "Martha Becker", 50, 5, 101854.952662978570000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 824, DateTimeKind.Utc).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 4, 12, 0, 45, 2, 151, DateTimeKind.Local).AddTicks(9981), new DateTime(2024, 2, 20, 16, 12, 1, 824, DateTimeKind.Utc).AddTicks(8500), "Sergio Streich", 37, 5, 209211.319200739690000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 824, DateTimeKind.Utc).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 5, 13, 15, 56, 5, 602, DateTimeKind.Local).AddTicks(7907), new DateTime(2024, 2, 20, 16, 12, 1, 825, DateTimeKind.Utc).AddTicks(2339), "Samantha Hauck", 62, 339331.732395012490000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 825, DateTimeKind.Utc).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1973, 10, 28, 18, 35, 50, 145, DateTimeKind.Local).AddTicks(8250), new DateTime(2024, 2, 20, 16, 12, 1, 825, DateTimeKind.Utc).AddTicks(5548), "Walter Braun", 27, 2, 175616.422747405240000m, new DateTime(2024, 2, 20, 16, 12, 1, 825, DateTimeKind.Utc).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 9, 8, 3, 34, 9, 850, DateTimeKind.Local).AddTicks(3992), new DateTime(2024, 2, 20, 16, 12, 1, 825, DateTimeKind.Utc).AddTicks(8878), "Maurice Cremin", 27, 3, 189986.377404321280000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 825, DateTimeKind.Utc).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 12, 30, 2, 5, 10, 309, DateTimeKind.Local).AddTicks(5582), new DateTime(2024, 2, 20, 16, 12, 1, 826, DateTimeKind.Utc).AddTicks(2671), "Lois Haag", 73, 1, 124157.866745556010000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 826, DateTimeKind.Utc).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 7, 31, 18, 29, 39, 126, DateTimeKind.Local).AddTicks(8925), new DateTime(2024, 2, 20, 16, 12, 1, 826, DateTimeKind.Utc).AddTicks(5769), "Megan Green", 21, 3, 259689.159097251640000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 826, DateTimeKind.Utc).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 1, 13, 20, 57, 0, 515, DateTimeKind.Local).AddTicks(3578), new DateTime(2024, 2, 20, 16, 12, 1, 826, DateTimeKind.Utc).AddTicks(9438), "Juanita Kshlerin", 27, 1, 187914.371770128370000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 826, DateTimeKind.Utc).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 6, 8, 16, 46, 58, 322, DateTimeKind.Local).AddTicks(1361), new DateTime(2024, 2, 20, 16, 12, 1, 827, DateTimeKind.Utc).AddTicks(5093), "Barry Schamberger", 8, 265765.730882681890000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 827, DateTimeKind.Utc).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1984, 4, 27, 10, 44, 36, 214, DateTimeKind.Local).AddTicks(9082), new DateTime(2024, 2, 20, 16, 12, 1, 827, DateTimeKind.Utc).AddTicks(7912), "Raul Wisozk", 27, 325663.21751554330000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 827, DateTimeKind.Utc).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 2, 1, 23, 20, 22, 500, DateTimeKind.Local).AddTicks(6500), new DateTime(2024, 2, 20, 16, 12, 1, 827, DateTimeKind.Utc).AddTicks(9465), "Jeffrey Metz", 9, 293339.236309515880000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 827, DateTimeKind.Utc).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 7, 28, 8, 10, 51, 352, DateTimeKind.Local).AddTicks(3719), new DateTime(2024, 2, 20, 16, 12, 1, 828, DateTimeKind.Utc).AddTicks(1352), "Heidi Crooks", 21, 1, 220661.911874347960000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 828, DateTimeKind.Utc).AddTicks(1351) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 4, 14, 6, 28, 53, 27, DateTimeKind.Local).AddTicks(5040), new DateTime(2024, 2, 20, 16, 12, 1, 828, DateTimeKind.Utc).AddTicks(2740), "Loren Heidenreich", 62, 3, 270105.32382035110000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 828, DateTimeKind.Utc).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 4, 18, 18, 54, 40, 655, DateTimeKind.Local).AddTicks(6221), new DateTime(2024, 2, 20, 16, 12, 1, 828, DateTimeKind.Utc).AddTicks(4040), "Jamie Kihn", 7, 3, 247819.023885787630000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 828, DateTimeKind.Utc).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 2, 13, 11, 29, 12, 984, DateTimeKind.Local).AddTicks(1444), new DateTime(2024, 2, 20, 16, 12, 1, 828, DateTimeKind.Utc).AddTicks(5733), "Estelle Rolfson", 33, 4, 143939.732475675880000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 828, DateTimeKind.Utc).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 3, 4, 12, 45, 40, 442, DateTimeKind.Local).AddTicks(3180), new DateTime(2024, 2, 20, 16, 12, 1, 828, DateTimeKind.Utc).AddTicks(7686), "Kenneth Braun", 9, 3, 217845.072664410220000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 828, DateTimeKind.Utc).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 10, 6, 10, 47, 8, 318, DateTimeKind.Local).AddTicks(4323), new DateTime(2024, 2, 20, 16, 12, 1, 828, DateTimeKind.Utc).AddTicks(8865), "Brett Anderson", 66, 1, 211397.413599731050000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 828, DateTimeKind.Utc).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1995, 11, 6, 18, 30, 50, 506, DateTimeKind.Local).AddTicks(1688), new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(290), "Phil Schaden", 33, 1, 322846.535893693750000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 11, 27, 4, 42, 14, 37, DateTimeKind.Local).AddTicks(9365), new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(2025), "Edna Little", 98, 1, 228003.165348737470000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 8, 29, 4, 46, 32, 179, DateTimeKind.Local).AddTicks(6616), new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(3448), "Lana Haley", 83, 4, 354891.294915295960000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 6, 14, 2, 6, 15, 11, DateTimeKind.Local).AddTicks(7510), new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(4428), "Ann Purdy", 67, 5, 29234.0957395504450000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 12, 5, 0, 16, 7, 906, DateTimeKind.Local).AddTicks(6524), new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(5447), "Leah Botsford", 42, 5, 206224.379412524320000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2001, 4, 22, 4, 54, 37, 5, DateTimeKind.Local).AddTicks(8566), new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(6330), "Vicki Deckow", 75, 4, 366887.130706089880000m, new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1977, 3, 3, 12, 47, 58, 26, DateTimeKind.Local).AddTicks(1457), new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(7454), "Dolores Kutch", 67, 2, 107535.187970639770000m, new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 4, 27, 10, 15, 51, 227, DateTimeKind.Local).AddTicks(7855), new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(8477), "Tanya Bernhard", 14, 4, 168375.708606190660000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 12, 16, 8, 39, 35, 865, DateTimeKind.Local).AddTicks(2233), new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(9358), "Santiago Bailey", 48, 5, 222342.559580331310000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1963, 10, 5, 9, 43, 24, 922, DateTimeKind.Local).AddTicks(8400), new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(715), "Amber Murphy", 92, 3, 365495.051262737620000m, new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 11, 12, 2, 25, 26, 712, DateTimeKind.Local).AddTicks(9558), new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(1857), "Bernice Nicolas", 44, 4, 325990.099895597140000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 3, 20, 0, 43, 10, 627, DateTimeKind.Local).AddTicks(5505), new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(2836), "Ashley Olson", 18, 3, 309992.832612899920000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 5, 14, 3, 22, 38, 169, DateTimeKind.Local).AddTicks(4204), new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(3747), "Natasha Raynor", 41, 257453.845869497020000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(3746) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1966, 1, 5, 18, 26, 34, 164, DateTimeKind.Local).AddTicks(7814), new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(4853), "Holly Moore", 65, 51715.015223188060000m, new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 7, 26, 3, 20, 17, 859, DateTimeKind.Local).AddTicks(7028), new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(6002), "Bennie Feest", 34, 1, 58183.860127456690000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 4, 5, 23, 56, 11, 67, DateTimeKind.Local).AddTicks(4919), new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(7073), "Darrell Grant", 25, 5, 314594.039937367960000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 7, 6, 4, 14, 59, 29, DateTimeKind.Local).AddTicks(843), new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(8043), "Ron Lockman", 18, 4, 266177.378464371520000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 4, 23, 15, 59, 54, 8, DateTimeKind.Local).AddTicks(7379), new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(8938), "Ira Smitham", 88, 3, 129257.101052678290000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 10, 7, 10, 15, 39, 175, DateTimeKind.Local).AddTicks(9183), new DateTime(2024, 2, 20, 16, 12, 1, 831, DateTimeKind.Utc).AddTicks(1906), "Guy Funk", 68, 10521.30066749466940000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 831, DateTimeKind.Utc).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 5, 23, 11, 8, 10, 227, DateTimeKind.Local).AddTicks(8415), new DateTime(2024, 2, 20, 16, 12, 1, 831, DateTimeKind.Utc).AddTicks(3471), "Stuart Mueller", 12, 323701.430251140880000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 831, DateTimeKind.Utc).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 7, 22, 12, 8, 58, 191, DateTimeKind.Local).AddTicks(737), new DateTime(2024, 2, 20, 16, 12, 1, 831, DateTimeKind.Utc).AddTicks(5331), "Jasmine Thompson", 31, 333363.177080958820000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 831, DateTimeKind.Utc).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 3, 30, 16, 19, 50, 707, DateTimeKind.Local).AddTicks(7692), new DateTime(2024, 2, 20, 16, 12, 1, 831, DateTimeKind.Utc).AddTicks(8585), "Roberto Hauck", 96, 4, 209820.406243567330000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 831, DateTimeKind.Utc).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 2, 22, 19, 53, 34, 106, DateTimeKind.Local).AddTicks(3540), new DateTime(2024, 2, 20, 16, 12, 1, 832, DateTimeKind.Utc).AddTicks(3563), "Joshua Kuhic", 92, 5, 321029.964676584010000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 832, DateTimeKind.Utc).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 11, 1, 7, 33, 30, 464, DateTimeKind.Local).AddTicks(9314), new DateTime(2024, 2, 20, 16, 12, 1, 832, DateTimeKind.Utc).AddTicks(7146), "Sherman Murphy", 31, 307128.197386546240000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 832, DateTimeKind.Utc).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1993, 6, 28, 15, 13, 28, 864, DateTimeKind.Local).AddTicks(7499), new DateTime(2024, 2, 20, 16, 12, 1, 833, DateTimeKind.Utc).AddTicks(452), "Carrie Skiles", 63, 2, 55106.442147371410000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 833, DateTimeKind.Utc).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 1, 29, 14, 36, 52, 824, DateTimeKind.Local).AddTicks(4028), new DateTime(2024, 2, 20, 16, 12, 1, 833, DateTimeKind.Utc).AddTicks(3461), "Cristina Heaney", 58, 1, 45572.1270512712130000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 833, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 7, 4, 12, 47, 40, 409, DateTimeKind.Local).AddTicks(8994), new DateTime(2024, 2, 20, 16, 12, 1, 833, DateTimeKind.Utc).AddTicks(6083), "Patti Larson", 5, 2, 325992.527427178420000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 833, DateTimeKind.Utc).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1971, 8, 22, 20, 22, 33, 803, DateTimeKind.Local).AddTicks(7690), new DateTime(2024, 2, 20, 16, 12, 1, 833, DateTimeKind.Utc).AddTicks(7123), "Pearl Willms", 82, 2, 369698.373292315720000m, new DateTime(2024, 2, 20, 16, 12, 1, 833, DateTimeKind.Utc).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 7, 4, 4, 9, 14, 698, DateTimeKind.Local).AddTicks(585), new DateTime(2024, 2, 20, 16, 12, 1, 833, DateTimeKind.Utc).AddTicks(7940), "Kerry Kuphal", 27, 2, 394732.173359703910000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 833, DateTimeKind.Utc).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 12, 25, 5, 21, 9, 435, DateTimeKind.Local).AddTicks(9262), new DateTime(2024, 2, 20, 16, 12, 1, 833, DateTimeKind.Utc).AddTicks(8708), "Norma Reynolds", 75, 2, 56039.011303643410000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 833, DateTimeKind.Utc).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 8, 22, 15, 30, 36, 297, DateTimeKind.Local).AddTicks(2370), new DateTime(2024, 2, 20, 16, 12, 1, 833, DateTimeKind.Utc).AddTicks(9927), "Arlene Turner", 80, 2, 258509.261043988360000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 833, DateTimeKind.Utc).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 3, 24, 1, 44, 17, 348, DateTimeKind.Local).AddTicks(1004), new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(1036), "Lynn Mayer", 32, 5, 20932.8200242117480000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 1, 18, 8, 9, 28, 725, DateTimeKind.Local).AddTicks(7247), new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(2271), "Freddie Ratke", 54, 3, 167179.233121861990000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 3, 29, 3, 2, 7, 879, DateTimeKind.Local).AddTicks(5353), new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(3274), "Miriam Carroll", 50, 26736.6529375787560000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 9, 4, 18, 13, 56, 941, DateTimeKind.Local).AddTicks(1451), new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(4165), "Winston Lehner", 49, 2, 45863.1136010767360000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 6, 27, 21, 5, 4, 601, DateTimeKind.Local).AddTicks(173), new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(4980), "Julia Stark", 82, 3, 394943.605895543110000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2000, 9, 20, 10, 2, 17, 253, DateTimeKind.Local).AddTicks(4038), new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(5745), "Lynne Schuster", 35, 280620.29896457140000m, new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 12, 5, 9, 42, 46, 518, DateTimeKind.Local).AddTicks(8027), new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(6726), "Genevieve Crist", 15, 3, 11781.78494629352620000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1992, 11, 12, 1, 58, 1, 788, DateTimeKind.Local).AddTicks(607), new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(8013), "Tomas Wyman", 2, 3, 343474.40280905140000m, new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 7, 17, 10, 25, 47, 371, DateTimeKind.Local).AddTicks(6908), new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(9190), "Rachael Koelpin", 35, 5, 375801.861482049070000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 6, 11, 0, 29, 0, 581, DateTimeKind.Local).AddTicks(7514), new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(68), "Austin Braun", 92, 5, 144953.563595924320000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 8, 16, 0, 16, 7, 473, DateTimeKind.Local).AddTicks(9093), new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(1329), "Dustin Heidenreich", 88, 5, 227149.007028169060000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 3, 7, 2, 56, 59, 341, DateTimeKind.Local).AddTicks(2881), new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(2449), "Jose Blanda", 48, 116764.328145922330000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 12, 28, 11, 46, 5, 650, DateTimeKind.Local).AddTicks(4560), new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(3242), "Julia Zemlak", 8, 250728.838072034260000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 12, 9, 16, 34, 43, 539, DateTimeKind.Local).AddTicks(8843), new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(5629), "Lula Jacobson", 47, 1, 77214.465891760720000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 3, 3, 4, 33, 25, 307, DateTimeKind.Local).AddTicks(3102), new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(7167), "Santos Jones", 55, 3, 276517.600696831120000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 11, 6, 12, 9, 57, 912, DateTimeKind.Local).AddTicks(5711), new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(8022), "Ron Kuvalis", 18, 1, 237632.431757347240000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 7, 13, 5, 52, 33, 124, DateTimeKind.Local).AddTicks(5543), new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(8787), "George Conroy", 45, 271499.336887424740000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 5, 20, 12, 41, 9, 136, DateTimeKind.Local).AddTicks(8938), new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(9690), "Naomi Bauch", 85, 4, 299544.76673935540000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 10, 27, 7, 46, 23, 458, DateTimeKind.Local).AddTicks(7512), new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(421), "Bert Conroy", 24, 122233.017902425420000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 6, 30, 19, 16, 7, 808, DateTimeKind.Local).AddTicks(6289), new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(1180), "Wilson Bauch", 15, 2, 104103.406001179510000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(1179) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 11, 7, 16, 59, 52, 212, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(1863), "Tanya Gerhold", 100, 2, 157215.80238460420000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 5, 21, 9, 9, 27, 983, DateTimeKind.Local).AddTicks(690), new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(3037), "Sean Fritsch", 61, 5, 393005.010633640720000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 1, 8, 21, 4, 23, 712, DateTimeKind.Local).AddTicks(8315), new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(4135), "Winifred Kautzer", 5, 1, 162343.153790472190000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 7, 10, 4, 16, 53, 179, DateTimeKind.Local).AddTicks(3807), new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(5230), "Cary Wintheiser", 35, 1, 341774.731927988440000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 8, 1, 21, 38, 26, 900, DateTimeKind.Local).AddTicks(1126), new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(5995), "Warren Kris", 73, 5, 100374.304286413420000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 1, 1, 15, 19, 12, 645, DateTimeKind.Local).AddTicks(5572), new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(6762), "Maryann Tromp", 10, 2, 53355.924401062390000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 9, 14, 21, 59, 6, 426, DateTimeKind.Local).AddTicks(4133), new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(7438), "Terence Cruickshank", 26, 1, 172938.912304072060000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 12, 2, 10, 50, 41, 172, DateTimeKind.Local).AddTicks(8538), new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(8182), "Ross Williamson", 16, 289610.365293463360000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 6, 7, 1, 6, 26, 938, DateTimeKind.Local).AddTicks(9785), new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(8958), "Shelley Towne", 58, 2, 300756.438342049420000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 12, 18, 2, 46, 22, 300, DateTimeKind.Local).AddTicks(5989), new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(9684), "Jeremy Hoeger", 73, 1, 235033.575623732590000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 6, 28, 14, 53, 27, 973, DateTimeKind.Local).AddTicks(2678), new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(313), "Noel Treutel", 54, 370783.753713839170000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1984, 6, 29, 13, 53, 19, 329, DateTimeKind.Local).AddTicks(7486), new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(1067), "Jessie Gislason", 57, 307246.598274414490000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1964, 1, 16, 20, 53, 7, 218, DateTimeKind.Local).AddTicks(702), new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(2256), "Alison Bruen", 40, 3, 132062.581257782230000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 10, 31, 9, 24, 29, 771, DateTimeKind.Local).AddTicks(9308), new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(3277), "Carrie Marks", 30, 5, 124412.687571998140000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 11, 1, 10, 2, 49, 518, DateTimeKind.Local).AddTicks(2213), new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(4060), "Lucille Grimes", 52, 2, 44659.2687973828270000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 7, 22, 11, 11, 3, 605, DateTimeKind.Local).AddTicks(1174), new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(4809), "Garry Barton", 98, 4, 284827.818186124060000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 7, 30, 17, 6, 56, 219, DateTimeKind.Local).AddTicks(5734), new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(5604), "Juana Stark", 4, 1, 40070.9124999387910000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 1, 14, 8, 47, 59, 4, DateTimeKind.Local).AddTicks(521), new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(6313), "Florence Willms", 34, 5, 29603.7895883474710000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1995, 4, 28, 4, 9, 20, 267, DateTimeKind.Local).AddTicks(6009), new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(7093), "Hazel Mann", 51, 219728.354092463830000m, new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 2, 18, 19, 7, 12, 458, DateTimeKind.Local).AddTicks(7527), new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(7810), "Jacqueline Kuhn", 60, 1, 351775.378456891990000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1964, 3, 8, 10, 57, 23, 338, DateTimeKind.Local).AddTicks(4750), new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(8585), "Jean Satterfield", 9, 5, 114172.743796150510000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1993, 8, 2, 18, 27, 3, 773, DateTimeKind.Local).AddTicks(9176), new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(9325), "Jody Purdy", 58, 1, 355322.378056280950000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 11, 26, 11, 59, 51, 164, DateTimeKind.Local).AddTicks(2043), new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(139), "Kent Fisher", 69, 296836.776538077610000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1961, 7, 4, 10, 39, 18, 45, DateTimeKind.Local).AddTicks(1024), new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(891), "Warren Feil", 70, 252650.303372261980000m, new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 12, 14, 15, 21, 27, 739, DateTimeKind.Local).AddTicks(6183), new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(2182), "Harriet Kreiger", 89, 4, 122350.000668733360000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 1, 12, 12, 38, 15, 626, DateTimeKind.Local).AddTicks(2266), new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(3103), "Ronnie Heller", 3, 5, 144884.911465496920000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 4, 1, 14, 22, 12, 897, DateTimeKind.Local).AddTicks(6663), new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(3912), "Ruth McClure", 72, 2, 321787.574194293340000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 3, 27, 10, 11, 21, 633, DateTimeKind.Local).AddTicks(9937), new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(4809), "Darrel Dietrich", 46, 3, 376025.447748088570000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 9, 7, 8, 44, 15, 954, DateTimeKind.Local).AddTicks(3817), new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(5607), "Winston Mayer", 48, 2, 259401.308876322460000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2000, 12, 9, 13, 52, 54, 10, DateTimeKind.Local).AddTicks(1749), new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(6365), "Krista Renner", 48, 5, 97830.540853664440000m, new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 10, 30, 3, 7, 15, 75, DateTimeKind.Local).AddTicks(225), new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(7172), "Mark Lakin", 14, 3, 137082.426553747210000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 9, 27, 20, 58, 44, 810, DateTimeKind.Local).AddTicks(1945), new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(7855), "Marilyn Greenholt", 56, 2, 42894.7289624291650000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 5, 21, 1, 0, 7, 995, DateTimeKind.Local).AddTicks(8127), new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(8619), "Kari Okuneva", 45, 5, 351835.147382758510000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 9, 12, 20, 10, 30, 610, DateTimeKind.Local).AddTicks(8498), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(438), "Yolanda Hauck", 1, 262030.486977767290000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 2, 3, 4, 17, 42, 753, DateTimeKind.Local).AddTicks(7208), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(1860), "Hector Feil", 95, 3, 180711.525200263840000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 8, 1, 11, 15, 22, 889, DateTimeKind.Local).AddTicks(7892), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(2712), "Ronald Lehner", 8, 2, 237085.898410155070000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1971, 7, 26, 10, 51, 37, 190, DateTimeKind.Local).AddTicks(1794), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(3570), "Samantha Considine", 51, 5, 105831.188018924020000m, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1955, 9, 30, 13, 56, 4, 943, DateTimeKind.Local).AddTicks(4883), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(4416), "Mindy Kub", 80, 1, 192212.945437717870000m, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 10, 7, 3, 39, 40, 482, DateTimeKind.Local).AddTicks(3803), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(5139), "Philip Streich", 65, 4, 236341.647977745040000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 7, 26, 0, 4, 2, 265, DateTimeKind.Local).AddTicks(1843), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(5920), "Woodrow O'Keefe", 14, 261878.827567112590000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1954, 8, 17, 16, 5, 31, 567, DateTimeKind.Local).AddTicks(8372), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(6778), "Eduardo Bergnaum", 44, 5, 384389.095327388830000m, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2003, 3, 23, 13, 25, 10, 412, DateTimeKind.Local).AddTicks(5132), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(7566), "Harriet Boyle", 89, 3, 173425.158041902120000m, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1966, 11, 9, 22, 8, 24, 298, DateTimeKind.Local).AddTicks(6720), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(8248), "Jana O'Reilly", 66, 5, 275527.521345549580000m, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1986, 4, 26, 19, 23, 14, 781, DateTimeKind.Local).AddTicks(1180), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(9060), "Shirley Fisher", 88, 2, 221479.677414881980000m, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 6, 1, 14, 51, 32, 390, DateTimeKind.Local).AddTicks(4537), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(9871), "Jordan Wyman", 21, 2, 237345.647296342510000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Birthdate", "CreateDate", "Name", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1995, 9, 22, 14, 12, 18, 887, DateTimeKind.Local).AddTicks(583), new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(1223), "Emily Little", 2, 47413.58873689450000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1996, 2, 7, 9, 14, 25, 926, DateTimeKind.Local).AddTicks(6680), new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(1998), "Linda Douglas", 7, 1, 54830.119116029650000m, new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 5, 24, 20, 55, 14, 455, DateTimeKind.Local).AddTicks(4937), new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(2853), "Javier Hoeger", 7, 1, 149228.507334995650000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 6, 26, 20, 47, 33, 535, DateTimeKind.Local).AddTicks(5114), new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(3670), "Angie Greenholt", 31, 2, 23233.3910557689490000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 2, 26, 23, 53, 15, 710, DateTimeKind.Local).AddTicks(8358), new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(4427), "Janie Murphy", 75, 1, 60879.343201064170000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 10, 29, 14, 53, 55, 600, DateTimeKind.Local).AddTicks(3242), new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(5251), "Cristina Romaguera", 1, 5, 57252.319621909870000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2003, 2, 12, 20, 4, 54, 166, DateTimeKind.Local).AddTicks(4478), new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(6082), "Bob Mohr", 25, 1, 73815.588469848670000m, new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 6, 15, 0, 42, 20, 526, DateTimeKind.Local).AddTicks(8282), new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(6804), "Marion Ritchie", 74, 5, 16022.0106158453410000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 9, 19, 17, 23, 16, 488, DateTimeKind.Local).AddTicks(1156), new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(7715), "Emily McDermott", 36, 3, 113243.503907777350000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 2, 22, 12, 16, 30, 188, DateTimeKind.Local).AddTicks(6696), new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(8462), "Sylvia Huel", 94, 2, 258299.638917585580000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(8462) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 1, 5, 0, 7, 28, 502, DateTimeKind.Local).AddTicks(4074), new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(9276), "Cedric Fay", 24, 34819.4152446182020000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 3, 10, 17, 4, 5, 242, DateTimeKind.Local).AddTicks(8179), new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(647), "Elaine Schaefer", 5, 1, 109542.904610884930000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 2, 3, 10, 18, 17, 484, DateTimeKind.Local).AddTicks(5475), new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(1596), "Sarah Schaefer", 18, 139847.593199902630000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 2, 1, 13, 57, 16, 905, DateTimeKind.Local).AddTicks(4196), new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(2441), "Natalie Schimmel", 28, 3, 109197.029980283560000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 2, 9, 16, 55, 59, 447, DateTimeKind.Local).AddTicks(5926), new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(3296), "Mae Watsica", 86, 5, 255081.602435179510000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 5, 6, 17, 36, 43, 190, DateTimeKind.Local).AddTicks(5985), new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(4096), "Kurt Becker", 98, 4, 174879.71685758560000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 7, 12, 9, 1, 49, 85, DateTimeKind.Local).AddTicks(8047), new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(4866), "Suzanne Barrows", 7, 2, 257495.379345271330000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1959, 1, 22, 17, 58, 12, 103, DateTimeKind.Local).AddTicks(127), new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(5643), "Neil Torp", 5, 5, 356404.94205430750000m, new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 6, 28, 21, 36, 38, 964, DateTimeKind.Local).AddTicks(8896), new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(6428), "Hector Crooks", 39, 5, 177612.559967671780000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 5, 18, 13, 50, 51, 202, DateTimeKind.Local).AddTicks(7084), new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(7228), "Claude Heathcote", 94, 360806.839198530520000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 3, 9, 17, 34, 18, 970, DateTimeKind.Local).AddTicks(6211), new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(7992), "Clyde Fahey", 29, 73049.267940580870000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1988, 6, 24, 13, 46, 41, 822, DateTimeKind.Local).AddTicks(606), new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(8746), "Toby Feest", 94, 5, 143093.446576990120000m, new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 1, 17, 21, 11, 25, 486, DateTimeKind.Local).AddTicks(3182), new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(70), "Rebecca Ondricka", 100, 1, 275796.862300639540000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1958, 7, 9, 17, 29, 18, 997, DateTimeKind.Local).AddTicks(9933), new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(1131), "Freda Wolf", 68, 4, 271512.523682801950000m, new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 6, 8, 9, 30, 31, 348, DateTimeKind.Local).AddTicks(2067), new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(2018), "Sharon McLaughlin", 3, 118413.292428654850000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 9, 4, 3, 48, 16, 396, DateTimeKind.Local).AddTicks(9606), new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(3182), "Maxine Grady", 58, 4, 159906.383491362550000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 2, 10, 18, 23, 40, 954, DateTimeKind.Local).AddTicks(6974), new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(4277), "Betsy Wiza", 21, 4, 276541.4541586030000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 7, 22, 23, 11, 48, 379, DateTimeKind.Local).AddTicks(1649), new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(5351), "Mike Price", 21, 2, 391163.15457097540000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 8, 10, 11, 19, 21, 138, DateTimeKind.Local).AddTicks(9365), new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(6564), "Kyle Crist", 99, 5, 247650.624129177610000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 8, 22, 1, 27, 46, 11, DateTimeKind.Local).AddTicks(1642), new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(7616), "Julian Langworth", 20, 5, 187163.147124852460000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 10, 17, 5, 33, 32, 732, DateTimeKind.Local).AddTicks(2517), new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(9172), "Keith Quitzon", 76, 4, 145115.514102424570000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 7, 22, 17, 45, 22, 470, DateTimeKind.Local).AddTicks(5797), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(688), "Roosevelt Barrows", 96, 282528.083542573690000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 7, 22, 22, 43, 1, 780, DateTimeKind.Local).AddTicks(7431), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(1608), "Jaime Jacobs", 14, 172951.780751203210000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 1, 30, 4, 32, 26, 603, DateTimeKind.Local).AddTicks(5198), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(2414), "Mark Ankunding", 86, 173279.766303982510000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 9, 3, 2, 54, 3, 187, DateTimeKind.Local).AddTicks(36), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(3180), "Ellen Legros", 83, 2, 111531.218435291320000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 5, 12, 0, 1, 5, 540, DateTimeKind.Local).AddTicks(7135), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(3864), "Adrienne Hintz", 96, 123784.096201297210000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 7, 4, 15, 13, 41, 627, DateTimeKind.Local).AddTicks(7324), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(4606), "Abel Pacocha", 50, 3, 268507.607600856640000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1994, 11, 4, 23, 5, 6, 823, DateTimeKind.Local).AddTicks(3559), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(5319), "Ella Kautzer", 85, 89547.532101226540000m, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1980, 11, 19, 0, 4, 28, 506, DateTimeKind.Local).AddTicks(6544), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(5956), "Kellie Heaney", 28, 4, 390315.030080352250000m, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 1, 19, 22, 15, 40, 739, DateTimeKind.Local).AddTicks(7086), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(6713), "Levi Dare", 73, 193407.016465136620000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 4, 5, 2, 16, 42, 492, DateTimeKind.Local).AddTicks(3463), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(7406), "Brad Casper", 78, 5, 150151.463451959440000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 1, 15, 5, 55, 30, 15, DateTimeKind.Local).AddTicks(8496), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(8081), "Jermaine Stiedemann", 46, 4, 378249.709425444730000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1997, 6, 10, 18, 56, 58, 204, DateTimeKind.Local).AddTicks(3208), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(9455), "Roxanne O'Hara", 6, 2, 353637.682681821580000m, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 10, 3, 18, 49, 34, 287, DateTimeKind.Local).AddTicks(6991), new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(406), "Dan Murazik", 95, 2, 392734.593744576970000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 7, 20, 20, 50, 13, 988, DateTimeKind.Local).AddTicks(3396), new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(1190), "Joanna Kuhlman", 20, 5, 36677.7854372230630000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(1190) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1987, 9, 17, 17, 29, 44, 208, DateTimeKind.Local).AddTicks(1709), new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(1960), "Paul Koss", 84, 5, 356263.925576476570000m, new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 4, 25, 13, 44, 24, 0, DateTimeKind.Local).AddTicks(110), new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(2672), "Irving Gerhold", 88, 4, 196229.969122871050000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 6, 29, 4, 9, 59, 441, DateTimeKind.Local).AddTicks(34), new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(3418), "Audrey Bartoletti", 63, 1, 83502.324047496370000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 2, 25, 19, 52, 3, 45, DateTimeKind.Local).AddTicks(2545), new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(4163), "Sonya Wilderman", 29, 1, 165885.636805132780000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Birthdate", "CreateDate", "Name", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1990, 9, 22, 13, 10, 5, 162, DateTimeKind.Local).AddTicks(452), new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(4942), "Walter Nolan", 2, 250937.218183350520000m, new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 3, 18, 21, 13, 29, 698, DateTimeKind.Local).AddTicks(2574), new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(5708), "Dora Ullrich", 35, 285578.079056896720000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 11, 15, 5, 33, 8, 813, DateTimeKind.Local).AddTicks(4949), new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(6550), "Audrey Torp", 5, 33086.4356621454010000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 10, 3, 1, 2, 19, 254, DateTimeKind.Local).AddTicks(1257), new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(7393), "Forrest Fritsch", 3, 5, 206226.084052633960000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 2, 7, 21, 34, 55, 367, DateTimeKind.Local).AddTicks(4247), new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(8731), "Vickie Ward", 84, 4, 105322.143446604880000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 5, 5, 0, 35, 43, 714, DateTimeKind.Local).AddTicks(6762), new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(9697), "Pamela Schimmel", 47, 5, 355687.29401142430000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1971, 4, 2, 6, 30, 39, 495, DateTimeKind.Local).AddTicks(7521), new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(598), "Angie Flatley", 51, 5, 263316.193038978940000m, new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 11, 11, 21, 8, 38, 586, DateTimeKind.Local).AddTicks(3711), new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(1366), "Ebony King", 37, 2, 151158.105026967730000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 3, 15, 3, 21, 45, 139, DateTimeKind.Local).AddTicks(8669), new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(2117), "Luis Heller", 33, 5, 295546.913118698530000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1982, 2, 19, 3, 59, 25, 313, DateTimeKind.Local).AddTicks(3832), new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(2877), "Joseph Jacobson", 68, 4, 313076.688764975710000m, new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 5, 31, 2, 45, 46, 735, DateTimeKind.Local).AddTicks(3202), new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(3665), "Dwayne Romaguera", 57, 3, 305634.493372092940000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 7, 15, 6, 17, 31, 123, DateTimeKind.Local).AddTicks(9228), new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(4463), "Ebony Lebsack", 88, 2, 245320.644649044760000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 3, 23, 18, 10, 8, 584, DateTimeKind.Local).AddTicks(9716), new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(5359), "Kristen Champlin", 49, 231059.38084475830000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 5, 2, 13, 55, 55, 90, DateTimeKind.Local).AddTicks(7882), new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(6281), "Sam Lebsack", 13, 2, 362192.925502640560000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 7, 29, 1, 0, 18, 389, DateTimeKind.Local).AddTicks(5259), new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(7081), "Kendra Legros", 63, 4, 285264.668519981530000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 10, 1, 14, 10, 5, 968, DateTimeKind.Local).AddTicks(4735), new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(8669), "Billy D'Amore", 50, 170803.979574163510000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 9, 2, 8, 48, 59, 722, DateTimeKind.Local).AddTicks(3405), new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(9970), "Kristin Mueller", 85, 277720.263505613620000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 9, 10, 1, 29, 42, 432, DateTimeKind.Local).AddTicks(2484), new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(743), "Troy Rath", 71, 194665.306864818130000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 4, 21, 8, 51, 45, 588, DateTimeKind.Local).AddTicks(4801), new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(1534), "Ruben Hoeger", 50, 1, 289666.656530284660000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 4, 18, 10, 7, 15, 673, DateTimeKind.Local).AddTicks(4915), new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(2381), "Loretta Marvin", 21, 1, 239497.131104695480000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 3, 13, 21, 24, 18, 238, DateTimeKind.Local).AddTicks(9052), new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(3313), "Perry Stoltenberg", 31, 1, 358791.031783406290000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 1, 30, 12, 41, 34, 867, DateTimeKind.Local).AddTicks(8886), new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(5996), "Tracy Reinger", 62, 211092.733833262570000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 8, 5, 20, 20, 2, 24, DateTimeKind.Local).AddTicks(8569), new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(7709), "Shelly McCullough", 37, 3, 64964.61185312890000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 12, 11, 23, 53, 49, 107, DateTimeKind.Local).AddTicks(3076), new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(8936), "Tami Boyle", 20, 3, 121262.719060920310000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Birthdate", "CreateDate", "Name", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 5, 8, 20, 27, 12, 727, DateTimeKind.Local).AddTicks(4844), new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(9664), "Amber Dietrich", 4, 354840.700718575360000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1981, 5, 29, 1, 48, 30, 456, DateTimeKind.Local).AddTicks(8633), new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(545), "Bernadette Mayert", 9, 112700.68516066840000m, new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 6, 9, 23, 12, 53, 313, DateTimeKind.Local).AddTicks(1885), new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(1513), "Rochelle DuBuque", 81, 1, 108184.103679021880000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1958, 2, 15, 20, 34, 30, 419, DateTimeKind.Local).AddTicks(5473), new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(2314), "Candice Spencer", 49, 2, 289268.219568692380000m, new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 2, 3, 7, 19, 40, 400, DateTimeKind.Local).AddTicks(9601), new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(2983), "Ora Rutherford", 73, 1, 374072.453871858160000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 2, 7, 5, 57, 0, 225, DateTimeKind.Local).AddTicks(2435), new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(3792), "Carolyn Stehr", 55, 4, 30271.0820056140760000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 9, 19, 14, 20, 35, 929, DateTimeKind.Local).AddTicks(4053), new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(4592), "Felix Osinski", 77, 4, 371432.813474918380000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 4, 5, 13, 44, 33, 103, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(5356), "Cynthia Will", 53, 206353.091510539990000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 10, 2, 12, 2, 59, 247, DateTimeKind.Local).AddTicks(697), new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(6105), "Monique Fritsch", 77, 2, 36719.6051661518590000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 8, 26, 13, 12, 51, 665, DateTimeKind.Local).AddTicks(1985), new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(7404), "Maxine Douglas", 93, 3, 364410.034965132640000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 8, 10, 5, 36, 53, 194, DateTimeKind.Local).AddTicks(8241), new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(8653), "Sergio Daugherty", 74, 5, 362856.358395040240000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2002, 8, 30, 15, 50, 10, 41, DateTimeKind.Local).AddTicks(5532), new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(9531), "Phil Funk", 95, 1, 249979.192428553630000m, new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 11, 4, 9, 41, 51, 830, DateTimeKind.Local).AddTicks(8908), new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(257), "Johnnie Kunde", 41, 1, 328445.604174450220000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 9, 12, 5, 47, 54, 672, DateTimeKind.Local).AddTicks(7569), new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(3961), "Juana Emmerich", 83, 3, 15066.2058463348540000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1954, 7, 7, 11, 22, 59, 723, DateTimeKind.Local).AddTicks(3817), new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(5294), "Al Rath", 15, 5, 116540.963418733480000m, new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1963, 11, 2, 19, 54, 25, 168, DateTimeKind.Local).AddTicks(4300), new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(6032), "Santos Keebler", 71, 4, 82363.947767860450000m, new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 6, 10, 8, 38, 11, 669, DateTimeKind.Local).AddTicks(5173), new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(6812), "Wm Gulgowski", 83, 3, 129781.942408646440000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 1, 6, 3, 30, 59, 946, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(8097), "Dominic Gutmann", 40, 3, 37927.7239952867260000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 3, 19, 9, 22, 47, 496, DateTimeKind.Local).AddTicks(4523), new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(8994), "Kendra Stracke", 66, 19146.8919491233570000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 4, 4, 22, 37, 35, 692, DateTimeKind.Local).AddTicks(2375), new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(52), "Jacqueline O'Keefe", 19, 3, 63579.53559704980000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 1, 20, 22, 22, 12, 253, DateTimeKind.Local).AddTicks(8809), new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(1408), "Gregg Howell", 72, 3, 265732.3520419720000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1982, 4, 5, 22, 37, 22, 170, DateTimeKind.Local).AddTicks(272), new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(2483), "Mindy Grady", 90, 4, 339848.30235465550000m, new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1973, 11, 7, 19, 33, 35, 319, DateTimeKind.Local).AddTicks(5669), new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(3813), "Clayton Stroman", 100, 3, 339605.986794127810000m, new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 11, 3, 19, 13, 10, 794, DateTimeKind.Local).AddTicks(5530), new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(5092), "Clark O'Kon", 85, 1, 340034.276018697250000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 4, 1, 0, 50, 5, 331, DateTimeKind.Local).AddTicks(2834), new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(6406), "Victoria Kuhlman", 54, 3, 33885.3594291834340000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(6405) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 12, 21, 5, 53, 32, 909, DateTimeKind.Local).AddTicks(1430), new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(8556), "Dwayne Rau", 13, 4, 362887.718301191320000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(8555) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2001, 4, 17, 5, 31, 9, 871, DateTimeKind.Local).AddTicks(9540), new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(149), "Natalie Miller", 30, 3, 393362.87087603830000m, new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2000, 5, 5, 16, 24, 54, 180, DateTimeKind.Local).AddTicks(6318), new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(1467), "Peter Hane", 84, 1, 326781.151493271790000m, new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 3, 23, 19, 27, 6, 326, DateTimeKind.Local).AddTicks(3233), new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(2619), "Rufus Russel", 17, 3, 334157.790296219620000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 11, 6, 8, 7, 41, 57, DateTimeKind.Local).AddTicks(1760), new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(3847), "Courtney Schuster", 90, 1, 291796.390065952840000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1955, 1, 14, 12, 0, 58, 129, DateTimeKind.Local).AddTicks(8974), new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(5079), "Victoria O'Keefe", 66, 324057.885233153620000m, new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 11, 6, 16, 16, 23, 805, DateTimeKind.Local).AddTicks(6415), new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(6860), "Anne Satterfield", 88, 1, 12901.252732375660000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 7, 3, 12, 47, 57, 850, DateTimeKind.Local).AddTicks(1454), new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(8403), "Lorraine Kutch", 55, 1, 322140.667084059190000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 11, 12, 23, 54, 39, 957, DateTimeKind.Local).AddTicks(1385), new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(9665), "Sylvia Emard", 86, 379201.819200479980000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 1, 18, 20, 0, 36, 321, DateTimeKind.Local).AddTicks(5219), new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(838), "Yolanda Ruecker", 56, 44861.1456544098280000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1964, 2, 2, 4, 2, 10, 173, DateTimeKind.Local).AddTicks(9309), new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(2077), "Raymond Ledner", 3, 2, 97103.846258437060000m, new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 7, 3, 14, 38, 58, 663, DateTimeKind.Local).AddTicks(731), new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(3313), "Peggy Doyle", 31, 1, 180578.018176508020000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 12, 19, 10, 23, 36, 505, DateTimeKind.Local).AddTicks(8939), new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(4453), "Kristen Rempel", 8, 1, 179390.595588624280000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 3, 26, 12, 52, 1, 808, DateTimeKind.Local).AddTicks(8982), new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(6379), "Natalie Kuvalis", 74, 5, 323969.299078913140000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 1, 12, 23, 3, 4, 648, DateTimeKind.Local).AddTicks(6857), new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(7738), "Rosemarie Hudson", 50, 4, 107033.004917386720000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1973, 8, 3, 20, 50, 45, 860, DateTimeKind.Local).AddTicks(3221), new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(8749), "Jacqueline O'Hara", 40, 1, 283468.307925595120000m, new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1956, 4, 19, 7, 17, 10, 387, DateTimeKind.Local).AddTicks(9505), new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(9676), "Miranda Torphy", 97, 2, 69527.698185828730000m, new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 11, 27, 16, 24, 5, 543, DateTimeKind.Local).AddTicks(7732), new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(468), "Andy Pouros", 94, 5, 229618.141217151820000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1976, 7, 1, 4, 17, 53, 485, DateTimeKind.Local).AddTicks(6551), new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(1192), "Arlene Wyman", 53, 2, 297840.919296885760000m, new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(1191) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 5, 30, 19, 23, 2, 163, DateTimeKind.Local).AddTicks(2247), new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(1943), "Laura Altenwerth", 16, 5, 71635.834014947140000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 3, 13, 14, 38, 29, 207, DateTimeKind.Local).AddTicks(7025), new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(2727), "Miriam Dietrich", 83, 2, 367822.379449973620000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 9, 26, 23, 42, 25, 324, DateTimeKind.Local).AddTicks(3966), new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(3487), "Anne Hilpert", 27, 4, 347883.449895224740000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1969, 2, 8, 13, 38, 26, 652, DateTimeKind.Local).AddTicks(730), new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(4561), "Jackie Marks", 84, 5, 67150.607135574550000m, new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 11, 1, 9, 24, 27, 481, DateTimeKind.Local).AddTicks(2477), new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(5643), "Gordon Kirlin", 60, 2, 349902.814233578440000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 6, 1, 8, 35, 28, 281, DateTimeKind.Local).AddTicks(8391), new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(6571), "Melanie Yundt", 44, 4, 203406.792944638390000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1975, 10, 15, 10, 59, 15, 284, DateTimeKind.Local).AddTicks(1085), new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(7333), "Mildred Wisoky", 74, 53630.804091740710000m, new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 1, 12, 20, 33, 4, 189, DateTimeKind.Local).AddTicks(9390), new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(8063), "Dallas Cronin", 89, 2, 136743.002271889510000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 9, 20, 16, 47, 7, 599, DateTimeKind.Local).AddTicks(1371), new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(8859), "Drew Beahan", 99, 1, 232126.576512133150000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 6, 23, 13, 19, 53, 660, DateTimeKind.Local).AddTicks(7824), new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(9593), "Lewis Hoppe", 83, 5, 142045.987546248490000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 3, 6, 6, 17, 7, 227, DateTimeKind.Local).AddTicks(4179), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(343), "Kelly Schumm", 32, 206461.296378775090000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 1, 30, 19, 26, 22, 546, DateTimeKind.Local).AddTicks(572), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(1114), "Shawna Connelly", 61, 4, 115326.176074093390000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1966, 12, 29, 5, 47, 9, 931, DateTimeKind.Local).AddTicks(4872), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(1785), "Jean Koepp", 92, 399327.823721878990000m, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 7, 10, 0, 53, 2, 761, DateTimeKind.Local).AddTicks(5449), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(2502), "Pauline Schaden", 91, 3, 378547.722617006140000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 4, 16, 13, 6, 47, 751, DateTimeKind.Local).AddTicks(5643), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(3281), "Ruby Corwin", 70, 5, 42995.532231826450000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 8, 20, 22, 24, 25, 698, DateTimeKind.Local).AddTicks(8337), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(4383), "Debbie Corkery", 28, 5, 129642.647632294930000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 5, 14, 5, 31, 46, 109, DateTimeKind.Local).AddTicks(8738), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(5424), "Winifred Kessler", 76, 3, 345085.058016115030000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 5, 26, 5, 8, 44, 956, DateTimeKind.Local).AddTicks(7969), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(6323), "Carrie Gulgowski", 89, 2, 174631.04590175620000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1981, 2, 9, 10, 24, 57, 577, DateTimeKind.Local).AddTicks(6441), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(7153), "Archie Ryan", 90, 3, 66970.134386009260000m, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1984, 6, 8, 7, 3, 39, 854, DateTimeKind.Local).AddTicks(8397), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(7929), "Kenny Russel", 7, 5, 348090.786762023620000m, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1976, 6, 23, 12, 14, 4, 410, DateTimeKind.Local).AddTicks(2680), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(8678), "Elias Olson", 91, 265510.292297901940000m, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1986, 7, 2, 5, 51, 46, 23, DateTimeKind.Local).AddTicks(2147), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(9449), "Celia Herman", 41, 3, 161407.38942905680000m, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 11, 20, 4, 3, 4, 800, DateTimeKind.Local).AddTicks(3168), new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(224), "Nathaniel Hoeger", 32, 4, 53566.845064740790000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 8, 15, 12, 17, 5, 496, DateTimeKind.Local).AddTicks(4887), new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(990), "Vicky Skiles", 18, 214169.248512846760000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 2, 22, 5, 14, 48, 776, DateTimeKind.Local).AddTicks(3518), new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(1738), "Robyn Ryan", 100, 3, 352652.325502925230000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 12, 24, 16, 24, 58, 752, DateTimeKind.Local).AddTicks(9570), new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(2464), "Don Kub", 55, 342887.701133384410000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 5, 16, 19, 40, 22, 173, DateTimeKind.Local).AddTicks(4308), new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(3105), "Kerry Towne", 6, 1, 299748.169892542660000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1975, 12, 21, 7, 5, 22, 592, DateTimeKind.Local).AddTicks(3412), new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(4418), "Sonja Paucek", 84, 2, 171915.792923770990000m, new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(4418) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 7, 10, 4, 4, 11, 319, DateTimeKind.Local).AddTicks(951), new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(5288), "Ron Dicki", 72, 3, 161531.270271578860000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1997, 5, 8, 13, 49, 20, 479, DateTimeKind.Local).AddTicks(6574), new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(6046), "Laura Baumbach", 76, 2, 260052.408286665790000m, new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 7, 30, 9, 29, 10, 783, DateTimeKind.Local).AddTicks(361), new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(6795), "Jennifer Schroeder", 49, 3, 378914.563757056720000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 7, 10, 2, 1, 32, 174, DateTimeKind.Local).AddTicks(6379), new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(7579), "Geoffrey Kling", 6, 1, 352721.192945305720000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Birthdate", "CreateDate", "Name", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 11, 15, 23, 2, 36, 667, DateTimeKind.Local).AddTicks(5236), new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(8259), "Elena Daugherty", 2, 58913.567036299030000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1995, 2, 3, 3, 40, 50, 797, DateTimeKind.Local).AddTicks(9138), new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(8963), "Bryan Ebert", 98, 267462.233201167930000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 3, 22, 2, 27, 0, 359, DateTimeKind.Local).AddTicks(6198), new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(9935), "Arthur Hodkiewicz", 32, 1, 89800.825340110420000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 12, 18, 0, 47, 20, 830, DateTimeKind.Local).AddTicks(3158), new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(714), "Marsha Bauch", 89, 1, 122787.38197807990000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1979, 11, 20, 14, 46, 57, 427, DateTimeKind.Local).AddTicks(2634), new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(1418), "Heather Bergstrom", 15, 139561.097643895840000m, new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(1417) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 6, 22, 17, 43, 24, 935, DateTimeKind.Local).AddTicks(7838), new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(2161), "Debbie Corkery", 2, 2, 156396.489418328110000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 1, 2, 7, 45, 53, 116, DateTimeKind.Local).AddTicks(4964), new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(3201), "Sharon Cremin", 90, 184591.427680706140000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 4, 4, 13, 48, 12, 322, DateTimeKind.Local).AddTicks(8178), new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(4242), "Marion Gerhold", 89, 4, 194251.571148317140000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 3, 27, 6, 28, 46, 56, DateTimeKind.Local).AddTicks(4843), new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(5144), "Leona Haag", 72, 1, 229308.72709999240000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 11, 9, 14, 6, 17, 510, DateTimeKind.Local).AddTicks(5205), new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(5800), "Martha Lindgren", 29, 197631.09285312340000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1980, 1, 21, 7, 24, 13, 101, DateTimeKind.Local).AddTicks(7365), new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(6583), "Cristina Schiller", 6, 363626.659272927040000m, new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1989, 1, 15, 6, 0, 4, 793, DateTimeKind.Local).AddTicks(5512), new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(7344), "Harvey Hane", 34, 1, 271182.589370001520000m, new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1963, 2, 22, 6, 14, 1, 477, DateTimeKind.Local).AddTicks(8529), new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(8110), "Doris Nader", 81, 1, 231888.43342929640000m, new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 10, 20, 7, 38, 35, 844, DateTimeKind.Local).AddTicks(1649), new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(8900), "Rex Hammes", 14, 2, 188258.264369718910000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1958, 4, 5, 3, 34, 40, 618, DateTimeKind.Local).AddTicks(3451), new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(9539), "Tonya Hessel", 24, 2, 389594.404236615490000m, new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1987, 9, 23, 23, 31, 11, 963, DateTimeKind.Local).AddTicks(6379), new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(469), "Margaret Harris", 42, 1, 260017.756235382850000m, new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1962, 2, 11, 8, 36, 8, 292, DateTimeKind.Local).AddTicks(8770), new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(1231), "Jean MacGyver", 38, 3, 295574.71448955280000m, new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 8, 17, 10, 45, 30, 641, DateTimeKind.Local).AddTicks(3899), new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(1909), "Rita McCullough", 11, 295852.49081889370000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 7, 16, 17, 3, 22, 401, DateTimeKind.Local).AddTicks(9370), new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(3138), "Dominic Denesik", 56, 4, 15157.6742595219010000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 12, 31, 7, 59, 23, 237, DateTimeKind.Local).AddTicks(2205), new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(4514), "Sherry Bergstrom", 9, 2, 282671.60484743530000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(4513) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 10, 24, 9, 14, 20, 536, DateTimeKind.Local).AddTicks(552), new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(5892), "Steven Prosacco", 53, 302574.66457075090000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 8, 4, 22, 20, 2, 754, DateTimeKind.Local).AddTicks(5872), new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(6881), "Terry Rogahn", 87, 2, 222877.262593599760000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 2, 7, 21, 0, 51, 799, DateTimeKind.Local).AddTicks(6546), new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(7693), "Colleen Brown", 96, 4, 25530.4016301392530000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1968, 2, 24, 23, 30, 36, 681, DateTimeKind.Local).AddTicks(6025), new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(8400), "Delores Hauck", 27, 1, 211151.596987634410000m, new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 1, 25, 2, 46, 5, 386, DateTimeKind.Local).AddTicks(7309), new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(9227), "Brooke Gorczany", 90, 29494.6943082810880000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 9, 22, 1, 20, 6, 168, DateTimeKind.Local).AddTicks(7444), new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(58), "Vicki Zboncak", 37, 3, 300745.245718446220000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 9, 13, 5, 52, 10, 378, DateTimeKind.Local).AddTicks(1618), new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(749), "Louise Torphy", 88, 2, 168091.476845440060000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 3, 30, 2, 23, 11, 151, DateTimeKind.Local).AddTicks(4023), new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(1509), "Charles Koch", 17, 3, 187117.723817385130000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1964, 12, 3, 8, 10, 48, 513, DateTimeKind.Local).AddTicks(4691), new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(2814), "Violet Parker", 7, 4, 379165.229903249260000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 9, 28, 18, 46, 53, 572, DateTimeKind.Local).AddTicks(2397), new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(3761), "Roger Waters", 92, 4, 26881.1348990852620000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 12, 4, 23, 35, 14, 296, DateTimeKind.Local).AddTicks(3096), new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(4487), "Jordan Pfeffer", 61, 3, 126026.706662868820000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1964, 4, 28, 23, 19, 41, 908, DateTimeKind.Local).AddTicks(2000), new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(5305), "Jerome Padberg", 45, 2, 144708.428191051780000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 11, 21, 5, 30, 49, 515, DateTimeKind.Local).AddTicks(3518), new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(6053), "Lyle Macejkovic", 50, 3, 221715.4794735760000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1970, 1, 1, 20, 21, 19, 382, DateTimeKind.Local).AddTicks(3982), new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(6801), "Suzanne Kilback", 85, 123564.522748806610000m, new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1993, 9, 17, 1, 38, 3, 140, DateTimeKind.Local).AddTicks(2629), new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(7524), "Anita Volkman", 90, 5, 305041.984718729170000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1995, 1, 13, 15, 52, 45, 724, DateTimeKind.Local).AddTicks(2731), new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(8242), "May Kuhn", 40, 132252.16509385750000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 5, 30, 0, 40, 3, 481, DateTimeKind.Local).AddTicks(8518), new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(8895), "May Dare", 96, 5, 393793.811793219880000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1995, 6, 6, 21, 36, 31, 305, DateTimeKind.Local).AddTicks(7148), new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(9580), "Jeannette Tillman", 100, 3, 346656.693427529020000m, new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1983, 11, 19, 19, 13, 10, 147, DateTimeKind.Local).AddTicks(4123), new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(344), "Danielle Lemke", 92, 2, 313218.20397946090000m, new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1973, 9, 7, 11, 31, 35, 437, DateTimeKind.Local).AddTicks(8974), new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(1043), "Kristine Stark", 49, 3, 64509.557498534710000m, new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 7, 9, 13, 46, 21, 286, DateTimeKind.Local).AddTicks(4292), new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(2338), "Kristie Rempel", 15, 1, 367372.591345688620000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 2, 12, 18, 1, 8, 267, DateTimeKind.Local).AddTicks(9188), new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(3277), "Bertha Pacocha", 42, 5, 285702.137761393720000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 2, 5, 15, 0, 16, 241, DateTimeKind.Local).AddTicks(5244), new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(4065), "Amber Mitchell", 79, 5, 343023.439098991420000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 10, 18, 0, 52, 4, 175, DateTimeKind.Local).AddTicks(77), new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(4779), "Sheldon Sauer", 36, 2, 198206.629779088960000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 4, 27, 1, 28, 36, 502, DateTimeKind.Local).AddTicks(8247), new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(5589), "Neil McDermott", 66, 5, 47034.8259470380360000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 8, 4, 3, 43, 56, 729, DateTimeKind.Local).AddTicks(5856), new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(6378), "Chad Mosciski", 38, 2, 92346.950489532430000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 12, 29, 11, 34, 33, 585, DateTimeKind.Local).AddTicks(1851), new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(7145), "Jon O'Reilly", 25, 5, 148054.309166183410000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 8, 26, 5, 3, 51, 538, DateTimeKind.Local).AddTicks(7378), new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(7875), "Gertrude Von", 18, 1, 193824.35028305140000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 2, 20, 10, 16, 49, 67, DateTimeKind.Local).AddTicks(5487), new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(8656), "Allison Wolff", 71, 4, 99209.059390670050000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 10, 29, 6, 45, 39, 908, DateTimeKind.Local).AddTicks(6524), new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(9521), "Janie Rau", 61, 3, 267860.143476293410000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 7, 15, 9, 27, 59, 628, DateTimeKind.Local).AddTicks(3418), new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(251), "Alan Fahey", 78, 43336.4776539895360000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 7, 28, 14, 4, 15, 562, DateTimeKind.Local).AddTicks(1407), new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(1543), "Pat Cummings", 2, 5, 389949.673400658010000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 10, 29, 15, 26, 12, 63, DateTimeKind.Local).AddTicks(1959), new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(2597), "Rosa Runte", 90, 1, 135127.066161249880000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 12, 24, 9, 40, 56, 94, DateTimeKind.Local).AddTicks(852), new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(3508), "Carl Dietrich", 87, 1, 181096.727304040330000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 7, 6, 17, 47, 26, 253, DateTimeKind.Local).AddTicks(3070), new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(4386), "Jeanne Abshire", 86, 152978.621197861930000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1986, 11, 8, 14, 21, 45, 819, DateTimeKind.Local).AddTicks(3851), new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(5184), "Jacquelyn Kassulke", 22, 60689.160634230430000m, new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 11, 8, 22, 26, 56, 738, DateTimeKind.Local).AddTicks(8336), new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(6072), "Laurie Schoen", 83, 2, 359657.817091913980000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 11, 10, 22, 54, 36, 211, DateTimeKind.Local).AddTicks(2541), new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(6817), "Daniel Rutherford", 33, 5, 373387.858647412690000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 3, 5, 4, 32, 25, 249, DateTimeKind.Local).AddTicks(7137), new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(7623), "Stephanie Wisoky", 32, 3, 352088.732342216860000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 5, 26, 14, 51, 56, 610, DateTimeKind.Local).AddTicks(8718), new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(8492), "May Conn", 37, 349196.759216152630000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 7, 28, 20, 46, 40, 984, DateTimeKind.Local).AddTicks(6579), new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(9271), "Arthur Satterfield", 10, 109618.247227218850000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 5, 10, 12, 56, 14, 277, DateTimeKind.Local).AddTicks(5077), new DateTime(2024, 2, 20, 16, 12, 1, 860, DateTimeKind.Utc).AddTicks(423), "Dallas Moore", 12, 2, 325355.259517017070000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 860, DateTimeKind.Utc).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1989, 4, 7, 17, 42, 4, 12, DateTimeKind.Local).AddTicks(1621), new DateTime(2024, 2, 20, 16, 12, 1, 860, DateTimeKind.Utc).AddTicks(6031), "Juana Hagenes", 17, 244494.208971152650000m, new DateTime(2024, 2, 20, 16, 12, 1, 860, DateTimeKind.Utc).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 5, 18, 15, 22, 1, 158, DateTimeKind.Local).AddTicks(5215), new DateTime(2024, 2, 20, 16, 12, 1, 861, DateTimeKind.Utc).AddTicks(1484), "Derek Watsica", 100, 3, 376218.151720356130000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 861, DateTimeKind.Utc).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 10, 6, 3, 27, 44, 904, DateTimeKind.Local).AddTicks(4313), new DateTime(2024, 2, 20, 16, 12, 1, 861, DateTimeKind.Utc).AddTicks(7025), "Robin Gutkowski", 79, 2, 120369.967888613290000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 861, DateTimeKind.Utc).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 4, 17, 23, 27, 21, 616, DateTimeKind.Local).AddTicks(9860), new DateTime(2024, 2, 20, 16, 12, 1, 861, DateTimeKind.Utc).AddTicks(9132), "Leslie Kub", 53, 5, 361613.66405098180000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 861, DateTimeKind.Utc).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1967, 7, 21, 9, 13, 48, 504, DateTimeKind.Local).AddTicks(5243), new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(44), "Johnathan Gibson", 89, 2, 340963.845812517970000m, new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 9, 3, 13, 16, 4, 255, DateTimeKind.Local).AddTicks(8285), new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(1024), "Verna Rodriguez", 74, 4, 215570.509884300730000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 10, 13, 15, 21, 21, 197, DateTimeKind.Local).AddTicks(8180), new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(1991), "Clinton Dach", 3, 4, 63117.445917962140000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1986, 2, 24, 19, 33, 50, 482, DateTimeKind.Local).AddTicks(8022), new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(2806), "Wendell Hodkiewicz", 63, 1, 172646.60230826020000m, new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 7, 25, 22, 1, 37, 882, DateTimeKind.Local).AddTicks(1479), new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(3756), "Darren Quitzon", 44, 193192.954033420240000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2000, 3, 31, 5, 39, 25, 331, DateTimeKind.Local).AddTicks(6619), new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(5244), "Rachel Klein", 70, 4, 391910.856657477550000m, new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 2, 2, 14, 57, 5, 922, DateTimeKind.Local).AddTicks(1623), new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(7107), "Rodolfo Heathcote", 31, 1, 292714.320833944870000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 10, 11, 11, 26, 47, 946, DateTimeKind.Local).AddTicks(5539), new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(8684), "Clarence O'Conner", 50, 2, 158723.163262048180000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(8684) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1966, 3, 28, 17, 11, 42, 993, DateTimeKind.Local).AddTicks(9379), new DateTime(2024, 2, 20, 16, 12, 1, 863, DateTimeKind.Utc).AddTicks(1871), "Albert Strosin", 71, 5, 177827.567023486240000m, new DateTime(2024, 2, 20, 16, 12, 1, 863, DateTimeKind.Utc).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 799, DateTimeKind.Utc).AddTicks(8278), new DateTime(2024, 2, 20, 16, 12, 1, 799, DateTimeKind.Utc).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 799, DateTimeKind.Utc).AddTicks(8281), new DateTime(2024, 2, 20, 16, 12, 1, 799, DateTimeKind.Utc).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 799, DateTimeKind.Utc).AddTicks(8283), new DateTime(2024, 2, 20, 16, 12, 1, 799, DateTimeKind.Utc).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 799, DateTimeKind.Utc).AddTicks(8285), new DateTime(2024, 2, 20, 16, 12, 1, 799, DateTimeKind.Utc).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 799, DateTimeKind.Utc).AddTicks(8288), new DateTime(2024, 2, 20, 16, 12, 1, 799, DateTimeKind.Utc).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 799, DateTimeKind.Utc).AddTicks(7877), new DateTime(2024, 2, 20, 16, 12, 1, 799, DateTimeKind.Utc).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 799, DateTimeKind.Utc).AddTicks(7883), new DateTime(2024, 2, 20, 16, 12, 1, 799, DateTimeKind.Utc).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 799, DateTimeKind.Utc).AddTicks(7886), new DateTime(2024, 2, 20, 16, 12, 1, 799, DateTimeKind.Utc).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 799, DateTimeKind.Utc).AddTicks(7888), new DateTime(2024, 2, 20, 16, 12, 1, 799, DateTimeKind.Utc).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 12, 1, 799, DateTimeKind.Utc).AddTicks(7890), new DateTime(2024, 2, 20, 16, 12, 1, 799, DateTimeKind.Utc).AddTicks(7890) });
        }
    }
}
