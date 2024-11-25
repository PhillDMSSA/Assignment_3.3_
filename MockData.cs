using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Assignment_4._1
{
    internal class MockData
    {
        public static List<Student> Students;

        public static List<Student> CreateData()
        {
            Students = new List<Student>();
            {
                new Student() { StudentId = 1, FirstName = "Kevin", LastName = "Billy", Address = "165 Hickory", Grade = 'B'};
                new Student() { StudentId = 2, FirstName = "Phill", LastName = "Deleon", Address = "955 Bel Aire Dr", Grade = 'A' };
            }
           return Students;
        }
        
    }
}
