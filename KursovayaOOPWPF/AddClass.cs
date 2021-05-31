using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaOOPWPF
{
    public static class DB
    {
        public static List<Toys> game = new List<Toys>();
        public static List<BakeryProducts> Bakery = new List<BakeryProducts>();
        public static List<Seafood> Seaf = new List<Seafood>();
    }
    public class AddClass
    {


        public void AddEl(string id, string NumProduct, string NameProduct, string Zena, string DataManufacturing, string Massa, string Rand1, string Rand2, string Rand3, string Rand4)
        {
            if (id == "0")
            {
                DB.game.Add(new Toys(NumProduct, NameProduct, Zena, DataManufacturing, Massa, Rand1, Rand2));
            }
            if (id == "1")
            {
                DB.Bakery.Add(new BakeryProducts(NumProduct, NameProduct, Zena, DataManufacturing, Massa, Rand1, Rand2, Rand3, Rand4));
            }
            if (id == "2")
            {
                DB.Seaf.Add(new Seafood(NumProduct, NameProduct, Zena, DataManufacturing, Massa, Rand1, Rand2, Rand3, Rand4));
            }
           // MainWindow.ShowDataGrid();
        }

    }
}
