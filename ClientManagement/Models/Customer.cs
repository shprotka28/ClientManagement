using System.ComponentModel.DataAnnotations.Schema;

namespace ClientManagement.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string NationalityID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EGN { get; set; }
        public ICollection<Email> Emails { get; set; }
        public ICollection<Phone> PhoneNumbers { get; set; }
        public string DateOfBirth { get; set; }
        public ICollection<Address> Adresses { get; set; }


    }
}
