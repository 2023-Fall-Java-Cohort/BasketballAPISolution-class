using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BasketballAPI.Migrations
{
    /// <inheritdoc />
    public partial class coachUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "CreateDate", "Name", "TeamId", "Title", "UpdateOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 20, 16, 12, 1, 870, DateTimeKind.Utc).AddTicks(4493), "Cathy Denesik", 1, 1, new DateTime(2024, 2, 20, 16, 12, 1, 870, DateTimeKind.Utc).AddTicks(4475) },
                    { 2, new DateTime(2024, 2, 20, 16, 12, 1, 872, DateTimeKind.Utc).AddTicks(534), "Catherine Bayer", 1, 2, new DateTime(2024, 2, 20, 16, 12, 1, 872, DateTimeKind.Utc).AddTicks(522) },
                    { 3, new DateTime(2024, 2, 20, 16, 12, 1, 872, DateTimeKind.Utc).AddTicks(6126), "Marilyn Bailey", 1, 3, new DateTime(2024, 2, 20, 16, 12, 1, 872, DateTimeKind.Utc).AddTicks(6125) },
                    { 4, new DateTime(2024, 2, 20, 16, 12, 1, 872, DateTimeKind.Utc).AddTicks(7512), "Ralph Hodkiewicz", 1, 4, new DateTime(2024, 2, 20, 16, 12, 1, 872, DateTimeKind.Utc).AddTicks(7511) },
                    { 5, new DateTime(2024, 2, 20, 16, 12, 1, 872, DateTimeKind.Utc).AddTicks(8681), "Roberto Effertz", 1, 5, new DateTime(2024, 2, 20, 16, 12, 1, 872, DateTimeKind.Utc).AddTicks(8681) },
                    { 6, new DateTime(2024, 2, 20, 16, 12, 1, 872, DateTimeKind.Utc).AddTicks(9879), "Sonia Herzog", 2, 1, new DateTime(2024, 2, 20, 16, 12, 1, 872, DateTimeKind.Utc).AddTicks(9879) },
                    { 7, new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(1340), "Elbert Fisher", 2, 2, new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(1340) },
                    { 8, new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(3765), "Alton Kulas", 2, 3, new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(3764) },
                    { 9, new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(5356), "Aaron Prosacco", 2, 4, new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(5356) },
                    { 10, new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(6376), "Steven Crooks", 2, 5, new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(6376) },
                    { 11, new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(7218), "Delores Kemmer", 3, 1, new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(7217) },
                    { 12, new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(8005), "Francis Kulas", 3, 2, new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(8004) },
                    { 13, new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(8979), "Damon Bashirian", 3, 3, new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(8979) },
                    { 14, new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(9961), "Sara Swaniawski", 3, 4, new DateTime(2024, 2, 20, 16, 12, 1, 873, DateTimeKind.Utc).AddTicks(9960) },
                    { 15, new DateTime(2024, 2, 20, 16, 12, 1, 874, DateTimeKind.Utc).AddTicks(858), "Aubrey Glover", 3, 5, new DateTime(2024, 2, 20, 16, 12, 1, 874, DateTimeKind.Utc).AddTicks(857) },
                    { 16, new DateTime(2024, 2, 20, 16, 12, 1, 874, DateTimeKind.Utc).AddTicks(1811), "Crystal Kiehn", 4, 1, new DateTime(2024, 2, 20, 16, 12, 1, 874, DateTimeKind.Utc).AddTicks(1810) },
                    { 17, new DateTime(2024, 2, 20, 16, 12, 1, 875, DateTimeKind.Utc).AddTicks(1804), "Julie Rolfson", 4, 2, new DateTime(2024, 2, 20, 16, 12, 1, 875, DateTimeKind.Utc).AddTicks(1798) },
                    { 18, new DateTime(2024, 2, 20, 16, 12, 1, 875, DateTimeKind.Utc).AddTicks(9575), "Cecil McDermott", 4, 3, new DateTime(2024, 2, 20, 16, 12, 1, 875, DateTimeKind.Utc).AddTicks(9573) },
                    { 19, new DateTime(2024, 2, 20, 16, 12, 1, 876, DateTimeKind.Utc).AddTicks(4944), "Jack Leannon", 4, 4, new DateTime(2024, 2, 20, 16, 12, 1, 876, DateTimeKind.Utc).AddTicks(4942) },
                    { 20, new DateTime(2024, 2, 20, 16, 12, 1, 877, DateTimeKind.Utc).AddTicks(529), "Rudolph Wintheiser", 4, 5, new DateTime(2024, 2, 20, 16, 12, 1, 877, DateTimeKind.Utc).AddTicks(528) },
                    { 21, new DateTime(2024, 2, 20, 16, 12, 1, 877, DateTimeKind.Utc).AddTicks(4634), "Patti Smitham", 5, 1, new DateTime(2024, 2, 20, 16, 12, 1, 877, DateTimeKind.Utc).AddTicks(4633) },
                    { 22, new DateTime(2024, 2, 20, 16, 12, 1, 877, DateTimeKind.Utc).AddTicks(8900), "Joann Jerde", 5, 2, new DateTime(2024, 2, 20, 16, 12, 1, 877, DateTimeKind.Utc).AddTicks(8898) },
                    { 23, new DateTime(2024, 2, 20, 16, 12, 1, 878, DateTimeKind.Utc).AddTicks(512), "Dallas Mayer", 5, 3, new DateTime(2024, 2, 20, 16, 12, 1, 878, DateTimeKind.Utc).AddTicks(511) },
                    { 24, new DateTime(2024, 2, 20, 16, 12, 1, 878, DateTimeKind.Utc).AddTicks(1446), "Melvin Kris", 5, 4, new DateTime(2024, 2, 20, 16, 12, 1, 878, DateTimeKind.Utc).AddTicks(1446) },
                    { 25, new DateTime(2024, 2, 20, 16, 12, 1, 878, DateTimeKind.Utc).AddTicks(2242), "Mindy Bins", 5, 5, new DateTime(2024, 2, 20, 16, 12, 1, 878, DateTimeKind.Utc).AddTicks(2241) }
                });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 9, 12, 23, 49, 20, 520, DateTimeKind.Local).AddTicks(350), new DateTime(2024, 2, 20, 16, 12, 1, 803, DateTimeKind.Utc).AddTicks(1551), "Gerald Kshlerin", 98, 2, 366980.829208168360000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 803, DateTimeKind.Utc).AddTicks(1546) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 11, 4, 21, 12, 21, 694, DateTimeKind.Local).AddTicks(7101), new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(1586), "Rafael Lubowitz", 19, 1, 261887.387117742610000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(1585) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 5, 24, 23, 52, 5, 992, DateTimeKind.Local).AddTicks(9502), new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(3335), "Carlos Maggio", 80, 4, 295323.327333766150000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 9, 23, 8, 22, 48, 847, DateTimeKind.Local).AddTicks(3818), new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(4145), "Marie Abshire", 95, 92107.351989300430000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(4144) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1957, 7, 30, 12, 25, 16, 728, DateTimeKind.Local).AddTicks(7436), new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(6312), "Danielle Mraz", 40, 1, 299160.690865454980000m, new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 10, 25, 23, 56, 50, 104, DateTimeKind.Local).AddTicks(2866), new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(7660), "Wallace Stroman", 56, 57316.563894290080000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 804, DateTimeKind.Utc).AddTicks(7659) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1954, 4, 29, 2, 24, 26, 202, DateTimeKind.Local).AddTicks(7667), new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(990), "Debbie Witting", 90, 4, 48954.0155037739810000m, new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1999, 3, 21, 15, 26, 43, 663, DateTimeKind.Local).AddTicks(9608), new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(1764), "Constance Hayes", 10, 5, 305642.000985891040000m, new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 1, 26, 3, 24, 42, 120, DateTimeKind.Local).AddTicks(7177), new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(2482), "Christopher Dare", 45, 1, 310823.881813388830000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(2482) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1980, 10, 18, 21, 9, 47, 9, DateTimeKind.Local).AddTicks(4340), new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(3988), "Bob O'Conner", 69, 1, 197899.253780069260000m, new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(3988) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1995, 1, 10, 22, 33, 18, 759, DateTimeKind.Local).AddTicks(7822), new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(5380), "Lillie Bogan", 95, 33834.1435016357140000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(5379) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 7, 16, 14, 46, 56, 480, DateTimeKind.Local).AddTicks(1898), new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(7856), "Candice Gaylord", 5, 176264.157377671210000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 805, DateTimeKind.Utc).AddTicks(7855) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 11, 30, 6, 56, 30, 917, DateTimeKind.Local).AddTicks(7837), new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(127), "Ana Lang", 11, 196982.192726028310000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 6, 20, 10, 46, 28, 709, DateTimeKind.Local).AddTicks(4351), new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(854), "Fredrick Kub", 37, 217647.376340648530000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(854) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1979, 5, 30, 19, 31, 21, 309, DateTimeKind.Local).AddTicks(1193), new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(2344), "Glenn Kohler", 20, 1, 256263.920571221410000m, new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(2344) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 2, 23, 13, 10, 46, 567, DateTimeKind.Local).AddTicks(8040), new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(4586), "Josefina Koch", 59, 4, 273821.424741798820000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 4, 6, 7, 46, 4, 637, DateTimeKind.Local).AddTicks(325), new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(5848), "Kurt Walter", 100, 2, 324612.244785000760000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1959, 11, 19, 14, 29, 50, 653, DateTimeKind.Local).AddTicks(6352), new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(7201), "Brandy Carter", 89, 1, 236360.008117752730000m, new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1978, 11, 16, 13, 16, 26, 14, DateTimeKind.Local).AddTicks(4232), new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(8099), "Guillermo Reichel", 21, 3, 361719.090379218640000m, new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(8098) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1993, 2, 17, 10, 44, 33, 296, DateTimeKind.Local).AddTicks(7490), new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(9584), "Juanita Cummerata", 20, 3, 46100.7740134835560000m, new DateTime(2024, 2, 20, 16, 12, 1, 806, DateTimeKind.Utc).AddTicks(9583) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2004, 2, 11, 5, 1, 14, 48, DateTimeKind.Local).AddTicks(6631), new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(1777), "Dewey Koss", 40, 2, 12202.32204499238230000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 8, 26, 18, 1, 7, 973, DateTimeKind.Local).AddTicks(7749), new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(2679), "Roman Fritsch", 49, 2, 213148.287247331530000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 12, 1, 15, 21, 18, 126, DateTimeKind.Local).AddTicks(6771), new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(3418), "Edith Streich", 39, 1, 60933.194498627350000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(3418) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2003, 2, 1, 10, 55, 23, 326, DateTimeKind.Local).AddTicks(5614), new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(4865), "Russell Ward", 23, 43933.5578761712260000m, new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(4865) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 6, 22, 19, 40, 20, 353, DateTimeKind.Local).AddTicks(5750), new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(7664), "Violet Paucek", 88, 5, 334789.721319089260000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1966, 1, 25, 12, 44, 30, 506, DateTimeKind.Local).AddTicks(1593), new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(8477), "Sonya Prohaska", 43, 48588.8329153253680000m, new DateTime(2024, 2, 20, 16, 12, 1, 807, DateTimeKind.Utc).AddTicks(8476) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2002, 9, 6, 10, 34, 12, 84, DateTimeKind.Local).AddTicks(9026), new DateTime(2024, 2, 20, 16, 12, 1, 808, DateTimeKind.Utc).AddTicks(2437), "Sharon Feil", 11, 2, 321823.757940028360000m, new DateTime(2024, 2, 20, 16, 12, 1, 808, DateTimeKind.Utc).AddTicks(2436) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 7, 14, 7, 15, 32, 522, DateTimeKind.Local).AddTicks(595), new DateTime(2024, 2, 20, 16, 12, 1, 808, DateTimeKind.Utc).AddTicks(5209), "Shane Ledner", 24, 337099.840020520060000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 808, DateTimeKind.Utc).AddTicks(5208) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 5, 6, 11, 18, 15, 961, DateTimeKind.Local).AddTicks(3239), new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(1619), "Michelle Weimann", 88, 344934.050436230440000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 10, 5, 12, 50, 4, 242, DateTimeKind.Local).AddTicks(5569), new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(2401), "Holly Schimmel", 92, 106148.716142189620000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 4, 11, 5, 40, 1, 55, DateTimeKind.Local).AddTicks(2002), new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(3194), "Lester Heathcote", 49, 2, 241961.477481667180000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2004, 1, 27, 5, 34, 51, 482, DateTimeKind.Local).AddTicks(3990), new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(4224), "Tommie Huel", 19, 2, 301821.697140976210000m, new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 5, 26, 12, 22, 16, 418, DateTimeKind.Local).AddTicks(879), new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(6925), "Tiffany Dare", 13, 212689.012200695410000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1968, 7, 19, 12, 50, 47, 757, DateTimeKind.Local).AddTicks(3581), new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(8634), "Mark Stamm", 76, 5, 265824.730948320430000m, new DateTime(2024, 2, 20, 16, 12, 1, 809, DateTimeKind.Utc).AddTicks(8633) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 3, 4, 13, 47, 56, 173, DateTimeKind.Local).AddTicks(4548), new DateTime(2024, 2, 20, 16, 12, 1, 810, DateTimeKind.Utc).AddTicks(3469), "Robyn McCullough", 16, 3, 188330.553093135040000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 810, DateTimeKind.Utc).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 7, 14, 0, 36, 47, 56, DateTimeKind.Local).AddTicks(9267), new DateTime(2024, 2, 20, 16, 12, 1, 810, DateTimeKind.Utc).AddTicks(5108), "Sonia Kling", 55, 4, 87650.537550574690000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 810, DateTimeKind.Utc).AddTicks(5105) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 11, 6, 1, 55, 8, 670, DateTimeKind.Local).AddTicks(5844), new DateTime(2024, 2, 20, 16, 12, 1, 810, DateTimeKind.Utc).AddTicks(9534), "Nelson Friesen", 56, 40926.4814334328060000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 810, DateTimeKind.Utc).AddTicks(9533) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 9, 23, 13, 0, 34, 741, DateTimeKind.Local).AddTicks(9093), new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(1293), "Roxanne Bechtelar", 39, 99143.11345729660000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(1292) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 10, 17, 17, 18, 48, 557, DateTimeKind.Local).AddTicks(4606), new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(4430), "Sylvester Walsh", 20, 3, 338577.705875923270000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(4429) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 9, 5, 10, 3, 21, 483, DateTimeKind.Local).AddTicks(7063), new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(6838), "Janet Vandervort", 89, 5, 161083.389116785450000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1982, 8, 10, 12, 36, 30, 781, DateTimeKind.Local).AddTicks(8393), new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(7724), "Melanie Bartell", 61, 5, 140683.932323150440000m, new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(7723) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 1, 5, 0, 14, 1, 69, DateTimeKind.Local).AddTicks(9483), new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(9214), "Monica Mitchell", 58, 5, 11680.98277117338880000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 811, DateTimeKind.Utc).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1973, 7, 13, 17, 35, 27, 892, DateTimeKind.Local).AddTicks(5219), new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(29), "Emmett Schneider", 59, 251140.124037518290000m, new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 10, 20, 16, 17, 6, 207, DateTimeKind.Local).AddTicks(9999), new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(1244), "Erma Balistreri", 6, 2, 357620.624374181080000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 2, 20, 9, 38, 37, 567, DateTimeKind.Local).AddTicks(7069), new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(2273), "Lucille Wehner", 81, 5, 154053.71062664140000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(2272) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 4, 4, 23, 9, 19, 281, DateTimeKind.Local).AddTicks(9215), new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(6186), "Ralph Lockman", 6, 2, 102104.883298701130000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 12, 29, 22, 9, 38, 893, DateTimeKind.Local).AddTicks(7206), new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(7184), "Geraldine Jaskolski", 9, 2, 266037.990666248440000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 5, 6, 23, 34, 27, 949, DateTimeKind.Local).AddTicks(7408), new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(7963), "Cody Bergnaum", 27, 94241.831920326730000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 7, 21, 23, 15, 42, 896, DateTimeKind.Local).AddTicks(9208), new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(8671), "Benny Mueller", 41, 2, 338589.677864072560000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 812, DateTimeKind.Utc).AddTicks(8670) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1960, 11, 28, 20, 5, 23, 728, DateTimeKind.Local).AddTicks(6695), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(655), "Joann Streich", 70, 3, 376016.137068625420000m, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1975, 3, 13, 7, 53, 29, 724, DateTimeKind.Local).AddTicks(8287), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(1479), "Freda Bernier", 47, 2, 117226.48898600860000m, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(1478) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1964, 1, 27, 14, 7, 10, 918, DateTimeKind.Local).AddTicks(7846), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(2939), "Sophia Rath", 99, 39620.2740657078970000m, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1974, 4, 13, 19, 13, 23, 143, DateTimeKind.Local).AddTicks(4771), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(3606), "Cristina Prosacco", 3, 1, 24963.8152680748030000m, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 11, 21, 7, 15, 32, 525, DateTimeKind.Local).AddTicks(882), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(4377), "Alberto Macejkovic", 88, 103200.559113546430000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(4377) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 11, 23, 15, 47, 25, 159, DateTimeKind.Local).AddTicks(5292), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(5921), "Ivan Block", 56, 1, 104104.538009769430000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 10, 25, 13, 18, 48, 365, DateTimeKind.Local).AddTicks(6783), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(6640), "Terrance Wisozk", 22, 2, 358605.653401297240000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(6639) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 5, 2, 7, 12, 24, 667, DateTimeKind.Local).AddTicks(1421), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(8026), "Nelson Parker", 34, 3, 384967.495074504670000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2002, 3, 6, 13, 0, 6, 702, DateTimeKind.Local).AddTicks(1012), new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(9111), "Irvin Hoppe", 3, 1, 189028.430241659440000m, new DateTime(2024, 2, 20, 16, 12, 1, 813, DateTimeKind.Utc).AddTicks(9110) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1991, 11, 19, 15, 11, 39, 940, DateTimeKind.Local).AddTicks(3591), new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(985), "Judith Shields", 32, 1, 59217.836236417420000m, new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(984) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 10, 27, 1, 9, 11, 838, DateTimeKind.Local).AddTicks(9059), new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(3879), "Moses Hane", 30, 384316.445519264170000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(3879) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 6, 15, 0, 34, 48, 709, DateTimeKind.Local).AddTicks(3967), new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(5332), "Eleanor Botsford", 32, 87040.872204674560000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(5332) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 4, 8, 6, 39, 57, 247, DateTimeKind.Local).AddTicks(5423), new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(7930), "Alice Hauck", 33, 339330.367755879490000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 1, 24, 8, 44, 27, 192, DateTimeKind.Local).AddTicks(1655), new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(8989), "Everett Carter", 42, 4, 337976.073635887690000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 814, DateTimeKind.Utc).AddTicks(8988) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 7, 2, 23, 13, 53, 326, DateTimeKind.Local).AddTicks(3351), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(1267), "Laura Grady", 46, 5, 50325.03842321110000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(1266) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 10, 14, 2, 0, 39, 28, DateTimeKind.Local).AddTicks(2597), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(3525), "Leland Becker", 60, 265801.648824639580000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 12, 14, 1, 58, 38, 70, DateTimeKind.Local).AddTicks(5568), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(4231), "Phil Rohan", 24, 1, 151162.288386193750000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 8, 3, 6, 35, 18, 70, DateTimeKind.Local).AddTicks(5082), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(4960), "Sammy Powlowski", 64, 4, 124640.733023844430000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 2, 15, 18, 31, 56, 136, DateTimeKind.Local).AddTicks(251), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(5696), "Mark Krajcik", 19, 319351.228641463060000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 10, 4, 8, 44, 26, 58, DateTimeKind.Local).AddTicks(6926), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(6359), "Sonia Wintheiser", 3, 2, 382640.914732840780000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2002, 8, 10, 5, 24, 7, 948, DateTimeKind.Local).AddTicks(7313), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(7602), "Lois Kovacek", 3, 5, 274489.035080294440000m, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1975, 11, 18, 7, 9, 44, 955, DateTimeKind.Local).AddTicks(6871), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(8405), "Penny Conroy", 32, 4, 200869.385400370690000m, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(8405) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1976, 5, 8, 22, 9, 10, 728, DateTimeKind.Local).AddTicks(8947), new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(9993), "Philip Bauch", 75, 4, 16429.4063479697740000m, new DateTime(2024, 2, 20, 16, 12, 1, 815, DateTimeKind.Utc).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 7, 19, 1, 10, 55, 711, DateTimeKind.Local).AddTicks(9772), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(658), "Peter Sanford", 64, 278320.371542433730000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 2, 19, 7, 10, 5, 506, DateTimeKind.Local).AddTicks(3506), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(1321), "Lillian Bechtelar", 5, 2, 27284.3770409742640000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1979, 1, 31, 23, 20, 55, 24, DateTimeKind.Local).AddTicks(4850), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(2077), "Jamie Connelly", 22, 91200.369723978310000m, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1981, 2, 9, 0, 21, 31, 634, DateTimeKind.Local).AddTicks(6046), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(2786), "Karl Carroll", 30, 2, 109108.90068073150000m, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(2786) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 8, 1, 16, 15, 15, 345, DateTimeKind.Local).AddTicks(5599), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(5688), "Jeffery Deckow", 40, 120134.849701088290000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 1, 3, 8, 38, 21, 462, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(6737), "Philip Hane", 74, 5, 370258.491770360950000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(6736) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 3, 12, 0, 11, 21, 931, DateTimeKind.Local).AddTicks(9951), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(8284), "Krista Sawayn", 69, 3, 274008.542079359740000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 4, 10, 15, 20, 54, 108, DateTimeKind.Local).AddTicks(3038), new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(9065), "Shelia Sawayn", 5, 5, 70838.331036351310000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 816, DateTimeKind.Utc).AddTicks(9064) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2001, 10, 24, 0, 37, 55, 169, DateTimeKind.Local).AddTicks(9538), new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(461), "Natasha Williamson", 24, 1, 316776.245034878320000m, new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 3, 18, 18, 13, 28, 15, DateTimeKind.Local).AddTicks(7832), new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(1172), "Curtis Morissette", 98, 144565.897747106020000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(1172) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 3, 7, 6, 34, 45, 945, DateTimeKind.Local).AddTicks(6791), new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(2515), "Freda Marquardt", 82, 262323.669450465730000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 10, 10, 20, 10, 33, 640, DateTimeKind.Local).AddTicks(6950), new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(3236), "Robin Kuvalis", 65, 333486.409217633350000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1962, 11, 3, 15, 19, 11, 541, DateTimeKind.Local).AddTicks(934), new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(3944), "Guillermo Collier", 79, 5, 136361.78078103970000m, new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(3943) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 5, 24, 4, 26, 42, 5, DateTimeKind.Local).AddTicks(4117), new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(6085), "Zachary Okuneva", 1, 4, 88372.302467662450000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 817, DateTimeKind.Utc).AddTicks(6085) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 12, 17, 13, 29, 36, 365, DateTimeKind.Local).AddTicks(4036), new DateTime(2024, 2, 20, 16, 12, 1, 819, DateTimeKind.Utc).AddTicks(4660), "Claudia Schultz", 54, 53836.45569631510000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 819, DateTimeKind.Utc).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1975, 4, 20, 17, 8, 3, 551, DateTimeKind.Local).AddTicks(1487), new DateTime(2024, 2, 20, 16, 12, 1, 819, DateTimeKind.Utc).AddTicks(9415), "Lynn Douglas", 85, 4, 43610.9341727151460000m, new DateTime(2024, 2, 20, 16, 12, 1, 819, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1981, 11, 14, 6, 37, 24, 520, DateTimeKind.Local).AddTicks(2669), new DateTime(2024, 2, 20, 16, 12, 1, 820, DateTimeKind.Utc).AddTicks(3728), "Conrad Bashirian", 63, 1, 83868.015258786970000m, new DateTime(2024, 2, 20, 16, 12, 1, 820, DateTimeKind.Utc).AddTicks(3723) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 11, 6, 8, 19, 12, 692, DateTimeKind.Local).AddTicks(3838), new DateTime(2024, 2, 20, 16, 12, 1, 821, DateTimeKind.Utc).AddTicks(2920), "Jerry Graham", 53, 201391.418453241370000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 821, DateTimeKind.Utc).AddTicks(2919) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 2, 27, 7, 7, 9, 240, DateTimeKind.Local).AddTicks(127), new DateTime(2024, 2, 20, 16, 12, 1, 822, DateTimeKind.Utc).AddTicks(6785), "Raymond Hammes", 81, 2, 191075.801346428950000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 822, DateTimeKind.Utc).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 12, 1, 16, 53, 39, 73, DateTimeKind.Local).AddTicks(2760), new DateTime(2024, 2, 20, 16, 12, 1, 823, DateTimeKind.Utc).AddTicks(120), "Wm Schneider", 64, 3, 206249.736402164770000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 823, DateTimeKind.Utc).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 1, 14, 10, 30, 8, 348, DateTimeKind.Local).AddTicks(4301), new DateTime(2024, 2, 20, 16, 12, 1, 823, DateTimeKind.Utc).AddTicks(4457), "Jasmine Bechtelar", 39, 3, 124739.143061231260000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 823, DateTimeKind.Utc).AddTicks(4456) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 5, 13, 15, 56, 5, 602, DateTimeKind.Local).AddTicks(7907), new DateTime(2024, 2, 20, 16, 12, 1, 825, DateTimeKind.Utc).AddTicks(2339), "Samantha Hauck", 62, 2, 339331.732395012490000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 825, DateTimeKind.Utc).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 10, 28, 18, 35, 50, 145, DateTimeKind.Local).AddTicks(8250), new DateTime(2024, 2, 20, 16, 12, 1, 825, DateTimeKind.Utc).AddTicks(5548), "Walter Braun", 27, 2, 175616.422747405240000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 825, DateTimeKind.Utc).AddTicks(5547) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1989, 12, 30, 2, 5, 10, 309, DateTimeKind.Local).AddTicks(5582), new DateTime(2024, 2, 20, 16, 12, 1, 826, DateTimeKind.Utc).AddTicks(2671), "Lois Haag", 73, 1, 124157.866745556010000m, new DateTime(2024, 2, 20, 16, 12, 1, 826, DateTimeKind.Utc).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1977, 7, 31, 18, 29, 39, 126, DateTimeKind.Local).AddTicks(8925), new DateTime(2024, 2, 20, 16, 12, 1, 826, DateTimeKind.Utc).AddTicks(5769), "Megan Green", 21, 3, 259689.159097251640000m, new DateTime(2024, 2, 20, 16, 12, 1, 826, DateTimeKind.Utc).AddTicks(5768) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1984, 4, 27, 10, 44, 36, 214, DateTimeKind.Local).AddTicks(9082), new DateTime(2024, 2, 20, 16, 12, 1, 827, DateTimeKind.Utc).AddTicks(7912), "Raul Wisozk", 27, 2, 325663.21751554330000m, new DateTime(2024, 2, 20, 16, 12, 1, 827, DateTimeKind.Utc).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 2, 1, 23, 20, 22, 500, DateTimeKind.Local).AddTicks(6500), new DateTime(2024, 2, 20, 16, 12, 1, 827, DateTimeKind.Utc).AddTicks(9465), "Jeffrey Metz", 9, 4, 293339.236309515880000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 827, DateTimeKind.Utc).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1986, 7, 28, 8, 10, 51, 352, DateTimeKind.Local).AddTicks(3719), new DateTime(2024, 2, 20, 16, 12, 1, 828, DateTimeKind.Utc).AddTicks(1352), "Heidi Crooks", 21, 1, 220661.911874347960000m, new DateTime(2024, 2, 20, 16, 12, 1, 828, DateTimeKind.Utc).AddTicks(1351) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 11, 27, 4, 42, 14, 37, DateTimeKind.Local).AddTicks(9365), new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(2025), "Edna Little", 98, 228003.165348737470000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1991, 8, 29, 4, 46, 32, 179, DateTimeKind.Local).AddTicks(6616), new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(3448), "Lana Haley", 83, 4, 354891.294915295960000m, new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(3447) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 4, 22, 4, 54, 37, 5, DateTimeKind.Local).AddTicks(8566), new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(6330), "Vicki Deckow", 75, 4, 366887.130706089880000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 3, 3, 12, 47, 58, 26, DateTimeKind.Local).AddTicks(1457), new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(7454), "Dolores Kutch", 67, 2, 107535.187970639770000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 4, 27, 10, 15, 51, 227, DateTimeKind.Local).AddTicks(7855), new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(8477), "Tanya Bernhard", 14, 168375.708606190660000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 829, DateTimeKind.Utc).AddTicks(8477) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 10, 5, 9, 43, 24, 922, DateTimeKind.Local).AddTicks(8400), new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(715), "Amber Murphy", 92, 3, 365495.051262737620000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(714) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 5, 14, 3, 22, 38, 169, DateTimeKind.Local).AddTicks(4204), new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(3747), "Natasha Raynor", 41, 4, 257453.845869497020000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(3746) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1986, 4, 5, 23, 56, 11, 67, DateTimeKind.Local).AddTicks(4919), new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(7073), "Darrell Grant", 25, 5, 314594.039937367960000m, new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 7, 6, 4, 14, 59, 29, DateTimeKind.Local).AddTicks(843), new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(8043), "Ron Lockman", 18, 266177.378464371520000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1985, 4, 23, 15, 59, 54, 8, DateTimeKind.Local).AddTicks(7379), new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(8938), "Ira Smitham", 88, 3, 129257.101052678290000m, new DateTime(2024, 2, 20, 16, 12, 1, 830, DateTimeKind.Utc).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 10, 7, 10, 15, 39, 175, DateTimeKind.Local).AddTicks(9183), new DateTime(2024, 2, 20, 16, 12, 1, 831, DateTimeKind.Utc).AddTicks(1906), "Guy Funk", 68, 3, 10521.30066749466940000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 831, DateTimeKind.Utc).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2002, 5, 23, 11, 8, 10, 227, DateTimeKind.Local).AddTicks(8415), new DateTime(2024, 2, 20, 16, 12, 1, 831, DateTimeKind.Utc).AddTicks(3471), "Stuart Mueller", 12, 1, 323701.430251140880000m, new DateTime(2024, 2, 20, 16, 12, 1, 831, DateTimeKind.Utc).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 7, 22, 12, 8, 58, 191, DateTimeKind.Local).AddTicks(737), new DateTime(2024, 2, 20, 16, 12, 1, 831, DateTimeKind.Utc).AddTicks(5331), "Jasmine Thompson", 31, 1, 333363.177080958820000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 831, DateTimeKind.Utc).AddTicks(5331) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 11, 1, 7, 33, 30, 464, DateTimeKind.Local).AddTicks(9314), new DateTime(2024, 2, 20, 16, 12, 1, 832, DateTimeKind.Utc).AddTicks(7146), "Sherman Murphy", 31, 1, 307128.197386546240000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 832, DateTimeKind.Utc).AddTicks(7145) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 1, 29, 14, 36, 52, 824, DateTimeKind.Local).AddTicks(4028), new DateTime(2024, 2, 20, 16, 12, 1, 833, DateTimeKind.Utc).AddTicks(3461), "Cristina Heaney", 58, 45572.1270512712130000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 833, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1992, 7, 4, 12, 47, 40, 409, DateTimeKind.Local).AddTicks(8994), new DateTime(2024, 2, 20, 16, 12, 1, 833, DateTimeKind.Utc).AddTicks(6083), "Patti Larson", 5, 2, 325992.527427178420000m, new DateTime(2024, 2, 20, 16, 12, 1, 833, DateTimeKind.Utc).AddTicks(6082) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 1, 18, 8, 9, 28, 725, DateTimeKind.Local).AddTicks(7247), new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(2271), "Freddie Ratke", 54, 167179.233121861990000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1997, 3, 29, 3, 2, 7, 879, DateTimeKind.Local).AddTicks(5353), new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(3274), "Miriam Carroll", 50, 1, 26736.6529375787560000m, new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1956, 9, 4, 18, 13, 56, 941, DateTimeKind.Local).AddTicks(1451), new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(4165), "Winston Lehner", 49, 45863.1136010767360000m, new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2002, 6, 27, 21, 5, 4, 601, DateTimeKind.Local).AddTicks(173), new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(4980), "Julia Stark", 82, 3, 394943.605895543110000m, new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 9, 20, 10, 2, 17, 253, DateTimeKind.Local).AddTicks(4038), new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(5745), "Lynne Schuster", 35, 2, 280620.29896457140000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(5745) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 11, 12, 1, 58, 1, 788, DateTimeKind.Local).AddTicks(607), new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(8013), "Tomas Wyman", 2, 3, 343474.40280905140000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 834, DateTimeKind.Utc).AddTicks(8012) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1959, 6, 11, 0, 29, 0, 581, DateTimeKind.Local).AddTicks(7514), new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(68), "Austin Braun", 92, 5, 144953.563595924320000m, new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(67) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 3, 7, 2, 56, 59, 341, DateTimeKind.Local).AddTicks(2881), new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(2449), "Jose Blanda", 48, 3, 116764.328145922330000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1954, 12, 28, 11, 46, 5, 650, DateTimeKind.Local).AddTicks(4560), new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(3242), "Julia Zemlak", 8, 5, 250728.838072034260000m, new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 12, 9, 16, 34, 43, 539, DateTimeKind.Local).AddTicks(8843), new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(5629), "Lula Jacobson", 47, 77214.465891760720000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1970, 3, 3, 4, 33, 25, 307, DateTimeKind.Local).AddTicks(3102), new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(7167), "Santos Jones", 55, 3, 276517.600696831120000m, new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(7166) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2000, 7, 13, 5, 52, 33, 124, DateTimeKind.Local).AddTicks(5543), new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(8787), "George Conroy", 45, 1, 271499.336887424740000m, new DateTime(2024, 2, 20, 16, 12, 1, 835, DateTimeKind.Utc).AddTicks(8787) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 10, 27, 7, 46, 23, 458, DateTimeKind.Local).AddTicks(7512), new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(421), "Bert Conroy", 24, 1, 122233.017902425420000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(421) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1991, 7, 10, 4, 16, 53, 179, DateTimeKind.Local).AddTicks(3807), new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(5230), "Cary Wintheiser", 35, 1, 341774.731927988440000m, new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1994, 8, 1, 21, 38, 26, 900, DateTimeKind.Local).AddTicks(1126), new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(5995), "Warren Kris", 73, 5, 100374.304286413420000m, new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1979, 1, 1, 15, 19, 12, 645, DateTimeKind.Local).AddTicks(5572), new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(6762), "Maryann Tromp", 10, 2, 53355.924401062390000m, new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1972, 9, 14, 21, 59, 6, 426, DateTimeKind.Local).AddTicks(4133), new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(7438), "Terence Cruickshank", 26, 1, 172938.912304072060000m, new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 12, 2, 10, 50, 41, 172, DateTimeKind.Local).AddTicks(8538), new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(8182), "Ross Williamson", 16, 4, 289610.365293463360000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 836, DateTimeKind.Utc).AddTicks(8181) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 6, 28, 14, 53, 27, 973, DateTimeKind.Local).AddTicks(2678), new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(313), "Noel Treutel", 54, 3, 370783.753713839170000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(312) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1995, 4, 28, 4, 9, 20, 267, DateTimeKind.Local).AddTicks(6009), new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(7093), "Hazel Mann", 51, 2, 219728.354092463830000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 2, 18, 19, 7, 12, 458, DateTimeKind.Local).AddTicks(7527), new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(7810), "Jacqueline Kuhn", 60, 351775.378456891990000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 837, DateTimeKind.Utc).AddTicks(7809) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 11, 26, 11, 59, 51, 164, DateTimeKind.Local).AddTicks(2043), new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(139), "Kent Fisher", 69, 4, 296836.776538077610000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 7, 4, 10, 39, 18, 45, DateTimeKind.Local).AddTicks(1024), new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(891), "Warren Feil", 70, 1, 252650.303372261980000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(890) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 1, 12, 12, 38, 15, 626, DateTimeKind.Local).AddTicks(2266), new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(3103), "Ronnie Heller", 3, 144884.911465496920000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(3102) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 12, 9, 13, 52, 54, 10, DateTimeKind.Local).AddTicks(1749), new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(6365), "Krista Renner", 48, 5, 97830.540853664440000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(6364) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1960, 9, 27, 20, 58, 44, 810, DateTimeKind.Local).AddTicks(1945), new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(7855), "Marilyn Greenholt", 56, 2, 42894.7289624291650000m, new DateTime(2024, 2, 20, 16, 12, 1, 838, DateTimeKind.Utc).AddTicks(7854) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 9, 12, 20, 10, 30, 610, DateTimeKind.Local).AddTicks(8498), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(438), "Yolanda Hauck", 1, 5, 262030.486977767290000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1977, 2, 3, 4, 17, 42, 753, DateTimeKind.Local).AddTicks(7208), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(1860), "Hector Feil", 95, 180711.525200263840000m, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(1860) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 7, 26, 10, 51, 37, 190, DateTimeKind.Local).AddTicks(1794), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(3570), "Samantha Considine", 51, 5, 105831.188018924020000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 9, 30, 13, 56, 4, 943, DateTimeKind.Local).AddTicks(4883), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(4416), "Mindy Kub", 80, 1, 192212.945437717870000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1969, 10, 7, 3, 39, 40, 482, DateTimeKind.Local).AddTicks(3803), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(5139), "Philip Streich", 65, 236341.647977745040000m, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 7, 26, 0, 4, 2, 265, DateTimeKind.Local).AddTicks(1843), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(5920), "Woodrow O'Keefe", 14, 2, 261878.827567112590000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 8, 17, 16, 5, 31, 567, DateTimeKind.Local).AddTicks(8372), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(6778), "Eduardo Bergnaum", 44, 5, 384389.095327388830000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 3, 23, 13, 25, 10, 412, DateTimeKind.Local).AddTicks(5132), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(7566), "Harriet Boyle", 89, 3, 173425.158041902120000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 11, 9, 22, 8, 24, 298, DateTimeKind.Local).AddTicks(6720), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(8248), "Jana O'Reilly", 66, 5, 275527.521345549580000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 4, 26, 19, 23, 14, 781, DateTimeKind.Local).AddTicks(1180), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(9060), "Shirley Fisher", 88, 2, 221479.677414881980000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 6, 1, 14, 51, 32, 390, DateTimeKind.Local).AddTicks(4537), new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(9871), "Jordan Wyman", 21, 237345.647296342510000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 839, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1995, 9, 22, 14, 12, 18, 887, DateTimeKind.Local).AddTicks(583), new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(1223), "Emily Little", 3, 2, 47413.58873689450000m, new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1996, 2, 7, 9, 14, 25, 926, DateTimeKind.Local).AddTicks(6680), new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(1998), "Linda Douglas", 7, 54830.119116029650000m, new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1994, 5, 24, 20, 55, 14, 455, DateTimeKind.Local).AddTicks(4937), new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(2853), "Javier Hoeger", 7, 1, 149228.507334995650000m, new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(2852) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 10, 29, 14, 53, 55, 600, DateTimeKind.Local).AddTicks(3242), new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(5251), "Cristina Romaguera", 1, 57252.319621909870000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 2, 12, 20, 4, 54, 166, DateTimeKind.Local).AddTicks(4478), new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(6082), "Bob Mohr", 25, 73815.588469848670000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 840, DateTimeKind.Utc).AddTicks(6081) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1988, 2, 3, 10, 18, 17, 484, DateTimeKind.Local).AddTicks(5475), new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(1596), "Sarah Schaefer", 18, 4, 139847.593199902630000m, new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(1596) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1966, 5, 6, 17, 36, 43, 190, DateTimeKind.Local).AddTicks(5985), new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(4096), "Kurt Becker", 98, 174879.71685758560000m, new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 7, 12, 9, 1, 49, 85, DateTimeKind.Local).AddTicks(8047), new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(4866), "Suzanne Barrows", 7, 257495.379345271330000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 1, 22, 17, 58, 12, 103, DateTimeKind.Local).AddTicks(127), new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(5643), "Neil Torp", 5, 5, 356404.94205430750000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(5643) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 3, 9, 17, 34, 18, 970, DateTimeKind.Local).AddTicks(6211), new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(7992), "Clyde Fahey", 29, 3, 73049.267940580870000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 6, 24, 13, 46, 41, 822, DateTimeKind.Local).AddTicks(606), new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(8746), "Toby Feest", 94, 5, 143093.446576990120000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 841, DateTimeKind.Utc).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Birthdate", "CreateDate", "Name", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 1, 17, 21, 11, 25, 486, DateTimeKind.Local).AddTicks(3182), new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(70), "Rebecca Ondricka", 1, 275796.862300639540000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 7, 9, 17, 29, 18, 997, DateTimeKind.Local).AddTicks(9933), new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(1131), "Freda Wolf", 68, 4, 271512.523682801950000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1967, 6, 8, 9, 30, 31, 348, DateTimeKind.Local).AddTicks(2067), new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(2018), "Sharon McLaughlin", 3, 1, 118413.292428654850000m, new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 9, 4, 3, 48, 16, 396, DateTimeKind.Local).AddTicks(9606), new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(3182), "Maxine Grady", 58, 159906.383491362550000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(3182) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 7, 22, 23, 11, 48, 379, DateTimeKind.Local).AddTicks(1649), new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(5351), "Mike Price", 21, 391163.15457097540000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1980, 8, 10, 11, 19, 21, 138, DateTimeKind.Local).AddTicks(9365), new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(6564), "Kyle Crist", 99, 5, 247650.624129177610000m, new DateTime(2024, 2, 20, 16, 12, 1, 842, DateTimeKind.Utc).AddTicks(6563) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 7, 22, 17, 45, 22, 470, DateTimeKind.Local).AddTicks(5797), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(688), "Roosevelt Barrows", 96, 1, 282528.083542573690000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1961, 7, 22, 22, 43, 1, 780, DateTimeKind.Local).AddTicks(7431), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(1608), "Jaime Jacobs", 14, 4, 172951.780751203210000m, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 1, 30, 4, 32, 26, 603, DateTimeKind.Local).AddTicks(5198), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(2414), "Mark Ankunding", 86, 3, 173279.766303982510000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1968, 9, 3, 2, 54, 3, 187, DateTimeKind.Local).AddTicks(36), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(3180), "Ellen Legros", 83, 2, 111531.218435291320000m, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 5, 12, 0, 1, 5, 540, DateTimeKind.Local).AddTicks(7135), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(3864), "Adrienne Hintz", 96, 1, 123784.096201297210000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1971, 7, 4, 15, 13, 41, 627, DateTimeKind.Local).AddTicks(7324), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(4606), "Abel Pacocha", 50, 3, 268507.607600856640000m, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 11, 4, 23, 5, 6, 823, DateTimeKind.Local).AddTicks(3559), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(5319), "Ella Kautzer", 85, 5, 89547.532101226540000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1980, 11, 19, 0, 4, 28, 506, DateTimeKind.Local).AddTicks(6544), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(5956), "Kellie Heaney", 28, 390315.030080352250000m, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 1, 19, 22, 15, 40, 739, DateTimeKind.Local).AddTicks(7086), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(6713), "Levi Dare", 73, 4, 193407.016465136620000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(6713) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 6, 10, 18, 56, 58, 204, DateTimeKind.Local).AddTicks(3208), new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(9455), "Roxanne O'Hara", 6, 2, 353637.682681821580000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 843, DateTimeKind.Utc).AddTicks(9454) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 9, 17, 17, 29, 44, 208, DateTimeKind.Local).AddTicks(1709), new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(1960), "Paul Koss", 84, 5, 356263.925576476570000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Birthdate", "CreateDate", "Name", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 4, 25, 13, 44, 24, 0, DateTimeKind.Local).AddTicks(110), new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(2672), "Irving Gerhold", 196229.969122871050000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(2671) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 9, 22, 13, 10, 5, 162, DateTimeKind.Local).AddTicks(452), new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(4942), "Walter Nolan", 6, 250937.218183350520000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1963, 3, 18, 21, 13, 29, 698, DateTimeKind.Local).AddTicks(2574), new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(5708), "Dora Ullrich", 35, 2, 285578.079056896720000m, new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(5707) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 5, 5, 0, 35, 43, 714, DateTimeKind.Local).AddTicks(6762), new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(9697), "Pamela Schimmel", 47, 355687.29401142430000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 844, DateTimeKind.Utc).AddTicks(9697) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 2, 19, 3, 59, 25, 313, DateTimeKind.Local).AddTicks(3832), new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(2877), "Joseph Jacobson", 68, 4, 313076.688764975710000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(2877) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1959, 3, 23, 18, 10, 8, 584, DateTimeKind.Local).AddTicks(9716), new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(5359), "Kristen Champlin", 49, 4, 231059.38084475830000m, new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 5, 2, 13, 55, 55, 90, DateTimeKind.Local).AddTicks(7882), new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(6281), "Sam Lebsack", 13, 362192.925502640560000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2001, 7, 29, 1, 0, 18, 389, DateTimeKind.Local).AddTicks(5259), new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(7081), "Kendra Legros", 63, 4, 285264.668519981530000m, new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(7080) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1979, 9, 2, 8, 48, 59, 722, DateTimeKind.Local).AddTicks(3405), new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(9970), "Kristin Mueller", 85, 5, 277720.263505613620000m, new DateTime(2024, 2, 20, 16, 12, 1, 845, DateTimeKind.Utc).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 9, 10, 1, 29, 42, 432, DateTimeKind.Local).AddTicks(2484), new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(743), "Troy Rath", 71, 3, 194665.306864818130000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 4, 21, 8, 51, 45, 588, DateTimeKind.Local).AddTicks(4801), new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(1534), "Ruben Hoeger", 50, 289666.656530284660000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(1534) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1981, 1, 30, 12, 41, 34, 867, DateTimeKind.Local).AddTicks(8886), new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(5996), "Tracy Reinger", 62, 3, 211092.733833262570000m, new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1961, 8, 5, 20, 20, 2, 24, DateTimeKind.Local).AddTicks(8569), new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(7709), "Shelly McCullough", 37, 3, 64964.61185312890000m, new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(7708) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 5, 8, 20, 27, 12, 727, DateTimeKind.Local).AddTicks(4844), new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(9664), "Amber Dietrich", 74, 4, 354840.700718575360000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 846, DateTimeKind.Utc).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 5, 29, 1, 48, 30, 456, DateTimeKind.Local).AddTicks(8633), new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(545), "Bernadette Mayert", 9, 4, 112700.68516066840000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1981, 6, 9, 23, 12, 53, 313, DateTimeKind.Local).AddTicks(1885), new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(1513), "Rochelle DuBuque", 81, 108184.103679021880000m, new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(1513) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 4, 5, 13, 44, 33, 103, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(5356), "Cynthia Will", 53, 4, 206353.091510539990000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(5355) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 8, 26, 13, 12, 51, 665, DateTimeKind.Local).AddTicks(1985), new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(7404), "Maxine Douglas", 93, 364410.034965132640000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(7403) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 8, 30, 15, 50, 10, 41, DateTimeKind.Local).AddTicks(5532), new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(9531), "Phil Funk", 95, 1, 249979.192428553630000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 847, DateTimeKind.Utc).AddTicks(9530) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1998, 9, 12, 5, 47, 54, 672, DateTimeKind.Local).AddTicks(7569), new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(3961), "Juana Emmerich", 83, 3, 15066.2058463348540000m, new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 7, 7, 11, 22, 59, 723, DateTimeKind.Local).AddTicks(3817), new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(5294), "Al Rath", 15, 5, 116540.963418733480000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(5294) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2000, 6, 10, 8, 38, 11, 669, DateTimeKind.Local).AddTicks(5173), new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(6812), "Wm Gulgowski", 83, 3, 129781.942408646440000m, new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1998, 1, 6, 3, 30, 59, 946, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(8097), "Dominic Gutmann", 40, 3, 37927.7239952867260000m, new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1988, 3, 19, 9, 22, 47, 496, DateTimeKind.Local).AddTicks(4523), new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(8994), "Kendra Stracke", 66, 19146.8919491233570000m, new DateTime(2024, 2, 20, 16, 12, 1, 848, DateTimeKind.Utc).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 4, 4, 22, 37, 35, 692, DateTimeKind.Local).AddTicks(2375), new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(52), "Jacqueline O'Keefe", 19, 63579.53559704980000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(52) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 4, 5, 22, 37, 22, 170, DateTimeKind.Local).AddTicks(272), new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(2483), "Mindy Grady", 90, 4, 339848.30235465550000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 11, 7, 19, 33, 35, 319, DateTimeKind.Local).AddTicks(5669), new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(3813), "Clayton Stroman", 100, 3, 339605.986794127810000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(3812) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 4, 1, 0, 50, 5, 331, DateTimeKind.Local).AddTicks(2834), new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(6406), "Victoria Kuhlman", 54, 33885.3594291834340000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(6405) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 12, 21, 5, 53, 32, 909, DateTimeKind.Local).AddTicks(1430), new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(8556), "Dwayne Rau", 13, 362887.718301191320000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 849, DateTimeKind.Utc).AddTicks(8555) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 4, 17, 5, 31, 9, 871, DateTimeKind.Local).AddTicks(9540), new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(149), "Natalie Miller", 30, 393362.87087603830000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 5, 5, 16, 24, 54, 180, DateTimeKind.Local).AddTicks(6318), new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(1467), "Peter Hane", 84, 1, 326781.151493271790000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(1465) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 1, 14, 12, 0, 58, 129, DateTimeKind.Local).AddTicks(8974), new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(5079), "Victoria O'Keefe", 66, 5, 324057.885233153620000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1966, 11, 6, 16, 16, 23, 805, DateTimeKind.Local).AddTicks(6415), new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(6860), "Anne Satterfield", 88, 1, 12901.252732375660000m, new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 7, 3, 12, 47, 57, 850, DateTimeKind.Local).AddTicks(1454), new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(8403), "Lorraine Kutch", 55, 322140.667084059190000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 11, 12, 23, 54, 39, 957, DateTimeKind.Local).AddTicks(1385), new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(9665), "Sylvia Emard", 86, 3, 379201.819200479980000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 850, DateTimeKind.Utc).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 1, 18, 20, 0, 36, 321, DateTimeKind.Local).AddTicks(5219), new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(838), "Yolanda Ruecker", 56, 1, 44861.1456544098280000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1964, 2, 2, 4, 2, 10, 173, DateTimeKind.Local).AddTicks(9309), new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(2077), "Raymond Ledner", 3, 2, 97103.846258437060000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 7, 3, 14, 38, 58, 663, DateTimeKind.Local).AddTicks(731), new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(3313), "Peggy Doyle", 31, 180578.018176508020000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 12, 19, 10, 23, 36, 505, DateTimeKind.Local).AddTicks(8939), new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(4453), "Kristen Rempel", 8, 179390.595588624280000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1986, 3, 26, 12, 52, 1, 808, DateTimeKind.Local).AddTicks(8982), new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(6379), "Natalie Kuvalis", 74, 5, 323969.299078913140000m, new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(6378) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 8, 3, 20, 50, 45, 860, DateTimeKind.Local).AddTicks(3221), new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(8749), "Jacqueline O'Hara", 40, 283468.307925595120000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 851, DateTimeKind.Utc).AddTicks(8748) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 7, 1, 4, 17, 53, 485, DateTimeKind.Local).AddTicks(6551), new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(1192), "Arlene Wyman", 53, 2, 297840.919296885760000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(1191) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1966, 9, 26, 23, 42, 25, 324, DateTimeKind.Local).AddTicks(3966), new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(3487), "Anne Hilpert", 27, 347883.449895224740000m, new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 2, 8, 13, 38, 26, 652, DateTimeKind.Local).AddTicks(730), new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(4561), "Jackie Marks", 84, 67150.607135574550000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(4560) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1975, 10, 15, 10, 59, 15, 284, DateTimeKind.Local).AddTicks(1085), new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(7333), "Mildred Wisoky", 74, 2, 53630.804091740710000m, new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(7333) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2003, 9, 20, 16, 47, 7, 599, DateTimeKind.Local).AddTicks(1371), new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(8859), "Drew Beahan", 99, 1, 232126.576512133150000m, new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Birthdate", "CreateDate", "Name", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 6, 23, 13, 19, 53, 660, DateTimeKind.Local).AddTicks(7824), new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(9593), "Lewis Hoppe", 5, 142045.987546248490000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 852, DateTimeKind.Utc).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 3, 6, 6, 17, 7, 227, DateTimeKind.Local).AddTicks(4179), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(343), "Kelly Schumm", 32, 1, 206461.296378775090000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(342) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 12, 29, 5, 47, 9, 931, DateTimeKind.Local).AddTicks(4872), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(1785), "Jean Koepp", 92, 5, 399327.823721878990000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1983, 7, 10, 0, 53, 2, 761, DateTimeKind.Local).AddTicks(5449), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(2502), "Pauline Schaden", 91, 3, 378547.722617006140000m, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 4, 16, 13, 6, 47, 751, DateTimeKind.Local).AddTicks(5643), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(3281), "Ruby Corwin", 70, 42995.532231826450000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1981, 8, 20, 22, 24, 25, 698, DateTimeKind.Local).AddTicks(8337), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(4383), "Debbie Corkery", 28, 129642.647632294930000m, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1956, 5, 14, 5, 31, 46, 109, DateTimeKind.Local).AddTicks(8738), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(5424), "Winifred Kessler", 76, 3, 345085.058016115030000m, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(5424) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 2, 9, 10, 24, 57, 577, DateTimeKind.Local).AddTicks(6441), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(7153), "Archie Ryan", 90, 3, 66970.134386009260000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1984, 6, 8, 7, 3, 39, 854, DateTimeKind.Local).AddTicks(8397), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(7929), "Kenny Russel", 7, 5, 348090.786762023620000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 6, 23, 12, 14, 4, 410, DateTimeKind.Local).AddTicks(2680), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(8678), "Elias Olson", 91, 3, 265510.292297901940000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 7, 2, 5, 51, 46, 23, DateTimeKind.Local).AddTicks(2147), new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(9449), "Celia Herman", 41, 3, 161407.38942905680000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 853, DateTimeKind.Utc).AddTicks(9448) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1970, 8, 15, 12, 17, 5, 496, DateTimeKind.Local).AddTicks(4887), new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(990), "Vicky Skiles", 18, 5, 214169.248512846760000m, new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(990) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 12, 24, 16, 24, 58, 752, DateTimeKind.Local).AddTicks(9570), new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(2464), "Don Kub", 55, 1, 342887.701133384410000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1973, 5, 16, 19, 40, 22, 173, DateTimeKind.Local).AddTicks(4308), new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(3105), "Kerry Towne", 6, 1, 299748.169892542660000m, new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(3104) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1968, 7, 10, 4, 4, 11, 319, DateTimeKind.Local).AddTicks(951), new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(5288), "Ron Dicki", 72, 161531.270271578860000m, new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(5287) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 7, 30, 9, 29, 10, 783, DateTimeKind.Local).AddTicks(361), new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(6795), "Jennifer Schroeder", 49, 378914.563757056720000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(6795) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1957, 11, 15, 23, 2, 36, 667, DateTimeKind.Local).AddTicks(5236), new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(8259), "Elena Daugherty", 13, 2, 58913.567036299030000m, new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(8259) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 3, 22, 2, 27, 0, 359, DateTimeKind.Local).AddTicks(6198), new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(9935), "Arthur Hodkiewicz", 32, 89800.825340110420000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 854, DateTimeKind.Utc).AddTicks(9935) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 11, 20, 14, 46, 57, 427, DateTimeKind.Local).AddTicks(2634), new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(1418), "Heather Bergstrom", 15, 139561.097643895840000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(1417) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1980, 3, 27, 6, 28, 46, 56, DateTimeKind.Local).AddTicks(4843), new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(5144), "Leona Haag", 72, 229308.72709999240000m, new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 11, 9, 14, 6, 17, 510, DateTimeKind.Local).AddTicks(5205), new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(5800), "Martha Lindgren", 29, 5, 197631.09285312340000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(5799) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 1, 15, 6, 0, 4, 793, DateTimeKind.Local).AddTicks(5512), new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(7344), "Harvey Hane", 34, 1, 271182.589370001520000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 2, 22, 6, 14, 1, 477, DateTimeKind.Local).AddTicks(8529), new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(8110), "Doris Nader", 81, 231888.43342929640000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2002, 10, 20, 7, 38, 35, 844, DateTimeKind.Local).AddTicks(1649), new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(8900), "Rex Hammes", 14, 2, 188258.264369718910000m, new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 4, 5, 3, 34, 40, 618, DateTimeKind.Local).AddTicks(3451), new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(9539), "Tonya Hessel", 24, 389594.404236615490000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 855, DateTimeKind.Utc).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 9, 23, 23, 31, 11, 963, DateTimeKind.Local).AddTicks(6379), new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(469), "Margaret Harris", 42, 260017.756235382850000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 2, 11, 8, 36, 8, 292, DateTimeKind.Local).AddTicks(8770), new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(1231), "Jean MacGyver", 38, 3, 295574.71448955280000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(1230) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1994, 8, 4, 22, 20, 2, 754, DateTimeKind.Local).AddTicks(5872), new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(6881), "Terry Rogahn", 87, 222877.262593599760000m, new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1974, 2, 7, 21, 0, 51, 799, DateTimeKind.Local).AddTicks(6546), new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(7693), "Colleen Brown", 96, 4, 25530.4016301392530000m, new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 2, 24, 23, 30, 36, 681, DateTimeKind.Local).AddTicks(6025), new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(8400), "Delores Hauck", 27, 1, 211151.596987634410000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 1, 25, 2, 46, 5, 386, DateTimeKind.Local).AddTicks(7309), new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(9227), "Brooke Gorczany", 90, 5, 29494.6943082810880000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 856, DateTimeKind.Utc).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 9, 22, 1, 20, 6, 168, DateTimeKind.Local).AddTicks(7444), new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(58), "Vicki Zboncak", 37, 300745.245718446220000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(58) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1964, 12, 3, 8, 10, 48, 513, DateTimeKind.Local).AddTicks(4691), new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(2814), "Violet Parker", 7, 379165.229903249260000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(2814) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 1, 1, 20, 21, 19, 382, DateTimeKind.Local).AddTicks(3982), new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(6801), "Suzanne Kilback", 85, 3, 123564.522748806610000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1993, 9, 17, 1, 38, 3, 140, DateTimeKind.Local).AddTicks(2629), new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(7524), "Anita Volkman", 90, 5, 305041.984718729170000m, new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1995, 1, 13, 15, 52, 45, 724, DateTimeKind.Local).AddTicks(2731), new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(8242), "May Kuhn", 40, 4, 132252.16509385750000m, new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(8242) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1995, 6, 6, 21, 36, 31, 305, DateTimeKind.Local).AddTicks(7148), new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(9580), "Jeannette Tillman", 100, 3, 346656.693427529020000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 857, DateTimeKind.Utc).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 11, 19, 19, 13, 10, 147, DateTimeKind.Local).AddTicks(4123), new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(344), "Danielle Lemke", 92, 2, 313218.20397946090000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 9, 7, 11, 31, 35, 437, DateTimeKind.Local).AddTicks(8974), new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(1043), "Kristine Stark", 49, 3, 64509.557498534710000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(1042) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1963, 12, 29, 11, 34, 33, 585, DateTimeKind.Local).AddTicks(1851), new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(7145), "Jon O'Reilly", 25, 5, 148054.309166183410000m, new DateTime(2024, 2, 20, 16, 12, 1, 858, DateTimeKind.Utc).AddTicks(7145) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 7, 15, 9, 27, 59, 628, DateTimeKind.Local).AddTicks(3418), new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(251), "Alan Fahey", 78, 3, 43336.4776539895360000m, 5, new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(250) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 12, 24, 9, 40, 56, 94, DateTimeKind.Local).AddTicks(852), new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(3508), "Carl Dietrich", 87, 181096.727304040330000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 7, 6, 17, 47, 26, 253, DateTimeKind.Local).AddTicks(3070), new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(4386), "Jeanne Abshire", 86, 1, 152978.621197861930000m, 1, new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 11, 8, 14, 21, 45, 819, DateTimeKind.Local).AddTicks(3851), new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(5184), "Jacquelyn Kassulke", 22, 1, 60689.160634230430000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 11, 8, 22, 26, 56, 738, DateTimeKind.Local).AddTicks(8336), new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(6072), "Laurie Schoen", 83, 359657.817091913980000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1961, 11, 10, 22, 54, 36, 211, DateTimeKind.Local).AddTicks(2541), new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(6817), "Daniel Rutherford", 33, 5, 373387.858647412690000m, new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1956, 3, 5, 4, 32, 25, 249, DateTimeKind.Local).AddTicks(7137), new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(7623), "Stephanie Wisoky", 32, 3, 352088.732342216860000m, new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 5, 26, 14, 51, 56, 610, DateTimeKind.Local).AddTicks(8718), new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(8492), "May Conn", 37, 4, 349196.759216152630000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 7, 28, 20, 46, 40, 984, DateTimeKind.Local).AddTicks(6579), new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(9271), "Arthur Satterfield", 10, 1, 109618.247227218850000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 859, DateTimeKind.Utc).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 5, 10, 12, 56, 14, 277, DateTimeKind.Local).AddTicks(5077), new DateTime(2024, 2, 20, 16, 12, 1, 860, DateTimeKind.Utc).AddTicks(423), "Dallas Moore", 12, 325355.259517017070000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 860, DateTimeKind.Utc).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 4, 7, 17, 42, 4, 12, DateTimeKind.Local).AddTicks(1621), new DateTime(2024, 2, 20, 16, 12, 1, 860, DateTimeKind.Utc).AddTicks(6031), "Juana Hagenes", 17, 244494.208971152650000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 860, DateTimeKind.Utc).AddTicks(6028) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 4, 17, 23, 27, 21, 616, DateTimeKind.Local).AddTicks(9860), new DateTime(2024, 2, 20, 16, 12, 1, 861, DateTimeKind.Utc).AddTicks(9132), "Leslie Kub", 53, 361613.66405098180000m, 3, new DateTime(2024, 2, 20, 16, 12, 1, 861, DateTimeKind.Utc).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 7, 21, 9, 13, 48, 504, DateTimeKind.Local).AddTicks(5243), new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(44), "Johnathan Gibson", 89, 2, 340963.845812517970000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 9, 3, 13, 16, 4, 255, DateTimeKind.Local).AddTicks(8285), new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(1024), "Verna Rodriguez", 74, 215570.509884300730000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(1024) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 2, 24, 19, 33, 50, 482, DateTimeKind.Local).AddTicks(8022), new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(2806), "Wendell Hodkiewicz", 63, 1, 172646.60230826020000m, 4, new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1970, 7, 25, 22, 1, 37, 882, DateTimeKind.Local).AddTicks(1479), new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(3756), "Darren Quitzon", 44, 5, 193192.954033420240000m, new DateTime(2024, 2, 20, 16, 12, 1, 862, DateTimeKind.Utc).AddTicks(3755) });

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
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 3, 28, 17, 11, 42, 993, DateTimeKind.Local).AddTicks(9379), new DateTime(2024, 2, 20, 16, 12, 1, 863, DateTimeKind.Utc).AddTicks(1871), "Albert Strosin", 71, 177827.567023486240000m, 2, new DateTime(2024, 2, 20, 16, 12, 1, 863, DateTimeKind.Utc).AddTicks(1871) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 3, 18, 3, 57, 2, 690, DateTimeKind.Local).AddTicks(6213), new DateTime(2024, 2, 20, 15, 20, 41, 39, DateTimeKind.Utc).AddTicks(4471), "Jo Daugherty", 94, 3, 289799.696738616730000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 39, DateTimeKind.Utc).AddTicks(4464) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 12, 12, 0, 34, 34, 709, DateTimeKind.Local).AddTicks(975), new DateTime(2024, 2, 20, 15, 20, 41, 40, DateTimeKind.Utc).AddTicks(3368), "Roy Kozey", 59, 2, 282193.89059927350000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 40, DateTimeKind.Utc).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 9, 20, 9, 4, 23, 941, DateTimeKind.Local).AddTicks(5556), new DateTime(2024, 2, 20, 15, 20, 41, 40, DateTimeKind.Utc).AddTicks(4504), "Anna Ernser", 54, 2, 387627.620983477540000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 40, DateTimeKind.Utc).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 11, 14, 20, 35, 43, 333, DateTimeKind.Local).AddTicks(4165), new DateTime(2024, 2, 20, 15, 20, 41, 40, DateTimeKind.Utc).AddTicks(5171), "Lisa Kshlerin", 80, 4, 14649.2311975799950000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 40, DateTimeKind.Utc).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 11, 30, 11, 26, 30, 223, DateTimeKind.Local).AddTicks(8362), new DateTime(2024, 2, 20, 15, 20, 41, 40, DateTimeKind.Utc).AddTicks(6116), "Vicky Streich", 78, 4, 60522.223643947510000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 40, DateTimeKind.Utc).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1993, 5, 13, 13, 42, 44, 439, DateTimeKind.Local).AddTicks(9667), new DateTime(2024, 2, 20, 15, 20, 41, 40, DateTimeKind.Utc).AddTicks(6893), "Freda Howell", 47, 5, 275938.410422660560000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 40, DateTimeKind.Utc).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 12, 30, 16, 24, 17, 470, DateTimeKind.Local).AddTicks(4927), new DateTime(2024, 2, 20, 15, 20, 41, 40, DateTimeKind.Utc).AddTicks(8016), "Sheila Simonis", 87, 118070.173008528640000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 40, DateTimeKind.Utc).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 1, 1, 14, 13, 23, 412, DateTimeKind.Local).AddTicks(2031), new DateTime(2024, 2, 20, 15, 20, 41, 40, DateTimeKind.Utc).AddTicks(8681), "Jenny Thompson", 47, 5, 262111.866594719560000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 40, DateTimeKind.Utc).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1995, 5, 2, 14, 58, 23, 74, DateTimeKind.Local).AddTicks(1606), new DateTime(2024, 2, 20, 15, 20, 41, 40, DateTimeKind.Utc).AddTicks(9286), "Gustavo Pouros", 74, 3, 120526.437621870010000m, new DateTime(2024, 2, 20, 15, 20, 41, 40, DateTimeKind.Utc).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 10, 24, 20, 6, 30, 453, DateTimeKind.Local).AddTicks(920), new DateTime(2024, 2, 20, 15, 20, 41, 40, DateTimeKind.Utc).AddTicks(9935), "Brett Schinner", 65, 259984.6587495010000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 40, DateTimeKind.Utc).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 6, 9, 13, 45, 57, 30, DateTimeKind.Local).AddTicks(9343), new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(496), "Sarah Waters", 93, 1, 87961.118631724120000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 3, 5, 13, 30, 19, 662, DateTimeKind.Local).AddTicks(9378), new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(1109), "Pablo Hahn", 91, 5, 84056.903654692270000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 12, 15, 9, 4, 5, 811, DateTimeKind.Local).AddTicks(831), new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(1705), "Eddie Lang", 53, 1, 65169.419085447160000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1965, 7, 19, 9, 40, 26, 135, DateTimeKind.Local).AddTicks(5800), new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(2667), "Lindsey Leannon", 100, 2, 324709.397470706680000m, new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1993, 12, 5, 14, 35, 27, 5, DateTimeKind.Local).AddTicks(6450), new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(3505), "Willie Lang", 6, 3, 157262.837386144480000m, new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(3505) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1993, 8, 27, 8, 34, 16, 472, DateTimeKind.Local).AddTicks(1194), new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(4150), "Jasmine Wiegand", 92, 3, 138706.137871153180000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 11, 22, 8, 49, 52, 900, DateTimeKind.Local).AddTicks(4760), new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(4737), "Kelly MacGyver", 47, 2, 330248.98293667630000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1961, 5, 3, 11, 33, 53, 843, DateTimeKind.Local).AddTicks(4672), new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(5323), "Lula Gulgowski", 25, 2, 57733.213176863110000m, new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 9, 25, 17, 50, 29, 668, DateTimeKind.Local).AddTicks(2098), new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(5907), "Dianne Jast", 17, 3, 44452.1746772793460000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 1, 29, 13, 12, 24, 466, DateTimeKind.Local).AddTicks(4190), new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(6538), "Emily Feil", 77, 356398.052892244990000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1967, 2, 28, 17, 2, 18, 463, DateTimeKind.Local).AddTicks(2431), new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(7031), "Stewart Cummings", 43, 5, 206015.515939206340000m, new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Birthdate", "CreateDate", "Name", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 3, 2, 14, 5, 4, 596, DateTimeKind.Local).AddTicks(6002), new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(7592), "Laura Smitham", 4, 126334.709453521390000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1984, 8, 20, 21, 13, 8, 278, DateTimeKind.Local).AddTicks(5959), new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(8152), "Alyssa Kshlerin", 70, 5, 290922.411286630360000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 9, 28, 8, 37, 38, 524, DateTimeKind.Local).AddTicks(86), new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(8713), "Lorena Kiehn", 78, 2, 55308.984552528190000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 12, 29, 6, 56, 25, 430, DateTimeKind.Local).AddTicks(1940), new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(9645), "Alex Quitzon", 8, 323724.34841076940000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 41, DateTimeKind.Utc).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 6, 12, 9, 56, 48, 744, DateTimeKind.Local).AddTicks(4342), new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(338), "Ronald Wyman", 32, 201954.747608587990000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 3, 8, 11, 22, 1, 815, DateTimeKind.Local).AddTicks(9699), new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(916), "Amelia Weimann", 21, 3, 52587.306430184620000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2003, 8, 24, 7, 23, 48, 885, DateTimeKind.Local).AddTicks(7502), new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(1423), "Doug Osinski", 46, 3, 391610.704056651940000m, new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 7, 13, 19, 6, 7, 501, DateTimeKind.Local).AddTicks(364), new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(1968), "Kerry Kris", 100, 1, 81749.162710127890000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 11, 13, 6, 56, 52, 65, DateTimeKind.Local).AddTicks(7919), new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(2913), "Josh Price", 46, 5, 179540.348114203690000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 2, 6, 22, 6, 44, 915, DateTimeKind.Local).AddTicks(9214), new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(3724), "Kenneth Johnson", 43, 3, 21916.9260522100360000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(3723) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 5, 22, 4, 23, 17, 836, DateTimeKind.Local).AddTicks(2296), new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(4331), "Cecelia Mills", 28, 3, 19661.5909394066920000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1997, 9, 27, 0, 44, 11, 591, DateTimeKind.Local).AddTicks(1205), new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(4940), "Jo Cassin", 100, 3, 29436.3203980855390000m, new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1969, 6, 15, 19, 12, 28, 481, DateTimeKind.Local).AddTicks(232), new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(5482), "Dean Wintheiser", 45, 2, 78864.234070674640000m, new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 6, 1, 4, 34, 52, 751, DateTimeKind.Local).AddTicks(3243), new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(6433), "Lorene Crooks", 81, 2, 188097.988867240780000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1986, 11, 4, 0, 57, 49, 472, DateTimeKind.Local).AddTicks(9793), new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(7065), "Dominic Fadel", 39, 4, 46261.5041498403070000m, new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2002, 8, 23, 15, 41, 30, 224, DateTimeKind.Local).AddTicks(362), new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(7691), "Francis Adams", 44, 3, 238221.115866879850000m, new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 8, 30, 5, 39, 30, 616, DateTimeKind.Local).AddTicks(7032), new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(8223), "Dale Crona", 28, 3, 254550.133334094640000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 9, 22, 20, 34, 37, 683, DateTimeKind.Local).AddTicks(1410), new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(8798), "Faye Hermann", 93, 5, 99249.413935613230000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(8798) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 10, 25, 23, 52, 19, 828, DateTimeKind.Local).AddTicks(3224), new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(9355), "Everett Klocko", 57, 5, 180628.243046359930000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 5, 6, 8, 32, 47, 280, DateTimeKind.Local).AddTicks(3479), new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(9865), "Ramiro Kihn", 31, 1, 394834.942369096180000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 42, DateTimeKind.Utc).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1984, 11, 4, 6, 55, 15, 214, DateTimeKind.Local).AddTicks(6519), new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(365), "Shelly Walsh", 66, 343917.663676253020000m, new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 9, 12, 1, 56, 25, 748, DateTimeKind.Local).AddTicks(313), new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(953), "Lori Rohan", 58, 4, 149787.848843567470000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 8, 13, 3, 44, 39, 948, DateTimeKind.Local).AddTicks(4191), new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(1453), "Christy O'Hara", 70, 3, 266150.241687338050000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2003, 1, 7, 7, 38, 29, 481, DateTimeKind.Local).AddTicks(8524), new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(2077), "Antonio Champlin", 82, 349862.215483327420000m, new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 1, 9, 1, 19, 28, 188, DateTimeKind.Local).AddTicks(3918), new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(3369), "Mildred Schoen", 16, 4, 71922.703227381880000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 6, 13, 3, 49, 26, 42, DateTimeKind.Local).AddTicks(7316), new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(4117), "Nadine Stokes", 61, 4, 130200.912718827460000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 3, 27, 19, 28, 18, 5, DateTimeKind.Local).AddTicks(2212), new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(4987), "Desiree Bogan", 4, 1, 309869.43867273250000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 9, 5, 2, 45, 27, 949, DateTimeKind.Local).AddTicks(2979), new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(5959), "Joseph Strosin", 49, 5, 152879.608488424990000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1977, 8, 24, 17, 4, 59, 233, DateTimeKind.Local).AddTicks(9051), new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(6826), "Camille Williamson", 66, 4, 325396.011676405270000m, new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1993, 1, 5, 0, 33, 33, 561, DateTimeKind.Local).AddTicks(144), new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(7689), "Luther Grimes", 46, 5, 216614.605245315280000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 1, 21, 7, 21, 50, 742, DateTimeKind.Local).AddTicks(7239), new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(8460), "Molly Batz", 16, 281166.522223776790000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 12, 16, 2, 8, 54, 766, DateTimeKind.Local).AddTicks(6990), new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(9758), "Dwayne Schamberger", 73, 1, 177037.180970060050000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 43, DateTimeKind.Utc).AddTicks(9757) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 8, 12, 13, 18, 34, 38, DateTimeKind.Local).AddTicks(6520), new DateTime(2024, 2, 20, 15, 20, 41, 44, DateTimeKind.Utc).AddTicks(1181), "Carrie Kunze", 83, 4, 177137.055783817990000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 44, DateTimeKind.Utc).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 6, 8, 22, 35, 22, 789, DateTimeKind.Local).AddTicks(5180), new DateTime(2024, 2, 20, 15, 20, 41, 44, DateTimeKind.Utc).AddTicks(4312), "Loren Barton", 54, 208412.364930377260000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 44, DateTimeKind.Utc).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 11, 9, 23, 4, 30, 499, DateTimeKind.Local).AddTicks(2395), new DateTime(2024, 2, 20, 15, 20, 41, 44, DateTimeKind.Utc).AddTicks(5832), "Dan Quitzon", 74, 47517.5118860234290000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 44, DateTimeKind.Utc).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 5, 20, 22, 13, 52, 673, DateTimeKind.Local).AddTicks(1924), new DateTime(2024, 2, 20, 15, 20, 41, 44, DateTimeKind.Utc).AddTicks(6688), "Lorraine Stiedemann", 3, 3, 370711.019653946260000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 44, DateTimeKind.Utc).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1984, 2, 20, 10, 8, 6, 661, DateTimeKind.Local).AddTicks(4556), new DateTime(2024, 2, 20, 15, 20, 41, 44, DateTimeKind.Utc).AddTicks(8130), "Mabel Morissette", 88, 3, 13776.90825173862850000m, new DateTime(2024, 2, 20, 15, 20, 41, 44, DateTimeKind.Utc).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 1, 10, 14, 36, 21, 647, DateTimeKind.Local).AddTicks(3418), new DateTime(2024, 2, 20, 15, 20, 41, 44, DateTimeKind.Utc).AddTicks(9094), "Marcia Cole", 30, 303120.414601388920000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 44, DateTimeKind.Utc).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1998, 10, 22, 1, 22, 2, 380, DateTimeKind.Local).AddTicks(2585), new DateTime(2024, 2, 20, 15, 20, 41, 44, DateTimeKind.Utc).AddTicks(9923), "Bethany Glover", 28, 1, 58418.638919778010000m, new DateTime(2024, 2, 20, 15, 20, 41, 44, DateTimeKind.Utc).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 1, 3, 21, 16, 56, 920, DateTimeKind.Local).AddTicks(8713), new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(518), "Loretta Lynch", 39, 2, 34786.1132236319680000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 1, 25, 9, 40, 42, 448, DateTimeKind.Local).AddTicks(8596), new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(1088), "Violet Mertz", 60, 5, 294674.958327157840000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 2, 19, 23, 18, 30, 21, DateTimeKind.Local).AddTicks(3115), new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(1739), "Merle Stark", 60, 1, 324285.622260991030000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 4, 3, 20, 48, 37, 31, DateTimeKind.Local).AddTicks(1604), new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(2263), "Grace Wilderman", 49, 5, 241336.304139344170000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 8, 3, 11, 2, 44, 536, DateTimeKind.Local).AddTicks(1572), new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(3388), "Antonio Hegmann", 43, 2, 16936.4728511051740000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 12, 7, 2, 35, 41, 79, DateTimeKind.Local).AddTicks(6278), new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(4322), "Evelyn Hauck", 5, 1, 341280.206978794450000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 9, 2, 13, 19, 10, 724, DateTimeKind.Local).AddTicks(911), new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(5172), "Lonnie Mann", 89, 1, 207083.713261073080000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 4, 2, 14, 37, 56, 439, DateTimeKind.Local).AddTicks(2345), new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(5849), "Francis Boyle", 35, 274714.156671778060000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 11, 1, 16, 55, 47, 402, DateTimeKind.Local).AddTicks(4966), new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(6480), "Bryant Morar", 97, 4, 237507.760974085930000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 7, 18, 13, 52, 11, 512, DateTimeKind.Local).AddTicks(5999), new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(7044), "Jan Corwin", 25, 360331.944656535010000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 3, 19, 8, 49, 59, 852, DateTimeKind.Local).AddTicks(7097), new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(7577), "Lydia Stanton", 17, 43954.8282361656160000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1975, 6, 14, 7, 3, 26, 62, DateTimeKind.Local).AddTicks(5179), new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(8143), "Donnie Goyette", 36, 1, 51100.414791992530000m, new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 1, 2, 17, 21, 54, 987, DateTimeKind.Local).AddTicks(9799), new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(8705), "Kent Stamm", 19, 2, 111866.607507083770000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 7, 14, 23, 43, 54, 774, DateTimeKind.Local).AddTicks(6390), new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(9314), "Jimmie Deckow", 52, 5, 233881.933364694670000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 7, 28, 22, 23, 56, 635, DateTimeKind.Local).AddTicks(5521), new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(9870), "Velma Ernser", 34, 5, 95968.484683865680000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 45, DateTimeKind.Utc).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 12, 9, 22, 49, 30, 730, DateTimeKind.Local).AddTicks(6442), new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(482), "Josefina Swift", 15, 4, 192493.485145594870000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1982, 5, 8, 16, 1, 59, 543, DateTimeKind.Local).AddTicks(6704), new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(1539), "Ora Altenwerth", 56, 4, 328584.606031323580000m, new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1995, 6, 4, 5, 3, 14, 257, DateTimeKind.Local).AddTicks(2699), new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(2189), "Delia Larkin", 90, 2, 373997.625668634490000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 8, 9, 23, 53, 38, 699, DateTimeKind.Local).AddTicks(5794), new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(2827), "Megan O'Conner", 80, 4, 315504.394870196080000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1973, 3, 6, 4, 40, 54, 549, DateTimeKind.Local).AddTicks(416), new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(3458), "Johnnie Rolfson", 77, 261553.054062167260000m, new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 1, 3, 22, 14, 11, 749, DateTimeKind.Local).AddTicks(2270), new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(3971), "Becky Wyman", 1, 4, 174050.066337899560000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1984, 10, 24, 8, 10, 50, 140, DateTimeKind.Local).AddTicks(3965), new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(4518), "Carmen Padberg", 27, 3, 18075.1089254482660000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 12, 24, 23, 4, 14, 1, DateTimeKind.Local).AddTicks(242), new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(5068), "Lee Schmeler", 31, 3, 357093.932198132860000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 1, 3, 12, 5, 8, 984, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(5584), "Jared Streich", 12, 4, 91825.241954194180000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 11, 4, 23, 35, 41, 726, DateTimeKind.Local).AddTicks(4673), new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(6081), "Melanie Bins", 64, 2, 247880.460361775920000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 5, 20, 15, 51, 30, 714, DateTimeKind.Local).AddTicks(6139), new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(6652), "Chris Gutmann", 3, 3, 196120.952372369560000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 9, 2, 17, 57, 45, 705, DateTimeKind.Local).AddTicks(5558), new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(8234), "Pamela Rippin", 12, 3, 322052.779612831270000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 46, DateTimeKind.Utc).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 8, 25, 19, 22, 38, 117, DateTimeKind.Local).AddTicks(8657), new DateTime(2024, 2, 20, 15, 20, 41, 47, DateTimeKind.Utc).AddTicks(415), "Fannie Harris", 2, 5, 307863.677086336660000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 47, DateTimeKind.Utc).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 5, 12, 13, 11, 42, 105, DateTimeKind.Local).AddTicks(8118), new DateTime(2024, 2, 20, 15, 20, 41, 47, DateTimeKind.Utc).AddTicks(1437), "Taylor Howell", 3, 13925.151289063420000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 47, DateTimeKind.Utc).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 8, 21, 19, 5, 33, 968, DateTimeKind.Local).AddTicks(4607), new DateTime(2024, 2, 20, 15, 20, 41, 47, DateTimeKind.Utc).AddTicks(2711), "Christian Mosciski", 17, 1, 139552.483770053110000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 47, DateTimeKind.Utc).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 3, 13, 22, 1, 47, 401, DateTimeKind.Local).AddTicks(4880), new DateTime(2024, 2, 20, 15, 20, 41, 47, DateTimeKind.Utc).AddTicks(3667), "Sammy Okuneva", 37, 3, 178720.600524787870000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 47, DateTimeKind.Utc).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1976, 1, 10, 8, 7, 18, 200, DateTimeKind.Local).AddTicks(768), new DateTime(2024, 2, 20, 15, 20, 41, 47, DateTimeKind.Utc).AddTicks(4589), "Jack Ernser", 49, 1, 133258.196265224020000m, new DateTime(2024, 2, 20, 15, 20, 41, 47, DateTimeKind.Utc).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1997, 4, 1, 8, 3, 55, 202, DateTimeKind.Local).AddTicks(306), new DateTime(2024, 2, 20, 15, 20, 41, 47, DateTimeKind.Utc).AddTicks(5712), "Christopher Morar", 70, 3, 399434.309212863460000m, new DateTime(2024, 2, 20, 15, 20, 41, 47, DateTimeKind.Utc).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 2, 9, 20, 47, 26, 336, DateTimeKind.Local).AddTicks(4578), new DateTime(2024, 2, 20, 15, 20, 41, 47, DateTimeKind.Utc).AddTicks(7260), "Rolando Deckow", 65, 3, 17237.2012813732450000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 47, DateTimeKind.Utc).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1989, 10, 4, 10, 3, 36, 247, DateTimeKind.Local).AddTicks(6585), new DateTime(2024, 2, 20, 15, 20, 41, 47, DateTimeKind.Utc).AddTicks(9004), "Martin Brakus", 42, 289649.281257419710000m, new DateTime(2024, 2, 20, 15, 20, 41, 47, DateTimeKind.Utc).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1979, 2, 2, 18, 27, 3, 638, DateTimeKind.Local).AddTicks(208), new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(185), "Aubrey Haag", 85, 5, 377909.711580721180000m, new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 7, 1, 14, 15, 16, 281, DateTimeKind.Local).AddTicks(5847), new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(1123), "Sophia Williamson", 14, 91387.483328387080000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 7, 24, 12, 55, 5, 342, DateTimeKind.Local).AddTicks(8339), new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(2073), "Harold McClure", 8, 1, 281622.784062216730000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 1, 30, 9, 54, 4, 500, DateTimeKind.Local).AddTicks(2931), new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(2902), "Elijah McLaughlin", 14, 5, 74856.26507723350000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 10, 30, 2, 55, 3, 217, DateTimeKind.Local).AddTicks(6375), new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(3564), "Antonia Wolf", 35, 4, 181048.488145797340000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 6, 12, 3, 45, 42, 640, DateTimeKind.Local).AddTicks(9620), new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(4271), "Howard Nienow", 28, 4, 108457.829909487490000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 12, 25, 16, 58, 40, 658, DateTimeKind.Local).AddTicks(6308), new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(5740), "Angelina Lesch", 61, 5, 380107.556029190980000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1992, 8, 12, 6, 53, 57, 629, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(6631), "Ruben Tromp", 29, 4, 165346.549004906350000m, new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 8, 4, 18, 3, 58, 65, DateTimeKind.Local).AddTicks(3503), new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(7279), "Dixie Fahey", 37, 23161.4017288208650000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1955, 8, 29, 16, 10, 1, 548, DateTimeKind.Local).AddTicks(9788), new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(7866), "Alexis Cronin", 74, 2, 163744.315317043360000m, new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 7, 3, 7, 20, 15, 402, DateTimeKind.Local).AddTicks(6711), new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(8770), "Antonio Haag", 81, 4, 299344.953733848610000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 1, 21, 10, 29, 43, 480, DateTimeKind.Local).AddTicks(8904), new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(9488), "Kenny Langworth", 87, 5, 113774.231501404360000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 48, DateTimeKind.Utc).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 9, 13, 7, 38, 6, 617, DateTimeKind.Local).AddTicks(8504), new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(153), "Matt Hodkiewicz", 58, 1, 228160.536259374280000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 3, 28, 4, 49, 29, 787, DateTimeKind.Local).AddTicks(3362), new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(708), "Charles Bahringer", 47, 74467.792878831160000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 7, 12, 18, 46, 39, 889, DateTimeKind.Local).AddTicks(4329), new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(1633), "Kathryn Jast", 71, 4, 296637.67468982620000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 6, 29, 20, 56, 36, 456, DateTimeKind.Local).AddTicks(5793), new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(2326), "Edgar Hills", 28, 254110.424792620360000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 9, 8, 21, 10, 11, 586, DateTimeKind.Local).AddTicks(9559), new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(2913), "Clifton Willms", 91, 1, 354977.535246656650000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 7, 29, 6, 12, 57, 922, DateTimeKind.Local).AddTicks(4199), new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(3482), "Clarence Beatty", 58, 4, 387240.318060160360000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1984, 4, 1, 20, 46, 43, 574, DateTimeKind.Local).AddTicks(3024), new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(4128), "Lindsey Schumm", 96, 241483.468514031760000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 8, 1, 5, 6, 12, 99, DateTimeKind.Local).AddTicks(3476), new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(4678), "Doyle Herzog", 80, 2, 380354.244790997350000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 6, 17, 6, 41, 46, 964, DateTimeKind.Local).AddTicks(4948), new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(5187), "Ora Hagenes", 93, 4, 348216.939413027740000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 2, 16, 17, 6, 27, 87, DateTimeKind.Local).AddTicks(2260), new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(5764), "Melba Kessler", 7, 1, 14522.3948555896240000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 8, 5, 7, 54, 45, 830, DateTimeKind.Local).AddTicks(2098), new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(6262), "Edgar Kuvalis", 80, 1, 140461.748984841820000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 6, 29, 9, 36, 24, 794, DateTimeKind.Local).AddTicks(6430), new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(6780), "Mack Heathcote", 50, 5, 311436.540665402350000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 12, 6, 20, 27, 47, 306, DateTimeKind.Local).AddTicks(2449), new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(7333), "Ross Reichel", 92, 1, 339671.142628507810000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 1, 14, 18, 56, 34, 388, DateTimeKind.Local).AddTicks(6120), new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(8283), "Edith Hills", 41, 353952.793015998010000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 4, 4, 16, 2, 46, 316, DateTimeKind.Local).AddTicks(6461), new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(8966), "Garrett Raynor", 72, 3, 27353.572987214230000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 1, 17, 23, 7, 33, 336, DateTimeKind.Local).AddTicks(7637), new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(9570), "Brittany Kohler", 70, 1, 200335.926083098120000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 49, DateTimeKind.Utc).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 1, 31, 0, 45, 6, 732, DateTimeKind.Local).AddTicks(1935), new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(191), "Jerry Nikolaus", 25, 318716.393058291790000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 12, 4, 8, 10, 43, 152, DateTimeKind.Local).AddTicks(3588), new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(805), "Cecilia Turcotte", 71, 1, 51606.830208551530000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1971, 12, 4, 10, 45, 59, 816, DateTimeKind.Local).AddTicks(9292), new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(1338), "Marc Gorczany", 71, 3, 310727.070487744420000m, new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(1338) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1998, 9, 20, 14, 38, 7, 654, DateTimeKind.Local).AddTicks(8664), new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(1894), "Cora Reichert", 5, 5, 37365.118351049440000m, new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 1, 11, 11, 7, 48, 207, DateTimeKind.Local).AddTicks(2192), new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(2440), "Suzanne Orn", 74, 1, 221267.370473326570000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1969, 3, 7, 21, 57, 26, 318, DateTimeKind.Local).AddTicks(3907), new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(2917), "Joseph Berge", 73, 2, 165858.204308124760000m, new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 8, 13, 10, 35, 29, 148, DateTimeKind.Local).AddTicks(9496), new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(3440), "Mitchell Hilll", 47, 278905.284731423080000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 8, 31, 20, 6, 31, 202, DateTimeKind.Local).AddTicks(381), new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(4141), "Stephanie Abbott", 13, 4, 182811.047452395040000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1974, 11, 4, 7, 23, 51, 769, DateTimeKind.Local).AddTicks(7425), new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(5010), "Justin Rutherford", 50, 305764.724283584530000m, new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1973, 5, 13, 12, 48, 59, 269, DateTimeKind.Local).AddTicks(2896), new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(5653), "Tony West", 11, 3, 115510.144542671440000m, new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 5, 13, 3, 43, 46, 493, DateTimeKind.Local).AddTicks(321), new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(6254), "Georgia Will", 41, 41640.1615905919180000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 12, 1, 4, 49, 30, 614, DateTimeKind.Local).AddTicks(6733), new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(6770), "Gary Stoltenberg", 58, 4, 333628.519076351710000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 9, 8, 6, 16, 53, 988, DateTimeKind.Local).AddTicks(2731), new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(7358), "Sean Terry", 68, 2, 309480.476265717760000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 5, 15, 9, 13, 51, 799, DateTimeKind.Local).AddTicks(9012), new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(7836), "Cody Adams", 68, 352780.764650758720000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 3, 8, 11, 24, 2, 957, DateTimeKind.Local).AddTicks(2136), new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(8386), "Pam Fay", 79, 1, 37871.5721505957970000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 2, 27, 13, 22, 26, 518, DateTimeKind.Local).AddTicks(4729), new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(8901), "Frank Moen", 60, 1, 215656.153956530680000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1995, 10, 27, 22, 52, 1, 71, DateTimeKind.Local).AddTicks(781), new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(9357), "Paul Hane", 77, 1, 23256.5894891274910000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 12, 5, 13, 50, 59, 466, DateTimeKind.Local).AddTicks(4787), new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(9869), "Mona Dibbert", 61, 4, 190490.765750569690000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 50, DateTimeKind.Utc).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 10, 24, 15, 43, 48, 778, DateTimeKind.Local).AddTicks(2980), new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(353), "Ramiro Wintheiser", 74, 2, 344870.231637442540000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(353) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1962, 5, 10, 1, 12, 11, 276, DateTimeKind.Local).AddTicks(9695), new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(1158), "Stacey O'Keefe", 58, 5, 220557.442188127840000m, new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 1, 18, 10, 27, 1, 983, DateTimeKind.Local).AddTicks(8664), new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(1932), "Ruth Weissnat", 91, 103190.961508600150000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(1932) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 7, 31, 23, 56, 17, 375, DateTimeKind.Local).AddTicks(6949), new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(2484), "Jean Spinka", 70, 4, 343546.325495735560000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 3, 22, 18, 29, 51, 365, DateTimeKind.Local).AddTicks(245), new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(2961), "Ralph Parisian", 15, 30327.5770388810860000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 6, 1, 11, 32, 31, 799, DateTimeKind.Local).AddTicks(70), new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(3507), "Donnie Schulist", 46, 218743.282988466460000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1954, 10, 17, 10, 37, 21, 238, DateTimeKind.Local).AddTicks(2668), new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(4046), "Tom Bogan", 37, 3, 88148.55428691610000m, new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 11, 25, 0, 0, 47, 344, DateTimeKind.Local).AddTicks(8358), new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(4557), "Carrie Larkin", 32, 1, 13151.77096583501230000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 5, 14, 19, 24, 42, 35, DateTimeKind.Local).AddTicks(7971), new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(5132), "Brandi Heaney", 40, 3, 322922.180554241440000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 5, 7, 5, 54, 23, 127, DateTimeKind.Local).AddTicks(2038), new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(5669), "Josephine Corwin", 44, 3, 120793.689052926880000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 8, 25, 16, 0, 14, 770, DateTimeKind.Local).AddTicks(6153), new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(6186), "Betsy O'Kon", 51, 238867.291104265840000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1999, 11, 16, 22, 42, 32, 791, DateTimeKind.Local).AddTicks(8245), new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(6770), "Darrel Stokes", 7, 2, 273412.112012041720000m, new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1991, 1, 4, 3, 36, 10, 848, DateTimeKind.Local).AddTicks(8315), new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(7611), "Olivia Grant", 68, 3, 352277.026255124740000m, new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 12, 14, 13, 55, 26, 861, DateTimeKind.Local).AddTicks(4757), new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(8332), "Alan Block", 45, 3, 83248.602021380890000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 5, 8, 7, 2, 37, 762, DateTimeKind.Local).AddTicks(3075), new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(8935), "Randall Schoen", 44, 239781.577574618290000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 1, 17, 9, 50, 31, 519, DateTimeKind.Local).AddTicks(1627), new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(9466), "Shelia Lesch", 100, 1, 389098.472924129920000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 51, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 3, 5, 9, 35, 56, 626, DateTimeKind.Local).AddTicks(8820), new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(47), "Leland Hackett", 48, 2, 280865.986810531060000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 10, 2, 10, 42, 49, 733, DateTimeKind.Local).AddTicks(764), new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(561), "Dallas Wolf", 89, 1, 279921.963797226520000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 12, 27, 23, 16, 32, 268, DateTimeKind.Local).AddTicks(7740), new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(1085), "Melanie Osinski", 53, 2, 95148.776474030230000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 9, 5, 23, 5, 24, 46, DateTimeKind.Local).AddTicks(1424), new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(1587), "Loren Kuphal", 50, 2, 128732.427849289930000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 8, 27, 6, 32, 33, 599, DateTimeKind.Local).AddTicks(5627), new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(2042), "Camille Ryan", 23, 5, 392342.054023872280000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 5, 26, 9, 29, 19, 107, DateTimeKind.Local).AddTicks(5454), new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(2562), "Carmen Braun", 37, 2, 245324.878617433930000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 11, 21, 19, 36, 40, 14, DateTimeKind.Local).AddTicks(7901), new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(3115), "Andy Morar", 44, 1, 158828.520383239060000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 5, 18, 14, 16, 41, 858, DateTimeKind.Local).AddTicks(7507), new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(3746), "Julius Schuster", 90, 1, 345051.189381289810000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 2, 16, 20, 38, 51, 662, DateTimeKind.Local).AddTicks(3159), new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(4540), "Maxine Raynor", 75, 4, 329277.600901937470000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 8, 21, 18, 32, 21, 851, DateTimeKind.Local).AddTicks(990), new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(5176), "Earl Romaguera", 76, 4, 280147.535354477950000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 2, 17, 5, 45, 30, 577, DateTimeKind.Local).AddTicks(3556), new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(5713), "Ronald Reinger", 51, 2, 299303.822071399330000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1985, 12, 28, 10, 5, 1, 140, DateTimeKind.Local).AddTicks(5423), new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(6267), "Nelson Larson", 30, 2, 350330.818227730720000m, new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1978, 6, 11, 12, 59, 10, 904, DateTimeKind.Local).AddTicks(7385), new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(6808), "Charlene McClure", 12, 1, 74958.047917122490000m, new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 9, 17, 20, 46, 56, 249, DateTimeKind.Local).AddTicks(4534), new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(7313), "Tony Bartoletti", 68, 5, 307653.606667452880000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 3, 18, 17, 22, 50, 869, DateTimeKind.Local).AddTicks(4855), new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(7865), "Silvia King", 7, 152699.510632867630000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1963, 7, 5, 20, 58, 11, 743, DateTimeKind.Local).AddTicks(742), new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(8350), "Brendan Ryan", 31, 5, 142523.070872857990000m, new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 1, 21, 6, 14, 20, 75, DateTimeKind.Local).AddTicks(670), new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(8902), "Darnell Abbott", 48, 1, 304083.076632877090000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1994, 5, 12, 13, 50, 41, 376, DateTimeKind.Local).AddTicks(2671), new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(9424), "Brian Smitham", 45, 2, 120381.875424970630000m, new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 9, 3, 5, 51, 28, 300, DateTimeKind.Local).AddTicks(4794), new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(9919), "Arthur Kovacek", 10, 4, 364461.130427695330000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 52, DateTimeKind.Utc).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1984, 4, 13, 12, 41, 9, 834, DateTimeKind.Local).AddTicks(8936), new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(711), "Gwen Brown", 18, 2, 370379.532142681480000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(711) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 8, 26, 10, 16, 4, 238, DateTimeKind.Local).AddTicks(367), new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(1404), "Jenna Prohaska", 82, 3, 347928.116894232280000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 12, 18, 8, 54, 5, 658, DateTimeKind.Local).AddTicks(8283), new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(1960), "Mindy Crona", 66, 1, 255035.654924372650000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1993, 4, 17, 13, 58, 53, 425, DateTimeKind.Local).AddTicks(9610), new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(2483), "Scott Carter", 56, 4, 355611.333933341710000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 8, 17, 21, 9, 25, 822, DateTimeKind.Local).AddTicks(166), new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(3066), "Muriel Bednar", 60, 3, 180846.648926745610000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 2, 1, 22, 11, 10, 930, DateTimeKind.Local).AddTicks(9318), new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(3607), "Jill Ferry", 55, 244453.975872066340000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1989, 6, 20, 19, 46, 7, 785, DateTimeKind.Local).AddTicks(8141), new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(4076), "Opal Jakubowski", 92, 5, 168264.260746665190000m, new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(4076) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 6, 30, 3, 8, 51, 211, DateTimeKind.Local).AddTicks(8228), new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(4613), "Eleanor Kunze", 24, 1, 121419.685568411350000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 10, 30, 23, 12, 47, 967, DateTimeKind.Local).AddTicks(7842), new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(5067), "Tomas Murazik", 94, 3, 199564.616228284570000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 6, 30, 3, 19, 46, 666, DateTimeKind.Local).AddTicks(2079), new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(5583), "Kate Bednar", 86, 3, 189580.42108816420000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(5582) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 2, 15, 5, 30, 46, 714, DateTimeKind.Local).AddTicks(4848), new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(6106), "Vincent Kuvalis", 24, 4, 318036.892257747640000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 11, 9, 20, 38, 45, 502, DateTimeKind.Local).AddTicks(8664), new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(6579), "Louis Dicki", 19, 196030.302705491140000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 10, 18, 13, 36, 32, 807, DateTimeKind.Local).AddTicks(2661), new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(7540), "Ryan Gibson", 44, 3, 219754.677416725870000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 8, 28, 19, 11, 35, 107, DateTimeKind.Local).AddTicks(324), new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(8170), "Gerald Schulist", 96, 5, 118410.249843132250000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 9, 27, 0, 35, 0, 226, DateTimeKind.Local).AddTicks(1028), new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(8703), "Sharon Abernathy", 38, 3, 352078.734308623390000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 2, 12, 2, 52, 50, 59, DateTimeKind.Local).AddTicks(3820), new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(9299), "Reginald Hills", 87, 5, 350926.524312636340000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 9, 7, 20, 22, 53, 493, DateTimeKind.Local).AddTicks(6241), new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(9815), "Melvin Muller", 6, 2, 88425.027831362290000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 53, DateTimeKind.Utc).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1987, 10, 29, 22, 57, 13, 424, DateTimeKind.Local).AddTicks(6253), new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(284), "Jasmine Gleason", 52, 392892.14560904320000m, new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 11, 27, 0, 46, 26, 86, DateTimeKind.Local).AddTicks(1679), new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(807), "Jaime Hermann", 37, 2, 241420.47728982910000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1956, 11, 24, 10, 5, 41, 917, DateTimeKind.Local).AddTicks(3955), new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(1352), "Cynthia Bahringer", 26, 3, 93891.555548430760000m, new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 7, 24, 14, 12, 54, 166, DateTimeKind.Local).AddTicks(8463), new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(1835), "Kari Adams", 21, 322031.639862620860000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1956, 12, 29, 7, 3, 37, 540, DateTimeKind.Local).AddTicks(1447), new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(2354), "Alexander Crooks", 61, 5, 203859.747338118550000m, new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1995, 8, 2, 19, 8, 57, 976, DateTimeKind.Local).AddTicks(916), new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(2859), "Irvin Dach", 24, 5, 50064.008601570070000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1976, 7, 24, 10, 15, 8, 127, DateTimeKind.Local).AddTicks(3505), new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(3568), "Dwayne Halvorson", 45, 5, 216329.79228034420000m, new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(3567) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 10, 11, 17, 54, 17, 566, DateTimeKind.Local).AddTicks(8984), new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(4366), "Dolores Wintheiser", 40, 3, 117700.898543321980000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1984, 7, 29, 13, 42, 4, 599, DateTimeKind.Local).AddTicks(5290), new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(5010), "Bill Dickinson", 88, 2, 299638.180010787790000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 4, 9, 20, 46, 42, 657, DateTimeKind.Local).AddTicks(5209), new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(5563), "Thelma Leuschke", 35, 3, 294185.909342350210000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 10, 16, 14, 4, 17, 945, DateTimeKind.Local).AddTicks(7962), new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(6149), "Connie Mohr", 54, 4, 291699.341033268730000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 12, 7, 10, 56, 24, 533, DateTimeKind.Local).AddTicks(5400), new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(6674), "Luke Gulgowski", 95, 5, 296131.821181041160000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1974, 3, 16, 21, 37, 44, 176, DateTimeKind.Local).AddTicks(6051), new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(7259), "April Nikolaus", 5, 298322.724696423430000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1996, 6, 19, 10, 57, 25, 433, DateTimeKind.Local).AddTicks(5168), new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(7788), "Adrian Nienow", 51, 4, 19021.3615978375240000m, new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1984, 5, 25, 18, 40, 21, 844, DateTimeKind.Local).AddTicks(3174), new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(8296), "Nick Wolf", 92, 4, 89507.686476315370000m, new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 5, 23, 10, 6, 32, 847, DateTimeKind.Local).AddTicks(7385), new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(8802), "Salvador Wehner", 57, 5, 120080.764136462860000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 3, 18, 13, 50, 19, 68, DateTimeKind.Local).AddTicks(7365), new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(9333), "Marlon Parker", 3, 3, 62363.016270949930000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 54, DateTimeKind.Utc).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 12, 11, 16, 56, 44, 157, DateTimeKind.Local).AddTicks(5200), new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(127), "Arturo Botsford", 7, 4, 23759.5948360251550000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 3, 25, 0, 16, 48, 870, DateTimeKind.Local).AddTicks(1221), new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(935), "Delia Raynor", 25, 2, 194143.798197071830000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 2, 27, 1, 27, 27, 100, DateTimeKind.Local).AddTicks(5712), new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(1518), "Lewis Bauch", 83, 309996.646506642670000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1980, 10, 5, 5, 3, 57, 54, DateTimeKind.Local).AddTicks(5723), new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(2121), "Raymond Mueller", 65, 3, 309094.006912608310000m, new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1986, 5, 9, 13, 0, 1, 956, DateTimeKind.Local).AddTicks(7310), new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(2660), "Scott Wolff", 31, 379325.664375672160000m, new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1969, 3, 23, 7, 55, 3, 399, DateTimeKind.Local).AddTicks(9906), new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(3144), "Alison Zboncak", 57, 1, 43730.9333135030620000m, new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 1, 29, 6, 7, 7, 971, DateTimeKind.Local).AddTicks(1412), new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(3665), "Eula Baumbach", 25, 1, 297442.123696036660000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 7, 15, 5, 3, 30, 923, DateTimeKind.Local).AddTicks(6603), new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(4211), "Jody Hayes", 9, 1, 135333.162858294820000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 7, 23, 16, 19, 50, 657, DateTimeKind.Local).AddTicks(8900), new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(4703), "Patricia Luettgen", 43, 2, 100056.589283984440000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 12, 5, 13, 16, 21, 889, DateTimeKind.Local).AddTicks(5491), new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(5229), "Malcolm Dach", 87, 2, 349870.297600944370000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(5228) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1960, 1, 10, 18, 53, 40, 489, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(5729), "Angelina Schmidt", 24, 3, 146137.221246952120000m, new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 3, 3, 10, 40, 40, 37, DateTimeKind.Local).AddTicks(4069), new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(6510), "Gregg Schaden", 38, 1, 367004.845575582490000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 7, 16, 16, 49, 45, 561, DateTimeKind.Local).AddTicks(2931), new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(7450), "Kenny Keeling", 60, 4, 376868.667239960860000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2002, 6, 6, 16, 24, 22, 335, DateTimeKind.Local).AddTicks(311), new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(8200), "Ralph Kris", 39, 1, 238717.902051525640000m, new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 12, 11, 15, 13, 36, 239, DateTimeKind.Local).AddTicks(4165), new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(8755), "Veronica Quigley", 91, 113794.735909970950000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1969, 9, 2, 16, 34, 45, 568, DateTimeKind.Local).AddTicks(932), new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(9348), "Van Cummings", 80, 5, 53037.940514743720000m, new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 10, 25, 13, 37, 49, 829, DateTimeKind.Local).AddTicks(3468), new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(9919), "Yvette Nikolaus", 88, 3, 124770.898682032840000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 55, DateTimeKind.Utc).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1988, 2, 4, 9, 13, 31, 640, DateTimeKind.Local).AddTicks(4343), new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(438), "Trevor Heathcote", 85, 4, 213154.340439015550000m, new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 4, 12, 13, 56, 21, 444, DateTimeKind.Local).AddTicks(808), new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(956), "Tommy Nikolaus", 8, 2, 11907.3852826949830000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 4, 9, 20, 47, 22, 541, DateTimeKind.Local).AddTicks(6140), new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(1576), "Violet Davis", 82, 3, 217937.564269716190000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 10, 10, 22, 7, 40, 56, DateTimeKind.Local).AddTicks(1904), new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(2039), "Frank Willms", 74, 4, 362025.013966281370000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 1, 17, 3, 27, 5, 410, DateTimeKind.Local).AddTicks(9048), new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(2555), "Jane Thiel", 13, 1, 136828.537266844660000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 4, 28, 2, 39, 12, 189, DateTimeKind.Local).AddTicks(3123), new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(3478), "Yvette Spencer", 76, 1, 119115.395647855870000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 10, 10, 2, 12, 55, 692, DateTimeKind.Local).AddTicks(1094), new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(4021), "Jessie O'Connell", 30, 5, 104289.37843991770000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1993, 2, 2, 12, 14, 48, 735, DateTimeKind.Local).AddTicks(9071), new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(4631), "Jake Waelchi", 50, 3, 80342.813701467580000m, new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1992, 5, 17, 13, 45, 11, 752, DateTimeKind.Local).AddTicks(3927), new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(5163), "Vanessa Mann", 55, 3, 12614.43075827442340000m, new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1985, 11, 19, 21, 10, 11, 879, DateTimeKind.Local).AddTicks(384), new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(5654), "Meghan Hermiston", 72, 3, 86857.758813786340000m, new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1984, 7, 14, 10, 55, 42, 918, DateTimeKind.Local).AddTicks(6890), new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(6193), "Marguerite Kemmer", 6, 3, 10717.96473822349510000m, new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 7, 7, 21, 21, 10, 296, DateTimeKind.Local).AddTicks(351), new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(6754), "Monique Marks", 25, 5, 46035.60453350260000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 3, 10, 17, 7, 42, 126, DateTimeKind.Local).AddTicks(861), new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(7242), "Harry Wintheiser", 77, 5, 147167.284893155140000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 11, 30, 23, 54, 11, 792, DateTimeKind.Local).AddTicks(4780), new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(7770), "Vickie Beatty", 98, 2, 207481.783762366090000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 6, 21, 15, 3, 42, 972, DateTimeKind.Local).AddTicks(8038), new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(8241), "Johnnie Bayer", 68, 4, 281252.64088083460000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 12, 18, 21, 44, 48, 718, DateTimeKind.Local).AddTicks(7297), new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(8788), "Eric Armstrong", 84, 381626.748683682310000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1993, 1, 15, 14, 36, 25, 894, DateTimeKind.Local).AddTicks(1970), new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(9673), "Katie Skiles", 31, 4, 345125.495089581040000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 56, DateTimeKind.Utc).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 2, 20, 18, 32, 19, 171, DateTimeKind.Local).AddTicks(3971), new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(261), "Judith Franecki", 71, 2, 237612.615533437810000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 3, 6, 0, 12, 18, 835, DateTimeKind.Local).AddTicks(67), new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(800), "Darren Schowalter", 77, 1, 297328.244274302530000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 3, 27, 3, 38, 15, 843, DateTimeKind.Local).AddTicks(3517), new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(1407), "Nichole Hahn", 53, 2, 329407.887615074440000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 12, 28, 20, 52, 45, 973, DateTimeKind.Local).AddTicks(2134), new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(1919), "Debbie Hilll", 13, 2, 148476.681334879420000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 1, 22, 7, 52, 4, 345, DateTimeKind.Local).AddTicks(5827), new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(2393), "Nathaniel Denesik", 42, 1, 398130.519768272710000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 3, 13, 22, 6, 34, 604, DateTimeKind.Local).AddTicks(1923), new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(2912), "Brandi Ritchie", 25, 4, 89813.810556013690000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1984, 5, 31, 18, 55, 3, 91, DateTimeKind.Local).AddTicks(8087), new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(3440), "Ella Friesen", 93, 271472.08619994670000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 2, 16, 18, 3, 24, 657, DateTimeKind.Local).AddTicks(9519), new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(3963), "Rhonda Bernhard", 70, 3, 24536.8202909335510000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 11, 25, 15, 10, 12, 551, DateTimeKind.Local).AddTicks(702), new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(4470), "Viola Nitzsche", 2, 5, 201558.616068316120000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 10, 4, 10, 29, 38, 402, DateTimeKind.Local).AddTicks(6972), new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(4973), "Jean Nader", 14, 5, 367634.75764724890000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 8, 14, 13, 59, 48, 772, DateTimeKind.Local).AddTicks(8295), new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(5763), "April Cassin", 85, 5, 399277.587519227680000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 3, 23, 11, 19, 6, 549, DateTimeKind.Local).AddTicks(9982), new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(6525), "Kent Langosh", 28, 5, 126868.619315355310000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 11, 28, 4, 19, 5, 931, DateTimeKind.Local).AddTicks(5981), new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(7173), "Eddie Pfeffer", 6, 160559.987070908350000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 11, 27, 6, 37, 57, 453, DateTimeKind.Local).AddTicks(1728), new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(7795), "Sally Mayer", 96, 1, 193255.49014404190000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 10, 17, 5, 35, 15, 565, DateTimeKind.Local).AddTicks(3732), new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(8330), "Walter Kihn", 76, 4, 121905.914846435710000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 7, 9, 7, 34, 46, 894, DateTimeKind.Local).AddTicks(1182), new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(8889), "Belinda Brakus", 1, 4, 285787.484094627310000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 11, 15, 13, 19, 43, 562, DateTimeKind.Local).AddTicks(4634), new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(9464), "Jessie Mayert", 37, 1, 229335.491761132630000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 57, DateTimeKind.Utc).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 12, 4, 3, 22, 28, 1, DateTimeKind.Local).AddTicks(1456), new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(4), "Sonya Carroll", 97, 2, 314139.836768547520000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1974, 10, 14, 15, 56, 23, 536, DateTimeKind.Local).AddTicks(1633), new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(539), "Victoria Davis", 60, 4, 154611.003425549440000m, new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 10, 31, 13, 55, 6, 859, DateTimeKind.Local).AddTicks(9391), new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(1037), "Ora Bauch", 93, 4, 275410.755191937550000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 4, 21, 21, 33, 50, 497, DateTimeKind.Local).AddTicks(6966), new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(1542), "William Wolff", 81, 4, 289373.527029399790000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2001, 12, 3, 10, 25, 7, 273, DateTimeKind.Local).AddTicks(5237), new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(2293), "Laurie Kunde", 62, 260717.44230819130000m, new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 7, 23, 18, 48, 3, 93, DateTimeKind.Local).AddTicks(8298), new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(3030), "Sabrina Wunsch", 20, 4, 134332.875325101820000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 4, 18, 7, 28, 35, 936, DateTimeKind.Local).AddTicks(6963), new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(3657), "Yolanda Luettgen", 43, 2, 326240.545192014430000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(3657) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 4, 28, 21, 49, 19, 472, DateTimeKind.Local).AddTicks(7261), new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(4226), "Van Turner", 78, 5, 215243.59254190480000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1958, 8, 25, 20, 24, 7, 382, DateTimeKind.Local).AddTicks(951), new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(4700), "Harold Stamm", 99, 154609.578477060580000m, new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 10, 18, 15, 40, 21, 611, DateTimeKind.Local).AddTicks(3445), new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(5246), "Jordan Denesik", 63, 5, 295536.172633340590000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1964, 3, 21, 3, 40, 9, 217, DateTimeKind.Local).AddTicks(5926), new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(5759), "Karen Schimmel", 15, 2, 189206.017906178380000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 1, 1, 12, 16, 29, 139, DateTimeKind.Local).AddTicks(6469), new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(6359), "Sylvester Strosin", 40, 1, 175811.885453938360000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 6, 13, 22, 14, 42, 858, DateTimeKind.Local).AddTicks(9268), new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(6871), "Michelle Ziemann", 31, 1, 398235.749841970420000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 6, 12, 6, 0, 21, 960, DateTimeKind.Local).AddTicks(5552), new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(7382), "Ramiro Cruickshank", 44, 4, 21488.3019020410030000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 8, 23, 5, 5, 51, 165, DateTimeKind.Local).AddTicks(6172), new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(7912), "Oscar Beer", 74, 371197.453091401030000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1959, 6, 16, 16, 2, 22, 622, DateTimeKind.Local).AddTicks(1572), new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(8417), "Tracy Reichel", 33, 1, 234369.203504420650000m, new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1978, 9, 27, 4, 32, 11, 361, DateTimeKind.Local).AddTicks(9698), new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(9274), "Randall Barrows", 95, 388121.216837979940000m, new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1958, 11, 22, 22, 26, 8, 10, DateTimeKind.Local).AddTicks(7008), new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(9900), "Ashley Littel", 44, 4, 227927.335229650150000m, new DateTime(2024, 2, 20, 15, 20, 41, 58, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 7, 10, 19, 13, 41, 703, DateTimeKind.Local).AddTicks(5798), new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(456), "Ollie Braun", 73, 4, 320193.306929342980000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1984, 12, 6, 2, 9, 15, 267, DateTimeKind.Local).AddTicks(2208), new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(973), "Gerald Gaylord", 61, 5, 75147.30778897510000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 10, 9, 11, 58, 30, 209, DateTimeKind.Local).AddTicks(5591), new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(1488), "Erica Kunde", 71, 117544.037017104610000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 5, 24, 3, 52, 19, 590, DateTimeKind.Local).AddTicks(6919), new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(2019), "Ollie Koelpin", 28, 31342.1568739961530000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1965, 2, 24, 13, 51, 24, 855, DateTimeKind.Local).AddTicks(4390), new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(2511), "Darin Ebert", 72, 3, 13931.8663381454860000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 1, 4, 4, 55, 15, 465, DateTimeKind.Local).AddTicks(2448), new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(3055), "Jody Goldner", 43, 1, 130948.717815057730000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 8, 28, 12, 45, 58, 825, DateTimeKind.Local).AddTicks(6993), new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(3535), "Jodi Ernser", 16, 5, 142559.558870200930000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 4, 17, 6, 38, 36, 619, DateTimeKind.Local).AddTicks(8379), new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(4019), "Danny Schaefer", 100, 168309.702871187530000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 1, 27, 2, 14, 31, 237, DateTimeKind.Local).AddTicks(5644), new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(4545), "Tracy Lang", 71, 5, 296307.84776379760000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1955, 4, 22, 14, 39, 10, 4, DateTimeKind.Local).AddTicks(4813), new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(5119), "Domingo Lebsack", 84, 2, 379078.588124713870000m, new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 3, 13, 7, 50, 48, 194, DateTimeKind.Local).AddTicks(8067), new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(6004), "Tiffany Schinner", 65, 5, 243815.610435124120000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 3, 23, 9, 54, 12, 747, DateTimeKind.Local).AddTicks(24), new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(6611), "Troy Paucek", 99, 2, 382747.854382735390000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1992, 3, 20, 5, 38, 30, 807, DateTimeKind.Local).AddTicks(3220), new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(7156), "Ross Little", 30, 34166.1214682903470000m, new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 4, 29, 10, 49, 51, 616, DateTimeKind.Local).AddTicks(2165), new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(7683), "Rick Brekke", 28, 305314.215808989520000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 2, 26, 1, 6, 51, 101, DateTimeKind.Local).AddTicks(9864), new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(8249), "Pedro Lesch", 31, 4, 234737.262527965330000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 5, 11, 16, 20, 3, 851, DateTimeKind.Local).AddTicks(3581), new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(8748), "Linda Schroeder", 84, 3, 152067.967626906490000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 8, 28, 14, 18, 10, 955, DateTimeKind.Local).AddTicks(3439), new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(9329), "Kelvin Bode", 44, 296746.820299474210000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 4, 15, 6, 14, 17, 26, DateTimeKind.Local).AddTicks(872), new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(9877), "Genevieve Runolfsdottir", 79, 4, 298673.585014027720000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 59, DateTimeKind.Utc).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 10, 11, 13, 25, 56, 332, DateTimeKind.Local).AddTicks(1592), new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(430), "Vincent Carter", 51, 1, 339812.971104047470000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Birthdate", "CreateDate", "Name", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 5, 26, 9, 18, 13, 615, DateTimeKind.Local).AddTicks(9120), new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(950), "Ruth Yundt", 5, 244104.095696676010000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 11, 7, 6, 6, 11, 251, DateTimeKind.Local).AddTicks(1812), new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(1409), "Joel Mertz", 73, 2, 232935.534581682130000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2001, 12, 8, 12, 33, 4, 186, DateTimeKind.Local).AddTicks(1039), new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(2282), "Zachary Johnston", 78, 3, 185905.064470815160000m, new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 8, 11, 21, 21, 20, 965, DateTimeKind.Local).AddTicks(4935), new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(2955), "Elisa Ernser", 28, 75244.673879231470000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(2954) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 1, 18, 23, 40, 48, 450, DateTimeKind.Local).AddTicks(1279), new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(3515), "Holly Trantow", 54, 3, 376522.624000774540000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 7, 19, 9, 22, 34, 874, DateTimeKind.Local).AddTicks(5331), new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(4112), "Ignacio O'Kon", 72, 398382.205886346490000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1956, 6, 30, 7, 31, 9, 977, DateTimeKind.Local).AddTicks(8510), new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(4680), "Lindsay Kemmer", 86, 4, 304547.161358042710000m, new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1963, 1, 26, 23, 1, 50, 797, DateTimeKind.Local).AddTicks(7153), new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(5190), "Virginia Willms", 21, 4, 398046.685902926830000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1964, 11, 15, 21, 11, 19, 207, DateTimeKind.Local).AddTicks(2760), new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(5719), "Gene Erdman", 58, 3, 309409.355503621090000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 5, 17, 7, 54, 2, 658, DateTimeKind.Local).AddTicks(6636), new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(6244), "Kathleen Bartell", 95, 5, 386467.98046177450000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1989, 10, 25, 19, 57, 37, 671, DateTimeKind.Local).AddTicks(5215), new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(6797), "Gene Nitzsche", 32, 2, 366559.402820245690000m, new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 2, 17, 0, 12, 9, 709, DateTimeKind.Local).AddTicks(287), new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(7313), "Sophie Stracke", 87, 4, 26365.5715877392180000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1968, 3, 19, 23, 5, 48, 165, DateTimeKind.Local).AddTicks(6174), new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(7806), "Erick Marvin", 100, 5, 303782.728204040140000m, new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 1, 2, 17, 31, 0, 553, DateTimeKind.Local).AddTicks(7124), new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(8559), "Kirk Lemke", 75, 5, 162572.986697132560000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1960, 4, 28, 18, 38, 39, 877, DateTimeKind.Local).AddTicks(4617), new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(9302), "Alex Wolff", 57, 4, 64780.644150666850000m, new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 8, 22, 21, 53, 8, 144, DateTimeKind.Local).AddTicks(5973), new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(9848), "Delbert Purdy", 32, 1, 70334.602370782480000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 60, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1979, 8, 10, 19, 16, 19, 711, DateTimeKind.Local).AddTicks(7625), new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(387), "Levi Ryan", 64, 284053.37520958540000m, new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 5, 18, 12, 50, 57, 144, DateTimeKind.Local).AddTicks(7720), new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(881), "Dewey Tremblay", 52, 2, 151718.231389943650000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 4, 20, 10, 57, 39, 498, DateTimeKind.Local).AddTicks(3610), new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(1420), "Darren Lind", 87, 3, 398444.269697528590000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(1419) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 2, 11, 15, 45, 27, 785, DateTimeKind.Local).AddTicks(1747), new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(1925), "Marjorie Aufderhar", 82, 5, 110361.475560081580000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 4, 21, 10, 29, 59, 948, DateTimeKind.Local).AddTicks(5016), new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(2492), "Bradford Hickle", 91, 4, 62595.354937872370000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 12, 9, 4, 40, 41, 67, DateTimeKind.Local).AddTicks(4775), new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(3014), "Gail Collier", 97, 4, 152354.219290157290000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 9, 12, 7, 4, 39, 345, DateTimeKind.Local).AddTicks(3790), new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(3539), "Ken Roob", 4, 2, 306717.150744546220000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 4, 9, 0, 1, 15, 43, DateTimeKind.Local).AddTicks(6525), new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(4082), "Tracy Littel", 43, 3, 318878.888635842070000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Birthdate", "CreateDate", "Name", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 10, 21, 6, 49, 43, 876, DateTimeKind.Local).AddTicks(3749), new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(4559), "Ramon McKenzie", 175052.597647290340000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1964, 7, 5, 6, 35, 56, 438, DateTimeKind.Local).AddTicks(8736), new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(5434), "Hannah Streich", 68, 4, 399919.375379264380000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 8, 21, 15, 57, 16, 122, DateTimeKind.Local).AddTicks(6115), new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(6036), "Melody Armstrong", 34, 3, 282762.822118774390000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 11, 10, 7, 21, 4, 124, DateTimeKind.Local).AddTicks(5156), new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(6634), "Jerry D'Amore", 29, 313052.071144166890000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1989, 1, 28, 18, 5, 2, 214, DateTimeKind.Local).AddTicks(7729), new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(7245), "Shannon Stokes", 20, 3, 255770.232884561320000m, new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 9, 10, 14, 59, 24, 601, DateTimeKind.Local).AddTicks(4868), new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(7780), "Karla Roberts", 43, 305164.066283925280000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 5, 26, 22, 44, 33, 470, DateTimeKind.Local).AddTicks(452), new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(8315), "Jaime Bins", 64, 1, 73963.73391137470000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 12, 30, 2, 40, 33, 719, DateTimeKind.Local).AddTicks(3918), new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(8817), "Jerome Ziemann", 77, 1, 252330.804818183770000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 6, 21, 20, 14, 9, 698, DateTimeKind.Local).AddTicks(2221), new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(9384), "Debra Dibbert", 80, 235983.032076440860000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1957, 10, 8, 8, 19, 34, 460, DateTimeKind.Local).AddTicks(3507), new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(9918), "Kathy Carroll", 40, 3, 15846.1937530522630000m, new DateTime(2024, 2, 20, 15, 20, 41, 61, DateTimeKind.Utc).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 1, 19, 1, 52, 41, 2, DateTimeKind.Local).AddTicks(5811), new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(412), "Cesar Feil", 3, 5, 336730.257516167830000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1958, 6, 11, 7, 22, 53, 425, DateTimeKind.Local).AddTicks(3824), new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(886), "Misty Ledner", 76, 2, 110082.927609498730000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1961, 12, 13, 0, 0, 8, 553, DateTimeKind.Local).AddTicks(4414), new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(1627), "Lewis Morar", 44, 1, 294908.04490962190000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 7, 19, 1, 31, 41, 971, DateTimeKind.Local).AddTicks(6650), new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(2356), "Alicia Carter", 83, 4, 15016.3971082013620000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 2, 5, 0, 18, 20, 133, DateTimeKind.Local).AddTicks(1514), new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(2960), "Celia Welch", 33, 1, 103510.129070879170000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1968, 4, 1, 1, 55, 20, 185, DateTimeKind.Local).AddTicks(5740), new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(3496), "Dawn Heathcote", 100, 2, 172415.013725973970000m, new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 2, 6, 23, 11, 26, 293, DateTimeKind.Local).AddTicks(3639), new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(4057), "Rudolph Wehner", 28, 155316.588722111950000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1979, 11, 4, 8, 14, 54, 362, DateTimeKind.Local).AddTicks(9214), new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(4590), "Nellie Flatley", 86, 5, 305040.660788301220000m, new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 8, 31, 12, 51, 46, 213, DateTimeKind.Local).AddTicks(1052), new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(5058), "Beatrice Becker", 90, 362252.631986637460000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1988, 6, 24, 1, 49, 17, 710, DateTimeKind.Local).AddTicks(1772), new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(5589), "Marcia Daniel", 70, 1, 66165.298678379410000m, new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 2, 26, 6, 37, 59, 476, DateTimeKind.Local).AddTicks(7396), new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(6065), "Juanita Bahringer", 73, 5, 116533.292244893020000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 6, 6, 2, 17, 12, 588, DateTimeKind.Local).AddTicks(5871), new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(6572), "Felipe Anderson", 4, 329054.789191765120000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 7, 23, 22, 36, 21, 992, DateTimeKind.Local).AddTicks(4726), new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(7116), "Marvin Rippin", 38, 2, 42762.3356265628150000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 6, 25, 12, 48, 21, 692, DateTimeKind.Local).AddTicks(718), new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(7713), "Jan Kautzer", 17, 4, 351408.171557665420000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1989, 7, 4, 15, 50, 39, 334, DateTimeKind.Local).AddTicks(3317), new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(8626), "Tricia Casper", 35, 5, 65520.076647525490000m, new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1991, 4, 7, 7, 49, 0, 607, DateTimeKind.Local).AddTicks(8129), new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(9371), "Tyrone Beer", 63, 5, 345615.620190758050000m, new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1984, 6, 23, 13, 4, 35, 861, DateTimeKind.Local).AddTicks(7937), new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(9972), "Susie Rohan", 46, 2, 58383.377592788680000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 62, DateTimeKind.Utc).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 9, 15, 10, 25, 57, 974, DateTimeKind.Local).AddTicks(8330), new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(564), "Sheryl Zulauf", 43, 5, 11456.805590591650000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 10, 31, 17, 55, 12, 960, DateTimeKind.Local).AddTicks(164), new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(1092), "Calvin Abshire", 55, 2, 130974.202311086410000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1998, 3, 6, 1, 21, 41, 57, DateTimeKind.Local).AddTicks(8165), new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(1676), "Peter Funk", 98, 276099.738828728740000m, new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1960, 10, 19, 3, 48, 34, 936, DateTimeKind.Local).AddTicks(8875), new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(2213), "Ricardo Powlowski", 19, 4, 394921.400170148140000m, new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 2, 14, 17, 3, 56, 295, DateTimeKind.Local).AddTicks(4091), new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(2919), "Boyd Schoen", 87, 5, 180003.869417821660000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2004, 1, 20, 21, 7, 50, 501, DateTimeKind.Local).AddTicks(6167), new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(3698), "Kellie Harvey", 8, 1, 259386.386239873870000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 11, 22, 16, 5, 3, 326, DateTimeKind.Local).AddTicks(2901), new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(4761), "Levi Conroy", 48, 2, 340098.86619480160000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 10, 5, 23, 29, 36, 674, DateTimeKind.Local).AddTicks(6374), new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(5836), "Darrell Haley", 56, 1, 33687.9658323978280000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 12, 28, 5, 7, 13, 468, DateTimeKind.Local).AddTicks(5521), new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(6523), "Forrest Schulist", 88, 1, 185565.958764707290000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 10, 31, 7, 23, 12, 997, DateTimeKind.Local).AddTicks(5613), new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(7256), "Angelo Funk", 42, 71093.116768177390000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1970, 7, 20, 14, 44, 29, 802, DateTimeKind.Local).AddTicks(9146), new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(7959), "Dexter Bosco", 67, 2, 279250.71037677670000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 7, 17, 17, 33, 52, 322, DateTimeKind.Local).AddTicks(7900), new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(8628), "Iris Barrows", 10, 3, 136682.839295998570000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1995, 10, 21, 22, 46, 38, 324, DateTimeKind.Local).AddTicks(4976), new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(9345), "Lester Rice", 75, 3, 314645.502280181920000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 63, DateTimeKind.Utc).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1998, 4, 9, 6, 51, 23, 594, DateTimeKind.Local).AddTicks(9387), new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(22), "Billie Hoeger", 71, 2, 327295.794631288330000m, new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 4, 28, 9, 50, 11, 185, DateTimeKind.Local).AddTicks(2130), new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(743), "Anita Gorczany", 67, 2, 259187.021325202480000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1979, 11, 20, 2, 7, 58, 598, DateTimeKind.Local).AddTicks(2604), new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(1843), "Faith McCullough", 10, 5, 255634.234671289360000m, new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1966, 1, 1, 5, 38, 18, 728, DateTimeKind.Local).AddTicks(2934), new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(2583), "Emma Mueller", 54, 1, 70339.237353496270000m, new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1969, 7, 8, 1, 6, 2, 198, DateTimeKind.Local).AddTicks(2118), new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(3262), "Jason Breitenberg", 22, 2, 293537.11232069860000m, new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1979, 1, 22, 1, 31, 51, 407, DateTimeKind.Local).AddTicks(7801), new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(3905), "Jim Bartell", 94, 77021.029436072140000m, new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 10, 4, 17, 8, 50, 75, DateTimeKind.Local).AddTicks(8164), new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(4404), "Doreen Greenholt", 88, 372497.806849070620000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 9, 22, 15, 0, 17, 116, DateTimeKind.Local).AddTicks(1865), new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(5023), "Glen Farrell", 24, 5, 27454.8389956211050000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(5022) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1962, 3, 19, 14, 56, 48, 902, DateTimeKind.Local).AddTicks(3156), new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(5555), "Marty Glover", 84, 5, 395750.770887749410000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 5, 9, 0, 19, 28, 735, DateTimeKind.Local).AddTicks(79), new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(6125), "Carmen Gutkowski", 3, 1, 293890.820076585280000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 9, 1, 0, 13, 19, 909, DateTimeKind.Local).AddTicks(6444), new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(6699), "Bennie Yost", 87, 2, 233808.520387698610000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1993, 2, 8, 11, 4, 59, 85, DateTimeKind.Local).AddTicks(9674), new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(7245), "Nancy Feeney", 35, 130739.068579655110000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 1, 13, 15, 39, 31, 634, DateTimeKind.Local).AddTicks(2567), new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(8066), "Rudy Grant", 51, 293487.514400905360000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 12, 20, 14, 58, 31, 227, DateTimeKind.Local).AddTicks(5299), new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(8867), "George Lockman", 4, 88332.779793734830000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1993, 3, 9, 13, 44, 19, 898, DateTimeKind.Local).AddTicks(9782), new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(9661), "Lydia Denesik", 25, 5, 85733.331440241280000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 64, DateTimeKind.Utc).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 6, 18, 1, 13, 3, 722, DateTimeKind.Local).AddTicks(2680), new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(335), "Allan Kunde", 60, 2, 46228.6190704183330000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 6, 15, 20, 22, 53, 570, DateTimeKind.Local).AddTicks(4319), new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(1008), "Jonathan Lind", 55, 2, 290198.173640921770000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 12, 9, 15, 23, 24, 910, DateTimeKind.Local).AddTicks(7069), new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(1757), "Lamar Jacobs", 10, 1, 99044.2631729950000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1958, 1, 7, 1, 16, 3, 267, DateTimeKind.Local).AddTicks(2737), new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(2437), "Francis Durgan", 83, 5, 84469.926833940820000m, new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1999, 1, 14, 11, 59, 45, 654, DateTimeKind.Local).AddTicks(8435), new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(3261), "Lorene Franecki", 28, 45101.8174532959960000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 5, 7, 6, 2, 48, 332, DateTimeKind.Local).AddTicks(752), new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(4061), "Velma Braun", 6, 1, 109868.602600432510000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 4, 14, 2, 19, 51, 258, DateTimeKind.Local).AddTicks(437), new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(4921), "Casey Wiza", 75, 2, 396466.360451964910000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 1, 8, 0, 35, 49, 620, DateTimeKind.Local).AddTicks(7810), new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(5632), "Conrad Schiller", 94, 5, 41822.3580832085110000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 4, 8, 12, 23, 17, 198, DateTimeKind.Local).AddTicks(1443), new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(6273), "Ramona Senger", 58, 387073.643216070970000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 8, 1, 14, 36, 27, 788, DateTimeKind.Local).AddTicks(5831), new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(6843), "Fred Mante", 64, 24885.8517721367350000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1966, 12, 18, 11, 40, 25, 797, DateTimeKind.Local).AddTicks(8413), new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(7455), "Gene Bogisich", 36, 3, 123933.05332258720000m, new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 11, 28, 0, 43, 15, 303, DateTimeKind.Local).AddTicks(5074), new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(8016), "Evan Willms", 41, 1, 178650.313313920750000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 3, 20, 20, 50, 48, 696, DateTimeKind.Local).AddTicks(8874), new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(8543), "Judy Gutmann", 90, 108777.26461741060000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1973, 12, 6, 18, 58, 6, 370, DateTimeKind.Local).AddTicks(4666), new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(9007), "Luz Simonis", 25, 3, 361319.913811056190000m, new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1997, 6, 19, 9, 12, 20, 860, DateTimeKind.Local).AddTicks(7802), new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(9529), "Doyle Volkman", 42, 4, 97654.3951189270000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 65, DateTimeKind.Utc).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 6, 27, 11, 47, 34, 11, DateTimeKind.Local).AddTicks(8333), new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(62), "Rolando Frami", 30, 1, 316364.019076839490000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 3, 8, 5, 9, 18, 22, DateTimeKind.Local).AddTicks(8519), new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(2064), "Rita Mohr", 87, 1, 379034.917423427320000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 8, 8, 9, 12, 14, 876, DateTimeKind.Local).AddTicks(6228), new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(3046), "Felipe Auer", 64, 5, 192746.970035350630000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1967, 4, 27, 12, 29, 24, 825, DateTimeKind.Local).AddTicks(4057), new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(3640), "Pamela Oberbrunner", 53, 310356.088423402960000m, new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 10, 12, 2, 19, 0, 778, DateTimeKind.Local).AddTicks(6572), new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(4204), "Miranda Bergstrom", 85, 75994.946254308370000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 3, 12, 19, 51, 9, 74, DateTimeKind.Local).AddTicks(2920), new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(4850), "Virgil Gutkowski", 16, 1, 100903.714931497780000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1995, 1, 6, 10, 1, 54, 769, DateTimeKind.Local).AddTicks(559), new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(5522), "Edwin Stracke", 48, 3, 357853.110313112170000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1974, 6, 1, 11, 3, 32, 370, DateTimeKind.Local).AddTicks(3120), new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(6177), "Bill Bogisich", 10, 1, 64963.170551616340000m, new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 5, 19, 12, 19, 6, 176, DateTimeKind.Local).AddTicks(9594), new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(6791), "Bernice Swaniawski", 24, 3, 176147.073049921210000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1961, 4, 22, 19, 7, 10, 318, DateTimeKind.Local).AddTicks(7279), new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(7403), "Dwayne Schuster", 57, 3, 59580.189819046510000m, new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Birthdate", "CreateDate", "Name", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 4, 28, 17, 36, 17, 654, DateTimeKind.Local).AddTicks(821), new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(7959), "Johnathan Kassulke", 2, 13454.48023689622360000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 2, 19, 9, 31, 51, 618, DateTimeKind.Local).AddTicks(1513), new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(8744), "Allison Doyle", 29, 3, 74749.637018126320000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1969, 9, 28, 23, 39, 21, 459, DateTimeKind.Local).AddTicks(5539), new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(9666), "Thelma Cruickshank", 66, 2, 289194.085928183140000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 66, DateTimeKind.Utc).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 5, 6, 11, 48, 18, 588, DateTimeKind.Local).AddTicks(3949), new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(373), "Viola Welch", 45, 2, 87346.357307474710000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1972, 4, 14, 6, 23, 45, 685, DateTimeKind.Local).AddTicks(9327), new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(1108), "Walter McGlynn", 10, 1, 218554.337469369970000m, new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1991, 4, 3, 16, 56, 53, 579, DateTimeKind.Local).AddTicks(3973), new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(1634), "Gloria Gaylord", 35, 16237.262536914760000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1975, 3, 19, 18, 32, 22, 827, DateTimeKind.Local).AddTicks(1595), new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(2184), "Wallace Abshire", 85, 16744.6824907924540000m, new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1997, 2, 22, 21, 11, 3, 477, DateTimeKind.Local).AddTicks(5992), new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(2705), "Elsie Cruickshank", 22, 1, 310018.356698974420000m, new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1964, 8, 24, 18, 28, 21, 436, DateTimeKind.Local).AddTicks(913), new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(3251), "Sophia Wintheiser", 28, 4, 383044.527639268420000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1995, 8, 12, 7, 56, 44, 960, DateTimeKind.Local).AddTicks(8513), new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(3831), "Karla Brown", 72, 5, 145222.895363384920000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 10, 29, 23, 41, 28, 755, DateTimeKind.Local).AddTicks(2408), new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(4319), "Alex Dibbert", 60, 1, 359168.335733283040000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1959, 5, 20, 15, 18, 1, 443, DateTimeKind.Local).AddTicks(1371), new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(4962), "Enrique Wunsch", 39, 5, 335464.058720534890000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1978, 11, 24, 5, 1, 17, 174, DateTimeKind.Local).AddTicks(6116), new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(6015), "Catherine Connelly", 57, 1, 108824.537088316780000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 11, 22, 16, 50, 36, 207, DateTimeKind.Local).AddTicks(4718), new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(6904), "Ada Leffler", 13, 1, 343973.791404909760000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1979, 1, 8, 9, 58, 21, 105, DateTimeKind.Local).AddTicks(3088), new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(7676), "Leo Bogan", 62, 4, 377831.07127392340000m, new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 2, 17, 6, 37, 59, 753, DateTimeKind.Local).AddTicks(85), new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(8355), "Carlos Predovic", 96, 2, 229358.239204636480000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2001, 8, 27, 20, 44, 16, 207, DateTimeKind.Local).AddTicks(288), new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(8990), "Paul Rempel", 17, 5, 22710.4976768549650000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1964, 10, 13, 16, 52, 1, 27, DateTimeKind.Local).AddTicks(7158), new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(9724), "Duane Baumbach", 96, 3, 237623.93604700360000m, new DateTime(2024, 2, 20, 15, 20, 41, 67, DateTimeKind.Utc).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1970, 9, 1, 9, 45, 0, 220, DateTimeKind.Local).AddTicks(6479), new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(400), "Neil Terry", 50, 4, 105707.978300268490000m, new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1964, 8, 7, 14, 39, 50, 532, DateTimeKind.Local).AddTicks(3216), new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(1057), "Angie Farrell", 21, 31409.4325912098580000m, new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1962, 1, 7, 10, 12, 50, 814, DateTimeKind.Local).AddTicks(8872), new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(1684), "Priscilla Abbott", 90, 1, 47977.6373361985210000m, new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 12, 23, 13, 26, 13, 538, DateTimeKind.Local).AddTicks(8936), new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(2711), "David Johnson", 40, 151967.61457501090000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 4, 4, 5, 35, 35, 125, DateTimeKind.Local).AddTicks(6582), new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(3341), "Theodore Jacobs", 76, 5, 238487.13009984160000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1993, 9, 7, 14, 49, 12, 623, DateTimeKind.Local).AddTicks(9983), new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(3919), "Albert Hodkiewicz", 20, 4, 386391.270966762610000m, new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 5, 22, 6, 58, 47, 86, DateTimeKind.Local).AddTicks(5301), new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(4913), "Alejandro Parker", 58, 73854.904196931250000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1982, 4, 25, 14, 42, 15, 805, DateTimeKind.Local).AddTicks(584), new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(5581), "Shannon Becker", 41, 306713.203370178010000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 9, 16, 2, 46, 37, 597, DateTimeKind.Local).AddTicks(3318), new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(6184), "Gladys Ritchie", 65, 5, 148162.197238783510000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 2, 28, 23, 48, 37, 963, DateTimeKind.Local).AddTicks(9119), new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(6791), "Johnny Reichert", 84, 23782.7636083814170000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1968, 7, 20, 15, 50, 58, 336, DateTimeKind.Local).AddTicks(8220), new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(7344), "Raymond Zulauf", 12, 5, 303323.42173861090000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 12, 28, 6, 35, 49, 529, DateTimeKind.Local).AddTicks(1), new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(7960), "Loretta Grant", 14, 325345.979099160490000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 12, 16, 0, 50, 33, 63, DateTimeKind.Local).AddTicks(4816), new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(9041), "Toby Hyatt", 15, 1, 299334.800682234580000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1955, 3, 13, 6, 25, 38, 782, DateTimeKind.Local).AddTicks(3441), new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(9866), "Kelli Hessel", 85, 382427.137594656040000m, new DateTime(2024, 2, 20, 15, 20, 41, 68, DateTimeKind.Utc).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1956, 3, 10, 15, 29, 23, 177, DateTimeKind.Local).AddTicks(4358), new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(560), "Elsie Langosh", 6, 2, 57744.671214906640000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1965, 4, 2, 22, 18, 59, 75, DateTimeKind.Local).AddTicks(2224), new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(1221), "Luther Smith", 68, 174578.520848962090000m, new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(1221) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 3, 3, 12, 58, 55, 939, DateTimeKind.Local).AddTicks(6120), new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(1883), "Edgar Leannon", 61, 5, 114191.467980072460000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 11, 29, 2, 50, 59, 607, DateTimeKind.Local).AddTicks(3999), new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(2589), "Kimberly Kuhlman", 16, 23328.1996030719250000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1983, 5, 9, 13, 37, 18, 536, DateTimeKind.Local).AddTicks(9596), new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(3373), "Tony Shanahan", 57, 1, 108735.566017638550000m, new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(3372) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 3, 20, 14, 56, 9, 808, DateTimeKind.Local).AddTicks(8274), new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(4083), "Megan Bechtelar", 53, 179624.39600734810000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1957, 5, 17, 21, 33, 12, 510, DateTimeKind.Local).AddTicks(6221), new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(4955), "Krystal Strosin", 10, 328800.252727103290000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 3, 25, 1, 20, 23, 513, DateTimeKind.Local).AddTicks(93), new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(6178), "Terrence Sporer", 56, 4, 290492.111924148280000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 4, 22, 9, 43, 40, 543, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(6980), "Mabel O'Connell", 35, 93222.059458966480000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1976, 3, 28, 22, 2, 4, 443, DateTimeKind.Local).AddTicks(5766), new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(8205), "Paula Aufderhar", 70, 5, 225001.927959263380000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(8205) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1984, 3, 20, 17, 23, 33, 442, DateTimeKind.Local).AddTicks(3891), new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(8842), "Pearl Mayer", 81, 3, 336220.676143062220000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 3, 1, 14, 35, 4, 863, DateTimeKind.Local).AddTicks(695), new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(9457), "Norma Waters", 12, 21364.2195744398230000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 69, DateTimeKind.Utc).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1962, 2, 15, 2, 54, 2, 507, DateTimeKind.Local).AddTicks(9320), new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(32), "Brittany Purdy", 73, 280084.733608777750000m, new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1976, 2, 6, 9, 52, 56, 241, DateTimeKind.Local).AddTicks(9672), new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(692), "Sabrina O'Kon", 26, 3, 143747.241338357920000m, new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 5, 25, 9, 5, 41, 739, DateTimeKind.Local).AddTicks(7073), new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(1399), "Adam Feil", 31, 5, 159764.216616616420000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1985, 11, 25, 0, 21, 45, 594, DateTimeKind.Local).AddTicks(113), new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(1990), "Sheri Collins", 47, 1, 170228.613529156120000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 12, 15, 14, 39, 45, 675, DateTimeKind.Local).AddTicks(1778), new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(3052), "Ian Wyman", 72, 51058.113511666810000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1981, 4, 22, 2, 58, 2, 725, DateTimeKind.Local).AddTicks(6312), new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(3693), "Lester Dare", 1, 4, 13560.17398033400350000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1979, 8, 8, 4, 32, 47, 707, DateTimeKind.Local).AddTicks(6889), new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(4296), "Tracy Mills", 80, 1, 68536.303584358990000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 11, 27, 17, 55, 27, 680, DateTimeKind.Local).AddTicks(4388), new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(4814), "Regina Deckow", 65, 199442.711806184980000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 1, 13, 17, 25, 8, 466, DateTimeKind.Local).AddTicks(9525), new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(5410), "Marcos Koss", 1, 1, 304608.812510993110000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 10, 6, 11, 53, 20, 701, DateTimeKind.Local).AddTicks(6154), new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(6030), "Gene Turcotte", 59, 2, 15732.6669774529090000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1980, 5, 24, 20, 3, 2, 853, DateTimeKind.Local).AddTicks(8044), new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(6553), "Melissa Hilpert", 42, 4, 205597.866051451630000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 4, 26, 10, 1, 15, 627, DateTimeKind.Local).AddTicks(3662), new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(7145), "Julia Johnson", 33, 1, 117104.366480485660000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1964, 2, 12, 21, 11, 9, 400, DateTimeKind.Local).AddTicks(6377), new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(7674), "Deanna Dibbert", 52, 1, 377834.088761956960000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1974, 4, 23, 22, 2, 22, 700, DateTimeKind.Local).AddTicks(2778), new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(8285), "Joann Weimann", 56, 3, 367968.568161879610000m, new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1987, 2, 25, 7, 42, 8, 608, DateTimeKind.Local).AddTicks(3067), new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(9136), "Rebecca McDermott", 99, 1, 114853.951153680820000m, new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1971, 8, 24, 16, 32, 57, 251, DateTimeKind.Local).AddTicks(7630), new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(9969), "Sheryl McDermott", 51, 2, 388723.228368104230000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 70, DateTimeKind.Utc).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 12, 15, 8, 12, 8, 700, DateTimeKind.Local).AddTicks(893), new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(670), "Della Hermiston", 53, 2, 178422.963296355430000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1984, 7, 3, 7, 3, 14, 274, DateTimeKind.Local).AddTicks(4916), new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(1306), "Abraham Mayer", 37, 1, 130090.332380471830000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1954, 10, 13, 20, 31, 28, 88, DateTimeKind.Local).AddTicks(4565), new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(1824), "Andy Hirthe", 9, 5, 360380.669187364270000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 7, 10, 4, 5, 1, 275, DateTimeKind.Local).AddTicks(6835), new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(2402), "Christopher Pouros", 91, 3, 88980.946437092440000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1986, 1, 24, 11, 20, 24, 764, DateTimeKind.Local).AddTicks(4625), new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(3011), "Lucia Herman", 47, 1, 37450.7228607522430000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1994, 11, 26, 11, 22, 30, 546, DateTimeKind.Local).AddTicks(187), new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(3560), "Perry Effertz", 29, 4, 96621.684932036410000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 5, 30, 5, 29, 52, 44, DateTimeKind.Local).AddTicks(3425), new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(4077), "Leroy Jacobi", 3, 4, 15081.6174162924820000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1977, 6, 19, 15, 41, 50, 413, DateTimeKind.Local).AddTicks(2181), new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(4628), "Janie Cronin", 59, 3, 125270.475101175940000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 7, 18, 14, 31, 14, 474, DateTimeKind.Local).AddTicks(2407), new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(5244), "Paul Weimann", 40, 1, 285341.441367045820000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1989, 5, 12, 17, 48, 14, 62, DateTimeKind.Local).AddTicks(3870), new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(6130), "Eric Ondricka", 18, 3, 125730.448672591480000m, new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1973, 10, 16, 5, 35, 41, 857, DateTimeKind.Local).AddTicks(7707), new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(6741), "Leslie Hickle", 94, 5, 326567.016645130420000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1996, 2, 17, 6, 43, 48, 968, DateTimeKind.Local).AddTicks(2513), new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(7334), "Sidney VonRueden", 84, 5, 258961.708014226870000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1987, 6, 26, 14, 20, 53, 900, DateTimeKind.Local).AddTicks(1966), new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(7904), "Lawrence Macejkovic", 54, 4, 139945.12923600130000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 9, 21, 11, 19, 19, 678, DateTimeKind.Local).AddTicks(7789), new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(8508), "Penny Welch", 15, 2, 176972.774085350740000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2002, 5, 2, 11, 22, 27, 992, DateTimeKind.Local).AddTicks(9579), new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(9013), "Micheal Orn", 95, 3, 398908.948686145810000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1983, 2, 18, 2, 22, 48, 410, DateTimeKind.Local).AddTicks(3339), new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(9564), "Constance Brekke", 47, 3, 113334.512686591810000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 71, DateTimeKind.Utc).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1955, 11, 23, 5, 27, 34, 747, DateTimeKind.Local).AddTicks(7781), new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(517), "Lee Hills", 99, 75354.775425778930000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 1, 12, 5, 10, 16, 957, DateTimeKind.Local).AddTicks(240), new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(1292), "Bernard Marquardt", 47, 4, 270977.74225841890000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(1291) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 4, 2, 23, 15, 30, 339, DateTimeKind.Local).AddTicks(2946), new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(2267), "Louis Grant", 98, 5, 82739.65933071760000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 1, 29, 12, 36, 21, 524, DateTimeKind.Local).AddTicks(7939), new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(3069), "Marjorie Hagenes", 12, 93069.408703103290000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1958, 4, 2, 22, 2, 35, 211, DateTimeKind.Local).AddTicks(5548), new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(3650), "Shirley Denesik", 59, 4, 225440.003385872980000m, new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1962, 4, 23, 14, 4, 3, 729, DateTimeKind.Local).AddTicks(4436), new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(4284), "Charlie Roberts", 79, 5, 67625.786169239860000m, new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1990, 11, 8, 15, 43, 53, 892, DateTimeKind.Local).AddTicks(7472), new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(4871), "Greg Dibbert", 20, 2, 185291.566916273470000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 8, 31, 3, 42, 9, 536, DateTimeKind.Local).AddTicks(4427), new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(5401), "Elijah Turner", 56, 5, 150327.379522209880000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(5401) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 3, 15, 21, 26, 45, 296, DateTimeKind.Local).AddTicks(9207), new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(5978), "Alicia Kunde", 28, 201331.39633311730000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1989, 9, 10, 14, 32, 12, 493, DateTimeKind.Local).AddTicks(1133), new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(6516), "Earl Collier", 54, 144639.799724074060000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1972, 6, 29, 4, 39, 10, 684, DateTimeKind.Local).AddTicks(5216), new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(6988), "Julie Schultz", 76, 4, 294208.997954728990000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1960, 12, 13, 15, 21, 44, 50, DateTimeKind.Local).AddTicks(5349), new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(7532), "Thelma Kreiger", 18, 4, 22459.23110692780000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2003, 8, 5, 23, 24, 0, 596, DateTimeKind.Local).AddTicks(684), new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(8030), "Stuart Kuhn", 97, 60933.982535713810000m, 5, new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1966, 2, 15, 10, 36, 17, 247, DateTimeKind.Local).AddTicks(5692), new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(8963), "Donnie Zboncak", 57, 5, 350295.515572179310000m, 1, new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1988, 12, 10, 9, 53, 2, 287, DateTimeKind.Local).AddTicks(708), new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(9886), "Eric Champlin", 76, 94948.822151930230000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 72, DateTimeKind.Utc).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1975, 11, 3, 10, 36, 9, 652, DateTimeKind.Local).AddTicks(6307), new DateTime(2024, 2, 20, 15, 20, 41, 73, DateTimeKind.Utc).AddTicks(654), "Glen Dibbert", 69, 1, 39790.3209587718280000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 73, DateTimeKind.Utc).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1967, 9, 18, 2, 11, 7, 938, DateTimeKind.Local).AddTicks(379), new DateTime(2024, 2, 20, 15, 20, 41, 73, DateTimeKind.Utc).AddTicks(1266), "Eunice Olson", 50, 4, 235164.265713482680000m, 2, new DateTime(2024, 2, 20, 15, 20, 41, 73, DateTimeKind.Utc).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(1962, 10, 24, 9, 18, 11, 681, DateTimeKind.Local).AddTicks(6660), new DateTime(2024, 2, 20, 15, 20, 41, 73, DateTimeKind.Utc).AddTicks(1852), "Daisy Berge", 48, 3, 152683.027698749980000m, new DateTime(2024, 2, 20, 15, 20, 41, 73, DateTimeKind.Utc).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "UpdateOn" },
                values: new object[] { new DateTime(2002, 2, 28, 15, 34, 53, 569, DateTimeKind.Local).AddTicks(9848), new DateTime(2024, 2, 20, 15, 20, 41, 73, DateTimeKind.Utc).AddTicks(2517), "Krystal Konopelski", 21, 1, 23931.2087691945610000m, new DateTime(2024, 2, 20, 15, 20, 41, 73, DateTimeKind.Utc).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(2000, 12, 31, 17, 59, 16, 94, DateTimeKind.Local).AddTicks(4896), new DateTime(2024, 2, 20, 15, 20, 41, 73, DateTimeKind.Utc).AddTicks(3152), "Tabitha Carter", 53, 3, 294606.770376774040000m, 3, new DateTime(2024, 2, 20, 15, 20, 41, 73, DateTimeKind.Utc).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "PositionId", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1998, 7, 10, 19, 45, 23, 874, DateTimeKind.Local).AddTicks(4176), new DateTime(2024, 2, 20, 15, 20, 41, 73, DateTimeKind.Utc).AddTicks(3685), "Essie Kreiger", 10, 5, 116239.0734672280000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 73, DateTimeKind.Utc).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Birthdate", "CreateDate", "Name", "NationalRank", "Salary", "TeamId", "UpdateOn" },
                values: new object[] { new DateTime(1992, 8, 15, 8, 55, 41, 366, DateTimeKind.Local).AddTicks(6928), new DateTime(2024, 2, 20, 15, 20, 41, 73, DateTimeKind.Utc).AddTicks(4227), "Inez Rath", 40, 340700.809947158170000m, 4, new DateTime(2024, 2, 20, 15, 20, 41, 73, DateTimeKind.Utc).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 15, 20, 41, 35, DateTimeKind.Utc).AddTicks(6060), new DateTime(2024, 2, 20, 15, 20, 41, 35, DateTimeKind.Utc).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 15, 20, 41, 35, DateTimeKind.Utc).AddTicks(6062), new DateTime(2024, 2, 20, 15, 20, 41, 35, DateTimeKind.Utc).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 15, 20, 41, 35, DateTimeKind.Utc).AddTicks(6063), new DateTime(2024, 2, 20, 15, 20, 41, 35, DateTimeKind.Utc).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 15, 20, 41, 35, DateTimeKind.Utc).AddTicks(6064), new DateTime(2024, 2, 20, 15, 20, 41, 35, DateTimeKind.Utc).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 15, 20, 41, 35, DateTimeKind.Utc).AddTicks(6066), new DateTime(2024, 2, 20, 15, 20, 41, 35, DateTimeKind.Utc).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 15, 20, 41, 35, DateTimeKind.Utc).AddTicks(5807), new DateTime(2024, 2, 20, 15, 20, 41, 35, DateTimeKind.Utc).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 15, 20, 41, 35, DateTimeKind.Utc).AddTicks(5811), new DateTime(2024, 2, 20, 15, 20, 41, 35, DateTimeKind.Utc).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 15, 20, 41, 35, DateTimeKind.Utc).AddTicks(5813), new DateTime(2024, 2, 20, 15, 20, 41, 35, DateTimeKind.Utc).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 15, 20, 41, 35, DateTimeKind.Utc).AddTicks(5814), new DateTime(2024, 2, 20, 15, 20, 41, 35, DateTimeKind.Utc).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateOn" },
                values: new object[] { new DateTime(2024, 2, 20, 15, 20, 41, 35, DateTimeKind.Utc).AddTicks(5816), new DateTime(2024, 2, 20, 15, 20, 41, 35, DateTimeKind.Utc).AddTicks(5816) });
        }
    }
}
