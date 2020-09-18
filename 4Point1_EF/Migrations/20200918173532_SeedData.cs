using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Point1_EF.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Location",
                table: "employee");

            migrationBuilder.InsertData(
                table: "location",
                columns: new[] { "id", "address", "city", "name", "postalcode" },
                values: new object[,]
                {
                    { -1, "123 Main Street", "Edmonton", "", "T6M5W2" },
                    { -2, "567 Side Street", "Vancouver", "", "T8M2X2" },
                    { -3, "246 Boulevard Street", "Edmonton", "", "T2Y8Z2" },
                    { -4, "357 Back Street", "Calgary", "", "T9T7L2" },
                    { -5, "852 Sesame Street", "Edmonton", "", "T9M2A9" }
                });

            migrationBuilder.InsertData(
                table: "employee",
                columns: new[] { "id", "dateofbirth", "enddate", "firstname", "hiredate", "lastname", "location_id" },
                values: new object[,]
                {
                    { -4, new DateTime(1973, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rose", new DateTime(2011, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeffrey", -1 },
                    { -42, new DateTime(1964, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Beverly", new DateTime(2013, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charles", -4 },
                    { -34, new DateTime(1954, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jean", new DateTime(2002, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Larry", -4 },
                    { -29, new DateTime(1966, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kayla", new DateTime(2002, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bradley", -4 },
                    { -28, new DateTime(1951, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Victoria", new DateTime(2008, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bradley", -4 },
                    { -20, new DateTime(1960, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Julia", new DateTime(2002, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicholas", -4 },
                    { -15, new DateTime(1978, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Johnny", new DateTime(2001, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexander", -4 },
                    { -12, new DateTime(1978, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Amy", new DateTime(2007, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henry", -4 },
                    { -8, new DateTime(1959, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Charlotte", new DateTime(2005, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sean", -4 },
                    { -5, new DateTime(1958, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janice", new DateTime(2011, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott", -4 },
                    { -100, new DateTime(1975, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephen", new DateTime(2008, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albert", -3 },
                    { -90, new DateTime(1952, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matthew", new DateTime(2007, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Louis", -3 },
                    { -89, new DateTime(1967, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Madison", new DateTime(2001, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin", -3 },
                    { -85, new DateTime(1954, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Julie", new DateTime(2001, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel", -3 },
                    { -78, new DateTime(1964, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Peter", new DateTime(2006, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Benjamin", -3 },
                    { -76, new DateTime(1971, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ryan", new DateTime(2003, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charles", -3 },
                    { -70, new DateTime(1970, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hannah", new DateTime(2012, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noah", -3 },
                    { -66, new DateTime(1964, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Natalie", new DateTime(2010, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donald", -3 },
                    { -65, new DateTime(1969, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Olivia", new DateTime(2007, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joseph", -3 },
                    { -56, new DateTime(1978, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Natalie", new DateTime(2011, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nathan", -3 },
                    { -54, new DateTime(1970, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Danielle", new DateTime(2014, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sean", -3 },
                    { -50, new DateTime(1972, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marie", new DateTime(2002, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", -3 },
                    { -46, new DateTime(1979, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Samantha", new DateTime(2003, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harold", -4 },
                    { -36, new DateTime(1978, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nicole", new DateTime(2013, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack", -3 },
                    { -49, new DateTime(1971, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Megan", new DateTime(2010, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eugene", -4 },
                    { -62, new DateTime(1964, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Donna", new DateTime(2001, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Randy", -4 },
                    { -72, new DateTime(1950, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lauren", new DateTime(2010, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philip", -5 },
                    { -63, new DateTime(1958, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jason", new DateTime(2006, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ethan", -5 },
                    { -59, new DateTime(1968, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emily", new DateTime(2011, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "William", -5 },
                    { -55, new DateTime(1968, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sara", new DateTime(2007, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donald", -5 },
                    { -53, new DateTime(1953, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna", new DateTime(2003, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wayne", -5 },
                    { -51, new DateTime(1951, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amy", new DateTime(2013, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephen", -5 },
                    { -44, new DateTime(1979, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ethan", new DateTime(2004, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott", -5 },
                    { -39, new DateTime(1962, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jason", new DateTime(2003, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jason", -5 },
                    { -37, new DateTime(1957, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephanie", new DateTime(2010, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan", -5 },
                    { -18, new DateTime(1974, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", new DateTime(2003, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Douglas", -5 },
                    { -17, new DateTime(1967, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Susan", new DateTime(2009, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arthur", -5 },
                    { -16, new DateTime(1967, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kathryn", new DateTime(2006, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bryan", -5 },
                    { -14, new DateTime(1978, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grace", new DateTime(2006, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher", -5 },
                    { -9, new DateTime(1951, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Karen", new DateTime(2010, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrew", -5 },
                    { -99, new DateTime(1960, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Natalie", new DateTime(2004, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brian", -4 },
                    { -96, new DateTime(1961, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jordan", new DateTime(2003, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", -4 },
                    { -93, new DateTime(1978, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Willie", new DateTime(2008, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Timothy", -4 },
                    { -92, new DateTime(1956, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Victoria", new DateTime(2005, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charles", -4 },
                    { -83, new DateTime(1968, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Barbara", new DateTime(2014, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Louis", -4 },
                    { -82, new DateTime(1971, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sandra", new DateTime(2006, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matthew", -4 },
                    { -74, new DateTime(1956, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin", new DateTime(2013, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tyler", -4 },
                    { -52, new DateTime(1954, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Emily", new DateTime(2010, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charles", -4 },
                    { -32, new DateTime(1969, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thomas", new DateTime(2001, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albert", -3 },
                    { -30, new DateTime(1956, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Samuel", new DateTime(2014, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tyler", -3 },
                    { -24, new DateTime(1967, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Janet", new DateTime(2010, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam", -3 },
                    { -88, new DateTime(1977, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Christian", new DateTime(2003, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dennis", -1 },
                    { -87, new DateTime(1951, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Amber", new DateTime(2014, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Timothy", -1 },
                    { -86, new DateTime(1956, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rose", new DateTime(2004, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brandon", -1 },
                    { -84, new DateTime(1976, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelly", new DateTime(2007, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henry", -1 },
                    { -80, new DateTime(1950, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nathan", new DateTime(2004, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jonathan", -1 },
                    { -79, new DateTime(1969, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jason", new DateTime(2005, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan", -1 },
                    { -77, new DateTime(1959, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Harold", new DateTime(2007, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Larry", -1 },
                    { -73, new DateTime(1955, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ralph", new DateTime(2011, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam", -1 },
                    { -68, new DateTime(1961, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lisa", new DateTime(2000, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", -1 },
                    { -67, new DateTime(1974, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Alexis", new DateTime(2010, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anthony", -1 },
                    { -61, new DateTime(1962, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Terry", new DateTime(2010, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", -1 },
                    { -48, new DateTime(1975, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kimberly", new DateTime(2001, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eugene", -1 },
                    { -47, new DateTime(1956, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rachel", new DateTime(2008, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas", -1 },
                    { -45, new DateTime(1953, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ethan", new DateTime(2012, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", -1 },
                    { -38, new DateTime(1972, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joyce", new DateTime(2009, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aaron", -1 },
                    { -35, new DateTime(1960, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "William", new DateTime(2006, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven", -1 },
                    { -33, new DateTime(1978, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Madison", new DateTime(2009, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ralph", -1 },
                    { -27, new DateTime(1978, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Steven", new DateTime(2008, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", -1 },
                    { -26, new DateTime(1957, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Deborah", new DateTime(2006, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brian", -1 },
                    { -22, new DateTime(1967, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Andrew", new DateTime(2013, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jordan", -1 },
                    { -6, new DateTime(1951, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Aaron", new DateTime(2000, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Larry", -1 },
                    { -94, new DateTime(1979, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Scott", new DateTime(2013, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicholas", -1 },
                    { -97, new DateTime(1953, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter", new DateTime(2005, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Randy", -1 },
                    { -10, new DateTime(1968, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vincent", new DateTime(2010, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logan", -2 },
                    { -11, new DateTime(1968, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Beverly", new DateTime(2008, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", -2 },
                    { -21, new DateTime(1965, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sophia", new DateTime(2001, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edward", -3 },
                    { -7, new DateTime(1968, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Helen", new DateTime(2012, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack", -3 },
                    { -3, new DateTime(1965, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Samantha", new DateTime(2000, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nathan", -3 },
                    { -2, new DateTime(1980, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Doris", new DateTime(2003, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edward", -3 },
                    { -1, new DateTime(1961, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Deborah", new DateTime(2007, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", -3 },
                    { -95, new DateTime(1966, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Frank", new DateTime(2006, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ryan", -2 },
                    { -91, new DateTime(1965, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tyler", new DateTime(2003, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", -2 },
                    { -75, new DateTime(1977, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cynthia", new DateTime(2004, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Russell", -2 },
                    { -71, new DateTime(1976, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Patrick", new DateTime(2014, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ralph", -2 },
                    { -69, new DateTime(1980, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Victoria", new DateTime(2005, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donald", -2 },
                    { -81, new DateTime(1961, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eric", new DateTime(2011, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roger", -5 },
                    { -64, new DateTime(1975, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jason", new DateTime(2002, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan", -2 },
                    { -58, new DateTime(1956, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Christian", new DateTime(2011, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brian", -2 },
                    { -57, new DateTime(1966, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "James", new DateTime(2004, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrew", -2 },
                    { -43, new DateTime(1953, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Beverly", new DateTime(2014, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edward", -2 },
                    { -41, new DateTime(1975, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eugene", new DateTime(2002, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", -2 },
                    { -40, new DateTime(1959, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marilyn", new DateTime(2002, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zachary", -2 },
                    { -31, new DateTime(1969, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Judith", new DateTime(2013, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriel", -2 },
                    { -25, new DateTime(1955, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Noah", new DateTime(2002, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brian", -2 },
                    { -23, new DateTime(1972, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lauren", new DateTime(2009, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jacob", -2 },
                    { -19, new DateTime(1966, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cheryl", new DateTime(2009, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", -2 },
                    { -13, new DateTime(1951, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Beverly", new DateTime(2001, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephen", -2 },
                    { -60, new DateTime(1962, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kimberly", new DateTime(2004, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zachary", -2 },
                    { -98, new DateTime(1953, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rose", new DateTime(2007, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven", -5 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Location",
                table: "employee",
                column: "location_id",
                principalTable: "location",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Location",
                table: "employee");

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -100);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -99);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -98);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -97);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -96);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -95);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -94);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -93);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -92);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -91);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -90);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -89);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -88);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -87);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -86);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -85);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -84);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -83);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -82);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -81);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -80);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -79);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -78);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -77);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -76);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -75);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -74);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -73);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -72);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -71);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -70);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -69);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -68);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -67);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -66);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -65);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -64);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -63);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -62);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -61);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -60);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -59);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -58);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -57);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -56);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -55);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -54);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -53);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -52);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -51);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -50);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "location",
                keyColumn: "id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "location",
                keyColumn: "id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "location",
                keyColumn: "id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "location",
                keyColumn: "id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "location",
                keyColumn: "id",
                keyValue: -1);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Location",
                table: "employee",
                column: "location_id",
                principalTable: "location",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
