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
        /// Depune numerar in soldul contului de investitii.
        /// </summary>
        /// <param name="adaugare"></param>
        public void DepunereValoareMonetara()
        {
            int plus = int.Parse(Console.ReadLine());
            this.valoareMonetara += plus;
            Console.WriteLine($"Noua dobanda lunara este {this.valoareMonetara * 0.005}.");
        }
        /// <summary>
        /// Retrage numerar din contul de investitii.
        /// </summary>
        public void RetragererValoareMonetara()
        {
            int minus = int.Parse(Console.ReadLine());
            if (this.valoareMonetara >= minus)
            {
                this.valoareMonetara -= minus;
                Console.WriteLine($"Noua dobanda lunara este {this.valoareMonetara * 0.005}.");
            }
            else
            {
                Console.WriteLine($"Fonduri insuficiente!");
            }
        }
        /// <summary>
        /// Verifica daca data de retragere a fost atinsa.
        /// </summary>
        /// <returns></returns>
        public bool CheckDataRetragere()
        {
            bool termenAtins = false;
            DateTime dataRetragere = DateTime.ParseExact(this.dataRetragere, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            if (dataRetragere <= DateTime.Today)
            {
                termenAtins = true;
            }
            return termenAtins;
        }
        /// <summary>
        /// Adauga dobanda soldului din contul de investitii.
        /// </summary>
        public void RecalculareSold()
        {
            this.valoareMonetara += this.valoareMonetara * 0.005;
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
