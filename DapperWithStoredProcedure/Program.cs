using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DapperWithStoredProcedure
{
    public class Customer
    {
        public string Id { get; set; }  
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
    public class  CustomerRepository
    {
        private readonly string _connectionString;

        public CustomerRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Customer> GetCustomers(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // return connection.Query<Customer>("GetCustomers", commandType: CommandType.StoredProcedure);
                // return connection.Query<Customer>("Select * from Customer");
                var parameter = new {Id = id};
                return connection.Query<Customer>("GetCustomerById", parameter, commandType: CommandType.StoredProcedure);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Customer Id");
            int id = int.Parse(Console.ReadLine());
            var connectionString = "Server=.;database=CommonDb;integrated security=True;TrustServerCertificate=True;";
            var repository = new CustomerRepository(connectionString);
            var customers = repository.GetCustomers(id);
            int count = customers.Count();
            if(count ==0)
                Console.WriteLine("Id not found..");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Id: {customer.Id}, Name: {customer.Name}, Phone:{customer.Phone},Address: {customer.Address}");
            }
        }
    }
}
