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
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        public Edit()
        {
            InitializeComponent();
            Combo1.Items.Add("Игрушки");
            Combo1.Items.Add("Выпечка");
            Combo1.Items.Add("Рыбные продукты");
            Combo1.Items.Add("Алкоголь");
            Combo1.Items.Add("Соки");

            textBox3Rand.Visibility = Visibility.Collapsed;
            textBox4Rand.Visibility = Visibility.Collapsed;
            lablebox3Rand.Visibility = Visibility.Collapsed;
            lablebox4Rand.Visibility = Visibility.Collapsed;
        }
        int idS=0;
        private void Combo2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // add();
        }
        public void add()
        {
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Combo1.SelectedItem.ToString() == "Игрушки")
            {
                
                        DB.game[idS].thisNumProduct = textBoxNum.Text;
                        DB.game[idS].thisNameProduct = textBoxName.Text;
                        DB.game[idS].thisZena = textBoxZena.Text;
                        DB.game[idS].thisDataManufacturing = datePickeData.Text;
                        DB.game[idS].thisMassa = textBoxMass.Text;
                        DB.game[idS].thisStructureToys = textBox1Rand.Text;
                        DB.game[idS].thisAgelimit = textBox2Rand.Text;
                 
            }
            if (Combo1.SelectedItem.ToString() == "Выпечка")
            {
                DB.Bakery[idS].thisNumProduct = textBoxNum.Text;
                DB.Bakery[idS].thisNameProduct =  textBoxName.Text;
                DB.Bakery[idS].thisZena = textBoxZena.Text;
                DB.Bakery[idS].thisDataManufacturing = datePickeData.Text;
                DB.Bakery[idS].thisMassa = textBoxMass.Text;
                DB.Bakery[idS].thisKolVoKCalories = textBox1Rand.Text;
                DB.Bakery[idS].thisStructureFood = textBox2Rand.Text;
                DB.Bakery[idS].thisTipBakeryProducts = textBox3Rand.Text;
                DB.Bakery[idS].thisSort = textBox4Rand.Text;
            }
            if (Combo1.SelectedItem.ToString() == "Рыбные продукты")
            {
                DB.Seaf[idS].thisNumProduct = textBoxNum.Text;
                DB.Seaf[idS].thisNameProduct = textBoxName.Text;
                DB.Seaf[idS].thisZena = textBoxZena.Text;
                DB.Seaf[idS].thisDataManufacturing = datePickeData.Text;
                DB.Seaf[idS].thisMassa = textBoxMass.Text;
                DB.Seaf[idS].thisKolVoKCalories = textBox1Rand.Text;
                DB.Seaf[idS].thisStructureFood = textBox2Rand.Text;
                DB.Seaf[idS].thisTipSeafood = textBox3Rand.Text;
                DB.Seaf[idS].thisFishingPlace = textBox4Rand.Text;
            }
            if (Combo1.SelectedItem.ToString() == "Алкоголь")
            {
                DB.Alco[idS].thisNumProduct = textBoxNum.Text;
                DB.Alco[idS].thisNameProduct = textBoxName.Text;
                DB.Alco[idS].thisZena = textBoxZena.Text;
                DB.Alco[idS].thisDataManufacturing = datePickeData.Text;
                DB.Alco[idS].thisMassa = textBoxMass.Text;
                DB.Alco[idS].thisAgelimitDrink = textBox1Rand.Text;
                DB.Alco[idS].thisStructureDrink = textBox2Rand.Text;
                DB.Alco[idS].thisTipAlcohol = textBox3Rand.Text;
                DB.Alco[idS].thisDegree = textBox4Rand.Text;
            }
            if (Combo1.SelectedItem.ToString() == "Соки")
            {
                DB.Juic[idS].thisNumProduct = textBoxNum.Text;
                DB.Juic[idS].thisNameProduct = textBoxName.Text;
                DB.Juic[idS].thisZena = textBoxZena.Text;
                DB.Juic[idS].thisDataManufacturing = datePickeData.Text;
                DB.Juic[idS].thisMassa = textBoxMass.Text;
                DB.Juic[idS].thisAgelimitDrink = textBox1Rand.Text;
                DB.Juic[idS].thisStructureDrink = textBox2Rand.Text;
                DB.Juic[idS].thisTipJuices = textBox3Rand.Text;
                DB.Juic[idS].thisBrandJuices = textBox4Rand.Text;
            }
        }

        private void Combo1If(object sender, SelectionChangedEventArgs e)
        {
            if (Combo1.SelectedItem.ToString() == "Игрушки")
            {
                Combo2Texte.Items.Clear();
                foreach (Toys i in DB.game)
                {
                    Combo2Texte.Items.Add(i.thisNumProduct);
                }

            }
            if (Combo1.SelectedItem.ToString() == "Выпечка")
            {
                Combo2Texte.Items.Clear();
                for (int i = 0; i < DB.Bakery.Count; i++)
                {
                    Combo2Texte.Items.Add(DB.Bakery[i].thisNumProduct);
                }
              
            }
            if (Combo1.SelectedItem.ToString() == "Рыбные продукты")
            {
                Combo2Texte.Items.Clear();
                foreach (Seafood b in DB.Seaf)
                {
                    Combo2Texte.Items.Add(b.thisNumProduct);
                }
            }
            if (Combo1.SelectedItem.ToString() == "Алкоголь")
            {
                Combo2Texte.Items.Clear();
                foreach (Alcohol c in DB.Alco)
                {
                    Combo2Texte.Items.Add(c.thisNumProduct);
                }
            }
            if (Combo1.SelectedItem.ToString() == "Соки")
            {
                Combo2Texte.Items.Clear();
                foreach (Juices d in DB.Juic)
                {
                    Combo2Texte.Items.Add(d.thisNumProduct);
                }
            }
            if (Combo1.SelectedItem.ToString() == "Игрушки")
            {
                //id = "0";
                textBox3Rand.Visibility = Visibility.Collapsed;
                textBox4Rand.Visibility = Visibility.Collapsed;
                lablebox3Rand.Visibility = Visibility.Collapsed;
                lablebox4Rand.Visibility = Visibility.Collapsed;
            }
            if (Combo1.SelectedItem.ToString() == "Выпечка")
            {
                //id = "1";
                lablebox3Rand.Visibility = Visibility.Visible;
                lablebox4Rand.Visibility = Visibility.Visible;
                lablebox1Rand.Content = "Кол-во калорий";
                lablebox2Rand.Content = "Структура";
                textBox3Rand.Visibility = Visibility.Visible;
                textBox4Rand.Visibility = Visibility.Visible;
                lablebox3Rand.Content = "Тип выпечки";
                lablebox4Rand.Content = "Сорт";
            }
            if (Combo1.SelectedItem.ToString() == "Рыбные продукты")
            {
                //id = "2";
                lablebox3Rand.Visibility = Visibility.Visible;
                lablebox4Rand.Visibility = Visibility.Visible;
                lablebox1Rand.Content = "Кол-во калорий";
                lablebox2Rand.Content = "Структура";
                textBox3Rand.Visibility = Visibility.Visible;
                textBox4Rand.Visibility = Visibility.Visible;
                lablebox3Rand.Content = "Тип продукта";
                lablebox4Rand.Content = "Место ловли";
            }
            if (Combo1.SelectedItem.ToString() == "Алкоголь")
            {
                //id = "3";
                lablebox3Rand.Visibility = Visibility.Visible;
                lablebox4Rand.Visibility = Visibility.Visible;
                lablebox1Rand.Content = "Возрастные ограничения";
                lablebox2Rand.Content = "Структура напитка";
                textBox3Rand.Visibility = Visibility.Visible;
                textBox4Rand.Visibility = Visibility.Visible;
                lablebox3Rand.Content = "Тип продукта";
                lablebox4Rand.Content = "Градус";
            }
            if (Combo1.SelectedItem.ToString() == "Соки")
            {
                //id = "4";
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
        
        private void AddClick1(object sender, RoutedEventArgs e)
        {
            if (Combo1.SelectedItem.ToString() == "Игрушки")
            {
                for (int i = 0; i < DB.game.Count; i++)
                {
                    if (DB.game[idS].thisNumProduct == Combo2Texte.Text)
                    {
                        textBoxNum.Text = DB.game[i].thisNumProduct;
                        textBoxName.Text = DB.game[i].thisNameProduct;
                        textBoxZena.Text = DB.game[i].thisZena;
                        datePickeData.Text = DB.game[i].thisDataManufacturing;
                        textBoxMass.Text = DB.game[i].thisMassa;
                        textBox1Rand.Text = DB.game[i].thisStructureToys;
                        textBox2Rand.Text = DB.game[i].thisAgelimit;
                        idS = i;
                    }
                }

            }
            if (Combo1.SelectedItem.ToString() == "Выпечка")
            {
                for (int i = 0; i < DB.Bakery.Count; i++)
                {
                    if (DB.Bakery[i].thisNumProduct == Combo2Texte.Text)
                    {
                        textBoxNum.Text = DB.Bakery[i].thisNumProduct;
                        textBoxName.Text = DB.Bakery[i].thisNameProduct;
                        textBoxZena.Text = DB.Bakery[i].thisZena;
                        datePickeData.Text = DB.Bakery[i].thisDataManufacturing;
                        textBoxMass.Text = DB.Bakery[i].thisMassa;
                        textBox1Rand.Text = DB.Bakery[i].thisKolVoKCalories;
                        textBox2Rand.Text = DB.Bakery[i].thisStructureFood;
                        textBox3Rand.Text = DB.Bakery[i].thisTipBakeryProducts;
                        textBox4Rand.Text = DB.Bakery[i].thisSort;
                        idS = i;
                    }
                }
            }
            if (Combo1.SelectedItem.ToString() == "Рыбные продукты")
            {
                for (int i = 0; i < DB.Seaf.Count; i++)
                {
                    if (DB.Seaf[i].thisNumProduct == Combo2Texte.Text)
                    {
                        textBoxNum.Text = DB.Seaf[i].thisNumProduct;
                        textBoxName.Text = DB.Seaf[i].thisNameProduct;
                        textBoxZena.Text = DB.Seaf[i].thisZena;
                        datePickeData.Text = DB.Seaf[i].thisDataManufacturing;
                        textBoxMass.Text = DB.Seaf[i].thisMassa;
                        textBox1Rand.Text = DB.Seaf[i].thisKolVoKCalories;
                        textBox2Rand.Text = DB.Seaf[i].thisStructureFood;
                        textBox3Rand.Text = DB.Seaf[i].thisTipSeafood;
                        textBox4Rand.Text = DB.Seaf[i].thisFishingPlace;
                        idS = i;
                    }
                }
            }
            if (Combo1.SelectedItem.ToString() == "Алкоголь")
            {
                for (int i = 0; i < DB.Alco.Count; i++)
                {
                    if (DB.Alco[i].thisNumProduct == Combo2Texte.Text)
                    {
                        textBoxNum.Text = DB.Alco[i].thisNumProduct;
                        textBoxName.Text = DB.Alco[i].thisNameProduct;
                        textBoxZena.Text = DB.Alco[i].thisZena;
                        datePickeData.Text = DB.Alco[i].thisDataManufacturing;
                        textBoxMass.Text = DB.Alco[i].thisMassa;
                        textBox1Rand.Text = DB.Alco[i].thisAgelimitDrink;
                        textBox2Rand.Text = DB.Alco[i].thisStructureDrink;
                        textBox3Rand.Text = DB.Alco[i].thisTipAlcohol;
                        textBox4Rand.Text = DB.Alco[i].thisDegree;
                        idS = i;
                    }
                }
            }
            if (Combo1.SelectedItem.ToString() == "Соки")
            {
                for (int i = 0; i < DB.Juic.Count; i++)
                {
                    if (DB.Juic[i].thisNumProduct == Combo2Texte.Text)
                    {
                        textBoxNum.Text = DB.Juic[i].thisNumProduct;
                        textBoxName.Text = DB.Juic[i].thisNameProduct;
                        textBoxZena.Text = DB.Juic[i].thisZena;
                        datePickeData.Text = DB.Juic[i].thisDataManufacturing;
                        textBoxMass.Text = DB.Juic[i].thisMassa;
                        textBox1Rand.Text = DB.Juic[i].thisAgelimitDrink;
                        textBox2Rand.Text = DB.Juic[i].thisStructureDrink;
                        textBox3Rand.Text = DB.Juic[i].thisTipJuices;
                        textBox4Rand.Text = DB.Juic[i].thisBrandJuices;
                        idS = i;
                    }
                }
            }
        }
    }
}
