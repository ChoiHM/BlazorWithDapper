using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace BlazorDapper.Core
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString = string.Empty;
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IDbConnection CreateConnection()
            => new MySqlConnection(_connectionString);
    }
}
