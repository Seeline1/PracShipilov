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

namespace Pyteshestvie_po_Rossii
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new MainPage());
            Manager.MainFrame = MainFrame;
        }

        private void btnSpisoktyrov_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Spisoktyrov());
        }

        private void btnTablicaOtelei_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TablicaOtelei());
        }

        private void btnYdalenieOtelya_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new YdalenieOtelya());
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                btnSpisoktyrov.Visibility = Visibility.Visible;
                btnTablicaOtelei.Visibility = Visibility.Visible;
                btnYdalenieOtelya.Visibility = Visibility.Visible;
                btnDROtelya.Visibility = Visibility.Visible;
            }
            else
            {
                btnSpisoktyrov.Visibility = Visibility.Hidden;
                btnTablicaOtelei.Visibility = Visibility.Hidden;
                btnYdalenieOtelya.Visibility = Visibility.Hidden;
                btnDROtelya.Visibility = Visibility.Hidden;
            }
        }

        private void btnDROtelya_Click(object sender, RoutedEventArgs e)
        {
            DROtelya drotelya = new DROtelya();
            drotelya.Show();
        }
    }
}
