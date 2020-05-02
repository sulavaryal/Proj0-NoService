using ConsoleShopper.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShopper.Repository.IRepositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<InventoryItem>> GetAllProductsAsync();
        Task<IEnumerable<InventoryItem>> GetProductsBySearchStringAsync(string searchString);
        Task<InventoryItem> GetProductByIdAsync(int id);
        Task CreateProductAsync(InventoryItem inventoryItemToCreate);
        Task UpdateProductAsync(InventoryItem inventoryItemToUpdate);
        Task DeleteProductAsync(InventoryItem inventoryItemToDelete);
    }
}