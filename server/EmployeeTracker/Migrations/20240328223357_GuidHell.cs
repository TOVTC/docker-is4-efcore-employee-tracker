using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeTracker.Migrations
{
    public partial class GuidHell : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("107d6eb3-1f61-4a1a-aba8-039454db136b"), "At our company, imagination takes form and creativity knows no bounds. We are a dynamic and innovative creative agency committed to transforming visions into vibrant, tangible realities. We are here to infuse your brand, project, or campaign with the kind of creativity that leaves a lasting impression. Our diverse team of visionaries, artists, strategists, and storytellers is united by a common goal: to craft exceptional experiences and narratives that captivate, inspire, and engage.\r\n\r\nWhether you're a startup seeking an identity or an established brand looking to refresh, we're here to turn your aspirations into a vibrant mosaic of success. Join us, and together, we'll bring your vision to life, one piece at a time. Your vision is our mission, and we're excited to explore the limitless possibilities with you." });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepartmentName" },
                values: new object[,]
                {
                    { new Guid("00e5b334-c661-4357-8dcf-0d1d0985db18"), "Operations" },
                    { new Guid("107d6eb3-1f61-4a1a-aba8-039454db136b"), "Executive" },
                    { new Guid("75209929-7231-432a-8fda-04a84d4a59dd"), "Human Resources" },
                    { new Guid("7a815ecd-7ab8-4848-af2e-114f9d38a719"), "Public Relations" },
                    { new Guid("89e84583-a348-42bb-bca8-09a118a32521"), "Info Tech" },
                    { new Guid("945a5bfa-012a-4047-b1e4-02592a3156bd"), "Administration" },
                    { new Guid("a80a1414-a130-4785-939f-09e7df7e00c2"), "Marketing" },
                    { new Guid("ac532fdc-2d1b-426c-9b1e-043e7727eeae"), "Finance" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "DeptId", "IsManagement", "JobTitle", "Salary" },
                values: new object[,]
                {
                    { new Guid("0126c299-2050-477d-99da-16c471a0dbe0"), new Guid("107d6eb3-1f61-4a1a-aba8-039454db136b"), true, "Vice President", 60000 },
                    { new Guid("0f9a68a3-7070-4644-aa22-1cee71e53457"), new Guid("89e84583-a348-42bb-bca8-09a118a32521"), true, "IT Manager", 55000 },
                    { new Guid("27db6ab3-0174-4312-bbba-31a0c37fa29f"), new Guid("75209929-7231-432a-8fda-04a84d4a59dd"), false, "HR Rep", 35000 },
                    { new Guid("59ffef4e-0b57-485e-a01e-56f227882a32"), new Guid("00e5b334-c661-4357-8dcf-0d1d0985db18"), false, "Data Clerk", 31000 },
                    { new Guid("6a410106-a382-48a1-9442-2d9ed6bbd905"), new Guid("945a5bfa-012a-4047-b1e4-02592a3156bd"), false, "Admin Assistant", 35000 },
                    { new Guid("814dffc8-aa86-45ac-bafb-5b1443309b5f"), new Guid("00e5b334-c661-4357-8dcf-0d1d0985db18"), false, "Customer Service", 31000 },
                    { new Guid("a930a5cf-2d6b-4d13-a5ba-4aece0e48cf8"), new Guid("89e84583-a348-42bb-bca8-09a118a32521"), false, "Developer", 40000 },
                    { new Guid("b2392061-ec9f-4435-8d08-25f0e0d62a72"), new Guid("ac532fdc-2d1b-426c-9b1e-043e7727eeae"), true, "Finance Manager", 50000 },
                    { new Guid("ba96796d-022c-4c80-bbd7-3c0bbbccc2cb"), new Guid("7a815ecd-7ab8-4848-af2e-114f9d38a719"), false, "PR Rep", 35000 },
                    { new Guid("bdb8cb52-263c-4847-af66-4a6ee96fa77e"), new Guid("a80a1414-a130-4785-939f-09e7df7e00c2"), false, "Marketing Rep", 35000 },
                    { new Guid("c5b68f11-04d6-4a4d-82ed-64ed19e25c57"), new Guid("00e5b334-c661-4357-8dcf-0d1d0985db18"), false, "Operations Attendant", 31000 },
                    { new Guid("cb5b26bd-bafd-4998-aac0-2cb019cf54b8"), new Guid("00e5b334-c661-4357-8dcf-0d1d0985db18"), true, "Operations Manager", 50000 },
                    { new Guid("cf744e92-3fe0-440d-acaf-140607d33b8e"), new Guid("107d6eb3-1f61-4a1a-aba8-039454db136b"), true, "President", 70000 },
                    { new Guid("dd4b442a-0e34-4a33-8fb2-5165bdcc6f2c"), new Guid("ac532fdc-2d1b-426c-9b1e-043e7727eeae"), false, "Accountant", 35000 },
                    { new Guid("f30f67c8-8d16-4a2f-9103-1b54a3f41c35"), new Guid("a80a1414-a130-4785-939f-09e7df7e00c2"), true, "Marketing Manager", 50000 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "LastName", "ManagerId", "RoleId" },
                values: new object[] { new Guid("ae401688-5e31-4356-9903-6be404a0ec04"), "Steven", "King", new Guid("ae401688-5e31-4356-9903-6be404a0ec04"), new Guid("cf744e92-3fe0-440d-acaf-140607d33b8e") });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "LastName", "ManagerId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("08769c56-14b4-4574-bb55-85c0d1b5aebc"), "Shanta", "Vollman", new Guid("ae401688-5e31-4356-9903-6be404a0ec04"), new Guid("cb5b26bd-bafd-4998-aac0-2cb019cf54b8") },
                    { new Guid("087a1c96-de0f-4330-b21c-82c9512f91d5"), "Adam", "Fripp", new Guid("ae401688-5e31-4356-9903-6be404a0ec04"), new Guid("cb5b26bd-bafd-4998-aac0-2cb019cf54b8") },
                    { new Guid("3b527114-8eed-4bee-a1a1-83699664a9ce"), "Payam", "Kaufling", new Guid("ae401688-5e31-4356-9903-6be404a0ec04"), new Guid("cb5b26bd-bafd-4998-aac0-2cb019cf54b8") },
                    { new Guid("55a952d6-83e9-4247-b8f0-6c793f15f004"), "Lex", "De Haan", new Guid("ae401688-5e31-4356-9903-6be404a0ec04"), new Guid("0126c299-2050-477d-99da-16c471a0dbe0") },
                    { new Guid("9b28ad17-684a-4bec-a751-773bdab16283"), "Michael", "Hartstein", new Guid("ae401688-5e31-4356-9903-6be404a0ec04"), new Guid("f30f67c8-8d16-4a2f-9103-1b54a3f41c35") },
                    { new Guid("bb20c8ba-86ac-4bc1-a0b6-7c22bd281834"), "Matthew", "Weiss", new Guid("ae401688-5e31-4356-9903-6be404a0ec04"), new Guid("cb5b26bd-bafd-4998-aac0-2cb019cf54b8") },
                    { new Guid("c91a1b1a-cafa-4525-8fda-6d2e8dfda8de"), "Neena", "Kochhar", new Guid("ae401688-5e31-4356-9903-6be404a0ec04"), new Guid("0126c299-2050-477d-99da-16c471a0dbe0") }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "LastName", "ManagerId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("01078c07-691b-4fcd-800c-7b03467db41f"), "Nancy", "Greenberg", new Guid("c91a1b1a-cafa-4525-8fda-6d2e8dfda8de"), new Guid("b2392061-ec9f-4435-8d08-25f0e0d62a72") },
                    { new Guid("01622712-c0bd-4c42-a91e-ea149e4de77b"), "Ki", "Gee", new Guid("3b527114-8eed-4bee-a1a1-83699664a9ce"), new Guid("c5b68f11-04d6-4a4d-82ed-64ed19e25c57") },
                    { new Guid("02591430-6655-472f-8b4d-ccad9725990e"), "James", "Landry", new Guid("bb20c8ba-86ac-4bc1-a0b6-7c22bd281834"), new Guid("59ffef4e-0b57-485e-a01e-56f227882a32") },
                    { new Guid("0662b018-3760-4b86-88c2-e7568ef72958"), "Michael", "Rogers", new Guid("3b527114-8eed-4bee-a1a1-83699664a9ce"), new Guid("c5b68f11-04d6-4a4d-82ed-64ed19e25c57") },
                    { new Guid("0b51241e-0f5d-41a9-9a28-ec4d0fd03b39"), "Hazel", "Philtanker", new Guid("3b527114-8eed-4bee-a1a1-83699664a9ce"), new Guid("c5b68f11-04d6-4a4d-82ed-64ed19e25c57") },
                    { new Guid("182f8815-0daf-469d-8bb4-9476deb6bba6"), "Hermann", "Baer", new Guid("c91a1b1a-cafa-4525-8fda-6d2e8dfda8de"), new Guid("ba96796d-022c-4c80-bbd7-3c0bbbccc2cb") },
                    { new Guid("2ee10769-799b-444d-a595-d55089186ca9"), "James", "Marlow", new Guid("087a1c96-de0f-4330-b21c-82c9512f91d5"), new Guid("814dffc8-aa86-45ac-bafb-5b1443309b5f") },
                    { new Guid("3262db26-8595-4297-9291-f3df62757ad4"), "Stephen", "Stiles", new Guid("08769c56-14b4-4574-bb55-85c0d1b5aebc"), new Guid("c5b68f11-04d6-4a4d-82ed-64ed19e25c57") },
                    { new Guid("37e7409c-e3ff-4a37-8b03-d44e4ef32250"), "Mozhe", "Atkinson", new Guid("087a1c96-de0f-4330-b21c-82c9512f91d5"), new Guid("814dffc8-aa86-45ac-bafb-5b1443309b5f") },
                    { new Guid("3dacacf6-c451-41d9-9d86-79c24fa54a5d"), "Alexander", "Hunold", new Guid("55a952d6-83e9-4247-b8f0-6c793f15f004"), new Guid("0f9a68a3-7070-4644-aa22-1cee71e53457") },
                    { new Guid("3f4fe214-be81-41f7-8b7b-f9d78d2f1f26"), "John", "Seo", new Guid("08769c56-14b4-4574-bb55-85c0d1b5aebc"), new Guid("c5b68f11-04d6-4a4d-82ed-64ed19e25c57") },
                    { new Guid("45ff097d-4b4c-4f47-ad0e-892878bb5b57"), "Jennifer", "Whalen", new Guid("c91a1b1a-cafa-4525-8fda-6d2e8dfda8de"), new Guid("6a410106-a382-48a1-9442-2d9ed6bbd905") },
                    { new Guid("616dc526-8d1d-41e4-be37-c80ad0a37bb6"), "Julia", "Nayer", new Guid("bb20c8ba-86ac-4bc1-a0b6-7c22bd281834"), new Guid("59ffef4e-0b57-485e-a01e-56f227882a32") },
                    { new Guid("7ae8f349-43dd-478f-952f-9dde68415b1f"), "Pat", "Fay", new Guid("9b28ad17-684a-4bec-a751-773bdab16283"), new Guid("bdb8cb52-263c-4847-af66-4a6ee96fa77e") },
                    { new Guid("82c71285-6896-4f33-82c6-cfcebe26c0c7"), "Laura", "Bissot", new Guid("087a1c96-de0f-4330-b21c-82c9512f91d5"), new Guid("814dffc8-aa86-45ac-bafb-5b1443309b5f") },
                    { new Guid("b26af6b7-1763-49a0-90ae-ffee423b9284"), "Joshua", "Patel", new Guid("08769c56-14b4-4574-bb55-85c0d1b5aebc"), new Guid("c5b68f11-04d6-4a4d-82ed-64ed19e25c57") },
                    { new Guid("b5d79dd3-ecce-458f-8b5f-c8d377f21e0d"), "Irene", "Mikkilineni", new Guid("bb20c8ba-86ac-4bc1-a0b6-7c22bd281834"), new Guid("59ffef4e-0b57-485e-a01e-56f227882a32") },
                    { new Guid("be21c122-ce50-487e-93e7-cfaaeb2992ab"), "Steven", "Markle", new Guid("bb20c8ba-86ac-4bc1-a0b6-7c22bd281834"), new Guid("59ffef4e-0b57-485e-a01e-56f227882a32") },
                    { new Guid("bf4694d8-fae4-4499-b465-df27b81668a8"), "Jason", "Mallin", new Guid("3b527114-8eed-4bee-a1a1-83699664a9ce"), new Guid("c5b68f11-04d6-4a4d-82ed-64ed19e25c57") },
                    { new Guid("c0c1351a-76c2-438b-a318-db9a57d739fe"), "TJ", "Olson", new Guid("087a1c96-de0f-4330-b21c-82c9512f91d5"), new Guid("814dffc8-aa86-45ac-bafb-5b1443309b5f") },
                    { new Guid("c3d60888-da8b-481e-9bf5-eef37f154efd"), "Renske", "Ladwig", new Guid("08769c56-14b4-4574-bb55-85c0d1b5aebc"), new Guid("c5b68f11-04d6-4a4d-82ed-64ed19e25c57") },
                    { new Guid("ed2caf61-43c9-4b76-8c0c-8a2d93648f87"), "Susan", "Mavris", new Guid("c91a1b1a-cafa-4525-8fda-6d2e8dfda8de"), new Guid("27db6ab3-0174-4312-bbba-31a0c37fa29f") }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "LastName", "ManagerId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("2965aaae-07a5-4501-8a76-bd89cedcc9de"), "Jose Manuel", "Urman", new Guid("01078c07-691b-4fcd-800c-7b03467db41f"), new Guid("dd4b442a-0e34-4a33-8fb2-5165bdcc6f2c") },
                    { new Guid("410e640d-40fd-4738-b60b-b5c01714d1d6"), "John", "Chen", new Guid("01078c07-691b-4fcd-800c-7b03467db41f"), new Guid("dd4b442a-0e34-4a33-8fb2-5165bdcc6f2c") },
                    { new Guid("5c0857a0-6dc3-400c-8e93-c4e96ce9f7fa"), "Luis", "Popp", new Guid("01078c07-691b-4fcd-800c-7b03467db41f"), new Guid("dd4b442a-0e34-4a33-8fb2-5165bdcc6f2c") },
                    { new Guid("79c27692-24aa-4ae9-b21c-a78aaf1f3b1d"), "David", "Austin", new Guid("3dacacf6-c451-41d9-9d86-79c24fa54a5d"), new Guid("a930a5cf-2d6b-4d13-a5ba-4aece0e48cf8") },
                    { new Guid("7ac7c118-2e59-4833-8fb1-ac76428b8368"), "Valli", "Pataballa", new Guid("3dacacf6-c451-41d9-9d86-79c24fa54a5d"), new Guid("a930a5cf-2d6b-4d13-a5ba-4aece0e48cf8") },
                    { new Guid("8c31e42f-bdb3-49d0-b912-b1525ba2409b"), "Daniel", "Faviet", new Guid("01078c07-691b-4fcd-800c-7b03467db41f"), new Guid("dd4b442a-0e34-4a33-8fb2-5165bdcc6f2c") },
                    { new Guid("bbc5c711-a0e0-45a4-8a6b-aee708297e46"), "Diana", "Lorentz", new Guid("3dacacf6-c451-41d9-9d86-79c24fa54a5d"), new Guid("a930a5cf-2d6b-4d13-a5ba-4aece0e48cf8") },
                    { new Guid("be6b5e30-7fd2-4a19-a3c6-a25ea164a317"), "Bruce", "Ernst", new Guid("3dacacf6-c451-41d9-9d86-79c24fa54a5d"), new Guid("a930a5cf-2d6b-4d13-a5ba-4aece0e48cf8") },
                    { new Guid("da17fcb1-5014-4c74-8ab7-bb42055e290b"), "Ismael", "Sciarra", new Guid("01078c07-691b-4fcd-800c-7b03467db41f"), new Guid("dd4b442a-0e34-4a33-8fb2-5165bdcc6f2c") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "About",
                keyColumn: "Id",
                keyValue: new Guid("107d6eb3-1f61-4a1a-aba8-039454db136b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("01622712-c0bd-4c42-a91e-ea149e4de77b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("02591430-6655-472f-8b4d-ccad9725990e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0662b018-3760-4b86-88c2-e7568ef72958"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0b51241e-0f5d-41a9-9a28-ec4d0fd03b39"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("182f8815-0daf-469d-8bb4-9476deb6bba6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2965aaae-07a5-4501-8a76-bd89cedcc9de"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2ee10769-799b-444d-a595-d55089186ca9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3262db26-8595-4297-9291-f3df62757ad4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("37e7409c-e3ff-4a37-8b03-d44e4ef32250"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3f4fe214-be81-41f7-8b7b-f9d78d2f1f26"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("410e640d-40fd-4738-b60b-b5c01714d1d6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("45ff097d-4b4c-4f47-ad0e-892878bb5b57"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5c0857a0-6dc3-400c-8e93-c4e96ce9f7fa"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("616dc526-8d1d-41e4-be37-c80ad0a37bb6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("79c27692-24aa-4ae9-b21c-a78aaf1f3b1d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7ac7c118-2e59-4833-8fb1-ac76428b8368"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7ae8f349-43dd-478f-952f-9dde68415b1f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("82c71285-6896-4f33-82c6-cfcebe26c0c7"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8c31e42f-bdb3-49d0-b912-b1525ba2409b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b26af6b7-1763-49a0-90ae-ffee423b9284"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b5d79dd3-ecce-458f-8b5f-c8d377f21e0d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("bbc5c711-a0e0-45a4-8a6b-aee708297e46"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("be21c122-ce50-487e-93e7-cfaaeb2992ab"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("be6b5e30-7fd2-4a19-a3c6-a25ea164a317"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("bf4694d8-fae4-4499-b465-df27b81668a8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c0c1351a-76c2-438b-a318-db9a57d739fe"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c3d60888-da8b-481e-9bf5-eef37f154efd"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("da17fcb1-5014-4c74-8ab7-bb42055e290b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ed2caf61-43c9-4b76-8c0c-8a2d93648f87"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("01078c07-691b-4fcd-800c-7b03467db41f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("08769c56-14b4-4574-bb55-85c0d1b5aebc"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("087a1c96-de0f-4330-b21c-82c9512f91d5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3b527114-8eed-4bee-a1a1-83699664a9ce"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3dacacf6-c451-41d9-9d86-79c24fa54a5d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("9b28ad17-684a-4bec-a751-773bdab16283"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("bb20c8ba-86ac-4bc1-a0b6-7c22bd281834"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("27db6ab3-0174-4312-bbba-31a0c37fa29f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("59ffef4e-0b57-485e-a01e-56f227882a32"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6a410106-a382-48a1-9442-2d9ed6bbd905"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("814dffc8-aa86-45ac-bafb-5b1443309b5f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a930a5cf-2d6b-4d13-a5ba-4aece0e48cf8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ba96796d-022c-4c80-bbd7-3c0bbbccc2cb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bdb8cb52-263c-4847-af66-4a6ee96fa77e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c5b68f11-04d6-4a4d-82ed-64ed19e25c57"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dd4b442a-0e34-4a33-8fb2-5165bdcc6f2c"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("75209929-7231-432a-8fda-04a84d4a59dd"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7a815ecd-7ab8-4848-af2e-114f9d38a719"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("945a5bfa-012a-4047-b1e4-02592a3156bd"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("55a952d6-83e9-4247-b8f0-6c793f15f004"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c91a1b1a-cafa-4525-8fda-6d2e8dfda8de"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0f9a68a3-7070-4644-aa22-1cee71e53457"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b2392061-ec9f-4435-8d08-25f0e0d62a72"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cb5b26bd-bafd-4998-aac0-2cb019cf54b8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f30f67c8-8d16-4a2f-9103-1b54a3f41c35"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("00e5b334-c661-4357-8dcf-0d1d0985db18"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("89e84583-a348-42bb-bca8-09a118a32521"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a80a1414-a130-4785-939f-09e7df7e00c2"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ac532fdc-2d1b-426c-9b1e-043e7727eeae"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ae401688-5e31-4356-9903-6be404a0ec04"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0126c299-2050-477d-99da-16c471a0dbe0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cf744e92-3fe0-440d-acaf-140607d33b8e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("107d6eb3-1f61-4a1a-aba8-039454db136b"));
        }
    }
}
