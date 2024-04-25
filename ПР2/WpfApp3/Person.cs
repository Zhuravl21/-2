using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp3
{
    internal class Person

    {

        public Person(String Name, String Surname) { 
            FirstName = Name;
            LastName = Surname;
        }
        private static String Name1;
        private static String Name2;
        public static String FirstName { get { return Name1; } set { Name1 = value; } }
        public static String LastName { get { return Name2; } set { Name2 = value; } }

        public int Age(DateTime Birthday)
        {
            TimeSpan difference = DateTime.Now.Subtract(Birthday);
            double years = difference.TotalDays / 365.25;
            return (int)years;
        }
    }
}
