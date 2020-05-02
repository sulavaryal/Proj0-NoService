using System.ComponentModel.DataAnnotations;

namespace ConsoleShopper.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(128)]
        public string FirstName { get; set; }
        [StringLength(128)]
        public string LastName { get; set; }
        [StringLength(128)]
        public string Email { get; set; }
        [StringLength(128)]
        public string PhoneNo { get; set; }

        [StringLength(128)]
        public string Password { get; set; }

        public CustomerAddress CustomerAddress { get; set; }

        public int UserTypeId { get; set; }
        public UserType UserType { get; set; }

        public override string ToString()
        {
            return $"Customer Details : \nId: {Id} \nFirst Name: {FirstName} \nLast Name: {LastName}";
        }
    }
}
