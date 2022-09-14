using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Student st = new Student()
        {
            Id = 1,
            Name = "Long"
        };

        List<Student> students = new List<Student>()
        {
            new Student() { Id = 2, Name = "Long", Major = new Major() { Id = 1, Name = "SE" } },
            new Student() { Id = 3, Name = "Diep", Major = new Major() { Id = 2, Name = "GD" } }
        };

        public MainWindow()
        {
            InitializeComponent();
            DataContext = st;
            lvStudent.ItemsSource = students;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(st.Id + " " + st.Name);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Edit done!");
        }
    }
}
