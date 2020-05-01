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
                    State = table.Column<string>(maxLength: 128, nullable: true),
                    City = table.Column<string>(maxLength: 128, nullable: true),
                    Street = table.Column<string>(maxLength: 128, nullable: true),
                    ApartmentNo = table.Column<string>(maxLength: 128, nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
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
                columns: new[] { "Id", "ApartmentNo", "City", "Email", "FirstName", "LastName", "Password", "PhoneNo", "State", "Street", "UserTypeId", "ZipCode" },
                values: new object[,]
                {
                    { 1, null, null, null, "Sulav", "Aryal", "password", null, null, null, 1, null },
                    { 18, null, null, null, "Althea", "Dent", "password", null, null, null, 2, null },
                    { 17, null, null, null, "Susy", "Argo", "password", null, null, null, 2, null },
                    { 16, null, null, null, "Mireya", "Pierro", "password", null, null, null, 2, null },
                    { 15, null, null, null, "Hans", "Spurgin", "password", null, null, null, 2, null },
                    { 14, null, null, null, "Moises", "Meche", "password", null, null, null, 2, null },
                    { 13, null, null, null, "Taneka", "Ord", "password", null, null, null, 2, null },
                    { 12, null, null, null, "Gigi", "Degree", "password", null, null, null, 2, null },
                    { 11, null, null, null, "Lucilla", "Chang", "password", null, null, null, 2, null },
                    { 10, null, null, null, "Beverley", "Digangi", "password", null, null, null, 2, null },
                    { 9, null, null, null, "Mirian", "Stroda", "password", null, null, null, 2, null },
                    { 8, null, null, null, "Jeana", "Dunston", "password", null, null, null, 2, null },
                    { 7, null, null, null, "Barret", "Waltrip", "password", null, null, null, 2, null },
                    { 6, null, null, null, "Maribeth", "Fontenot", "password", null, null, null, 2, null },
                    { 5, null, null, null, "Kenneth", "Windsor", "password", null, null, null, 2, null },
                    { 4, null, null, null, "Bettie", "Turek", "password", null, null, null, 2, null },
                    { 3, null, null, null, "Brigitte", "Laufer", "password", null, null, null, 2, null },
                    { 2, null, null, null, "Danyelle", "Tsosie", "password", null, null, null, 2, null },
                    { 19, null, null, null, "Rosana", "Purvis", "password", null, null, null, 2, null },
                    { 20, null, null, null, "Serena", "San", "password", null, null, null, 2, null }
                });

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
