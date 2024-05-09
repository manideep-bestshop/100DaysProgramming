using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperWebAPIStoredProcedure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerRepository _customerRepository;
        public CustomerController()
        {
            string connectionString = "Server=.;database=CommonDb;integrated security=True;TrustServerCertificate=True;";
            _customerRepository = new CustomerRepository(connectionString);
        }
        public IEnumerable<Customer> GetCustomers()
        {
            var customers = _customerRepository.GetCustomers();
            return customers;
        }
    }
}
