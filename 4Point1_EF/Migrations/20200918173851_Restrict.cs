using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Point1_EF.Migrations
{
    public partial class Restrict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Location",
                table: "employee");

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -100,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1956, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dorothy", new DateTime(2002, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -99,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1959, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nancy", new DateTime(2011, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sean" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -98,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1955, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jose", new DateTime(2013, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tyler", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -97,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1962, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Frank", new DateTime(2013, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Richard", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -96,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1979, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bradley", new DateTime(2002, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicholas", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -95,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1953, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aaron", new DateTime(2005, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexander" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -94,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1952, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joshua", new DateTime(2012, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henry", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -93,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1977, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jesse", new DateTime(2014, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -92,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1950, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bruce", new DateTime(2000, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -91,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1975, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harold", new DateTime(2008, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jesse", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -90,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1950, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Abigail", new DateTime(2007, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frank", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -89,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1965, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Melissa", new DateTime(2013, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -88,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1978, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Billy", new DateTime(2014, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -87,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1971, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donna", new DateTime(2002, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tyler" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -86,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1952, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", new DateTime(2013, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Douglas", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -85,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1956, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kayla", new DateTime(2003, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nathan", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -84,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1959, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Logan", new DateTime(2010, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ralph", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -83,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1975, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexis", new DateTime(2008, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charles" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -82,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1977, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henry", new DateTime(2009, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brian", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -81,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anthony", new DateTime(2009, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christian", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -80,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donna", new DateTime(2003, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -79,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1952, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brittany", new DateTime(2014, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bobby", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -78,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1962, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samantha", new DateTime(2009, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Richard", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -77,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1978, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deborah", new DateTime(2008, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paul", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -76,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1979, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicole", new DateTime(2005, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bobby" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -75,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1953, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Willie", new DateTime(2012, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Raymond", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -74,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1970, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Denise", new DateTime(2001, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnny", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -73,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1967, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kenneth", new DateTime(2014, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -72,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1980, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jessica", new DateTime(2002, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -71,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1958, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linda", new DateTime(2006, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -70,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1976, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack", new DateTime(2009, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnny", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -69,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1961, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel", new DateTime(2008, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noah", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -68,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1962, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harold", new DateTime(2009, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -67,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1950, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelly", new DateTime(2004, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kenneth", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -66,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1962, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin", new DateTime(2008, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Randy", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -65,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1953, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anthony", new DateTime(2007, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -64,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1958, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Douglas", new DateTime(2000, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -63,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1974, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logan", new DateTime(2003, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -62,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1967, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Melissa", new DateTime(2011, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bradley" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -61,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1955, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jason", new DateTime(2008, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philip", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -60,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1961, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brian", new DateTime(2002, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexander", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -59,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1957, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruth", new DateTime(2004, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ethan", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -58,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1955, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arthur", new DateTime(2011, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noah", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -57,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1971, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ashley", new DateTime(2012, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arthur", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -56,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1962, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keith", new DateTime(2004, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Russell", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -55,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1954, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joshua", new DateTime(2009, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jordan", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -54,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1962, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Victoria", new DateTime(2011, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kyle", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -53,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1976, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Justin", new DateTime(2011, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frank", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -52,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1967, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sean", new DateTime(2011, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albert", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -51,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1953, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Carol", new DateTime(2010, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Larry", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -50,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ralph", new DateTime(2009, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roger", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -49,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1979, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Diane", new DateTime(2005, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -48,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1970, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barbara", new DateTime(2013, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arthur", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -47,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1969, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Julia", new DateTime(2014, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jesse" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -46,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1959, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albert", new DateTime(2012, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dennis", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -45,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1963, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bryan", new DateTime(2011, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brian", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -44,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1959, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sara", new DateTime(2003, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexander", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -43,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1952, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ronald", new DateTime(2007, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roy", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -42,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1965, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bruce", new DateTime(2009, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrick", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -41,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1960, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debra", new DateTime(2007, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wayne" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -40,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1968, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jerry", new DateTime(2008, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edward", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -39,
                columns: new[] { "dateofbirth", "enddate", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1962, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2011, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gregory", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -38,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1965, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janet", new DateTime(2013, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrew", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -37,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1969, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Matthew", new DateTime(2002, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -36,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1955, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kathleen", new DateTime(2006, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ralph", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -35,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1950, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eric", new DateTime(2012, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carl" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -34,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1963, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pamela", new DateTime(2005, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "George", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -33,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1976, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sarah", new DateTime(2013, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Richard" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -32,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debra", new DateTime(2002, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeffrey", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -31,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "location_id" },
                values: new object[] { new DateTime(1953, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna", new DateTime(2010, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -30,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1966, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeremy", new DateTime(2014, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keith" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -29,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1962, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jose", new DateTime(2011, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frank" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -28,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1975, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Linda", new DateTime(2004, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christian", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -27,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1951, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donna", new DateTime(2012, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roger", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -26,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1979, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bryan", new DateTime(2004, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -25,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janice", new DateTime(2008, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -24,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1977, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Douglas", new DateTime(2010, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vincent", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -23,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1973, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kayla", new DateTime(2012, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicholas", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -22,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1979, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lauren", new DateTime(2005, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -21,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1954, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Keith", new DateTime(2008, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Louis", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -20,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1974, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Margaret", new DateTime(2004, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -19,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Andrea", new DateTime(2002, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joseph", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -18,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1967, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Keith", new DateTime(2010, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eugene", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -17,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1962, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bruce", new DateTime(2014, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrick", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -16,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1951, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eugene", new DateTime(2001, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -15,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1963, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas", new DateTime(2002, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paul", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -14,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1971, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rebecca", new DateTime(2002, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joshua", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -13,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debra", new DateTime(2008, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jason", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -12,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1953, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Judith", new DateTime(2000, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zachary", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -11,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1973, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bobby", new DateTime(2011, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -10,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1956, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "William", new DateTime(2013, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriel" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -9,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1958, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kevin", new DateTime(2009, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philip", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -8,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1953, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeremy", new DateTime(2007, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -7,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1971, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rose", new DateTime(2014, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kevin", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -6,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1970, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jerry", new DateTime(2009, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sean", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -5,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1958, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brian", new DateTime(2010, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrick", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -4,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1968, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sean", new DateTime(2013, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -3,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1956, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jordan", new DateTime(2000, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gregory", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -2,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1952, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Timothy", new DateTime(2000, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Benjamin", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -1,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1974, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Theresa", new DateTime(2001, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dylan", -2 });

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Location",
                table: "employee",
                column: "location_id",
                principalTable: "location",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Location",
                table: "employee");

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -100,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1975, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephen", new DateTime(2008, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albert", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -99,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1960, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Natalie", new DateTime(2004, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brian" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -98,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1953, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rose", new DateTime(2007, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -97,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1953, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter", new DateTime(2005, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Randy", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -96,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1961, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jordan", new DateTime(2003, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -95,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1966, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frank", new DateTime(2006, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ryan" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -94,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1979, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott", new DateTime(2013, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicholas", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -93,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1978, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Willie", new DateTime(2008, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Timothy" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -92,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1956, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Victoria", new DateTime(2005, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charles" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -91,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1965, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tyler", new DateTime(2003, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -90,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1952, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matthew", new DateTime(2007, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Louis", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -89,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1967, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madison", new DateTime(2001, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -88,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1977, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christian", new DateTime(2003, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dennis" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -87,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1951, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amber", new DateTime(2014, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Timothy" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -86,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1956, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rose", new DateTime(2004, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brandon", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -85,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1954, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Julie", new DateTime(2001, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -84,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1976, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelly", new DateTime(2007, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henry", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -83,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1968, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Barbara", new DateTime(2014, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Louis" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -82,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1971, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sandra", new DateTime(2006, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matthew", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -81,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1961, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eric", new DateTime(2011, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roger", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -80,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1950, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nathan", new DateTime(2004, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jonathan", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -79,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1969, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jason", new DateTime(2005, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -78,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter", new DateTime(2006, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Benjamin", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -77,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1959, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harold", new DateTime(2007, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Larry", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -76,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1971, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ryan", new DateTime(2003, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charles" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -75,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1977, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cynthia", new DateTime(2004, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Russell", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -74,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1956, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin", new DateTime(2013, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tyler", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -73,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1955, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ralph", new DateTime(2011, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -72,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1950, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lauren", new DateTime(2010, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philip", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -71,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1976, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrick", new DateTime(2014, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ralph", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -70,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1970, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hannah", new DateTime(2012, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noah", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -69,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1980, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Victoria", new DateTime(2005, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donald", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -68,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1961, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lisa", new DateTime(2000, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -67,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1974, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexis", new DateTime(2010, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anthony", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -66,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natalie", new DateTime(2010, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donald", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -65,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1969, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olivia", new DateTime(2007, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joseph", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -64,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1975, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jason", new DateTime(2002, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -63,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1958, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jason", new DateTime(2006, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ethan" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -62,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1964, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donna", new DateTime(2001, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Randy" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -61,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1962, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terry", new DateTime(2010, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -60,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1962, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kimberly", new DateTime(2004, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zachary", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -59,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1968, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emily", new DateTime(2011, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "William", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -58,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1956, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christian", new DateTime(2011, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brian", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -57,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "James", new DateTime(2004, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrew", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -56,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1978, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Natalie", new DateTime(2011, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nathan", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -55,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1968, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sara", new DateTime(2007, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donald", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -54,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1970, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Danielle", new DateTime(2014, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sean", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -53,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1953, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna", new DateTime(2003, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wayne", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -52,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1954, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Emily", new DateTime(2010, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charles", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -51,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1951, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amy", new DateTime(2013, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephen", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -50,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1972, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marie", new DateTime(2002, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -49,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1971, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Megan", new DateTime(2010, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eugene", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -48,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1975, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kimberly", new DateTime(2001, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eugene", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -47,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1956, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rachel", new DateTime(2008, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -46,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1979, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samantha", new DateTime(2003, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harold", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -45,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1953, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ethan", new DateTime(2012, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -44,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1979, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ethan", new DateTime(2004, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -43,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1953, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverly", new DateTime(2014, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edward", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -42,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1964, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverly", new DateTime(2013, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charles", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -41,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1975, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eugene", new DateTime(2002, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -40,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1959, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marilyn", new DateTime(2002, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zachary", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -39,
                columns: new[] { "dateofbirth", "enddate", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1962, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jason", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -38,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1972, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joyce", new DateTime(2009, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aaron", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -37,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1957, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephanie", new DateTime(2010, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -36,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1978, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicole", new DateTime(2013, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -35,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1960, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "William", new DateTime(2006, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -34,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1954, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jean", new DateTime(2002, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Larry", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -33,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1978, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madison", new DateTime(2009, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ralph" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -32,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1969, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thomas", new DateTime(2001, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albert", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -31,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "location_id" },
                values: new object[] { new DateTime(1969, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Judith", new DateTime(2013, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -30,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1956, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel", new DateTime(2014, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tyler" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -29,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1966, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kayla", new DateTime(2002, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bradley" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -28,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1951, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Victoria", new DateTime(2008, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bradley", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -27,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1978, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven", new DateTime(2008, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -26,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1957, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deborah", new DateTime(2006, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brian", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -25,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1955, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Noah", new DateTime(2002, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brian", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -24,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1967, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janet", new DateTime(2010, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -23,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1972, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lauren", new DateTime(2009, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jacob", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -22,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1967, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Andrew", new DateTime(2013, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jordan", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -21,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1965, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sophia", new DateTime(2001, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edward", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -20,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1960, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Julia", new DateTime(2002, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicholas", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -19,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1966, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cheryl", new DateTime(2009, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -18,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1974, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", new DateTime(2003, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Douglas", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -17,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1967, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Susan", new DateTime(2009, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arthur", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -16,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1967, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kathryn", new DateTime(2006, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bryan", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -15,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1978, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Johnny", new DateTime(2001, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexander", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -14,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1978, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grace", new DateTime(2006, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -13,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1951, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverly", new DateTime(2001, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephen", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -12,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1978, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Amy", new DateTime(2007, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henry", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -11,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1968, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverly", new DateTime(2008, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", -2 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -10,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname" },
                values: new object[] { new DateTime(1968, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vincent", new DateTime(2010, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logan" });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -9,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1951, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karen", new DateTime(2010, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrew", -5 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -8,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1959, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charlotte", new DateTime(2005, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sean", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -7,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1968, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Helen", new DateTime(2012, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -6,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1951, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aaron", new DateTime(2000, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Larry", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -5,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1958, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janice", new DateTime(2011, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott", -4 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -4,
                columns: new[] { "dateofbirth", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1973, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rose", new DateTime(2011, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeffrey", -1 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -3,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1965, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Samantha", new DateTime(2000, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nathan", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -2,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1980, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Doris", new DateTime(2003, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edward", -3 });

            migrationBuilder.UpdateData(
                table: "employee",
                keyColumn: "id",
                keyValue: -1,
                columns: new[] { "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[] { new DateTime(1961, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Deborah", new DateTime(2007, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", -3 });

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Location",
                table: "employee",
                column: "location_id",
                principalTable: "location",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
