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
            // Seed UserType data
            modelBuilder.Entity<UserType>().HasData(
                new UserType { Id = 1, Type = "Admin" },
                new UserType { Id = 2, Type = "Customer" }
                );
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
        }
    }
}
