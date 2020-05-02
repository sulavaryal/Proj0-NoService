using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleShopper.Domain
{
    public class InventoryItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public int LoggedUserId { get; set; }
        public DateTimeOffset? Changeddate { get; set; }
     
    }
}
