using Dapper1.Entities;
using Dapper1.Repositories;
using Microsoft.Extensions.Options;

namespace Dapper1.Services
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _emplEmployeeRepository;
        private readonly ConnectionString _connectionString;

        public EmployeeService(IOptions<ConnectionString> connectionString)
        {
            _connectionString = connectionString.Value;
            _emplEmployeeRepository = new EmployeeRepository(_connectionString.MySqlConnection);
        }

        public Employee GetEmployeeById(int id)
        {
            var employee = _emplEmployeeRepository.GetEmployeeById(id);
            if(employee == null)
            {
                return null;
            }

            return employee;
        }
    }
}
