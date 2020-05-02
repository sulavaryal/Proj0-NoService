using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleShopper.Domain
{
    public class Product
    {
        public Product()
        {
            this.Inventory = new HashSet<InventoryItem>();
        }
        public int Id { get; set; }
        [StringLength(128)]
        public string Name { get; set; }

        public ICollection<InventoryItem> Inventory{get;set;}
    }
}