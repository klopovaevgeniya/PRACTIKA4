using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;
using PRACTIKA4.teremok1DataSetTableAdapters;

namespace PRACTIKA4
{
    public partial class WindowDS1 : Window
    {
        employeeTableAdapter employee = new employeeTableAdapter();
        public WindowDS1()
        {
            InitializeComponent();
            EmployeeGrid.ItemsSource = employee.GetData();
            FiltrBox.ItemsSource = employee.GetData();
            FiltrBox.DisplayMemberPath = "ID_employee";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowDS2 window = new WindowDS2();
            window.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowDS3 window = new WindowDS3();
            window.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            EmployeeGrid.ItemsSource = employee.SearchBySurname(SearchBox.Text);
        }

        private void FiltrBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FiltrBox.SelectedItem != null)
            {
                var id = (int)(FiltrBox.SelectedItem as DataRowView).Row[0]; 
                EmployeeGrid.ItemsSource = employee.FiltrByID(id);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            EmployeeGrid.ItemsSource = employee.GetData();
            SearchBox.Clear();
        }
    }
}
