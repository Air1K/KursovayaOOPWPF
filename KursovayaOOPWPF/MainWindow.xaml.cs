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
        public static void ShowDataGrid()
        {
          //  AllSpisokToys.ItemsSource = DB.game;
            //datagridBakeryProducts.ItemsSource = DB.Bakery;

//            datagridSeafood.ItemsSource = DB.Seaf;
        }
        private void ObnovlenButtonClick(object sender, RoutedEventArgs e)
        {
           
                AllSpisokToys.ItemsSource = DB.game;
            AllSpisokToys.Items.Refresh();
            
            datagridBakeryProducts.ItemsSource = DB.Bakery;
            datagridBakeryProducts.Items.Refresh();

            datagridSeafood.ItemsSource = DB.Seaf;
            datagridSeafood.Items.Refresh();

            datagridAlcogol.ItemsSource = DB.Alco;
            datagridAlcogol.Items.Refresh();

            datagridJusu.ItemsSource = DB.Juic;
            datagridJusu.Items.Refresh();
            //datagridSeafood.
            //(i.thisNumProduct, i.thisNameProduct, i.thisZena, i.thisDataManufacturing, i.thisMassa, i.thisStructureFood, i.thisKolVoKCalories, i.thisFishingPlace, i.thisTipSeafood);


        }

        private void DellElement(object sender, RoutedEventArgs e)
        {
            Dell delClick = new Dell();
            delClick.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Edit Ed = new Edit();
            Ed.Show();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Serialize serialize = new Serialize();
            serialize.Save();
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            Serialize serialize = new Serialize();
            serialize.Load();
        }



        /*  private void AddClickButton(object sender, RoutedEventArgs e)
          {
             // WindowAddClass addclass = new WindowAddClass();
             // addclass.Show();
          }*/
    }
}
