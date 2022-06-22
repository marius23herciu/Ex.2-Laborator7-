﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex._2_Laborator7_
{
    class Economii
    {
        private string numarCont;
        private double valoareMonetara;
        /// <summary>
        /// Creaza cont de economii.
        /// </summary>
        /// <param name="numarCont"></param>
        /// <param name="valoareMonetara"></param>
        public Economii(string numarCont, double valoareMonetara)
        {
            this.numarCont = numarCont;
            this.valoareMonetara = valoareMonetara;
        }
        /// <summary>
        /// Returneaza soldul contului de economii.
        /// </summary>
        /// <returns></returns>
        public double GetSoldEconomii()
        {
            return this.valoareMonetara;
        }
        /// <summary>
        /// Depune numerar in soldul contului de economii.
        /// </summary>
        /// <param name="adaugare"></param>
        public void DepunereValoareMonetara()
        {
            int plus = int.Parse(Console.ReadLine());
            this.valoareMonetara += plus;
            Console.WriteLine($"Noua dobanda lunara este {this.valoareMonetara * 0.005}.");
        }
        /// <summary>
        /// Retrage numerar din contul de economii.
        /// </summary>
        public void RetragererValoareMonetara()
        {
            int minus = int.Parse(Console.ReadLine());
            if (this.valoareMonetara >= minus)
            {
                this.valoareMonetara -= minus;
                Console.WriteLine($"Noua dobanda lunara este {this.valoareMonetara*0.005}.");
            }
            else
            {
                Console.WriteLine($"Fonduri insuficiente!");
            }
        }
        /// <summary>
        /// Adauga dobanda soldului din contul de economii.
        /// </summary>
        public void RecalculareSold()
        {
            this.valoareMonetara += this.valoareMonetara * 0.005;
        }
        /// <summary>
        /// Afiseaza soldul contului de economii.
        /// </summary>
        public void Afisare()
        {
            Console.WriteLine($"{this.valoareMonetara}");
        }
    }
}
