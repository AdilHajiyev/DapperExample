using Microsoft.Data.SqlClient;

namespace Dapper1.Repositories
{
    public class BaseSqlRepository

    {
        private readonly string _connectionString;
        public BaseSqlRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        public Microsoft.Data.SqlClient.SqlConnection OpenSqlConnection()
        {
            try
            {
                var connection = new SqlConnection(_connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occurred while opening a SQL connection.", ex);
            }
        }
    }
}
