﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using CourseManagementSystem.Models.Database;

namespace CourseManagementSystem.Migrations
{
    [DbContext(typeof(myDatabase))]
    [Migration("20200709010917_AddRequiredDataTables")]
    partial class AddRequiredDataTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CourseManagementSystem.Models.Database.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CourseManagementSystem.Models.DomainModels.Assessment", b =>
                {
                    b.Property<string>("assessmentName")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("assessmentMarks");

                    b.Property<string>("assessmentMaxMarks");

                    b.Property<string>("courseid");

                    b.Property<string>("teacherid");

                    b.HasKey("assessmentName");

                    b.ToTable("Assessments");
                });

            modelBuilder.Entity("CourseManagementSystem.Models.DomainModels.Course", b =>
                {
                    b.Property<string>("courseid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("courseFaculty");

                    b.Property<string>("courseName");

                    b.HasKey("courseid");

                    b.ToTable("Courses");

                    b.HasData(
                        new { courseid = "CIS1000", courseFaculty = "T2001", courseName = "C-Sharp" },
                        new { courseid = "CIS1001", courseFaculty = "T2002", courseName = "Java" },
                        new { courseid = "CIS1002", courseFaculty = "T2003", courseName = "Android" },
                        new { courseid = "CIS1003", courseFaculty = "T2002", courseName = "Ios" },
                        new { courseid = "CIS1004", courseFaculty = "T2003", courseName = "Operating Sysytems" }
                    );
                });

            modelBuilder.Entity("CourseManagementSystem.Models.DomainModels.Student", b =>
                {
                    b.Property<string>("studentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("courseids1");

                    b.Property<string>("courseids2");

                    b.Property<string>("courseids3");

                    b.Property<string>("emailaddr");

                    b.Property<string>("major");

                    b.Property<string>("studentname");

                    b.HasKey("studentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CourseManagementSystem.Models.DomainModels.StudentAssignmentData", b =>
                {
                    b.Property<string>("stuAssessId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("assignmentID");

                    b.Property<string>("assignmentMarks");

                    b.Property<string>("courseid");

                    b.Property<string>("studentID");

                    b.HasKey("stuAssessId");

                    b.ToTable("StudentAssignmentTable");
                });

            modelBuilder.Entity("CourseManagementSystem.Models.DomainModels.StudentCourseData", b =>
                {
                    b.Property<string>("stucourseID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("courseGrade");

                    b.Property<string>("courseID");

                    b.Property<string>("courseStatus");

                    b.Property<string>("studentID");

                    b.HasKey("stucourseID");

                    b.ToTable("StudentCoursesTable");
                });

            modelBuilder.Entity("CourseManagementSystem.Models.DomainModels.Teacher", b =>
                {
                    b.Property<string>("teacherid")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(9);

                    b.Property<string>("courseid");

                    b.Property<string>("teachername");

                    b.HasKey("teacherid");

                    b.HasIndex("courseid");

                    b.ToTable("Teachers");

                    b.HasData(
                        new { teacherid = "T2001", teachername = "Deepu" },
                        new { teacherid = "T2002", teachername = "Krishna" },
                        new { teacherid = "T2003", teachername = "Radha" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CourseManagementSystem.Models.DomainModels.Teacher", b =>
                {
                    b.HasOne("CourseManagementSystem.Models.DomainModels.Course", "CourseofTeacher")
                        .WithMany()
                        .HasForeignKey("courseid");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CourseManagementSystem.Models.Database.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CourseManagementSystem.Models.Database.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CourseManagementSystem.Models.Database.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CourseManagementSystem.Models.Database.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
