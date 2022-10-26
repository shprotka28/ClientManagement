using Microsoft.AspNetCore.Mvc;
using ClientManagement.Data;
using ClientManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Web;
using System.Collections.Generic;


namespace ClientManagement.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ClientManagmentDbContext _context;
        public CustomersController (ClientManagmentDbContext context) => _context = context;
        public async Task<IActionResult> Index()
        {
            GeneralViewModel generalViewModel = new GeneralViewModel();
            generalViewModel.NationalityID = _context.Customers.Select(cust => cust.NationalityID).ToString();
            generalViewModel.FirstName = _context.Customers.Select(cust => cust.FirstName).ToString();
            generalViewModel.LastName = _context.Customers.Select(cust => cust.LastName).ToString();
            generalViewModel.EGN = _context.Customers.Select(cust => cust.EGN).ToString();
            generalViewModel.EmailAddresses = (IEnumerable<string>)_context.Customers.Select(cust => cust.Emails).ToList();
            generalViewModel.Phones = (IEnumerable<string>)_context.Customers.Select(cust => cust.PhoneNumbers).ToList();
            generalViewModel.DateOfBirth = _context.Customers.Select(cust => cust.DateOfBirth).ToString();
            generalViewModel.Addresses = (IEnumerable<List<string>>)_context.Customers.Select(cust => cust.Adresses);

            return View(generalViewModel);

            //var customers = _context.Customers.Join(_context.Emails,
            //    customer => customer.ID,
            //    email => email.CustomerId,
            //    (customer, email) => new
            //    {
            //        customer.NationalityID,
            //        customer.FirstName,
            //        customer.LastName,
            //        customer.EGN,
            //        email.EmailAddress
            //    });

            //return View(await customers.ToListAsync());
        }
        public async Task<IActionResult> Index(List<IFormFile> files)
        {
            var size = files.Sum(f => f.Length);
            var filePaths = new List<string>();
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    var filePath = Path.Combine((Directory.GetCurrentDirectory() + "/UPLOADS/TOBEVALIDATED"), formFile.FileName);
                    filePaths.Add(filePath);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }
            return Ok(new { files.Count, size, filePaths });
        }

    }
}

