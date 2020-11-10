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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ServisController servisController;

        public MainWindow()
        {
            InitializeComponent();

            try
            {
                servisController = new ServisController();
                lbContent.ItemsSource = servisController.ServisWs;
            }
            catch
            {
                MessageBox.Show("error db");
            }

        }

        private void btChange_Click(object sender, RoutedEventArgs e)
        {
            var b = sender as Button;
            var s = b.DataContext as ServisW;

            MessageBox.Show(s.Name);

        }

        private void btDell_Click(object sender, RoutedEventArgs e)
        {

            Button button = sender as Button;

            ServisW servis = button.DataContext as ServisW;

            MessageBox.Show(servis.Name);

        }

        private void UpName_Click(object sender, RoutedEventArgs e)
        {
            servisController.ServisWs=   servisController.ServisWs.OrderBy(x => x.Name).ToList();
            lbContent.ItemsSource = servisController.ServisWs;
        }
    }
}
