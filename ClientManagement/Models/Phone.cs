using System.ComponentModel.DataAnnotations.Schema;

namespace ClientManagement.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public int CustomerId { get; set; }

    }
}
