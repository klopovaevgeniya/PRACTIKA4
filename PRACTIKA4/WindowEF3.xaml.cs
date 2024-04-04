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
using System.Windows.Shapes;

namespace PRACTIKA4
{
    public partial class WindowEF3 : Window
    {
        private teremok1Entities teremok = new teremok1Entities();
        public WindowEF3()
        {
            InitializeComponent();
            BlinGrid.ItemsSource = teremok.blini.ToList();
            FiltrBox.ItemsSource = teremok.blini.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BlinGrid.ItemsSource = teremok.blini.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowEF1 window = new WindowEF1();
            window.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WindowEF3 window = new WindowEF3();
            window.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            BlinGrid.ItemsSource = teremok.blini.ToList().Where(item => item.nameblin.Contains(SearchBox.Text));
        }

        private void FiltrBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FiltrBox.SelectedItem != null)
            {
                var selected = FiltrBox.SelectedItem as blini;
               // BlinGrid.ItemsSource = teremok.blini.ToList().Where(item => item.ID_blini == selected);
            }
        }
    }
}
