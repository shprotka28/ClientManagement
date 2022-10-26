using System.ComponentModel.DataAnnotations.Schema;

namespace ClientManagement.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string City { get; set; }
        public string AddressLine { get; set; }
        public int CustomerId { get; set; }

    }
}
