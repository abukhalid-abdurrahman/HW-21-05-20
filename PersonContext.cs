using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Task
{
    class PersonContext
    {
        private static string connectionString = "Data Source=localhost;Initial catalog=Faridun;Integrated Security=True";
        public static List<Task.Models.Person> Read()
        {
            List<Task.Models.Person> persons = new List<Task.Models.Person>();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                string sqlQuery = "select * from Person";
                persons = db.Query<Task.Models.Person>(sqlQuery).ToList();
            }
            return persons;
        }

        public static int Create(Task.Models.Person person)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "insert into Person (LastName, FirstName, MiddleName) values(@LastName, @FirstName, @MiddleName); select cast(SCOPE_IDENTITY() as int)";
                int newPersonId = db.Query<int>(sqlQuery, person).FirstOrDefault();
                return newPersonId;
            }
        }
    }
}
