using ConsoleShopper.Domain;
using ConsoleShopper.Repository.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Xunit;

namespace ConsoleShopper.Tests
{
    public class CustomerCRUDTests
    {
        
        [Fact]
        public void AddsPlayerToDb()
        {
            
            //Arrange - create an object to configure your inmemory DB.
            var options = new DbContextOptionsBuilder<ConsoleShopperDbContext>()
                .UseInMemoryDatabase(databaseName: "AddsCustomerToDb")
                .Options;


            //Act - send in the configure object to the DbContext constructor to be used in configuring the DbContext
            using (var db = new ConsoleShopperDbContext(options))
            {
                Customer customer = new Customer { Id = 6, FirstName = "Maribeth", LastName = "Fontenot", Password = "password", UserTypeId = 2 };
                db.Add(customer);
                db.SaveChanges();
            }

            //Assert
            using (var context = new ConsoleShopperDbContext(options)) 
            {
                Assert.Equal(1, context.Customers.Count());
                var customer1 = context.Customers.Where(x => x.FirstName == "Maribeth").FirstOrDefault();
                Assert.Equal("Maribeth", customer1.FirstName);
            }
        }
    }
}
