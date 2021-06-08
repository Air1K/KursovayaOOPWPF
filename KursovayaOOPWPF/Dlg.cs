﻿using System;
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
            }
            dsp();
            return Const;
        }

    }
}
