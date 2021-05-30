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
        }
        
        //    ComboProdukt.Items.Add("Театр");
        AddClass gg = new AddClass();
        private void SaveButtonClick(object sender, RoutedEventArgs e)
        {
            
            if (ComboProdukt.SelectedItem.ToString() == "Игрушки")
            {
                gg.AddEl("0", textBoxNum.Text, textBoxName.Text, textBoxZena.Text, datePickeData.Text, textBoxMass.Text, textBoxStruckt.Text, textBoxAgeLimit.Text);
                //textBox5.Text, textBox6.Text, textBox1.Text, textBox2.Text, textBox4.Text, dateTimePicker1.Text, textBox3.Text

            }
        }
    }
}
