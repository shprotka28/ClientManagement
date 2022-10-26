using System.ComponentModel.DataAnnotations.Schema;

namespace ClientManagement.Models
{
    public class Email
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; set; }

    }
}
