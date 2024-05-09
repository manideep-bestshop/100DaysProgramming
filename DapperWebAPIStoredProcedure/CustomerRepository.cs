using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace DapperWebAPIStoredProcedure
{
    public class CustomerRepository
    {
        private readonly string _connectionString;
        public CustomerRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IEnumerable<Customer> GetCustomers()
        {
            using(SqlConnection db=new SqlConnection(_connectionString))
            {
                return db.Query<Customer>("GetCustomers", commandType: CommandType.StoredProcedure);
            }
        }
    }
}
