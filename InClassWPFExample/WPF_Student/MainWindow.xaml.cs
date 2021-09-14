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

namespace WPF_Student
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string id, first, last, probation, gpa, bursar;
            id = txtSoonerID.Text;
            first = txtFName.Text;
            last = txtLName.Text;
            //probation = txtProb.Text;
            gpa = txtGPA.Text;
            bursar = txtBB.Text;

            Student stud = new Student(Convert.ToInt32(id), first, last, Convert.ToDouble(bursar));
            stud.GPA = Convert.ToDouble(gpa);
            stud.IsOnProbation = chkProb.IsChecked.Value;

            ListBoxOUT.Items.Add(stud);
        }

        private void ListBoxOUT_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student selectedStudent = (Student) ListBoxOUT.SelectedItem;
            MessageBox.Show($"{selectedStudent.ToString()} has a Burshar Balance of {selectedStudent.CheckBalance().ToString("C")}");
        }
    }
}
