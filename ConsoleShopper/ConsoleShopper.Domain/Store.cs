using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleShopper.Domain
{
    public class Store
    {
        public int Id { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
    }
}
