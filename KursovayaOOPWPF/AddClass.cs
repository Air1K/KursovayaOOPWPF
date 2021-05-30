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
    }
    public class AddClass
    {


        public void AddEl(string id, string NumProduct, string NameProduct, string Zena, string DataManufacturing, string Massa, string StructureToys, string Agelimit)
        {
            if (id == "0")
            {
                DB.game.Add(new Toys(NumProduct, NameProduct, Zena, DataManufacturing, Massa, StructureToys, Agelimit));
            }

        }

    }
}
