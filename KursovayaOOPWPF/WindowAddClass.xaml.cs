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


namespace KursovayaOOPWPF
{
    /// <summary>
    /// Логика взаимодействия для WindowAddClass.xaml
    /// </summary>
    public partial class WindowAddClass : Window
    {
        public WindowAddClass()
        {
            InitializeComponent();
            ComboProdukt.Items.Add("Игрушки");
            ComboProdukt.Items.Add("Выпечка");
            ComboProdukt.Items.Add("Рыбные продукты");
            ComboProdukt.Items.Add("Алкоголь");
            ComboProdukt.Items.Add("Соки");
            //textBox1Rand.Visible = false;
            textBox3Rand.Visibility = Visibility.Collapsed;
            textBox4Rand.Visibility = Visibility.Collapsed;
            lablebox3Rand.Visibility = Visibility.Collapsed;
            lablebox4Rand.Visibility = Visibility.Collapsed;
        }
        string id = "";
        //    ComboProdukt.Items.Add("Театр");
        AddClass gg = new AddClass();
        private void SaveButtonClick(object sender, RoutedEventArgs e)
        {
            gg.AddEl(id, textBoxNum.Text, textBoxName.Text, textBoxZena.Text, datePickeData.Text, textBoxMass.Text, textBox1Rand.Text, textBox2Rand.Text, textBox3Rand.Text, textBox4Rand.Text);
        }

        private void ComboProdukt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (ComboProdukt.SelectedItem.ToString() == "Игрушки")
            {
                id = "0";
                textBox3Rand.Visibility = Visibility.Collapsed;
                textBox4Rand.Visibility = Visibility.Collapsed;
                lablebox3Rand.Visibility = Visibility.Collapsed;
                lablebox4Rand.Visibility = Visibility.Collapsed;
            }
            if (ComboProdukt.SelectedItem.ToString() == "Выпечка")
            {
                id = "1";
                lablebox3Rand.Visibility = Visibility.Visible;
                lablebox4Rand.Visibility = Visibility.Visible;
                lablebox1Rand.Content = "Кол-во калорий";
                lablebox2Rand.Content = "Структура";
                textBox3Rand.Visibility = Visibility.Visible;
                textBox4Rand.Visibility = Visibility.Visible;
                lablebox3Rand.Content = "Тип выпечки";
                lablebox4Rand.Content = "Сорт";
            }
            if (ComboProdukt.SelectedItem.ToString() == "Рыбные продукты")
            {
                id = "2";
                lablebox3Rand.Visibility = Visibility.Visible;
                lablebox4Rand.Visibility = Visibility.Visible;
                lablebox1Rand.Content = "Кол-во калорий";
                lablebox2Rand.Content = "Структура";
                textBox3Rand.Visibility = Visibility.Visible;
                textBox4Rand.Visibility = Visibility.Visible;
                lablebox3Rand.Content = "Тип продукта";
                lablebox4Rand.Content = "Место ловли";
            }
            if (ComboProdukt.SelectedItem.ToString() == "Алкоголь")
            {
                id = "3";
                lablebox3Rand.Visibility = Visibility.Visible;
                lablebox4Rand.Visibility = Visibility.Visible;
                lablebox1Rand.Content = "Возрастные ограничения";
                lablebox2Rand.Content = "Структура напитка";
                textBox3Rand.Visibility = Visibility.Visible;
                textBox4Rand.Visibility = Visibility.Visible;
                lablebox3Rand.Content = "Тип продукта";
                lablebox4Rand.Content = "Градус";
            }
            if (ComboProdukt.SelectedItem.ToString() == "Соки")
            {
                id = "4";
                lablebox3Rand.Visibility = Visibility.Visible;
                lablebox4Rand.Visibility = Visibility.Visible;
                lablebox1Rand.Content = "Возрастные ограничения";
                lablebox2Rand.Content = "Структура напитка";
                textBox3Rand.Visibility = Visibility.Visible;
                textBox4Rand.Visibility = Visibility.Visible;
                lablebox3Rand.Content = "Тип сока";
                lablebox4Rand.Content = "Бренд";
            }
        }
    }
}

