using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleShopper.Domain
{
    public class CustomerAddress
    {
        public int Id { get; set; }
        [StringLength(128)]
        public string Street { get; set; }
        [StringLength(128)]
        public string City { get; set; }
        [StringLength(128)]
        public string  State { get; set; }
        [StringLength(128)]
        public string Zip { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
