using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Point1_EF.Migrations
{
    public partial class LocationNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -100,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1955, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Emma", new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hernandez", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -99,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1969, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Katherine", new DateTime(2005, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rivera", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -98,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1980, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Helen", new DateTime(2010, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garcia", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -97,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Christian", new DateTime(2011, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Long", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -96,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1952, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jonathan", new DateTime(2000, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramirez", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -95,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1978, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Arthur", new DateTime(2012, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garcia", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -94,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1972, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abigail", new DateTime(2013, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -93,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1962, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linda", new DateTime(2004, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -92,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1977, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lauren", new DateTime(2013, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ross" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -91,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1973, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roger", new DateTime(2007, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Green", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -90,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1976, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dorothy", new DateTime(2005, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelly", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -89,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicholas", new DateTime(2004, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bailey", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -88,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1958, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeffrey", new DateTime(2011, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruiz", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -87,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1954, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack", new DateTime(2010, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anderson" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -86,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1958, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel", new DateTime(2008, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Long", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -85,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1980, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeffrey", new DateTime(2004, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morales", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -84,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1952, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eugene", new DateTime(2002, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Murphy", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -83,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1974, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emma", new DateTime(2013, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alvarez", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -82,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1963, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna", new DateTime(2000, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Young", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -81,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1970, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justin", new DateTime(2014, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harris", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -80,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1967, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nathan", new DateTime(2005, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baker", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -79,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1960, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bruce", new DateTime(2013, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flores", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -78,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1959, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jeremy", new DateTime(2001, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wood" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -77,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1957, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Willie", new DateTime(2001, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ortiz", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -76,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1962, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joyce", new DateTime(2013, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anderson" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -75,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1967, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matthew", new DateTime(2013, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruiz", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -74,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1972, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joe", new DateTime(2009, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chavez", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -73,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1958, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Susan", new DateTime(2014, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Davis" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -72,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1963, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paul", new DateTime(2008, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gutierrez" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -71,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Randy", new DateTime(2003, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lopez", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -70,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1972, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexander", new DateTime(2006, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stewart", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -69,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1958, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", new DateTime(2013, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cooper", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -68,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1950, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dylan", new DateTime(2010, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanders", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -67,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1951, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ronald", new DateTime(2005, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -66,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna", new DateTime(2011, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hughes", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -65,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1963, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", new DateTime(2010, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hughes" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -64,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1961, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joshua", new DateTime(2002, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roberts", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -63,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1975, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keith", new DateTime(2006, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wood", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -62,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1950, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brandon", new DateTime(2005, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cox", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -61,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1956, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carl", new DateTime(2010, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morgan", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -60,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1952, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justin", new DateTime(2003, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Torres", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -59,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1975, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Arthur", new DateTime(2008, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nelson", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -58,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1952, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert", new DateTime(2000, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Williams", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -57,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1974, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deborah", new DateTime(2001, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alvarez" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -56,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1977, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Victoria", new DateTime(2000, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Price", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -55,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sara", new DateTime(2005, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foster", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -54,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1974, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jennifer", new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanchez", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -53,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1978, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nathan", new DateTime(2004, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foster", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -52,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1959, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cynthia", new DateTime(2004, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stewart", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -51,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1965, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Doris", new DateTime(2011, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -50,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1972, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", new DateTime(2007, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perez", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -49,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1954, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Betty", new DateTime(2014, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peterson", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -48,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1977, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linda", new DateTime(2009, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peterson", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -47,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1958, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", new DateTime(2011, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turner", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -46,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1965, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Scott", new DateTime(2008, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramos", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -45,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1968, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tyler", new DateTime(2012, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -44,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carolyn", new DateTime(2011, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carter", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -43,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1979, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philip", new DateTime(2005, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cooper", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -42,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1962, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kenneth", new DateTime(2014, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanders", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -41,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1955, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Aaron", new DateTime(2008, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -40,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1976, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jessica", new DateTime(2009, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evans", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -39,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1968, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pamela", new DateTime(2000, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -38,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1957, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kevin", new DateTime(2012, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nelson", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -37,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1974, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Alexis", new DateTime(2003, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smith", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -36,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1957, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michelle", new DateTime(2010, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carter", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -35,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1951, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jean", new DateTime(2004, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cooper", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -34,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1957, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anthony", new DateTime(2012, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Richardson", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -33,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1979, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sara", new DateTime(2003, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jimenez", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -32,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1951, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rachel", new DateTime(2008, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanchez" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -31,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1961, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel", new DateTime(2014, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taylor" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -30,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1963, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frances", new DateTime(2012, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -29,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1951, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ronald", new DateTime(2005, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baker", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -28,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1965, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joan", new DateTime(2000, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Castillo", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -27,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1956, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philip", new DateTime(2006, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martinez", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -26,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1974, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madison", new DateTime(2001, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hill", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -25,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1980, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Theresa", new DateTime(2006, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brooks", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -24,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1976, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heather", new DateTime(2009, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Campbell" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -23,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1954, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott", new DateTime(2004, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lopez", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -22,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1965, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sarah", new DateTime(2009, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hill" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -21,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1968, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher", new DateTime(2006, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilson", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -20,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1961, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carol", new DateTime(2005, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moore", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -19,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1961, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bobby", new DateTime(2013, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wright", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -18,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1974, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeremy", new DateTime(2000, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jackson", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -17,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1970, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hannah", new DateTime(2002, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lewis" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -16,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1973, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sharon", new DateTime(2010, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Allen" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -15,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1967, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shirley", new DateTime(2013, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hernandez", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -14,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1965, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jerry", new DateTime(2001, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Campbell", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -13,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1967, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brian", new DateTime(2009, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -12,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1956, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Carol", new DateTime(2005, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "King" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -11,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1958, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverly", new DateTime(2009, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jones", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -10,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1969, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrick", new DateTime(2001, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Allen", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -9,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Timothy", new DateTime(2014, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -8,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Theresa", new DateTime(2008, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nelson", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -7,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1979, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabella", new DateTime(2011, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Campbell", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -6,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1963, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverly", new DateTime(2006, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cox", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -5,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1956, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joshua", new DateTime(2005, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hill" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -4,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1977, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ethan", new DateTime(2014, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -3,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1973, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jacqueline", new DateTime(2006, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Allen", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -2,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1960, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brittany", new DateTime(2002, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brown" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -1,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1969, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pamela", new DateTime(2000, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edwards", -3 });

            migrationBuilder.UpdateData(
                table: "location",
                keyColumn: "id",
                keyValue: -5,
                column: "name",
                value: "Elmo Store");

            migrationBuilder.UpdateData(
                table: "location",
                keyColumn: "id",
                keyValue: -4,
                column: "name",
                value: "Silly Store");

            migrationBuilder.UpdateData(
                table: "location",
                keyColumn: "id",
                keyValue: -3,
                column: "name",
                value: "Corporate Headquarters");

            migrationBuilder.UpdateData(
                table: "location",
                keyColumn: "id",
                keyValue: -2,
                column: "name",
                value: "Awesome Store");

            migrationBuilder.UpdateData(
                table: "location",
                keyColumn: "id",
                keyValue: -1,
                column: "name",
                value: "Super Duper Store");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -100,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1959, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amber", new DateTime(2006, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flores", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -99,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1980, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cynthia", new DateTime(2006, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thompson", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -98,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1977, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ronald", new DateTime(2004, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watson", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -97,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1970, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paul", new DateTime(2013, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cox", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -96,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1954, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "William", new DateTime(2011, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanchez", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -95,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1962, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sandra", new DateTime(2004, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bailey", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -94,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1957, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Benjamin", new DateTime(2006, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miller", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -93,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1980, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Laura", new DateTime(2001, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evans", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -92,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1978, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janet", new DateTime(2001, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anderson" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -91,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1958, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brenda", new DateTime(2008, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brown", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -90,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1968, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ralph", new DateTime(2000, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Price", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -89,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1959, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philip", new DateTime(2000, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phillips", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -88,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1969, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "William", new DateTime(2014, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hall", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -87,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1973, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", new DateTime(2002, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brooks" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -86,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1978, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Edward", new DateTime(2004, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hernandez", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -85,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1951, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albert", new DateTime(2004, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diaz", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -84,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1971, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Albert", new DateTime(2010, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mendoza", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -83,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1952, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicholas", new DateTime(2003, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robinson", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -82,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1965, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Richard", new DateTime(2003, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roberts", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -81,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1974, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dorothy", new DateTime(2007, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramirez", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -80,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1973, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Megan", new DateTime(2009, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moore", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -79,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1978, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natalie", new DateTime(2010, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruiz", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -78,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1972, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Randy", new DateTime(2014, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Richardson" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -77,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1971, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madison", new DateTime(2002, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rodriguez", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -76,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1972, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albert", new DateTime(2005, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perez" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -75,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1952, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heather", new DateTime(2008, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bennet", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -74,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ann", new DateTime(2002, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peterson", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -73,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1950, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ashley", new DateTime(2005, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roberts" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -72,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1959, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jordan", new DateTime(2007, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stewart" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -71,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1959, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice", new DateTime(2013, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bailey", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -70,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1952, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Benjamin", new DateTime(2001, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -69,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1977, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Abigail", new DateTime(2011, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -68,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1958, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Katherine", new DateTime(2008, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brown", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -67,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1968, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pamela", new DateTime(2004, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martinez", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -66,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1968, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Julia", new DateTime(2012, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -65,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1971, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Justin", new DateTime(2007, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cooper" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -64,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1955, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elizabeth", new DateTime(2002, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adams", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -63,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1956, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gerald", new DateTime(2010, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Howard", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -62,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1974, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "David", new DateTime(2004, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patel", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -61,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1956, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gerald", new DateTime(2001, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taylor", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -60,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1970, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sharon", new DateTime(2000, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turner", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -59,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1971, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evelyn", new DateTime(2000, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kim", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -58,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1955, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Richard", new DateTime(2006, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cooper", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -57,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1965, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Karen", new DateTime(2005, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "King" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -56,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abigail", new DateTime(2000, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edwards", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -55,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1959, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kayla", new DateTime(2000, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moore", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -54,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1954, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice", new DateTime(2011, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phillips", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -53,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1957, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dorothy", new DateTime(2008, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robinson", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -52,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1974, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", new DateTime(2007, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peterson", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -51,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1954, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charlotte", new DateTime(2005, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -50,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1955, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sophia", new DateTime(2012, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -49,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1952, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mary", new DateTime(2012, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Richardson", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -48,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1953, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wayne", new DateTime(2004, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kim", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -47,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1968, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emily", new DateTime(2013, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bailey", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -46,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1951, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nancy", new DateTime(2008, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martinez", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -45,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1974, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aaron", new DateTime(2008, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baker", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -44,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1960, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Betty", new DateTime(2011, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miller", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -43,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emma", new DateTime(2014, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harris", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -42,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1952, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carolyn", new DateTime(2013, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -41,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1957, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gregory", new DateTime(2012, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -40,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1979, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cynthia", new DateTime(2002, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mendoza", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -39,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1965, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Theresa", new DateTime(2013, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Myers", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -38,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1974, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kathryn", new DateTime(2006, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -37,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1961, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roy", new DateTime(2008, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thompson", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -36,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1957, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carolyn", new DateTime(2001, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hill", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -35,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1954, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Larry", new DateTime(2010, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gray", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -34,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1956, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice", new DateTime(2009, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Green", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -33,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1960, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrick", new DateTime(2004, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -32,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1952, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cheryl", new DateTime(2011, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morris" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -31,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1959, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Wayne", new DateTime(2013, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelly" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -30,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1970, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diane", new DateTime(2002, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roberts", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -29,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1973, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marilyn", new DateTime(2013, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hughes", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -28,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1974, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wayne", new DateTime(2010, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -27,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1951, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kimberly", new DateTime(2001, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Richardson", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -26,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1972, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angela", new DateTime(2014, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Price", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -25,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1954, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eugene", new DateTime(2001, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wood", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -24,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1950, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angela", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -23,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1980, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jennifer", new DateTime(2009, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilson", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -22,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1973, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philip", new DateTime(2014, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hall" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -21,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1977, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mark", new DateTime(2014, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garcia", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -20,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1951, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barbara", new DateTime(2009, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hall", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -19,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1973, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rebecca", new DateTime(2003, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hall", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -18,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1962, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anthony", new DateTime(2010, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adams", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -17,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1968, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ralph", new DateTime(2007, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reed" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -16,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1964, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arthur", new DateTime(2006, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moore" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -15,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noah", new DateTime(2008, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morales", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -14,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1975, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Willie", new DateTime(2014, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roberts", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -13,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walter", new DateTime(2004, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nelson", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -12,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1978, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sean", new DateTime(2008, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanchez" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -11,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1967, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jordan", new DateTime(2009, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnson", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -10,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debra", new DateTime(2007, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nelson", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -9,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1972, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martha", new DateTime(2001, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rivera", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -8,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1965, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Julia", new DateTime(2001, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lopez", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -7,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Alexis", new DateTime(2004, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baker", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -6,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1974, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virginia", new DateTime(2012, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wright", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -5,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1958, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Julia", new DateTime(2008, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garcia" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -4,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1968, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vincent", new DateTime(2006, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "King" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -3,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1959, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eric", new DateTime(2001, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelly", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -2,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1961, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Michelle", new DateTime(2008, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Richardson" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -1,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1972, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Betty", new DateTime(2004, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foster", -4 });

            migrationBuilder.UpdateData(
                table: "location",
                keyColumn: "id",
                keyValue: -5,
                column: "name",
                value: "");

            migrationBuilder.UpdateData(
                table: "location",
                keyColumn: "id",
                keyValue: -4,
                column: "name",
                value: "");

            migrationBuilder.UpdateData(
                table: "location",
                keyColumn: "id",
                keyValue: -3,
                column: "name",
                value: "");

            migrationBuilder.UpdateData(
                table: "location",
                keyColumn: "id",
                keyValue: -2,
                column: "name",
                value: "");

            migrationBuilder.UpdateData(
                table: "location",
                keyColumn: "id",
                keyValue: -1,
                column: "name",
                value: "");
        }
    }
}
