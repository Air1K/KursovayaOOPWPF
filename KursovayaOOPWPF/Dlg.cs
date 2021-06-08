using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaOOPWPF
{

    public delegate void Dsp();

    public class Dlg
    {

        public Dsp dsp;
        string Const = string.Empty;

        void DefaultDsp()
        {
            Const += "Добавлен новый класс\n";
        }

        void OnAddToy()
        {
            Const += "Добавлена игрушка";
        }

        void OnAddBakery()
        {
            Const += "Добавлена выпечка";
        }
        void OnAddSeafood()
        {
            Const += "Добавлен морепродукт";
        }
        void OnAddAlcohol()
        {
            Const += "Добавлен алкоголь";
        }
        void OnAddJuices()
        {
            Const += "Добавлен сок";
        }

        public string DspOnMsg(object GetClass)
        {
            dsp += DefaultDsp;
            switch(GetClass.GetType().ToString())
            {
                case "KursovayaOOPWPF.Toys":
                    dsp += OnAddToy;
                    break;
                case "KursovayaOOPWPF.BakeryProducts":
                    dsp += OnAddBakery;
                    break;
                case "KursovayaOOPWPF.Seafood":
                    dsp += OnAddSeafood;
                    break;
                case "KursovayaOOPWPF.Alcohol":
                    dsp += OnAddAlcohol;
                    break;
                case "KursovayaOOPWPF.Juices":
                    dsp += OnAddJuices;
                    break;
            }
            dsp();
            return Const;
        }

    }
}
