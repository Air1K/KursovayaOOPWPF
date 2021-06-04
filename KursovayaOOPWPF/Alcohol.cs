using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaOOPWPF
{
    [Serializable]
    public class Alcohol : Drink
    {
        private string TipAlcohol;
        private string Degree; // Градус

        public Alcohol(string TipAlcohol, string Degree, string AgelimitDrink, string StructureDrink, string NumProduct, string NameProduct, string Zena, string DataManufacturing, string Massa) : base(AgelimitDrink, StructureDrink, NumProduct, NameProduct, Zena, DataManufacturing, Massa)
        {
            this.TipAlcohol = TipAlcohol;
            this.Degree = Degree;
        }

        public string thisTipAlcohol
        {
            get
            { return this.TipAlcohol; }
            set
            { this.TipAlcohol = value is string ? value : null; }
        }

        public string thisDegree
        {
            get
            { return this.Degree; }
            set
            { this.Degree = value is string ? value : null; }
        }
    }
}
