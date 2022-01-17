using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savonia_Semester_1
{
    class Class2
    {
        public static string Connection2()
        {
            string ConectionString2 = @" Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Sping_Semester_Database_Login.mdf;Integrated Security = True";
            return ConectionString2;
        }
    }
}
