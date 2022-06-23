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
        }
        /// <summary>
        /// Retrage numerar din contul de investitii.
        /// </summary>
        public int RetragererValoareMonetara()
        {
            int minus = int.Parse(Console.ReadLine());
            if (CheckDataRetragere() == true)
            {
                if (this.valoareMonetara >= minus)
                {
                    this.valoareMonetara -= minus;
                    return minus;
                }
                else
                {
                    Console.WriteLine($"Fonduri insuficiente!");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Veti putea retrage bani din contul de investitii incepand cu data de {GetDataRetragere()}");
            }
            return 0;
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
        /// Recalculeaza si adauga dobanda soldului din contul de investitii.
        /// </summary>
        public void RecalculareSold()
        {
            double dobanda = this.valoareMonetara * 0.005;
            this.valoareMonetara += dobanda;
            Console.WriteLine($"Dobanda adaugata este {dobanda}.");
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
