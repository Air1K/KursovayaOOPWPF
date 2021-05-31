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
    /// Логика взаимодействия для Dell.xaml
    /// </summary>
    public partial class Dell : Window
    {
        public Dell()
        {
            InitializeComponent();
            Combo1.Items.Add("Игрушки");
            Combo1.Items.Add("Выпечка");
            Combo1.Items.Add("Рыбные продукты");
            Combo1.Items.Add("Алкоголь");
            Combo1.Items.Add("Соки");
        }

        private void DellButtonClickEl(object sender, RoutedEventArgs e)
        {
            if (Combo1.SelectedItem.ToString() == "Игрушки")
            {
                for(int i = 0; i<DB.game.Count; i++)
                {
                    if(DB.game[i].thisNumProduct == Combo2.Text)
                    {
                        DB.game.RemoveAt(i);
                    }
                }

            }
            if (Combo1.SelectedItem.ToString() == "Выпечка")
            {
                for (int i = 0; i < DB.Bakery.Count; i++)
                {
                    if (DB.Bakery[i].thisNumProduct == Combo2.Text)
                    {
                        DB.Bakery.RemoveAt(i);
                    }
                }
            }
            if (Combo1.SelectedItem.ToString() == "Рыбные продукты")
            {
                for (int i = 0; i < DB.Seaf.Count; i++)
                {
                    if (DB.Seaf[i].thisNumProduct == Combo2.Text)
                    {
                        DB.Seaf.RemoveAt(i);
                    }
                }
            }
            if (Combo1.SelectedItem.ToString() == "Алкоголь")
            {
                for (int i = 0; i < DB.Alco.Count; i++)
                {
                    if (DB.Alco[i].thisNumProduct == Combo2.Text)
                    {
                        DB.Alco.RemoveAt(i);
                    }
                }
            }
            if (Combo1.SelectedItem.ToString() == "Соки")
            {
                for (int i = 0; i < DB.Juic.Count; i++)
                {
                    if (DB.Juic[i].thisNumProduct == Combo2.Text)
                    {
                        DB.Juic.RemoveAt(i);
                    }
                }
            }
        }

        private void Combo1If(object sender, SelectionChangedEventArgs e)
        {
            
            if (Combo1.SelectedItem.ToString() == "Игрушки")
            {
                Combo2.Items.Clear();
                foreach (Toys i in DB.game)
                {
                    Combo2.Items.Add(i.thisNumProduct);
                }
                
            }
            if (Combo1.SelectedItem.ToString() == "Выпечка")
            {
                Combo2.Items.Clear();
                for (int i = 0; i < DB.Bakery.Count; i++)
                {
                    Combo2.Items.Add(DB.Bakery[i].thisNumProduct);
                }
                foreach (BakeryProducts a in DB.Bakery)
                {
                    
                }
            }
            if (Combo1.SelectedItem.ToString() == "Рыбные продукты")
            {
                Combo2.Items.Clear();
                foreach (Seafood b in DB.Seaf)
                {
                    Combo2.Items.Add(b.thisNumProduct);
                }
            }
            if (Combo1.SelectedItem.ToString() == "Алкоголь")
            {
                Combo2.Items.Clear();
                foreach (Alcohol c in DB.Alco)
                {
                    Combo2.Items.Add(c.thisNumProduct);
                }
            }
            if (Combo1.SelectedItem.ToString() == "Соки")
            {
                Combo2.Items.Clear();
                foreach (Juices d in DB.Juic)
                {
                    Combo2.Items.Add(d.thisNumProduct);
                }
            }
        }
    }
}
