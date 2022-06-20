using System;
using System.Collections.Generic;
using System.Text;

namespace Ex._2_Laborator7_
{
    class ContCurent
    {
        private string numarCont;
        private double valoareMonetara;
        /// <summary>
        /// Creaza Cont Curent.
        /// </summary>
        /// <param name="numarCont"></param>
        /// <param name="valoareMonetara"></param>
        public ContCurent(string numarCont, double valoareMonetara)
        {
            this.numarCont = numarCont;
            this.valoareMonetara = valoareMonetara;
        }
        /// <summary>
        /// Returneaza soldul pentru cont curent.
        /// </summary>
        /// <returns></returns>
        public double GetSoldCurent()
        {
            return this.valoareMonetara;
        }
        /// <summary>
        /// Seteaza valoarea contului curent.
        /// </summary>
        /// <param name="modificare"></param>
        public void SetValoareMonetara(double modificare)
        {
            this.valoareMonetara += modificare;
        }
        /// <summary>
        /// Afiseaza valoarea contului curent.
        /// </summary>
        public void Afisare()
        {
            Console.WriteLine($"{this.valoareMonetara}");
        }
        /// <summary>
        /// Returneaza ContCurent.
        /// </summary>
        /// <returns></returns>
        public ContCurent GetContCurentOrigin()
        {
            string numarCont = this.numarCont;
            double valoareMonetara = this.valoareMonetara;
            ContCurent contCurent = new ContCurent(numarCont, valoareMonetara);
            return contCurent;
        }
    }
}
