using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaOOPWPF
{
    [Serializable]
    public class Food : Product
    {
        private string KolVoKCalories;
        private string StructureFood;

        public Food(string KolVoKCalories, string StructureFood, string NumProduct, string NameProduct, string Zena, string DataManufacturing, string Massa) : base(NumProduct, NameProduct, Zena, DataManufacturing, Massa)
        {
            this.KolVoKCalories = KolVoKCalories;
            this.StructureFood = StructureFood;
        }

        public string thisKolVoKCalories
        {
            get
            { return this.KolVoKCalories; }
            set
            { this.KolVoKCalories = value is string ? value : null; }
        }

        public string thisStructureFood
        {
            get
            { return this.StructureFood; }
            set
            { this.StructureFood = value is string ? value : null; }
        }
    }
}
