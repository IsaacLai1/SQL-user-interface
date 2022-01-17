using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savonia_Semester_1
{
    class Class1
    {
        public static string Connection()
        {
            string ConectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Spring_Semester_Database.mdf;Integrated Security=True";
            return ConectionString;
        }
    }
}
