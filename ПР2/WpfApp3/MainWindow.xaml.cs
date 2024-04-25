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
using System.IO;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
  
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Birthday.SelectedDate == null || Name.Text == "" || Surname.Text == "")
            {
                MessageBox.Show("Ни одно из полей не должно быть пустым!");
                return;
            }
            Person employee = new Person(Name.Text, Surname.Text);
            DateTime dob = Birthday.SelectedDate.Value;
            MessageBox.Show($"Имя: {Person.FirstName}\nФамилия: {Person.LastName}\nВозраст: {employee.Age(dob)}");
        }
    }
}
