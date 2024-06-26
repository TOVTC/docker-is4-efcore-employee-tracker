﻿// <auto-generated />
using System;
using EmployeeTracker;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeTracker.Migrations
{
    [DbContext(typeof(EmployeeTrackerDbContext))]
    partial class EmployeeTrackerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeTracker.Models.AboutUs", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("About");

                    b.HasData(
                        new
                        {
                            Id = new Guid("107d6eb3-1f61-4a1a-aba8-039454db136b"),
                            Description = "At our company, imagination takes form and creativity knows no bounds. We are a dynamic and innovative creative agency committed to transforming visions into vibrant, tangible realities. We are here to infuse your brand, project, or campaign with the kind of creativity that leaves a lasting impression. Our diverse team of visionaries, artists, strategists, and storytellers is united by a common goal: to craft exceptional experiences and narratives that captivate, inspire, and engage.\r\n\r\nWhether you're a startup seeking an identity or an established brand looking to refresh, we're here to turn your aspirations into a vibrant mosaic of success. Join us, and together, we'll bring your vision to life, one piece at a time. Your vision is our mission, and we're excited to explore the limitless possibilities with you."
                        });
                });

            modelBuilder.Entity("EmployeeTracker.Models.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("945a5bfa-012a-4047-b1e4-02592a3156bd"),
                            DepartmentName = "Administration"
                        },
                        new
                        {
                            Id = new Guid("107d6eb3-1f61-4a1a-aba8-039454db136b"),
                            DepartmentName = "Executive"
                        },
                        new
                        {
                            Id = new Guid("ac532fdc-2d1b-426c-9b1e-043e7727eeae"),
                            DepartmentName = "Finance"
                        },
                        new
                        {
                            Id = new Guid("75209929-7231-432a-8fda-04a84d4a59dd"),
                            DepartmentName = "Human Resources"
                        },
                        new
                        {
                            Id = new Guid("89e84583-a348-42bb-bca8-09a118a32521"),
                            DepartmentName = "Info Tech"
                        },
                        new
                        {
                            Id = new Guid("a80a1414-a130-4785-939f-09e7df7e00c2"),
                            DepartmentName = "Marketing"
                        },
                        new
                        {
                            Id = new Guid("00e5b334-c661-4357-8dcf-0d1d0985db18"),
                            DepartmentName = "Operations"
                        },
                        new
                        {
                            Id = new Guid("7a815ecd-7ab8-4848-af2e-114f9d38a719"),
                            DepartmentName = "Public Relations"
                        });
                });

            modelBuilder.Entity("EmployeeTracker.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ManagerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.HasIndex("RoleId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ae401688-5e31-4356-9903-6be404a0ec04"),
                            FirstName = "Steven",
                            LastName = "King",
                            ManagerId = new Guid("ae401688-5e31-4356-9903-6be404a0ec04"),
                            RoleId = new Guid("cf744e92-3fe0-440d-acaf-140607d33b8e")
                        },
                        new
                        {
                            Id = new Guid("55a952d6-83e9-4247-b8f0-6c793f15f004"),
                            FirstName = "Lex",
                            LastName = "De Haan",
                            ManagerId = new Guid("ae401688-5e31-4356-9903-6be404a0ec04"),
                            RoleId = new Guid("0126c299-2050-477d-99da-16c471a0dbe0")
                        },
                        new
                        {
                            Id = new Guid("c91a1b1a-cafa-4525-8fda-6d2e8dfda8de"),
                            FirstName = "Neena",
                            LastName = "Kochhar",
                            ManagerId = new Guid("ae401688-5e31-4356-9903-6be404a0ec04"),
                            RoleId = new Guid("0126c299-2050-477d-99da-16c471a0dbe0")
                        },
                        new
                        {
                            Id = new Guid("9b28ad17-684a-4bec-a751-773bdab16283"),
                            FirstName = "Michael",
                            LastName = "Hartstein",
                            ManagerId = new Guid("ae401688-5e31-4356-9903-6be404a0ec04"),
                            RoleId = new Guid("f30f67c8-8d16-4a2f-9103-1b54a3f41c35")
                        },
                        new
                        {
                            Id = new Guid("3dacacf6-c451-41d9-9d86-79c24fa54a5d"),
                            FirstName = "Alexander",
                            LastName = "Hunold",
                            ManagerId = new Guid("55a952d6-83e9-4247-b8f0-6c793f15f004"),
                            RoleId = new Guid("0f9a68a3-7070-4644-aa22-1cee71e53457")
                        },
                        new
                        {
                            Id = new Guid("01078c07-691b-4fcd-800c-7b03467db41f"),
                            FirstName = "Nancy",
                            LastName = "Greenberg",
                            ManagerId = new Guid("c91a1b1a-cafa-4525-8fda-6d2e8dfda8de"),
                            RoleId = new Guid("b2392061-ec9f-4435-8d08-25f0e0d62a72")
                        },
                        new
                        {
                            Id = new Guid("bb20c8ba-86ac-4bc1-a0b6-7c22bd281834"),
                            FirstName = "Matthew",
                            LastName = "Weiss",
                            ManagerId = new Guid("ae401688-5e31-4356-9903-6be404a0ec04"),
                            RoleId = new Guid("cb5b26bd-bafd-4998-aac0-2cb019cf54b8")
                        },
                        new
                        {
                            Id = new Guid("087a1c96-de0f-4330-b21c-82c9512f91d5"),
                            FirstName = "Adam",
                            LastName = "Fripp",
                            ManagerId = new Guid("ae401688-5e31-4356-9903-6be404a0ec04"),
                            RoleId = new Guid("cb5b26bd-bafd-4998-aac0-2cb019cf54b8")
                        },
                        new
                        {
                            Id = new Guid("3b527114-8eed-4bee-a1a1-83699664a9ce"),
                            FirstName = "Payam",
                            LastName = "Kaufling",
                            ManagerId = new Guid("ae401688-5e31-4356-9903-6be404a0ec04"),
                            RoleId = new Guid("cb5b26bd-bafd-4998-aac0-2cb019cf54b8")
                        },
                        new
                        {
                            Id = new Guid("08769c56-14b4-4574-bb55-85c0d1b5aebc"),
                            FirstName = "Shanta",
                            LastName = "Vollman",
                            ManagerId = new Guid("ae401688-5e31-4356-9903-6be404a0ec04"),
                            RoleId = new Guid("cb5b26bd-bafd-4998-aac0-2cb019cf54b8")
                        },
                        new
                        {
                            Id = new Guid("45ff097d-4b4c-4f47-ad0e-892878bb5b57"),
                            FirstName = "Jennifer",
                            LastName = "Whalen",
                            ManagerId = new Guid("c91a1b1a-cafa-4525-8fda-6d2e8dfda8de"),
                            RoleId = new Guid("6a410106-a382-48a1-9442-2d9ed6bbd905")
                        },
                        new
                        {
                            Id = new Guid("ed2caf61-43c9-4b76-8c0c-8a2d93648f87"),
                            FirstName = "Susan",
                            LastName = "Mavris",
                            ManagerId = new Guid("c91a1b1a-cafa-4525-8fda-6d2e8dfda8de"),
                            RoleId = new Guid("27db6ab3-0174-4312-bbba-31a0c37fa29f")
                        },
                        new
                        {
                            Id = new Guid("182f8815-0daf-469d-8bb4-9476deb6bba6"),
                            FirstName = "Hermann",
                            LastName = "Baer",
                            ManagerId = new Guid("c91a1b1a-cafa-4525-8fda-6d2e8dfda8de"),
                            RoleId = new Guid("ba96796d-022c-4c80-bbd7-3c0bbbccc2cb")
                        },
                        new
                        {
                            Id = new Guid("7ae8f349-43dd-478f-952f-9dde68415b1f"),
                            FirstName = "Pat",
                            LastName = "Fay",
                            ManagerId = new Guid("9b28ad17-684a-4bec-a751-773bdab16283"),
                            RoleId = new Guid("bdb8cb52-263c-4847-af66-4a6ee96fa77e")
                        },
                        new
                        {
                            Id = new Guid("be6b5e30-7fd2-4a19-a3c6-a25ea164a317"),
                            FirstName = "Bruce",
                            LastName = "Ernst",
                            ManagerId = new Guid("3dacacf6-c451-41d9-9d86-79c24fa54a5d"),
                            RoleId = new Guid("a930a5cf-2d6b-4d13-a5ba-4aece0e48cf8")
                        },
                        new
                        {
                            Id = new Guid("79c27692-24aa-4ae9-b21c-a78aaf1f3b1d"),
                            FirstName = "David",
                            LastName = "Austin",
                            ManagerId = new Guid("3dacacf6-c451-41d9-9d86-79c24fa54a5d"),
                            RoleId = new Guid("a930a5cf-2d6b-4d13-a5ba-4aece0e48cf8")
                        },
                        new
                        {
                            Id = new Guid("7ac7c118-2e59-4833-8fb1-ac76428b8368"),
                            FirstName = "Valli",
                            LastName = "Pataballa",
                            ManagerId = new Guid("3dacacf6-c451-41d9-9d86-79c24fa54a5d"),
                            RoleId = new Guid("a930a5cf-2d6b-4d13-a5ba-4aece0e48cf8")
                        },
                        new
                        {
                            Id = new Guid("bbc5c711-a0e0-45a4-8a6b-aee708297e46"),
                            FirstName = "Diana",
                            LastName = "Lorentz",
                            ManagerId = new Guid("3dacacf6-c451-41d9-9d86-79c24fa54a5d"),
                            RoleId = new Guid("a930a5cf-2d6b-4d13-a5ba-4aece0e48cf8")
                        },
                        new
                        {
                            Id = new Guid("8c31e42f-bdb3-49d0-b912-b1525ba2409b"),
                            FirstName = "Daniel",
                            LastName = "Faviet",
                            ManagerId = new Guid("01078c07-691b-4fcd-800c-7b03467db41f"),
                            RoleId = new Guid("dd4b442a-0e34-4a33-8fb2-5165bdcc6f2c")
                        },
                        new
                        {
                            Id = new Guid("410e640d-40fd-4738-b60b-b5c01714d1d6"),
                            FirstName = "John",
                            LastName = "Chen",
                            ManagerId = new Guid("01078c07-691b-4fcd-800c-7b03467db41f"),
                            RoleId = new Guid("dd4b442a-0e34-4a33-8fb2-5165bdcc6f2c")
                        },
                        new
                        {
                            Id = new Guid("da17fcb1-5014-4c74-8ab7-bb42055e290b"),
                            FirstName = "Ismael",
                            LastName = "Sciarra",
                            ManagerId = new Guid("01078c07-691b-4fcd-800c-7b03467db41f"),
                            RoleId = new Guid("dd4b442a-0e34-4a33-8fb2-5165bdcc6f2c")
                        },
                        new
                        {
                            Id = new Guid("2965aaae-07a5-4501-8a76-bd89cedcc9de"),
                            FirstName = "Jose Manuel",
                            LastName = "Urman",
                            ManagerId = new Guid("01078c07-691b-4fcd-800c-7b03467db41f"),
                            RoleId = new Guid("dd4b442a-0e34-4a33-8fb2-5165bdcc6f2c")
                        },
                        new
                        {
                            Id = new Guid("5c0857a0-6dc3-400c-8e93-c4e96ce9f7fa"),
                            FirstName = "Luis",
                            LastName = "Popp",
                            ManagerId = new Guid("01078c07-691b-4fcd-800c-7b03467db41f"),
                            RoleId = new Guid("dd4b442a-0e34-4a33-8fb2-5165bdcc6f2c")
                        },
                        new
                        {
                            Id = new Guid("616dc526-8d1d-41e4-be37-c80ad0a37bb6"),
                            FirstName = "Julia",
                            LastName = "Nayer",
                            ManagerId = new Guid("bb20c8ba-86ac-4bc1-a0b6-7c22bd281834"),
                            RoleId = new Guid("59ffef4e-0b57-485e-a01e-56f227882a32")
                        },
                        new
                        {
                            Id = new Guid("b5d79dd3-ecce-458f-8b5f-c8d377f21e0d"),
                            FirstName = "Irene",
                            LastName = "Mikkilineni",
                            ManagerId = new Guid("bb20c8ba-86ac-4bc1-a0b6-7c22bd281834"),
                            RoleId = new Guid("59ffef4e-0b57-485e-a01e-56f227882a32")
                        },
                        new
                        {
                            Id = new Guid("02591430-6655-472f-8b4d-ccad9725990e"),
                            FirstName = "James",
                            LastName = "Landry",
                            ManagerId = new Guid("bb20c8ba-86ac-4bc1-a0b6-7c22bd281834"),
                            RoleId = new Guid("59ffef4e-0b57-485e-a01e-56f227882a32")
                        },
                        new
                        {
                            Id = new Guid("be21c122-ce50-487e-93e7-cfaaeb2992ab"),
                            FirstName = "Steven",
                            LastName = "Markle",
                            ManagerId = new Guid("bb20c8ba-86ac-4bc1-a0b6-7c22bd281834"),
                            RoleId = new Guid("59ffef4e-0b57-485e-a01e-56f227882a32")
                        },
                        new
                        {
                            Id = new Guid("82c71285-6896-4f33-82c6-cfcebe26c0c7"),
                            FirstName = "Laura",
                            LastName = "Bissot",
                            ManagerId = new Guid("087a1c96-de0f-4330-b21c-82c9512f91d5"),
                            RoleId = new Guid("814dffc8-aa86-45ac-bafb-5b1443309b5f")
                        },
                        new
                        {
                            Id = new Guid("37e7409c-e3ff-4a37-8b03-d44e4ef32250"),
                            FirstName = "Mozhe",
                            LastName = "Atkinson",
                            ManagerId = new Guid("087a1c96-de0f-4330-b21c-82c9512f91d5"),
                            RoleId = new Guid("814dffc8-aa86-45ac-bafb-5b1443309b5f")
                        },
                        new
                        {
                            Id = new Guid("2ee10769-799b-444d-a595-d55089186ca9"),
                            FirstName = "James",
                            LastName = "Marlow",
                            ManagerId = new Guid("087a1c96-de0f-4330-b21c-82c9512f91d5"),
                            RoleId = new Guid("814dffc8-aa86-45ac-bafb-5b1443309b5f")
                        },
                        new
                        {
                            Id = new Guid("c0c1351a-76c2-438b-a318-db9a57d739fe"),
                            FirstName = "TJ",
                            LastName = "Olson",
                            ManagerId = new Guid("087a1c96-de0f-4330-b21c-82c9512f91d5"),
                            RoleId = new Guid("814dffc8-aa86-45ac-bafb-5b1443309b5f")
                        },
                        new
                        {
                            Id = new Guid("bf4694d8-fae4-4499-b465-df27b81668a8"),
                            FirstName = "Jason",
                            LastName = "Mallin",
                            ManagerId = new Guid("3b527114-8eed-4bee-a1a1-83699664a9ce"),
                            RoleId = new Guid("c5b68f11-04d6-4a4d-82ed-64ed19e25c57")
                        },
                        new
                        {
                            Id = new Guid("0662b018-3760-4b86-88c2-e7568ef72958"),
                            FirstName = "Michael",
                            LastName = "Rogers",
                            ManagerId = new Guid("3b527114-8eed-4bee-a1a1-83699664a9ce"),
                            RoleId = new Guid("c5b68f11-04d6-4a4d-82ed-64ed19e25c57")
                        },
                        new
                        {
                            Id = new Guid("01622712-c0bd-4c42-a91e-ea149e4de77b"),
                            FirstName = "Ki",
                            LastName = "Gee",
                            ManagerId = new Guid("3b527114-8eed-4bee-a1a1-83699664a9ce"),
                            RoleId = new Guid("c5b68f11-04d6-4a4d-82ed-64ed19e25c57")
                        },
                        new
                        {
                            Id = new Guid("0b51241e-0f5d-41a9-9a28-ec4d0fd03b39"),
                            FirstName = "Hazel",
                            LastName = "Philtanker",
                            ManagerId = new Guid("3b527114-8eed-4bee-a1a1-83699664a9ce"),
                            RoleId = new Guid("c5b68f11-04d6-4a4d-82ed-64ed19e25c57")
                        },
                        new
                        {
                            Id = new Guid("c3d60888-da8b-481e-9bf5-eef37f154efd"),
                            FirstName = "Renske",
                            LastName = "Ladwig",
                            ManagerId = new Guid("08769c56-14b4-4574-bb55-85c0d1b5aebc"),
                            RoleId = new Guid("c5b68f11-04d6-4a4d-82ed-64ed19e25c57")
                        },
                        new
                        {
                            Id = new Guid("3262db26-8595-4297-9291-f3df62757ad4"),
                            FirstName = "Stephen",
                            LastName = "Stiles",
                            ManagerId = new Guid("08769c56-14b4-4574-bb55-85c0d1b5aebc"),
                            RoleId = new Guid("c5b68f11-04d6-4a4d-82ed-64ed19e25c57")
                        },
                        new
                        {
                            Id = new Guid("3f4fe214-be81-41f7-8b7b-f9d78d2f1f26"),
                            FirstName = "John",
                            LastName = "Seo",
                            ManagerId = new Guid("08769c56-14b4-4574-bb55-85c0d1b5aebc"),
                            RoleId = new Guid("c5b68f11-04d6-4a4d-82ed-64ed19e25c57")
                        },
                        new
                        {
                            Id = new Guid("b26af6b7-1763-49a0-90ae-ffee423b9284"),
                            FirstName = "Joshua",
                            LastName = "Patel",
                            ManagerId = new Guid("08769c56-14b4-4574-bb55-85c0d1b5aebc"),
                            RoleId = new Guid("c5b68f11-04d6-4a4d-82ed-64ed19e25c57")
                        });
                });

            modelBuilder.Entity("EmployeeTracker.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DeptId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsManagement")
                        .HasColumnType("bit");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cf744e92-3fe0-440d-acaf-140607d33b8e"),
                            DeptId = new Guid("107d6eb3-1f61-4a1a-aba8-039454db136b"),
                            IsManagement = true,
                            JobTitle = "President",
                            Salary = 70000
                        },
                        new
                        {
                            Id = new Guid("0126c299-2050-477d-99da-16c471a0dbe0"),
                            DeptId = new Guid("107d6eb3-1f61-4a1a-aba8-039454db136b"),
                            IsManagement = true,
                            JobTitle = "Vice President",
                            Salary = 60000
                        },
                        new
                        {
                            Id = new Guid("f30f67c8-8d16-4a2f-9103-1b54a3f41c35"),
                            DeptId = new Guid("a80a1414-a130-4785-939f-09e7df7e00c2"),
                            IsManagement = true,
                            JobTitle = "Marketing Manager",
                            Salary = 50000
                        },
                        new
                        {
                            Id = new Guid("0f9a68a3-7070-4644-aa22-1cee71e53457"),
                            DeptId = new Guid("89e84583-a348-42bb-bca8-09a118a32521"),
                            IsManagement = true,
                            JobTitle = "IT Manager",
                            Salary = 55000
                        },
                        new
                        {
                            Id = new Guid("b2392061-ec9f-4435-8d08-25f0e0d62a72"),
                            DeptId = new Guid("ac532fdc-2d1b-426c-9b1e-043e7727eeae"),
                            IsManagement = true,
                            JobTitle = "Finance Manager",
                            Salary = 50000
                        },
                        new
                        {
                            Id = new Guid("cb5b26bd-bafd-4998-aac0-2cb019cf54b8"),
                            DeptId = new Guid("00e5b334-c661-4357-8dcf-0d1d0985db18"),
                            IsManagement = true,
                            JobTitle = "Operations Manager",
                            Salary = 50000
                        },
                        new
                        {
                            Id = new Guid("6a410106-a382-48a1-9442-2d9ed6bbd905"),
                            DeptId = new Guid("945a5bfa-012a-4047-b1e4-02592a3156bd"),
                            IsManagement = false,
                            JobTitle = "Admin Assistant",
                            Salary = 35000
                        },
                        new
                        {
                            Id = new Guid("27db6ab3-0174-4312-bbba-31a0c37fa29f"),
                            DeptId = new Guid("75209929-7231-432a-8fda-04a84d4a59dd"),
                            IsManagement = false,
                            JobTitle = "HR Rep",
                            Salary = 35000
                        },
                        new
                        {
                            Id = new Guid("ba96796d-022c-4c80-bbd7-3c0bbbccc2cb"),
                            DeptId = new Guid("7a815ecd-7ab8-4848-af2e-114f9d38a719"),
                            IsManagement = false,
                            JobTitle = "PR Rep",
                            Salary = 35000
                        },
                        new
                        {
                            Id = new Guid("bdb8cb52-263c-4847-af66-4a6ee96fa77e"),
                            DeptId = new Guid("a80a1414-a130-4785-939f-09e7df7e00c2"),
                            IsManagement = false,
                            JobTitle = "Marketing Rep",
                            Salary = 35000
                        },
                        new
                        {
                            Id = new Guid("a930a5cf-2d6b-4d13-a5ba-4aece0e48cf8"),
                            DeptId = new Guid("89e84583-a348-42bb-bca8-09a118a32521"),
                            IsManagement = false,
                            JobTitle = "Developer",
                            Salary = 40000
                        },
                        new
                        {
                            Id = new Guid("dd4b442a-0e34-4a33-8fb2-5165bdcc6f2c"),
                            DeptId = new Guid("ac532fdc-2d1b-426c-9b1e-043e7727eeae"),
                            IsManagement = false,
                            JobTitle = "Accountant",
                            Salary = 35000
                        },
                        new
                        {
                            Id = new Guid("59ffef4e-0b57-485e-a01e-56f227882a32"),
                            DeptId = new Guid("00e5b334-c661-4357-8dcf-0d1d0985db18"),
                            IsManagement = false,
                            JobTitle = "Data Clerk",
                            Salary = 31000
                        },
                        new
                        {
                            Id = new Guid("814dffc8-aa86-45ac-bafb-5b1443309b5f"),
                            DeptId = new Guid("00e5b334-c661-4357-8dcf-0d1d0985db18"),
                            IsManagement = false,
                            JobTitle = "Customer Service",
                            Salary = 31000
                        },
                        new
                        {
                            Id = new Guid("c5b68f11-04d6-4a4d-82ed-64ed19e25c57"),
                            DeptId = new Guid("00e5b334-c661-4357-8dcf-0d1d0985db18"),
                            IsManagement = false,
                            JobTitle = "Operations Attendant",
                            Salary = 31000
                        });
                });

            modelBuilder.Entity("EmployeeTracker.Models.Employee", b =>
                {
                    b.HasOne("EmployeeTracker.Models.Employee", "Manager")
                        .WithMany("Subordinates")
                        .HasForeignKey("ManagerId");

                    b.HasOne("EmployeeTracker.Models.Role", "Role")
                        .WithMany("Employees")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("EmployeeTracker.Models.Role", b =>
                {
                    b.HasOne("EmployeeTracker.Models.Department", "Department")
                        .WithMany("Roles")
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EmployeeTracker.Models.Department", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("EmployeeTracker.Models.Employee", b =>
                {
                    b.Navigation("Subordinates");
                });

            modelBuilder.Entity("EmployeeTracker.Models.Role", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
