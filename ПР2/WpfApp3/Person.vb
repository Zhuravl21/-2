using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    class Person
    {
        Private String Name1;
        Private String Name2;

        Public String FirstName
        {
            Get { Return Name1; }
            Set { Name1 = value; }
        }

        Public String LastName
        {
            Get { Return Name2; }
            Set { Name2 = value; }
        }

        Public int Age(DateTime Birthday){
            TimeSpan difference = DateTime.Now.Subtract(Birthday);
            Return (int)difference.TotalDays / 365.25;
    }
}

