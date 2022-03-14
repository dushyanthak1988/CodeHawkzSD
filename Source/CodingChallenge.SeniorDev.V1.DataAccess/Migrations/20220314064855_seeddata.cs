using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodingChallenge.SeniorDev.V1.DataAccess.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Birthdate", "CourseID", "Email", "FirstName", "IsDeleted", "LastName", "NICNo", "RegistrationID" },
                values: new object[,]
                {
                    { new Guid("c6e8a7aa-1c42-48fd-b62c-8f4d0396cc7f"), new DateTimeOffset(new DateTime(1988, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), null, "Student1@gmail.com", "Student", false, "1", "882970051V", "ST001" },
                    { new Guid("65bd271f-93e0-45e3-9ec2-6721ff00f901"), new DateTimeOffset(new DateTime(1985, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), null, "Student2@gmail.com", "Student", false, "2", "852970051V", "ST002" },
                    { new Guid("d1d4790d-0fb1-4d5b-8b50-b89dadaf2fb7"), new DateTimeOffset(new DateTime(1983, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), null, "Student3@gmail.com", "Student", false, "3", "832970051V", "ST003" },
                    { new Guid("e6a417dc-9216-4fcc-80d9-a5a37abe175e"), new DateTimeOffset(new DateTime(1984, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), null, "Student4@gmail.com", "Studen4", false, "4", "842970051V", "ST004" },
                    { new Guid("c1da41a0-36b8-49c7-b3ce-b52789b18956"), new DateTimeOffset(new DateTime(1981, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), null, "Student5@gmail.com", "Student", false, "5", "812970051V", "ST005" },
                    { new Guid("ecbf8e0f-71f6-45d7-b63b-c1636b603300"), new DateTimeOffset(new DateTime(1982, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), null, "Student6@gmail.com", "Student", false, "6", "822970051V", "ST001" },
                    { new Guid("9febddb5-fd5a-4d8a-ab02-fc4f76d89df9"), new DateTimeOffset(new DateTime(1980, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), null, "Student7@gmail.com", "Student", false, "7", "802970051V", "ST007" },
                    { new Guid("304792b4-f6ec-4825-aba6-08d405e28361"), new DateTimeOffset(new DateTime(1986, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), null, "Student8@gmail.com", "Student", false, "8", "862970051V", "ST008" },
                    { new Guid("b4d50499-1e54-423d-9326-f2237a6d60bb"), new DateTimeOffset(new DateTime(1989, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), null, "Student9@gmail.com", "Student", false, "9", "892970051V", "ST009" },
                    { new Guid("82bef9b5-bfcc-4a04-aba1-ba714800aa23"), new DateTimeOffset(new DateTime(1987, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), null, "Student10@gmail.com", "Student", false, "10", "872970051V", "ST010" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Birthdate", "Email", "FirstName", "IsDeleted", "LastName" },
                values: new object[,]
                {
                    { new Guid("222f43e0-8d53-454d-959d-4ab82c1e34fc"), new DateTimeOffset(new DateTime(1955, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "Teacher1@gmail.com", "Teacher", false, "1" },
                    { new Guid("512f5e2f-c530-4aed-ba57-2c325e98e257"), new DateTimeOffset(new DateTime(1955, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "Teacher2@gmail.com", "Teacher", false, "2" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "Description", "IsDeleted", "MaximumStudentLimit", "Subject", "TeacherID", "Title" },
                values: new object[] { new Guid("58ec1e1f-ef31-4795-b069-968b37f254f3"), "Course 1 ", false, 20, "Subject 1", new Guid("222f43e0-8d53-454d-959d-4ab82c1e34fc"), "Course 1 " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "Description", "IsDeleted", "MaximumStudentLimit", "Subject", "TeacherID", "Title" },
                values: new object[] { new Guid("b80c48e3-1eb8-4b60-a6a8-4ef07fa14ae9"), "Course 2 ", false, 30, "Subject 2", new Guid("512f5e2f-c530-4aed-ba57-2c325e98e257"), "Course 2 " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: new Guid("58ec1e1f-ef31-4795-b069-968b37f254f3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: new Guid("b80c48e3-1eb8-4b60-a6a8-4ef07fa14ae9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("304792b4-f6ec-4825-aba6-08d405e28361"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("65bd271f-93e0-45e3-9ec2-6721ff00f901"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("82bef9b5-bfcc-4a04-aba1-ba714800aa23"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("9febddb5-fd5a-4d8a-ab02-fc4f76d89df9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("b4d50499-1e54-423d-9326-f2237a6d60bb"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("c1da41a0-36b8-49c7-b3ce-b52789b18956"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("c6e8a7aa-1c42-48fd-b62c-8f4d0396cc7f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("d1d4790d-0fb1-4d5b-8b50-b89dadaf2fb7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("e6a417dc-9216-4fcc-80d9-a5a37abe175e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("ecbf8e0f-71f6-45d7-b63b-c1636b603300"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: new Guid("222f43e0-8d53-454d-959d-4ab82c1e34fc"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: new Guid("512f5e2f-c530-4aed-ba57-2c325e98e257"));
        }
    }
}
