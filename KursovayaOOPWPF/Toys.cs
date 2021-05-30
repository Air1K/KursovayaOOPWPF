using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaOOPWPF
{
    public class Toys : Product //Игрушки
    {
        private string StructureToys;
        private string Agelimit;

        public Toys(string NumProduct, string NameProduct, string Zena, string DataManufacturing, string Massa, string StructureToys, string Agelimit) : base(NumProduct, NameProduct, Zena, DataManufacturing, Massa)
        {
            this.StructureToys = StructureToys;
            this.Agelimit = Agelimit;
        }

        public string thisStructureToys
        {
            get
            { return this.StructureToys; }
            set
            { this.StructureToys = value is string ? value : null; }
        }

        public string thisAgelimit
        {
            get
            { return this.Agelimit; }
            set
            { this.Agelimit = value is string ? value : null; }
        }
    }
}
