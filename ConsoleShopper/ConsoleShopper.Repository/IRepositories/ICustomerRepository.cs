using ConsoleShopper.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleShopper.Repository
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomersAsync();
        Task<IEnumerable<Customer>> GetCustomerBySearchStringAsync(string searchString);
        Task<Customer> GetCustomerByIdAsync(int id);
        Task InsertCustomerAsync(Customer customerToInsert);
        Task UpdateCustomerAsync(Customer customerToUpdate);
        Task DeleteCustomerAsync(int id);
        Task<bool> IsAdmin(string username, string password);
    }
}