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
                    FirstName = table.Column<string>(maxLength: 255, nullable: true),
                    LastName = table.Column<string>(maxLength: 255, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNo = table.Column<string>(nullable: true),
                    Password = table.Column<string>(maxLength: 16, nullable: true),
                    Address = table.Column<string>(maxLength: 255, nullable: true),
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
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "Password", "PhoneNo", "UserTypeId" },
                values: new object[,]
                {
                    { 1, null, null, "Sulav", "Aryal", "password", null, 1 },
                    { 18, null, null, "Althea", "Dent", "password", null, 2 },
                    { 17, null, null, "Susy", "Argo", "password", null, 2 },
                    { 16, null, null, "Mireya", "Pierro", "password", null, 2 },
                    { 15, null, null, "Hans", "Spurgin", "password", null, 2 },
                    { 14, null, null, "Moises", "Meche", "password", null, 2 },
                    { 13, null, null, "Taneka", "Ord", "password", null, 2 },
                    { 12, null, null, "Gigi", "Degree", "password", null, 2 },
                    { 11, null, null, "Lucilla", "Chang", "password", null, 2 },
                    { 10, null, null, "Beverley", "Digangi", "password", null, 2 },
                    { 9, null, null, "Mirian", "Stroda", "password", null, 2 },
                    { 8, null, null, "Jeana", "Dunston", "password", null, 2 },
                    { 7, null, null, "Barret", "Waltrip", "password", null, 2 },
                    { 6, null, null, "Maribeth", "Fontenot", "password", null, 2 },
                    { 5, null, null, "Kenneth", "Windsor", "password", null, 2 },
                    { 4, null, null, "Bettie", "Turek", "password", null, 2 },
                    { 3, null, null, "Brigitte", "Laufer", "password", null, 2 },
                    { 2, null, null, "Danyelle", "Tsosie", "password", null, 2 },
                    { 19, null, null, "Rosana", "Purvis", "password", null, 2 },
                    { 20, null, null, "Serena", "San", "password", null, 2 }
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
