using System.Linq;

namespace ClientManagement.Models
{
    public class GeneralViewModel
    {
        private Customer customer;
        private Email email;
        private Phone phone;
        private Address address;

        public string NationalityID
        {
            set { customer.NationalityID = value; }
            get { return customer.NationalityID; }
        }
        public string FirstName 
        {
            set { customer.FirstName = value; }
            get { return customer.FirstName; }
        }
        public string LastName 
        {
            set { customer.LastName = value; }
            get { return customer.LastName; }
        }
        public string EGN 
        {
            set { customer.EGN = value; }
            get { return customer.EGN; }
        }
        public IEnumerable<string> EmailAddresses
        {
            set
            {
                var emailAddresses = customer.Emails.Select(e => email.EmailAddress);
                emailAddresses = value.ToList();
            }
            get { return customer.Emails.Select(e => email.EmailAddress); }
        }
        public IEnumerable<string> Phones
        {
            set 
            {
                var phoneNumbers = customer.PhoneNumbers.Select(pn => pn.PhoneNumber);
                phoneNumbers = value.ToList();
            }
            get { return customer.PhoneNumbers.Select(pn => pn.PhoneNumber); }
        }

        public string DateOfBirth 
        {
            set { customer.DateOfBirth = value; }
            get { return customer.DateOfBirth; }
        }

        public IEnumerable<List<string>> Addresses
        {
            set
            {
                var addresses = (IEnumerable<List<string>>)customer.Adresses.Select(a => new { a.CountryCode, a.City, a.AddressLine });
                addresses = value.ToList();
            }
            get { return (IEnumerable<List<string>>)customer.Adresses.Select(a => new { a.CountryCode, a.City, a.AddressLine }); }
        }

    }
}
