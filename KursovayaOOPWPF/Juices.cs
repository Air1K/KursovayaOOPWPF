using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaOOPWPF
{
    [Serializable]
    public class Juices : Drink
    {
        private string TipJuices;
        private string BrandJuices;

        public Juices(string TipJuices, string BrandJuices, string AgelimitDrink, string StructureDrink, string NumProduct, string NameProduct, string Zena, string DataManufacturing, string Massa) : base(AgelimitDrink, StructureDrink, NumProduct, NameProduct, Zena, DataManufacturing, Massa)
        {
            this.TipJuices = TipJuices;
            this.BrandJuices = BrandJuices;
        }

        public string thisTipJuices
        {
            get
            { return this.TipJuices; }
            set
            { this.TipJuices = value is string ? value : null; }
        }

        public string thisBrandJuices
        {
            get
            { return this.BrandJuices; }
            set
            { this.BrandJuices = value is string ? value : null; }
        }
    }
}
