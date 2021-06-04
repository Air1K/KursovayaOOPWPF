using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaOOPWPF
{
    [Serializable]
    public class Drink : Product
    {
        private string AgelimitDrink;
        private string StructureDrink;

        public Drink(string AgelimitDrink, string StructureDrink, string NumProduct, string NameProduct, string Zena, string DataManufacturing, string Massa) : base(NumProduct, NameProduct, Zena, DataManufacturing, Massa)
        {
            this.AgelimitDrink = AgelimitDrink;
            this.StructureDrink = StructureDrink;
        }

        public string thisAgelimitDrink
        {
            get
            { return this.AgelimitDrink; }
            set
            { this.AgelimitDrink = value is string ? value : null; }
        }

        public string thisStructureDrink
        {
            get
            { return this.StructureDrink; }
            set
            { this.StructureDrink = value is string ? value : null; }
        }
    }
}
