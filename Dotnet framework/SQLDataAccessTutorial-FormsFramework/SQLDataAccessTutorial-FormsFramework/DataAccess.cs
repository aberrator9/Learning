using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SQLDataAccessTutorial_FormsFramework
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Sample")))
            {
                return connection.Query<Person>($"SELECT * FROM dbo.People WHERE LastName = '{lastName}'").ToList();
            }
        }
    }
}
