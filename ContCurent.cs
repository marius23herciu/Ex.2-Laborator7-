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
        /// Depune in cont curent.
        /// </summary>
        /// <param name="modificare"></param>
        public void DepunereContCurent()
        {
            int plus = int.Parse(Console.ReadLine());
            this.valoareMonetara += plus;
        }
        /// <summary>
        /// Extrage bani din cont curent.
        /// </summary>
        public int RetragereContCurent()
        {
            int minus = int.Parse(Console.ReadLine());
            if (this.valoareMonetara >= minus)
            {
                this.valoareMonetara -= minus;
                return minus;
            }
            else
            {
                Console.WriteLine($"Fonduri insuficiente!");
            }
            return 0;
        }
        /// <summary>
        /// Afiseaza valoarea contului curent.
        /// </summary>
        public void Afisare()
        {
            Console.WriteLine($"{this.valoareMonetara}");
        }
    }
}
