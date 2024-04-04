using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PRACTIKA4
{
    public partial class WindowEF1 : Window
    {
        private teremok1Entities teremok = new teremok1Entities();
        public WindowEF1()
        {
            InitializeComponent();
            EmployeeGrid.ItemsSource = teremok.employee.ToList();
            FiltrBox.ItemsSource = teremok.employee.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowEF2 window = new WindowEF2();
            window.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowEF3 window = new WindowEF3();
            window.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            EmployeeGrid.ItemsSource = teremok.employee.Where(item => item.surname.Contains(SearchBox.Text)).ToList();
        }

        private void FiltrBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           if (FiltrBox.SelectedItem != null)
           {
                var selected = FiltrBox.SelectedItem as employee;
                EmployeeGrid.ItemsSource = teremok.employee.Where(item => item.ID_employee == selected.ID_employee).ToList(); 
           } 
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            EmployeeGrid.ItemsSource = teremok.employee.ToList();
            SearchBox.Clear();
        }
    }
}
