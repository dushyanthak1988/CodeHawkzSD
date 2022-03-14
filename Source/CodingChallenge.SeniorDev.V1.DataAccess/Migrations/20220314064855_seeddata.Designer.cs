﻿// <auto-generated />
using System;
using CodingChallenge.SeniorDev.V1.DataAccess.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodingChallenge.SeniorDev.V1.DataAccess.Migrations
{
    [DbContext(typeof(CodingChallengeDataContext))]
    [Migration("20220314064855_seeddata")]
    partial class seeddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodingChallenge.SeniorDev.V1.Common.Entity.Course", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MaximumStudentLimit")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TeacherID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("TeacherID");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            ID = new Guid("58ec1e1f-ef31-4795-b069-968b37f254f3"),
                            Description = "Course 1 ",
                            IsDeleted = false,
                            MaximumStudentLimit = 20,
                            Subject = "Subject 1",
                            TeacherID = new Guid("222f43e0-8d53-454d-959d-4ab82c1e34fc"),
                            Title = "Course 1 "
                        },
                        new
                        {
                            ID = new Guid("b80c48e3-1eb8-4b60-a6a8-4ef07fa14ae9"),
                            Description = "Course 2 ",
                            IsDeleted = false,
                            MaximumStudentLimit = 30,
                            Subject = "Subject 2",
                            TeacherID = new Guid("512f5e2f-c530-4aed-ba57-2c325e98e257"),
                            Title = "Course 2 "
                        });
                });

            modelBuilder.Entity("CodingChallenge.SeniorDev.V1.Common.Entity.Student", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("Birthdate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("CourseID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NICNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            ID = new Guid("c6e8a7aa-1c42-48fd-b62c-8f4d0396cc7f"),
                            Birthdate = new DateTimeOffset(new DateTime(1988, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)),
                            Email = "Student1@gmail.com",
                            FirstName = "Student",
                            IsDeleted = false,
                            LastName = "1",
                            NICNo = "882970051V",
                            RegistrationID = "ST001"
                        },
                        new
                        {
                            ID = new Guid("65bd271f-93e0-45e3-9ec2-6721ff00f901"),
                            Birthdate = new DateTimeOffset(new DateTime(1985, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)),
                            Email = "Student2@gmail.com",
                            FirstName = "Student",
                            IsDeleted = false,
                            LastName = "2",
                            NICNo = "852970051V",
                            RegistrationID = "ST002"
                        },
                        new
                        {
                            ID = new Guid("d1d4790d-0fb1-4d5b-8b50-b89dadaf2fb7"),
                            Birthdate = new DateTimeOffset(new DateTime(1983, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)),
                            Email = "Student3@gmail.com",
                            FirstName = "Student",
                            IsDeleted = false,
                            LastName = "3",
                            NICNo = "832970051V",
                            RegistrationID = "ST003"
                        },
                        new
                        {
                            ID = new Guid("e6a417dc-9216-4fcc-80d9-a5a37abe175e"),
                            Birthdate = new DateTimeOffset(new DateTime(1984, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)),
                            Email = "Student4@gmail.com",
                            FirstName = "Studen4",
                            IsDeleted = false,
                            LastName = "4",
                            NICNo = "842970051V",
                            RegistrationID = "ST004"
                        },
                        new
                        {
                            ID = new Guid("c1da41a0-36b8-49c7-b3ce-b52789b18956"),
                            Birthdate = new DateTimeOffset(new DateTime(1981, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)),
                            Email = "Student5@gmail.com",
                            FirstName = "Student",
                            IsDeleted = false,
                            LastName = "5",
                            NICNo = "812970051V",
                            RegistrationID = "ST005"
                        },
                        new
                        {
                            ID = new Guid("ecbf8e0f-71f6-45d7-b63b-c1636b603300"),
                            Birthdate = new DateTimeOffset(new DateTime(1982, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)),
                            Email = "Student6@gmail.com",
                            FirstName = "Student",
                            IsDeleted = false,
                            LastName = "6",
                            NICNo = "822970051V",
                            RegistrationID = "ST001"
                        },
                        new
                        {
                            ID = new Guid("9febddb5-fd5a-4d8a-ab02-fc4f76d89df9"),
                            Birthdate = new DateTimeOffset(new DateTime(1980, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)),
                            Email = "Student7@gmail.com",
                            FirstName = "Student",
                            IsDeleted = false,
                            LastName = "7",
                            NICNo = "802970051V",
                            RegistrationID = "ST007"
                        },
                        new
                        {
                            ID = new Guid("304792b4-f6ec-4825-aba6-08d405e28361"),
                            Birthdate = new DateTimeOffset(new DateTime(1986, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)),
                            Email = "Student8@gmail.com",
                            FirstName = "Student",
                            IsDeleted = false,
                            LastName = "8",
                            NICNo = "862970051V",
                            RegistrationID = "ST008"
                        },
                        new
                        {
                            ID = new Guid("b4d50499-1e54-423d-9326-f2237a6d60bb"),
                            Birthdate = new DateTimeOffset(new DateTime(1989, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)),
                            Email = "Student9@gmail.com",
                            FirstName = "Student",
                            IsDeleted = false,
                            LastName = "9",
                            NICNo = "892970051V",
                            RegistrationID = "ST009"
                        },
                        new
                        {
                            ID = new Guid("82bef9b5-bfcc-4a04-aba1-ba714800aa23"),
                            Birthdate = new DateTimeOffset(new DateTime(1987, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)),
                            Email = "Student10@gmail.com",
                            FirstName = "Student",
                            IsDeleted = false,
                            LastName = "10",
                            NICNo = "872970051V",
                            RegistrationID = "ST010"
                        });
                });

            modelBuilder.Entity("CodingChallenge.SeniorDev.V1.Common.Entity.Teacher", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("Birthdate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            ID = new Guid("222f43e0-8d53-454d-959d-4ab82c1e34fc"),
                            Birthdate = new DateTimeOffset(new DateTime(1955, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)),
                            Email = "Teacher1@gmail.com",
                            FirstName = "Teacher",
                            IsDeleted = false,
                            LastName = "1"
                        },
                        new
                        {
                            ID = new Guid("512f5e2f-c530-4aed-ba57-2c325e98e257"),
                            Birthdate = new DateTimeOffset(new DateTime(1955, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)),
                            Email = "Teacher2@gmail.com",
                            FirstName = "Teacher",
                            IsDeleted = false,
                            LastName = "2"
                        });
                });

            modelBuilder.Entity("CodingChallenge.SeniorDev.V1.Common.Entity.Course", b =>
                {
                    b.HasOne("CodingChallenge.SeniorDev.V1.Common.Entity.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("CodingChallenge.SeniorDev.V1.Common.Entity.Student", b =>
                {
                    b.HasOne("CodingChallenge.SeniorDev.V1.Common.Entity.Course", null)
                        .WithMany("Students")
                        .HasForeignKey("CourseID");
                });

            modelBuilder.Entity("CodingChallenge.SeniorDev.V1.Common.Entity.Course", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}