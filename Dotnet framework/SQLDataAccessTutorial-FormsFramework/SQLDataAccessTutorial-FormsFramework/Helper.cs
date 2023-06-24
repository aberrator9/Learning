using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDataAccessTutorial_FormsFramework
{
    public class Helper
    {
        public static string CnnVal(string name) => ConfigurationManager.ConnectionStrings[name].ConnectionString;
    }
}
