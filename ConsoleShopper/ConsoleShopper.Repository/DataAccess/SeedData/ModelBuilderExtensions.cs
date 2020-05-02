using ConsoleShopper.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleShopper.Repository.DataAccess
{
  
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region UserType Seed
            // Seed UserType data
            modelBuilder.Entity<UserType>().HasData(
                new UserType { Id = 1, Type = "Admin" },
                new UserType { Id = 2, Type = "Customer" }
                );
            #endregion

            #region CustomerAddress Seed
            modelBuilder.Entity<CustomerAddress>().HasData(
                new CustomerAddress { Id = 3, Street = "96 Franklin Ave.", City = "Fort Worth", State = "TX", Zip = "76110", CustomerId = 1 },
                new CustomerAddress { Id = 2, Street = "17 Johnson Street", City = "Green Bay", State = "WI", Zip = "54302", CustomerId = 2 },
                new CustomerAddress { Id = 4, Street = "752 South Main Drive", City = "Maplewood", State = "NJ", Zip = "07040", CustomerId = 3 },
                new CustomerAddress { Id = 5, Street = "7518 Sherwood Street", City = "Gastonia", State = "NC", Zip = "28052", CustomerId = 4 },
                new CustomerAddress { Id = 6, Street = "6 College St.", City = "Belleville", State = "NJ", Zip = "07109", CustomerId = 5 },
                new CustomerAddress { Id = 1, Street = "67 Carriage Drive", City = "Aberdeen", State = "SD", Zip = "57401", CustomerId = 6 },
                new CustomerAddress { Id = 7, Street = "580 West Deerfield Road", City = "Missoula", State = "MT", Zip = "59801", CustomerId = 7 },
                new CustomerAddress { Id = 8, Street = "37 Pilgrim Lane", City = "West Palm Beach", State = "FL", Zip = "33404", CustomerId = 8 },
                new CustomerAddress { Id = 9, Street = "84 Woodsman St.", City = "Roseville", State = "MI", Zip = "48066", CustomerId = 9 },
                new CustomerAddress { Id = 10, Street = "89 North Devonshire Dr", City = "Green Cove Springs", State = "FL", Zip = "32043", CustomerId = 10 },
                new CustomerAddress { Id = 11, Street = "3 Myers Street", City = "Wenatchee", State = "WA", Zip = "98801", CustomerId = 11 },
                new CustomerAddress { Id = 12, Street = "265 Prairie St.", City = "Munster", State = "IN", Zip = "46321", CustomerId = 12 },
                new CustomerAddress { Id = 13, Street = "467 South Smoky Hollow St", City = "Huntington", State = "NY", Zip = "11743", CustomerId = 13 },
                new CustomerAddress { Id = 14, Street = "48 W. Oak St.", City = "Meadow", State = "NJ", Zip = "08003", CustomerId = 14 },
                new CustomerAddress { Id = 15, Street = "41 Buckingham Ave", City = "Lancaster", State = "NY", Zip = "14086", CustomerId = 15 },
                new CustomerAddress { Id = 16, Street = "290 Marsh St. ", City = "Manahawkin", State = "NJ", Zip = "08050", CustomerId = 16 },
                new CustomerAddress { Id = 17, Street = "206 New Saddle Ave.", City = "Canandaigua", State = "NY", Zip = "14424", CustomerId = 17 },
                new CustomerAddress { Id = 18, Street = "58 Fifth St.", City = "Eastpointe", State = "MI", Zip = "48021", CustomerId = 18 },
                new CustomerAddress { Id = 19, Street = "2 State St.", City = "Saint Augustine", State = "FL", Zip = "32084", CustomerId = 19 },
                new CustomerAddress { Id = 20, Street = "8471 East Brandywine Street", City = "Cedar Rapids", State = "AZ", Zip = "52402", CustomerId = 20 }
                );
            #endregion

            #region Customer Seed
            // Seed Customer data
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, FirstName = "Sulav", LastName = "Aryal", Password = "password", UserTypeId = 1},
                new Customer { Id = 2, FirstName = "Danyelle", LastName = "Tsosie", Password = "password", UserTypeId = 2 },
                new Customer { Id = 3, FirstName = "Brigitte", LastName = "Laufer", Password = "password", UserTypeId = 2 },
                new Customer { Id = 4, FirstName = "Bettie", LastName = "Turek", Password = "password", UserTypeId = 2 },
                new Customer { Id = 5, FirstName = "Kenneth", LastName = "Windsor", Password = "password", UserTypeId = 2 },
                new Customer { Id = 6, FirstName = "Maribeth", LastName = "Fontenot", Password = "password", UserTypeId = 2 },
                new Customer { Id = 7, FirstName = "Barret", LastName = "Waltrip", Password = "password", UserTypeId = 2 },
                new Customer { Id = 8, FirstName = "Jeana", LastName = "Dunston", Password = "password", UserTypeId = 2 },
                new Customer { Id = 9, FirstName = "Mirian", LastName = "Stroda", Password = "password", UserTypeId = 2 },
                new Customer { Id = 10, FirstName = "Beverley", LastName = "Digangi", Password = "password", UserTypeId = 2 },
                new Customer { Id = 11, FirstName = "Lucilla", LastName = "Chang", Password = "password", UserTypeId = 2 },
                new Customer { Id = 12, FirstName = "Gigi", LastName = "Degree", Password = "password", UserTypeId = 2 },
                new Customer { Id = 13, FirstName = "Taneka", LastName = "Ord", Password = "password", UserTypeId = 2 },
                new Customer { Id = 14, FirstName = "Moises", LastName = "Meche", Password = "password", UserTypeId = 2 },
                new Customer { Id = 15, FirstName = "Hans", LastName = "Spurgin", Password = "password", UserTypeId = 2 },
                new Customer { Id = 16, FirstName = "Mireya", LastName = "Pierro", Password = "password", UserTypeId = 2 },
                new Customer { Id = 17, FirstName = "Susy", LastName = "Argo", Password = "password", UserTypeId = 2 },
                new Customer { Id = 18, FirstName = "Althea", LastName = "Dent", Password = "password", UserTypeId = 2 },
                new Customer { Id = 19, FirstName = "Rosana", LastName = "Purvis", Password = "password", UserTypeId = 2 },
                new Customer { Id = 20, FirstName = "Serena", LastName = "San", Password = "password", UserTypeId = 2 }
            );
            #endregion

            #region Products Seed
            // Seed Product Names
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Bass Guitar" },
                new Product { Id = 2, Name = "Piano" },
                new Product { Id = 3, Name = "Acoustic Guitar" },
                new Product { Id = 4, Name = "Bamboo Flute" },
                new Product { Id = 5, Name = "Accordion" },
                new Product { Id = 6, Name = "Piccolo" },
                new Product { Id = 7, Name = "Trombone" },
                new Product { Id = 8, Name = "Violin" },
                new Product { Id = 9, Name = "Guitar" },
                new Product { Id = 10, Name = "Bagpipes" },
                new Product { Id = 11, Name = "Ukulele" },
                new Product { Id = 12, Name = "Saxophone" },
                new Product { Id = 13, Name = "Kazoo" },
                new Product { Id = 14, Name = "Zither" },
                new Product { Id = 15, Name = "Banjo" },
                new Product { Id = 16, Name = "Oboe" },
                new Product { Id = 17, Name = "Wooden Flute" },
                new Product { Id = 18, Name = "Recorder" },
                new Product { Id = 19, Name = "Snare Drum" },
                new Product { Id = 20, Name = "Spoons" }
              );
            #endregion

            #region Store Seed
            modelBuilder.Entity<Store>().HasData(
                new Store { Id = 1, Name = "Florida" },
                new Store { Id = 2, Name = "New York" },
                new Store { Id = 3, Name = "Texas" },
                new Store { Id = 4, Name = "Washington" },
                new Store { Id = 5, Name = "California" }
               
            );
            #endregion

            #region Inventory Seed
            modelBuilder.Entity<InventoryItem>().HasData(
                new InventoryItem { Id = 1, StoreId = 1, ProductId = 1, Quantity = 20, Price = 150.55M, LoggedUserId = 1, Changeddate = DateTime.Now.ToLocalTime() },
                new InventoryItem { Id = 2, StoreId = 2, ProductId = 2, Quantity = 20, Price = 250.55M, LoggedUserId = 1, Changeddate = DateTime.Now.ToLocalTime() },
                new InventoryItem { Id = 3, StoreId = 3, ProductId = 3, Quantity = 20, Price = 350.55M, LoggedUserId = 1, Changeddate = DateTime.Now.ToLocalTime() },
                new InventoryItem { Id = 4, StoreId = 4, ProductId = 4, Quantity = 20, Price = 150.55M, LoggedUserId = 1, Changeddate = DateTime.Now.ToLocalTime() },
                new InventoryItem { Id = 5, StoreId = 5, ProductId = 5, Quantity = 20, Price = 250.55M, LoggedUserId = 1, Changeddate = DateTime.Now.ToLocalTime() },
                new InventoryItem { Id = 6, StoreId = 1, ProductId = 6, Quantity = 20, Price = 350.55M, LoggedUserId = 1, Changeddate = DateTime.Now.ToLocalTime() },
                new InventoryItem { Id = 7, StoreId = 2, ProductId = 7, Quantity = 20, Price = 150.55M, LoggedUserId = 1, Changeddate = DateTime.Now.ToLocalTime() },
                new InventoryItem { Id = 8, StoreId = 3, ProductId = 8, Quantity = 20, Price = 250.55M, LoggedUserId = 1, Changeddate = DateTime.Now.ToLocalTime() },
                new InventoryItem { Id = 9, StoreId = 4, ProductId = 9, Quantity = 20, Price = 350.55M, LoggedUserId = 1, Changeddate = DateTime.Now.ToLocalTime() },
                new InventoryItem { Id = 10, StoreId = 5, ProductId = 10, Quantity = 20, Price = 150.55M, LoggedUserId = 1, Changeddate = DateTime.Now.ToLocalTime() },
                new InventoryItem { Id = 11, StoreId = 1, ProductId = 11, Quantity = 20, Price = 250.55M, LoggedUserId = 1, Changeddate = DateTime.Now.ToLocalTime() },
                new InventoryItem { Id = 12, StoreId = 2, ProductId = 12, Quantity = 20, Price = 350.55M, LoggedUserId = 1, Changeddate = DateTime.Now.ToLocalTime() },
                new InventoryItem { Id = 13, StoreId = 3, ProductId = 13, Quantity = 20, Price = 150.55M, LoggedUserId = 1, Changeddate = DateTime.Now.ToLocalTime() },
                new InventoryItem { Id = 14, StoreId = 4, ProductId = 14, Quantity = 20, Price = 250.55M, LoggedUserId = 1, Changeddate = DateTime.Now.ToLocalTime() },
                new InventoryItem { Id = 15, StoreId = 5, ProductId = 15, Quantity = 20, Price = 350.55M, LoggedUserId = 1, Changeddate = DateTime.Now.ToLocalTime() },
                new InventoryItem { Id = 16, StoreId = 1, ProductId = 16, Quantity = 20, Price = 150.55M, LoggedUserId = 1, Changeddate = DateTime.Now.ToLocalTime() },
                new InventoryItem { Id = 17, StoreId = 2, ProductId = 17, Quantity = 20, Price = 250.55M, LoggedUserId = 1, Changeddate = DateTime.Now.ToLocalTime() },
                new InventoryItem { Id = 18, StoreId = 3, ProductId = 18, Quantity = 20, Price = 350.55M, LoggedUserId = 1, Changeddate = DateTime.Now.ToLocalTime() },
                new InventoryItem { Id = 19, StoreId = 4, ProductId = 19, Quantity = 20, Price = 150.55M, LoggedUserId = 1, Changeddate = DateTime.Now.ToLocalTime() },
                new InventoryItem { Id = 20, StoreId = 5, ProductId = 20, Quantity = 20, Price = 250.55M, LoggedUserId = 1, Changeddate = DateTime.Now.ToLocalTime() }
                );
            #endregion
        }
    }
}
