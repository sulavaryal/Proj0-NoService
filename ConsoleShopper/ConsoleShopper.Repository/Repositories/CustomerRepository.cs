using ConsoleShopper.Domain;
using ConsoleShopper.Repository.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleShopper.Repository
{
    public class CustomerRepository : ICustomerRepository
    {

       
        private readonly ConsoleShopperDbContext _dbContext;
        public ILogger _logger { get; }

        public CustomerRepository(ConsoleShopperDbContext dbContext, ILogger logger )
        {
            
            _dbContext = dbContext;
            _logger = logger;
        }

        #region Get Customer Data (DQL)
        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            return await _dbContext.Customers.Include(x=>x.CustomerAddress).Select(x => x).AsNoTracking().ToListAsync();
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            try
            {
                return await _dbContext.Customers.Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return null;
            }

        }

        public async Task<IEnumerable<Customer>> GetCustomerBySearchStringAsync(string searchString)
        {
            try
            {
                if (!string.IsNullOrEmpty(searchString)) 
                {
                    var result =  await _dbContext.Customers.Where(c => c.LastName.ToLower().Contains(searchString.ToLower()) ||
                        c.FirstName.ToUpper().Contains(searchString.ToLower()))
                    .Select(x => x).AsNoTracking().ToListAsync();
                    return result;

                }
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }
        #endregion

        #region Insert, Update, Delete Data (DML)

        public async Task InsertCustomerAsync(Customer customerToInsert)
        {
            try
            {
               _dbContext.Customers.Add(customerToInsert);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public async Task UpdateCustomerAsync(Customer customerToUpdate)
        {
            try
            {
                _dbContext.Customers.Update(customerToUpdate);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task DeleteCustomerAsync(int id)
        {
            var customerToDelete = await _dbContext.Customers.
                Include(c => c.CustomerAddress)
                .AsNoTracking()
                .FirstOrDefaultAsync(x=>x.Id == id);
            try
            {
               _dbContext.Customers.Remove(customerToDelete);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        #endregion


        public async Task<bool> IsAdmin(string username, string password)
        {
            var customer = await _dbContext.Customers.Where(x => x.FirstName == username &&
            x.Password == password && x.UserTypeId == 1).FirstOrDefaultAsync();

            if (customer != null)
            {
                // Acts as a session holder. 
                SessionHolder.userId = customer.Id;
                return true;
            }
            return false;
        }
    }
}
