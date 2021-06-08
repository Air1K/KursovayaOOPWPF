using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KursovayaOOPWPF
{
    public static class DB
    {
        public static List<Toys> game = new List<Toys>();
        public static List<BakeryProducts> Bakery = new List<BakeryProducts>();
        public static List<Seafood> Seaf = new List<Seafood>();
        public static List<Alcohol> Alco = new List<Alcohol>();
        public static List<Juices> Juic = new List<Juices>();
    }
    public class AddClass
    {


        public void AddEl(string id, string NumProduct, string NameProduct, string Zena, string DataManufacturing, string Massa, string Rand1, string Rand2, string Rand3, string Rand4)
        {
            Dlg dlg = new Dlg();
            if (id == "0")
            {
                Toys toy = new Toys(NumProduct, NameProduct, Zena, DataManufacturing, Massa, Rand1, Rand2);
                DB.game.Add(toy);
                MessageBox.Show(dlg.DspOnMsg(toy));
            }
            if (id == "1")
            {
                BakeryProducts products = new BakeryProducts(Rand3, Rand4, Rand1, Rand2, NumProduct, NameProduct, Zena, DataManufacturing, Massa);
                DB.Bakery.Add(products);
                MessageBox.Show(dlg.DspOnMsg(products));
            }
            if (id == "2")
            {
                Seafood seafood = new Seafood(Rand3, Rand4, Rand1, Rand2, NumProduct, NameProduct, Zena, DataManufacturing, Massa);
                DB.Seaf.Add(seafood);
                MessageBox.Show(dlg.DspOnMsg(seafood));
            }
            if (id == "3")
            { 
                Alcohol alcohol = new Alcohol(Rand3, Rand4, Rand1, Rand2, NumProduct, NameProduct, Zena, DataManufacturing, Massa);
                DB.Alco.Add(alcohol);
                MessageBox.Show(dlg.DspOnMsg(alcohol));
            }
            if (id == "4")
            {
                Juices juices = new Juices(Rand3, Rand4, Rand1, Rand2, NumProduct, NameProduct, Zena, DataManufacturing, Massa);
                DB.Juic.Add(juices);
                MessageBox.Show(dlg.DspOnMsg(juices));
            }
            // MainWindow.ShowDataGrid();
        }

    }
}
