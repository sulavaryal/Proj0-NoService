using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleShopper.Repository.DataAccess.CSMigration
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StoreLocations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 128, nullable: true),
                    LastName = table.Column<string>(maxLength: 128, nullable: true),
                    Email = table.Column<string>(maxLength: 128, nullable: true),
                    PhoneNo = table.Column<string>(maxLength: 128, nullable: true),
                    Password = table.Column<string>(maxLength: 128, nullable: true),
                    UserTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_UserTypes_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "UserTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(maxLength: 128, nullable: true),
                    City = table.Column<string>(maxLength: 128, nullable: true),
                    State = table.Column<string>(maxLength: 128, nullable: true),
                    Zip = table.Column<string>(maxLength: 128, nullable: true),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerAddress_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    StoreLocationId = table.Column<int>(nullable: false),
                    OrderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_StoreLocations_StoreLocationId",
                        column: x => x.StoreLocationId,
                        principalTable: "StoreLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UserTypes",
                columns: new[] { "Id", "Type" },
                values: new object[] { 1, "Admin" });

            migrationBuilder.InsertData(
                table: "UserTypes",
                columns: new[] { "Id", "Type" },
                values: new object[] { 2, "Customer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "PhoneNo", "UserTypeId" },
                values: new object[,]
                {
                    { 1, null, "Sulav", "Aryal", "password", null, 1 },
                    { 18, null, "Althea", "Dent", "password", null, 2 },
                    { 17, null, "Susy", "Argo", "password", null, 2 },
                    { 16, null, "Mireya", "Pierro", "password", null, 2 },
                    { 15, null, "Hans", "Spurgin", "password", null, 2 },
                    { 14, null, "Moises", "Meche", "password", null, 2 },
                    { 13, null, "Taneka", "Ord", "password", null, 2 },
                    { 12, null, "Gigi", "Degree", "password", null, 2 },
                    { 11, null, "Lucilla", "Chang", "password", null, 2 },
                    { 10, null, "Beverley", "Digangi", "password", null, 2 },
                    { 9, null, "Mirian", "Stroda", "password", null, 2 },
                    { 8, null, "Jeana", "Dunston", "password", null, 2 },
                    { 7, null, "Barret", "Waltrip", "password", null, 2 },
                    { 6, null, "Maribeth", "Fontenot", "password", null, 2 },
                    { 5, null, "Kenneth", "Windsor", "password", null, 2 },
                    { 4, null, "Bettie", "Turek", "password", null, 2 },
                    { 3, null, "Brigitte", "Laufer", "password", null, 2 },
                    { 2, null, "Danyelle", "Tsosie", "password", null, 2 },
                    { 19, null, "Rosana", "Purvis", "password", null, 2 },
                    { 20, null, "Serena", "San", "password", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "CustomerAddress",
                columns: new[] { "Id", "City", "CustomerId", "State", "Street", "Zip" },
                values: new object[,]
                {
                    { 3, "Fort Worth", 1, "TX", "96 Franklin Ave.", "76110" },
                    { 18, "Eastpointe", 18, "MI", "58 Fifth St.", "48021" },
                    { 17, "Canandaigua", 17, "NY", "206 New Saddle Ave.", "14424" },
                    { 16, "Manahawkin", 16, "NJ", "290 Marsh St. ", "08050" },
                    { 15, "Lancaster", 15, "NY", "41 Buckingham Ave", "14086" },
                    { 14, "Meadow", 14, "NJ", "48 W. Oak St.", "08003" },
                    { 13, "Huntington", 13, "NY", "467 South Smoky Hollow St", "11743" },
                    { 12, "Munster", 12, "IN", "265 Prairie St.", "46321" },
                    { 11, "Wenatchee", 11, "WA", "3 Myers Street", "98801" },
                    { 10, "Green Cove Springs", 10, "FL", "89 North Devonshire Dr", "32043" },
                    { 9, "Roseville", 9, "MI", "84 Woodsman St.", "48066" },
                    { 8, "West Palm Beach", 8, "FL", "37 Pilgrim Lane", "33404" },
                    { 7, "Missoula", 7, "MT", "580 West Deerfield Road", "59801" },
                    { 1, "Aberdeen", 6, "SD", "67 Carriage Drive", "57401" },
                    { 6, "Belleville", 5, "NJ", "6 College St.", "07109" },
                    { 5, "Gastonia", 4, "NC", "7518 Sherwood Street", "28052" },
                    { 4, "Maplewood", 3, "NJ", "752 South Main Drive", "07040" },
                    { 2, "Green Bay", 2, "WI", "17 Johnson Street", "54302" },
                    { 19, "Saint Augustine", 19, "FL", "2 State St.", "32084" },
                    { 20, "Cedar Rapids", 20, "AZ", "8471 East Brandywine Street", "52402" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_CustomerId",
                table: "CustomerAddress",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserTypeId",
                table: "Customers",
                column: "UserTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderID",
                table: "Products",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StoreLocationId",
                table: "Products",
                column: "StoreLocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerAddress");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "StoreLocations");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "UserTypes");
        }
    }
}
