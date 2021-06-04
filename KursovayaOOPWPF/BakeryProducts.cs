using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaOOPWPF
{
    [Serializable]
    public class BakeryProducts : Food //Выпечка
    {
        private string TipBakeryProducts;
        private string Sort;

        public BakeryProducts(string TipBakeryProducts, string Sort, string KolVoKCalories, string StructureFood, string NumProduct, string NameProduct, string Zena, string DataManufacturing, string Massa) : base(KolVoKCalories, StructureFood, NumProduct, NameProduct, Zena, DataManufacturing, Massa)
        {
            this.TipBakeryProducts = TipBakeryProducts;
            this.Sort = Sort;
        }

        public string thisTipBakeryProducts
        {
            get
            { return this.TipBakeryProducts; }
            set
            { this.TipBakeryProducts = value is string ? value : null; }
        }

        public string thisSort
        {
            get
            { return this.Sort; }
            set
            { this.Sort = value is string ? value : null; }
        }
    }
}
