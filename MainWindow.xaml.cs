using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment_4._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
            


           
            
        }
       
        private void LoadData()
        {
            var student = new List<Student>
            {
                new Student() { StudentId = 1, FirstName = "Kevin", LastName = "Billy", Address = "165 Hickory", Grade = 'B' },
                new Student() { StudentId = 2, FirstName = "Phill", LastName = "Deleon", Address = "955 Bel Aire Dr", Grade = 'A' }
            };
            studentData.ItemsSource = student;
            
        }
    }
}
        
    
