using Dapper1.Entities;
using Dapper;
using Dapper.Contrib.Extensions;


namespace Dapper1.Repositories
{
    public class EmployeeRepository : BaseSqlRepository
    {
        public EmployeeRepository(string connectionString) : base(connectionString)
        {
        }
        public Employee AddEmployee(Employee newEmployee)
        {
            var conn = OpenSqlConnection();
            conn.Insert(newEmployee);

            conn.Close();
            return newEmployee;
        }
        public Employee GetEmployeeById(int id)
        {
            var conn = OpenSqlConnection();
            var emp = conn.QuerySingleOrDefault<Employee>("select * from Employees where Id=@id", new
            {
                id=id
            });
            conn.Close();
            return emp;
        }
    }
}
