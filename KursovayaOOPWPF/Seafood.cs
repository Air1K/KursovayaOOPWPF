using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaOOPWPF
{
    [Serializable]
    public class Seafood : Food //Рыбные продукты
    {
        private string TipSeafood;
    private string FishingPlace; //Место ловли

    public Seafood(string TipSeafood, string FishingPlace, string KolVoKCalories, string StructureFood, string NumProduct, string NameProduct, string Zena, string DataManufacturing, string Massa) : base(KolVoKCalories, StructureFood, NumProduct, NameProduct, Zena, DataManufacturing, Massa)
    {
        this.TipSeafood = TipSeafood;
        this.FishingPlace = FishingPlace;
    }

    public string thisTipSeafood
    {
        get
        { return this.TipSeafood; }
        set
        { this.TipSeafood = value is string ? value : null; }
    }

    public string thisFishingPlace
    {
        get
        { return this.FishingPlace; }
        set
        { this.FishingPlace = value is string ? value : null; }
    }
}
}
