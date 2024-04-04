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
    public partial class WindowDS3 : Window
    {
        bliniTableAdapter blin = new bliniTableAdapter();
        public WindowDS3()
        {
            InitializeComponent();
            BlinGrid.ItemsSource = blin.GetData();
            FiltrBox.ItemsSource = blin.GetData();
            FiltrBox.DisplayMemberPath = "price";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowDS1 window = new WindowDS1();
            window.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowDS2 window = new WindowDS2();
            window.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            BlinGrid.ItemsSource = blin.SearchByNameblin(SearchBox.Text);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            BlinGrid.ItemsSource = blin.GetData();
            SearchBox.Clear();
        
        }
    }
}
