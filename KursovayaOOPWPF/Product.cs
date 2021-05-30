using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaOOPWPF
{
    public class Product
    {
        private string NumProduct;
        private string NameProduct;
        private string Zena;
        private string DataManufacturing; //Дата производство
        private string Massa;

        public Product(string NumProduct, string NameProduct, string Zena, string DataManufacturing, string Massa)
        {
            this.NumProduct = NumProduct;
            this.NameProduct = NameProduct;
            this.Zena = Zena;
            this.DataManufacturing = DataManufacturing;
            this.Massa = Massa;
        }
        public string thisNumProduct
        {
            get
            { return this.NumProduct; }
            set
            { this.NumProduct = value is string ? value : null; }
        }

        public string thisNameProduct
        {
            get
            { return this.NameProduct; }
            set
            { this.NameProduct = value is string ? value : null; }
        }

        public string thisZena
        {
            get
            { return this.Zena; }
            set
            { this.Zena = value is string ? value : null; }
        }

        public string thisDataManufacturing
        {
            get
            { return this.DataManufacturing; }
            set
            { this.DataManufacturing = value is string ? value : null; }
        }

        public string thisMassa
        {
            get
            { return this.Massa; }
            set
            { this.Massa = value is string ? value : null; }
        }
    }
}
