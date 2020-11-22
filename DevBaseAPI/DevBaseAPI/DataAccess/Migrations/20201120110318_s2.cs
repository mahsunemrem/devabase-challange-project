using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class s2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "AddedDate", "DateOfBorn", "Email", "Name", "Surname", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("81980971-b2a6-4b5b-bbe8-49a222ac9972"), new DateTime(2020, 11, 20, 14, 3, 18, 55, DateTimeKind.Local).AddTicks(2998), new DateTime(2019, 11, 5, 15, 11, 40, 923, DateTimeKind.Unspecified).AddTicks(7714), "E.Mac@amazon.co", "Blake", "Thorne", "ebay.info", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(2930) },
                    { new Guid("17269bc5-2a08-40f5-8c01-333c34fcb870"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7253), new DateTime(2011, 11, 10, 15, 23, 34, 767, DateTimeKind.Unspecified).AddTicks(2792), "T.Taylor@theguardian.us", "Ariana", "Buckley", "maplin.org", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7310) },
                    { new Guid("d3dfe82b-595d-4b22-97cd-1f9e14d7d930"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7190), new DateTime(2012, 10, 31, 6, 14, 49, 296, DateTimeKind.Unspecified).AddTicks(9360), "Lily.Sanders@deviantart.com", "Aaron", "Blair", "arstechnica.us", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7251) },
                    { new Guid("b2cfee45-e91b-4b63-8d1d-612a61b434bc"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7164), new DateTime(2000, 8, 15, 19, 9, 42, 370, DateTimeKind.Unspecified).AddTicks(3416), "E.Chadwick@gmail.org.uk", "Brandon", "Barlow", "msdn.org.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7189) },
                    { new Guid("8353162c-410c-4035-9e8e-d3f6c5f380db"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7101), new DateTime(1979, 10, 8, 11, 58, 43, 78, DateTimeKind.Unspecified).AddTicks(1961), "C.Walker@qq.co.uk", "Evelyn", "Wright", "pinterest.us", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7163) },
                    { new Guid("7172a9ae-d1b2-4afe-a7ed-3f7f01d7c4eb"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7078), new DateTime(1974, 3, 15, 8, 24, 30, 199, DateTimeKind.Unspecified).AddTicks(5635), "Elijah.Taylor@taobao.co.uk", "Ariana", "Bradshaw", "sky.com", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7100) },
                    { new Guid("b8923173-fabd-4cf9-a562-1167ce9ca97c"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7016), new DateTime(2004, 6, 12, 14, 52, 18, 839, DateTimeKind.Unspecified).AddTicks(1622), "L.Riddick@msdn.biz", "Tristan", "Sanders", "baidu.com", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7077) },
                    { new Guid("62ccf67a-665a-45f5-a859-4735a3db9e37"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6993), new DateTime(2009, 8, 7, 5, 6, 50, 453, DateTimeKind.Unspecified).AddTicks(3620), "M.Haines@paypal.com", "Ian", "Briggs", "techcrunch.info", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7015) },
                    { new Guid("dcae0815-83b9-4825-9f90-a782f8e1dd65"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6929), new DateTime(1978, 2, 19, 7, 50, 32, 159, DateTimeKind.Unspecified).AddTicks(7929), "Faith.Carroll@wordpress.com", "Molly", "Silva", "cnn.info", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6991) },
                    { new Guid("e633bf43-0f4b-4f1d-9463-be71b0b735e3"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6903), new DateTime(2009, 11, 18, 18, 32, 13, 97, DateTimeKind.Unspecified).AddTicks(7804), "L.Briggs@stackoverflow.biz", "Angel", "Blair", "flipkart.net", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6926) },
                    { new Guid("0da85d4d-5fcc-4ca7-bb7b-624057011ed9"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6825), new DateTime(2015, 4, 19, 21, 32, 7, 710, DateTimeKind.Unspecified).AddTicks(9894), "Addison.Coles@studio1337.us", "Madeline", "Jones", "pinterest.co", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6902) },
                    { new Guid("da8c97ac-c6e6-4864-80b6-e5654b2fbc4b"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6800), new DateTime(2002, 8, 7, 16, 11, 59, 963, DateTimeKind.Unspecified).AddTicks(1156), "L.Jackson@deviantart.co.uk", "Adam", "Wood", "youtube.co.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6824) },
                    { new Guid("3dbfd86d-3056-4a68-b056-2bb41747e0ab"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6738), new DateTime(2002, 10, 25, 0, 53, 56, 682, DateTimeKind.Unspecified).AddTicks(2834), "M.Whitehouse@lego.com", "Riley", "Chadwick", "yahoo.net", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6798) },
                    { new Guid("eb371911-acf1-4620-9555-c99ee364006f"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6676), new DateTime(2001, 9, 17, 16, 23, 34, 823, DateTimeKind.Unspecified).AddTicks(2800), "Reagan.Briggs@qq.org", "Alex", "Smith", "youtube.us", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6736) },
                    { new Guid("41946809-ecc2-4196-b9e7-ed9c4bbc77c1"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6653), new DateTime(1995, 10, 9, 15, 13, 45, 213, DateTimeKind.Unspecified).AddTicks(9611), "H.Harris@163.com", "Piper", "Wilson", "deviantart.org", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6675) },
                    { new Guid("c26fba8e-8470-4d9c-af53-fb3b2a9e580d"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6590), new DateTime(2014, 11, 16, 6, 15, 43, 592, DateTimeKind.Unspecified).AddTicks(9320), "Oliver.Swift@bestbuy.net", "Adrian", "Bradshaw", "stackoverflow.us", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6651) },
                    { new Guid("5c107f5a-0dde-4441-b4e8-acec89c1520f"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6567), new DateTime(2009, 2, 23, 13, 44, 2, 961, DateTimeKind.Unspecified).AddTicks(6082), "Henry.Obrien@arstechnica.us", "Allison", "Stuart", "expedia.org", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6589) },
                    { new Guid("58d16677-02ec-4132-8bf3-699b33fb8840"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6502), new DateTime(2005, 8, 26, 16, 34, 35, 427, DateTimeKind.Unspecified).AddTicks(3118), "N.Watson@stackoverflow.net", "Savannah", "Weaver", "sky.org", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6566) },
                    { new Guid("93e2c306-1585-406e-ab18-808868a58569"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6477), new DateTime(1985, 11, 15, 19, 58, 4, 148, DateTimeKind.Unspecified).AddTicks(7654), "J.Giles@taobao.us", "Levi", "Whitehouse", "lego.info", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6501) },
                    { new Guid("06e224c5-8899-4759-9905-185c15e76e77"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6385), new DateTime(2002, 12, 19, 11, 45, 12, 587, DateTimeKind.Unspecified).AddTicks(6212), "L.Summers@expedia.net", "Scarlett", "Nash", "ebay.org.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6476) },
                    { new Guid("25addac4-fa1f-46b6-a5d6-6743c21ab224"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6362), new DateTime(1991, 6, 19, 3, 33, 7, 674, DateTimeKind.Unspecified).AddTicks(7223), "C.Nash@linkedin.co", "Reagan", "Briggs", "stackoverflow.info", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6384) },
                    { new Guid("91b96c8c-9bce-41fb-9837-9e0abf5f0b3f"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6305), new DateTime(1975, 6, 29, 20, 12, 49, 260, DateTimeKind.Unspecified).AddTicks(2199), "S.Walters@bing.org", "Savannah", "Thornton", "amazon.co.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6361) },
                    { new Guid("599ba6e3-0870-4102-8a3e-4783aa1f3286"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7312), new DateTime(1996, 5, 10, 11, 52, 52, 803, DateTimeKind.Unspecified).AddTicks(611), "Xavier.Boyd@163.co", "Nathan", "Cullen", "youtube.info", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7334) },
                    { new Guid("caf52e6b-1a87-477d-9d56-6f8a5f880d44"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6282), new DateTime(1973, 3, 31, 22, 44, 4, 684, DateTimeKind.Unspecified).AddTicks(1776), "E.Kenny@paypal.org.uk", "Naomi", "Watson", "pinterest.co.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6303) },
                    { new Guid("ff93eae9-6922-440b-981f-2bc473d1ac21"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7336), new DateTime(2004, 3, 20, 18, 16, 19, 611, DateTimeKind.Unspecified).AddTicks(6296), "Alexa.Joyce@etsy.info", "Emily", "Savage", "qq.info", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7392) },
                    { new Guid("e780c42a-f91f-4291-a34d-5b5de8a333e9"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7416), new DateTime(1989, 7, 14, 13, 17, 52, 823, DateTimeKind.Unspecified).AddTicks(3912), "M.Silva@yahoo.co.uk", "Emma", "Williams", "expedia.org", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7505) },
                    { new Guid("60315e96-a7cd-44ee-bf4b-fa047ad0f4b5"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8399), new DateTime(2008, 1, 9, 10, 20, 12, 483, DateTimeKind.Unspecified).AddTicks(8922), "Elizabeth.Whittaker@bing.net", "Amelia", "Boyd", "msdn.org", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8459) },
                    { new Guid("2e88e74d-0070-43b7-a95b-8ba4149f1d42"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8376), new DateTime(1981, 9, 3, 22, 9, 31, 754, DateTimeKind.Unspecified).AddTicks(3296), "M.Briggs@bestbuy.biz", "Daniel", "Thomas", "microsoft.com", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8398) },
                    { new Guid("916fbf0c-8c38-4a36-8b36-0b2e14f39680"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8315), new DateTime(1976, 7, 10, 4, 21, 29, 878, DateTimeKind.Unspecified).AddTicks(5390), "Chloe.Jackson@cnn.net", "Gabriel", "Riddick", "ebay.biz", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8374) },
                    { new Guid("f8818e46-8438-4460-b0c7-f7634ca6f25f"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8289), new DateTime(2004, 3, 12, 3, 48, 51, 554, DateTimeKind.Unspecified).AddTicks(2860), "Adrian.Power@wikia.net", "Carson", "Giles", "arstechnica.us", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8314) },
                    { new Guid("f131937f-a51d-4f2b-8819-e70cc3e8b67a"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8213), new DateTime(1991, 9, 26, 12, 15, 36, 308, DateTimeKind.Unspecified).AddTicks(1875), "A.Lewis@maplin.info", "Sarah", "Mclean", "amazon.info", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8287) },
                    { new Guid("9134d92b-c3a3-4204-95ac-19cf2ea7a8e7"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8189), new DateTime(1985, 2, 23, 23, 17, 9, 290, DateTimeKind.Unspecified).AddTicks(4032), "D.Haines@deviantart.info", "Morgan", "Williams", "theguardian.com", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8212) },
                    { new Guid("7785ac66-5a6e-4f9a-9f5c-9b2750c331e8"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8127), new DateTime(2004, 1, 12, 21, 50, 31, 483, DateTimeKind.Unspecified).AddTicks(582), "P.Barlow@stackoverflow.com", "Evelyn", "Jackson", "wikia.net", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8188) },
                    { new Guid("76d3161f-20f8-44b9-a263-72575339ad1d"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8101), new DateTime(1974, 3, 1, 14, 1, 2, 808, DateTimeKind.Unspecified).AddTicks(7754), "L.Briggs@taobao.us", "Harper", "Whelan", "google.org", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8126) },
                    { new Guid("259f3a2b-1010-4385-8c83-ff82e1c55ad4"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8042), new DateTime(1997, 7, 4, 11, 55, 0, 286, DateTimeKind.Unspecified).AddTicks(2969), "Caroline.Osborne@deviantart.biz", "Parker", "Savage", "wordpress.co.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8100) },
                    { new Guid("02d7fae6-c9e6-4643-a0f4-17bd7debc9a4"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7983), new DateTime(1991, 8, 3, 10, 45, 10, 176, DateTimeKind.Unspecified).AddTicks(7684), "Isaac.Sanders@live.com", "Ella", "Stuart", "studio1337.co.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8041) },
                    { new Guid("14701d19-fe10-4df2-a1a8-121afc4357ed"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7960), new DateTime(2003, 4, 12, 19, 14, 58, 536, DateTimeKind.Unspecified).AddTicks(8238), "E.Williams@cnn.biz", "Lucas", "Vaughan", "amazon.co.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7982) },
                    { new Guid("9e8be155-f5c9-42b3-9217-34d82cd1b77e"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7897), new DateTime(1980, 12, 4, 5, 27, 40, 662, DateTimeKind.Unspecified).AddTicks(5826), "Genesis.Little@163.org", "Madelyn", "Dale", "arstechnica.net", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7958) },
                    { new Guid("3b61aaa8-0917-410d-bedc-f5be3a4ad035"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7874), new DateTime(1988, 7, 2, 8, 50, 4, 181, DateTimeKind.Unspecified).AddTicks(8465), "M.Leach@youtube.net", "Nolan", "Giles", "sohu.co.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7895) },
                    { new Guid("5d191ecb-98ba-4d5f-81ef-229992716374"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7811), new DateTime(1988, 9, 7, 23, 38, 34, 238, DateTimeKind.Unspecified).AddTicks(913), "C.Thompson@taobao.co", "Levi", "Shepherd", "studio1337.com", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7872) },
                    { new Guid("ccb46cca-1d63-49dc-a875-f290f9dba551"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7788), new DateTime(1989, 8, 25, 5, 59, 33, 275, DateTimeKind.Unspecified).AddTicks(7719), "J.Harris@expedia.com", "Ava", "Shepherd", "etsy.co", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7810) },
                    { new Guid("eca998e3-2450-4388-ad61-68a5481a19e9"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7724), new DateTime(1986, 3, 27, 15, 50, 34, 642, DateTimeKind.Unspecified).AddTicks(5641), "M.Robinson@163.org.uk", "Alexis", "White", "live.co", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7787) },
                    { new Guid("c46ba212-dac8-420f-9677-4d6f727cface"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7702), new DateTime(1993, 2, 7, 4, 48, 55, 40, DateTimeKind.Unspecified).AddTicks(7675), "Joshua.Green@live.biz", "Carson", "Burrows", "163.com", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7723) },
                    { new Guid("13d776bc-6409-42bb-ae4d-06f9c4c1ac10"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7638), new DateTime(1977, 1, 7, 5, 42, 17, 459, DateTimeKind.Unspecified).AddTicks(2140), "Jeremiah.Weaver@deviantart.net", "Skylar", "Summers", "wikia.co.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7700) },
                    { new Guid("9e1e2483-a605-476c-87c2-83b83791354e"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7616), new DateTime(2005, 1, 29, 6, 25, 57, 50, DateTimeKind.Unspecified).AddTicks(296), "Brianna.Thompson@yelp.co", "Melanie", "Power", "sohu.co", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7637) },
                    { new Guid("8a37e396-2952-42fe-b9dd-89ec7120cd9d"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7531), new DateTime(2012, 9, 8, 15, 17, 23, 613, DateTimeKind.Unspecified).AddTicks(9920), "Grace.Wright@163.org", "Emma", "Barlow", "yahoo.org.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7614) },
                    { new Guid("72773163-24c0-42a5-8f57-5a2570c32b26"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7507), new DateTime(2019, 9, 5, 7, 38, 1, 230, DateTimeKind.Unspecified).AddTicks(8578), "Addison.Davies@lego.org.uk", "Lucas", "Haines", "wikia.com", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7530) },
                    { new Guid("79ca66a3-2c6b-49fd-a3cc-d2c2ef4482d8"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7393), new DateTime(2007, 4, 2, 14, 38, 30, 408, DateTimeKind.Unspecified).AddTicks(9516), "Levi.Mclean@arstechnica.co", "Blake", "Roberts", "cnn.org", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(7414) },
                    { new Guid("9295007c-6e7f-490f-9755-f727c2fcee22"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6219), new DateTime(2019, 6, 17, 18, 2, 24, 986, DateTimeKind.Unspecified).AddTicks(4188), "A.Joyce@gmail.us", "Eli", "Naylor", "ebay.biz", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6281) },
                    { new Guid("a2c7c20d-675d-421a-9e90-6ef62e71f491"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6195), new DateTime(1980, 10, 29, 12, 15, 51, 196, DateTimeKind.Unspecified).AddTicks(5173), "O.Silva@globo.org.uk", "Khloe", "Green", "pinterest.co", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6218) },
                    { new Guid("45070723-2fc2-4777-90e1-0925e5f7dc93"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6118), new DateTime(2004, 1, 10, 2, 1, 53, 776, DateTimeKind.Unspecified).AddTicks(334), "Jocelyn.Swift@techcrunch.info", "Tyler", "Wright", "163.net", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6194) },
                    { new Guid("024cef97-9f1a-4485-bfdf-58da6f54cd41"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4859), new DateTime(1997, 7, 8, 21, 14, 12, 705, DateTimeKind.Unspecified).AddTicks(3355), "Sofia.Abbott@linkedin.org", "Jack", "Lord", "stackoverflow.org.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4883) },
                    { new Guid("021fddbe-1a37-47de-aaff-316ba8a63498"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4761), new DateTime(1985, 3, 5, 1, 16, 22, 997, DateTimeKind.Unspecified).AddTicks(5366), "Genesis.Schofield@sky.co.uk", "Ashley", "Naylor", "sohu.us", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4857) },
                    { new Guid("a2a287be-6f11-4e00-a7de-4155e0863424"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4738), new DateTime(1982, 8, 25, 17, 4, 53, 561, DateTimeKind.Unspecified).AddTicks(8562), "Zoe.Little@sohu.org.uk", "Mackenzie", "Akhtar", "paypal.co", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4760) },
                    { new Guid("6265e937-2130-451a-a63f-6ccd965bd7fd"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4658), new DateTime(2016, 3, 1, 0, 53, 47, 88, DateTimeKind.Unspecified).AddTicks(5798), "Allison.Mellor@wikia.org", "Sarah", "Jones", "cnn.biz", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4736) },
                    { new Guid("fb3a870b-f7a8-4864-9e7f-cd068314c9a1"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4633), new DateTime(1987, 12, 11, 14, 27, 58, 717, DateTimeKind.Unspecified).AddTicks(736), "B.Giles@bbc.org", "Skylar", "Obrien", "expedia.co.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4656) },
                    { new Guid("d141fa5d-329c-4916-84e2-d9d0f9495f10"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4567), new DateTime(1984, 1, 21, 13, 51, 48, 49, DateTimeKind.Unspecified).AddTicks(9917), "E.Akhtar@theguardian.info", "Hudson", "Williams", "linkedin.net", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4629) },
                    { new Guid("36c46a8c-cc97-42ce-9845-e2cae81b0696"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4495), new DateTime(1999, 7, 30, 1, 24, 0, 79, DateTimeKind.Unspecified).AddTicks(9989), "Nolan.Lewis@google.co.uk", "David", "Mac", "yahoo.net", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4565) },
                    { new Guid("b7aa2c6c-e53e-4934-bde2-f0b6b7ebda0d"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4468), new DateTime(1992, 1, 1, 16, 12, 4, 373, DateTimeKind.Unspecified).AddTicks(6863), "B.Thomas@techcrunch.co.uk", "Zoe", "Boyd", "ask.org", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4494) },
                    { new Guid("cedac1db-850a-49ac-8265-0d9bf0b87b18"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4406), new DateTime(2002, 7, 5, 20, 54, 8, 691, DateTimeKind.Unspecified).AddTicks(6362), "E.Riddick@wikipedia.org.uk", "Noah", "Osborne", "pinterest.co", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4467) },
                    { new Guid("87a048f2-95ec-40d4-ac50-18d1e2236ebf"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4383), new DateTime(2007, 12, 16, 8, 50, 34, 407, DateTimeKind.Unspecified).AddTicks(1052), "Kevin.Barlow@youtube.org.uk", "Aria", "Rossi", "maplin.co.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4405) },
                    { new Guid("1e790f4c-7e8c-4a1d-9550-3c48446e2496"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4312), new DateTime(2020, 1, 6, 11, 27, 6, 197, DateTimeKind.Unspecified).AddTicks(5354), "L.Power@globo.org.uk", "Zachary", "Mellor", "youtube.info", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4381) },
                    { new Guid("e4ffefec-0a6a-4003-93c5-b41e27aa1869"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4290), new DateTime(1994, 5, 9, 4, 24, 5, 250, DateTimeKind.Unspecified).AddTicks(3458), "Autumn.Abbott@theguardian.org.uk", "Victoria", "Cullen", "live.co.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4311) },
                    { new Guid("13509399-9060-495b-9187-9c2d8a380251"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4220), new DateTime(1974, 5, 15, 13, 8, 22, 610, DateTimeKind.Unspecified).AddTicks(9982), "K.Brown@studio1337.com", "Scott", "Seymour", "wikia.us", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4289) },
                    { new Guid("949c1fc6-2778-4b66-b1cd-461f6a21507b"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4192), new DateTime(2007, 12, 2, 1, 5, 36, 988, DateTimeKind.Unspecified).AddTicks(2996), "A.Summers@globo.co", "Reagan", "Lindsay", "lego.info", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4217) },
                    { new Guid("669e8e46-6e04-4477-bc6d-2761b43be06e"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4036), new DateTime(1977, 7, 31, 17, 34, 2, 456, DateTimeKind.Unspecified).AddTicks(5682), "Autumn.Blair@globo.co", "Evelyn", "Whitehouse", "bbc.co.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4190) },
                    { new Guid("ce47f87e-cf3f-45ba-b0ec-48582229af69"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4001), new DateTime(1998, 6, 24, 0, 0, 37, 424, DateTimeKind.Unspecified).AddTicks(3559), "G.Akhtar@yahoo.org.uk", "Brody", "Hooper", "arstechnica.us", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4035) },
                    { new Guid("817b9cc5-0286-48af-9882-79c4e81c8b6a"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(3936), new DateTime(2016, 3, 16, 4, 15, 7, 29, DateTimeKind.Unspecified).AddTicks(8016), "Isaiah.Whitehouse@maplin.co.uk", "Alyssa", "Lindsay", "qq.net", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(3999) },
                    { new Guid("77a71a53-af73-486e-8ba4-49f18c55dc36"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(3908), new DateTime(1976, 12, 28, 15, 20, 10, 421, DateTimeKind.Unspecified).AddTicks(2985), "S.Schofield@taobao.org", "Gianna", "Thompson", "adamriddick.biz", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(3932) },
                    { new Guid("d33ed60b-0d1b-4148-92d0-08f0df3fa555"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(3792), new DateTime(2016, 9, 11, 9, 58, 16, 536, DateTimeKind.Unspecified).AddTicks(1130), "L.Wood@live.com", "Luke", "Rossi", "wikia.net", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(3906) },
                    { new Guid("cbdbbd28-0150-42f3-b051-2eac3bcb60b5"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(3763), new DateTime(1972, 11, 11, 20, 34, 35, 753, DateTimeKind.Unspecified).AddTicks(553), "London.Buckley@bet365.com", "Lucy", "Thornton", "yahoo.com", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(3791) },
                    { new Guid("ae27601e-a9c3-4dad-b7f3-ba87adda1cf9"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(3497), new DateTime(2002, 10, 30, 21, 30, 50, 717, DateTimeKind.Unspecified).AddTicks(1390), "Grace.Summers@bbc.net", "Bella", "Mohamed", "linkedin.org.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(3709) },
                    { new Guid("72c9b907-6acb-4a57-8cf0-0d762e479f52"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4884), new DateTime(1985, 7, 31, 12, 46, 32, 464, DateTimeKind.Unspecified).AddTicks(2158), "E.Green@maplin.info", "Jace", "Sanders", "gmail.com", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4950) },
                    { new Guid("0a25ae19-dcfe-4e70-8a46-7474dbd5f5ad"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4952), new DateTime(2020, 5, 16, 13, 58, 0, 58, DateTimeKind.Unspecified).AddTicks(2706), "Mia.Whittaker@taobao.org.uk", "Dylan", "Whitehead", "cnn.org.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4974) },
                    { new Guid("05a18181-c640-470d-a09f-4a72ac40cbb4"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(4975), new DateTime(1987, 11, 26, 18, 23, 51, 398, DateTimeKind.Unspecified).AddTicks(2594), "E.Power@techcrunch.co.uk", "Anna", "Williams", "flipkart.info", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5036) },
                    { new Guid("80ae7fd5-cfdd-4c55-9e34-687beccedc04"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5037), new DateTime(1976, 8, 3, 9, 42, 56, 690, DateTimeKind.Unspecified).AddTicks(5771), "W.Whelan@lego.biz", "Gianna", "Wright", "wikipedia.net", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5060) },
                    { new Guid("9397a401-1c23-40a6-80cd-04adb68812d2"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6095), new DateTime(2012, 2, 3, 0, 10, 56, 917, DateTimeKind.Unspecified).AddTicks(5958), "Samuel.Barlow@wordpress.info", "Sophie", "Riddick", "adamriddick.biz", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6117) },
                    { new Guid("6c6044c8-1fbd-40cb-91a5-0179177f970f"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6031), new DateTime(1982, 8, 26, 9, 38, 51, 576, DateTimeKind.Unspecified).AddTicks(2301), "Serenity.Seymour@globo.com", "Bella", "Giles", "cnn.us", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6093) },
                    { new Guid("0d122a07-c63b-4721-90a1-2f51fb986f86"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6008), new DateTime(2006, 10, 15, 17, 48, 24, 980, DateTimeKind.Unspecified).AddTicks(9148), "Ellie.Stuart@sky.co.uk", "Natalie", "Kenny", "stackoverflow.info", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(6030) },
                    { new Guid("5f3eb81e-aec7-4668-baa3-bf3d94c7e083"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5947), new DateTime(2001, 10, 12, 15, 58, 21, 152, DateTimeKind.Unspecified).AddTicks(1202), "C.Blair@bbc.info", "Paul", "Weaver", "stackoverflow.biz", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5968) },
                    { new Guid("b65f0233-b607-4d22-bec4-2c5fa20c117b"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5884), new DateTime(1980, 10, 8, 3, 39, 23, 724, DateTimeKind.Unspecified).AddTicks(5163), "J.Swift@linkedin.co", "Ayden", "Carroll", "studio1337.us", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5946) },
                    { new Guid("1a80d346-3eae-4c96-a3ac-cbc0bcc2e669"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5862), new DateTime(1979, 12, 15, 13, 30, 51, 428, DateTimeKind.Unspecified).AddTicks(4421), "Jasmine.Mcfarlane@theguardian.org", "Ryder", "Boyd", "flipkart.org", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5883) },
                    { new Guid("13447f1b-afd0-474a-b9bb-5e6379f37a2b"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5799), new DateTime(1979, 12, 22, 12, 12, 15, 778, DateTimeKind.Unspecified).AddTicks(5432), "Maya.Naylor@wikipedia.co", "Mason", "Swift", "theguardian.org.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5860) },
                    { new Guid("12f9517c-6305-477f-958d-532c149c0a0f"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5776), new DateTime(2017, 10, 28, 9, 58, 28, 853, DateTimeKind.Unspecified).AddTicks(256), "L.Baldwin@google.com", "Harper", "Mohamed", "linkedin.us", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5798) },
                    { new Guid("81018594-48f1-4f4c-84da-e5dfb520f27a"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5712), new DateTime(2018, 7, 23, 5, 18, 50, 489, DateTimeKind.Unspecified).AddTicks(6910), "G.Barlow@paypal.biz", "Aaliyah", "Roberts", "arstechnica.com", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5775) },
                    { new Guid("06cd7a61-181d-45e9-b18e-7bb93fe6bfbb"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5685), new DateTime(2017, 11, 25, 5, 24, 5, 797, DateTimeKind.Unspecified).AddTicks(6832), "L.Hancock@theguardian.org.uk", "Madelyn", "Riddick", "wikia.org", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5711) },
                    { new Guid("808c484b-54d2-4520-b076-0cbf7df106b4"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8460), new DateTime(2016, 9, 29, 16, 40, 54, 295, DateTimeKind.Unspecified).AddTicks(6970), "Z.Little@ask.biz", "Nolan", "Wood", "deviantart.co", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8483) },
                    { new Guid("068ee288-1e35-45b9-a84f-7a4f1d39aa17"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5622), new DateTime(1990, 1, 10, 20, 35, 4, 249, DateTimeKind.Unspecified).AddTicks(4470), "K.Boyd@expedia.co", "David", "Riddick", "ebay.org.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5684) },
                    { new Guid("9524fe26-348d-4acc-be0b-ec7cad546e16"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5535), new DateTime(1993, 4, 7, 12, 3, 18, 556, DateTimeKind.Unspecified).AddTicks(5384), "S.Roberts@etsy.co", "Nevaeh", "Walters", "bing.com", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5597) },
                    { new Guid("a3c73c6d-0d55-4830-9216-0691d8beed31"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5511), new DateTime(1981, 1, 17, 19, 38, 16, 361, DateTimeKind.Unspecified).AddTicks(5302), "B.Williams@bet365.org.uk", "Ryan", "Hilton", "pinterest.us", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5534) },
                    { new Guid("2a0fbb62-e1f6-4bd4-bd64-fca1d1df8078"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5434), new DateTime(1976, 7, 7, 18, 45, 38, 362, DateTimeKind.Unspecified).AddTicks(3164), "Adam.Hilton@163.co", "Mia", "Roberts", "wikipedia.co.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5509) },
                    { new Guid("73870f73-a044-40d4-a561-971b932b3a06"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5405), new DateTime(2020, 5, 29, 13, 32, 54, 321, DateTimeKind.Unspecified).AddTicks(7516), "David.Barlow@yahoo.co", "Kimberly", "Smith", "msdn.biz", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5430) },
                    { new Guid("3be3d160-8549-49af-9cc8-71fd514d2f58"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5342), new DateTime(2015, 2, 20, 12, 23, 26, 931, DateTimeKind.Unspecified).AddTicks(8550), "J.Robinson@etsy.biz", "Isabella", "Riddick", "amazon.net", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5364) },
                    { new Guid("06f007bb-0791-4b0b-bcee-6b974815cb63"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5236), new DateTime(2008, 7, 4, 12, 18, 16, 775, DateTimeKind.Unspecified).AddTicks(8932), "I.Nelson@163.us", "Jaxon", "Boyd", "stackoverflow.co.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5340) },
                    { new Guid("0972fbcc-e10e-4ef7-96fc-a385d8e1011d"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5213), new DateTime(1974, 5, 2, 4, 38, 58, 510, DateTimeKind.Unspecified).AddTicks(4064), "M.Jackson@expedia.co.uk", "Joseph", "Wright", "bestbuy.us", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5235) },
                    { new Guid("ef7d7374-f98d-4aa7-8242-bc4346baf8ab"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5148), new DateTime(1985, 2, 11, 7, 20, 5, 498, DateTimeKind.Unspecified).AddTicks(768), "Jeremiah.Whitehouse@adamriddick.com", "Kayden", "Jones", "lego.info", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5212) },
                    { new Guid("3a725ee6-0d3a-4528-be9c-863c1e7a152e"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5126), new DateTime(2015, 7, 20, 21, 11, 12, 615, DateTimeKind.Unspecified).AddTicks(828), "S.Wood@techcrunch.co.uk", "Ellie", "Savage", "amazon.info", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5147) },
                    { new Guid("83370067-91a9-469c-a59f-82c7b2ffde5a"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5061), new DateTime(1980, 3, 1, 22, 54, 35, 338, DateTimeKind.Unspecified).AddTicks(7385), "Bailey.Fleming@sohu.net", "Harper", "Adam", "baidu.org.uk", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5124) },
                    { new Guid("8694d6f4-5aeb-419f-9835-269b119f6ed0"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5598), new DateTime(1976, 7, 9, 17, 54, 8, 644, DateTimeKind.Unspecified).AddTicks(4317), "Hailey.Fleming@etsy.info", "Alexander", "Fleming", "yelp.net", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(5620) },
                    { new Guid("d8f904dc-cc73-4711-abf8-617d0106a118"), new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8484), new DateTime(1980, 10, 22, 11, 46, 7, 242, DateTimeKind.Unspecified).AddTicks(5945), "A.Evans@arstechnica.biz", "Parker", "Wilson", "paypal.biz", new DateTime(2020, 11, 20, 14, 3, 18, 61, DateTimeKind.Local).AddTicks(8574) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("021fddbe-1a37-47de-aaff-316ba8a63498"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("024cef97-9f1a-4485-bfdf-58da6f54cd41"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("02d7fae6-c9e6-4643-a0f4-17bd7debc9a4"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("05a18181-c640-470d-a09f-4a72ac40cbb4"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("068ee288-1e35-45b9-a84f-7a4f1d39aa17"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("06cd7a61-181d-45e9-b18e-7bb93fe6bfbb"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("06e224c5-8899-4759-9905-185c15e76e77"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("06f007bb-0791-4b0b-bcee-6b974815cb63"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("0972fbcc-e10e-4ef7-96fc-a385d8e1011d"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("0a25ae19-dcfe-4e70-8a46-7474dbd5f5ad"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("0d122a07-c63b-4721-90a1-2f51fb986f86"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("0da85d4d-5fcc-4ca7-bb7b-624057011ed9"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("12f9517c-6305-477f-958d-532c149c0a0f"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("13447f1b-afd0-474a-b9bb-5e6379f37a2b"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("13509399-9060-495b-9187-9c2d8a380251"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("13d776bc-6409-42bb-ae4d-06f9c4c1ac10"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("14701d19-fe10-4df2-a1a8-121afc4357ed"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("17269bc5-2a08-40f5-8c01-333c34fcb870"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("1a80d346-3eae-4c96-a3ac-cbc0bcc2e669"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("1e790f4c-7e8c-4a1d-9550-3c48446e2496"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("259f3a2b-1010-4385-8c83-ff82e1c55ad4"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("25addac4-fa1f-46b6-a5d6-6743c21ab224"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("2a0fbb62-e1f6-4bd4-bd64-fca1d1df8078"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("2e88e74d-0070-43b7-a95b-8ba4149f1d42"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("36c46a8c-cc97-42ce-9845-e2cae81b0696"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("3a725ee6-0d3a-4528-be9c-863c1e7a152e"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("3b61aaa8-0917-410d-bedc-f5be3a4ad035"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("3be3d160-8549-49af-9cc8-71fd514d2f58"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("3dbfd86d-3056-4a68-b056-2bb41747e0ab"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("41946809-ecc2-4196-b9e7-ed9c4bbc77c1"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("45070723-2fc2-4777-90e1-0925e5f7dc93"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("58d16677-02ec-4132-8bf3-699b33fb8840"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("599ba6e3-0870-4102-8a3e-4783aa1f3286"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("5c107f5a-0dde-4441-b4e8-acec89c1520f"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("5d191ecb-98ba-4d5f-81ef-229992716374"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("5f3eb81e-aec7-4668-baa3-bf3d94c7e083"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("60315e96-a7cd-44ee-bf4b-fa047ad0f4b5"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("6265e937-2130-451a-a63f-6ccd965bd7fd"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("62ccf67a-665a-45f5-a859-4735a3db9e37"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("669e8e46-6e04-4477-bc6d-2761b43be06e"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("6c6044c8-1fbd-40cb-91a5-0179177f970f"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("7172a9ae-d1b2-4afe-a7ed-3f7f01d7c4eb"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("72773163-24c0-42a5-8f57-5a2570c32b26"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("72c9b907-6acb-4a57-8cf0-0d762e479f52"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("73870f73-a044-40d4-a561-971b932b3a06"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("76d3161f-20f8-44b9-a263-72575339ad1d"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("7785ac66-5a6e-4f9a-9f5c-9b2750c331e8"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("77a71a53-af73-486e-8ba4-49f18c55dc36"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("79ca66a3-2c6b-49fd-a3cc-d2c2ef4482d8"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("808c484b-54d2-4520-b076-0cbf7df106b4"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("80ae7fd5-cfdd-4c55-9e34-687beccedc04"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("81018594-48f1-4f4c-84da-e5dfb520f27a"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("817b9cc5-0286-48af-9882-79c4e81c8b6a"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("81980971-b2a6-4b5b-bbe8-49a222ac9972"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("83370067-91a9-469c-a59f-82c7b2ffde5a"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("8353162c-410c-4035-9e8e-d3f6c5f380db"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("8694d6f4-5aeb-419f-9835-269b119f6ed0"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("87a048f2-95ec-40d4-ac50-18d1e2236ebf"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("8a37e396-2952-42fe-b9dd-89ec7120cd9d"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("9134d92b-c3a3-4204-95ac-19cf2ea7a8e7"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("916fbf0c-8c38-4a36-8b36-0b2e14f39680"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("91b96c8c-9bce-41fb-9837-9e0abf5f0b3f"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("9295007c-6e7f-490f-9755-f727c2fcee22"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("9397a401-1c23-40a6-80cd-04adb68812d2"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("93e2c306-1585-406e-ab18-808868a58569"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("949c1fc6-2778-4b66-b1cd-461f6a21507b"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("9524fe26-348d-4acc-be0b-ec7cad546e16"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("9e1e2483-a605-476c-87c2-83b83791354e"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("9e8be155-f5c9-42b3-9217-34d82cd1b77e"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("a2a287be-6f11-4e00-a7de-4155e0863424"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("a2c7c20d-675d-421a-9e90-6ef62e71f491"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("a3c73c6d-0d55-4830-9216-0691d8beed31"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("ae27601e-a9c3-4dad-b7f3-ba87adda1cf9"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("b2cfee45-e91b-4b63-8d1d-612a61b434bc"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("b65f0233-b607-4d22-bec4-2c5fa20c117b"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("b7aa2c6c-e53e-4934-bde2-f0b6b7ebda0d"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("b8923173-fabd-4cf9-a562-1167ce9ca97c"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("c26fba8e-8470-4d9c-af53-fb3b2a9e580d"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("c46ba212-dac8-420f-9677-4d6f727cface"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("caf52e6b-1a87-477d-9d56-6f8a5f880d44"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("cbdbbd28-0150-42f3-b051-2eac3bcb60b5"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("ccb46cca-1d63-49dc-a875-f290f9dba551"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("ce47f87e-cf3f-45ba-b0ec-48582229af69"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("cedac1db-850a-49ac-8265-0d9bf0b87b18"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("d141fa5d-329c-4916-84e2-d9d0f9495f10"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("d33ed60b-0d1b-4148-92d0-08f0df3fa555"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("d3dfe82b-595d-4b22-97cd-1f9e14d7d930"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("d8f904dc-cc73-4711-abf8-617d0106a118"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("da8c97ac-c6e6-4864-80b6-e5654b2fbc4b"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("dcae0815-83b9-4825-9f90-a782f8e1dd65"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("e4ffefec-0a6a-4003-93c5-b41e27aa1869"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("e633bf43-0f4b-4f1d-9463-be71b0b735e3"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("e780c42a-f91f-4291-a34d-5b5de8a333e9"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("eb371911-acf1-4620-9555-c99ee364006f"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("eca998e3-2450-4388-ad61-68a5481a19e9"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("ef7d7374-f98d-4aa7-8242-bc4346baf8ab"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("f131937f-a51d-4f2b-8819-e70cc3e8b67a"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("f8818e46-8438-4460-b0c7-f7634ca6f25f"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("fb3a870b-f7a8-4864-9e7f-cd068314c9a1"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("ff93eae9-6922-440b-981f-2bc473d1ac21"));
        }
    }
}
