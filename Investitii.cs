using System;
using System.Collections.Generic;
using System.Text;

namespace Ex._2_Laborator7_
{
    class Investitii
    {
        private string numarCont;
        private double valoareMonetara;
        private string dataRetragere;
        /// <summary>
        /// Creaza cont de investitii.
        /// </summary>
        /// <param name="numarCont"></param>
        /// <param name="valoareMonetara"></param>
        /// <param name="dataRetragere"></param>
        public Investitii(string numarCont, double valoareMonetara, string dataRetragere)
        {
            this.numarCont = numarCont;
            this.valoareMonetara = valoareMonetara;
            this.dataRetragere = dataRetragere;
        }
        /// <summary>
        /// Returneaza soldul contului de investitii.
        /// </summary>
        /// <returns></returns>
        public double GetSoldInvestitii()
        {
            return this.valoareMonetara;
        }
        /// <summary>
        /// Seteaza soldul de investitii.
        /// </summary>
        /// <param name="adaugare"></param>
        public void SetValoareMonetara(double adaugare)
        {
            this.valoareMonetara += adaugare;
        }
        /// <summary>
        /// Dobanda dobanda.
        /// </summary>
        /// <returns></returns>
        public double GetDobanda()
        {
            return this.valoareMonetara * 0.05;
        }
        /// <summary>
        /// Returneaza obiectul Investitii.
        /// </summary>
        /// <returns></returns>
        public Investitii GetContInvestitiiOrigin()
        {
            string numarCont = this.numarCont;
            double valoareMonetara = this.valoareMonetara;
            Investitii contInvestitii = new Investitii(numarCont, valoareMonetara, dataRetragere);
            return contInvestitii;
        }
        /// <summary>
        /// Returneaza data de retragere pentru contul de investitii.
        /// </summary>
        /// <returns></returns>
        public string GetDataRetragere()
        {
            return this.dataRetragere;
        }
        /// <summary>
        /// Afiseaza soldul contului de investitii.
        /// </summary>
        public void Afisare()
        {
            Console.WriteLine($"{this.valoareMonetara}");
        }
    }
}
