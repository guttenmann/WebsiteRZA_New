using WebsiteRZA_New.Models;
using Microsoft.EntityFrameworkCore;

namespace WebsiteRZA_New.Services
{

    public class CustomerService
    {
        private readonly TlS2301206RzaContext _context;
        public CustomerService(TlS2301206RzaContext context)
        {
            _context = context;
        }
    }
}
