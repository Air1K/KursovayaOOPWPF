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

namespace KursovayaOOPWPF
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

        private void AddClassButtonClick(object sender, RoutedEventArgs e)
        {
            WindowAddClass addclass = new WindowAddClass();
           
            addclass.Show();
            //AllSpisokToys.ItemsSource = "";
        }

        private void ObnovlenButtonClick(object sender, RoutedEventArgs e)
        {
            foreach (Toys i in DB.game)
                AllSpisokToys.ItemsSource = DB.game;
           // AllSpisokToys.ItemsSource = (i.thisNumProduct, i.thisNameProduct, i.thisZena, i.thisDataManufacturing, i.thisMassa, i.thisStructureToys, i.thisAgelimit);
        }



        /*  private void AddClickButton(object sender, RoutedEventArgs e)
          {
             // WindowAddClass addclass = new WindowAddClass();
             // addclass.Show();
          }*/
    }
}
