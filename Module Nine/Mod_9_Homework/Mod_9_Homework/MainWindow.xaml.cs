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

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students { get; set; }
        int index = -1;
        public MainWindow()
        {
            InitializeComponent();
            students = new List<Student>();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            string firstName, lastName, city;
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            city = txtCity.Text;
            Student newStudent = new Student(firstName, lastName, city);
            students.Add(newStudent);
            string message = "Student " + firstName + " " + lastName + " Has been created, amount of registered students " + students.Count;
            MessageBox.Show(message);
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            index++;
            if (students.Count == 0)
            {
                MessageBox.Show("There are no students registered.");
                return;
            }
            if(index >= students.Count)
            {
                index = 0;
            }
            txtFirstName.Text = students[index].mFirstName;
            txtLastName.Text = students[index].mLastName;
            txtCity.Text = students[index].mCity;
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            index--;
            if (students.Count == 0)
            {
                MessageBox.Show("There are no students registered.");
                return;
            }
            if (index < 0)
            {
                index = (students.Count-1);
            }
            txtFirstName.Text = students[index].mFirstName;
            txtLastName.Text = students[index].mLastName;
            txtCity.Text = students[index].mCity;
        }
    }
}
