using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Assignment_4._1
{
    public class MockData
    {
        public ObservableCollection<Student> Students { get; set; }

       public void AddStudent(string FirstName, string LastnName, string Address, char Grade)
        {
            Students.Add(new Student { FirstName = "Jake", LastName = "StateFarm", Address = "321 Old West Ln", Grade = 'C'});
        }
        
        
    }
}
