using System;
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
        /// Seteaza soldul contului de economii.
        /// </summary>
        /// <param name="adaugare"></param>
        public void SetValoareMonetara(double adaugare)
        {
            this.valoareMonetara += adaugare;
        }
        /// <summary>
        /// Returneaza dobanda.
        /// </summary>
        /// <returns></returns>
        public double GetDobanda()
        {
            return this.valoareMonetara * 0.05;
        }
        /// <summary>
        /// Returneaza obiectul Economii.
        /// </summary>
        /// <returns></returns>
        public Economii GetContEconomiiOrigin()
        {
            string numarCont = this.numarCont;
            double valoareMonetara = this.valoareMonetara;
            Economii contEconomii = new Economii(numarCont, valoareMonetara);
            return contEconomii;
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
