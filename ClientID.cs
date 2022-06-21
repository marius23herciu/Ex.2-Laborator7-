using System;
using System.Collections.Generic;
using System.Text;

namespace Ex._2_Laborator7_
{
    class ClientID
    {
        private string clientID;
        private ContCurent contCurent;
        private Economii contEconomii;
        private Investitii contInvestitii;
        /// <summary>
        /// Creaza ID-ul Clientului si Contul Curent.
        /// </summary>
        /// <param name="clientID"></param>
        /// <param name="contCurent"></param>
        public ClientID(string clientID, ContCurent contCurent)
        {
            this.clientID = clientID;
            this.contCurent = contCurent;
        }
        /// <summary>
        /// Creaza ID-ul Clientului, Contul Curent si Contul de Economii.
        /// </summary>
        /// <param name="clientID"></param>
        /// <param name="contCurent"></param>
        /// <param name="contEtconomii"></param>
        public ClientID(string clientID, ContCurent contCurent, Economii contEtconomii)
        {
            this.clientID = clientID;
            this.contCurent = contCurent;
            this.contEconomii = contEtconomii;
        }
        /// <summary>
        /// Creaza ID-ul Clientului, Contul Curent si Contul de Investitii.
        /// </summary>
        /// <param name="clientID"></param>
        /// <param name="contCurent"></param>
        /// <param name="contInvestitii"></param>
        public ClientID(string clientID, ContCurent contCurent, Investitii contInvestitii)
        {
            this.clientID = clientID;
            this.contCurent = contCurent;
            this.contInvestitii = contInvestitii;
        }
        /// <summary>
        /// Creaza ID-ul Clientului, Contul Curent, Contul de Economii si Contul de Investitii.
        /// </summary>
        /// <param name="clientID"></param>
        /// <param name="contCurent"></param>
        /// <param name="contEtconomii"></param>
        /// <param name="contInvestitii"></param>
        public ClientID(string clientID, ContCurent contCurent, Economii contEtconomii, Investitii contInvestitii)
        {
            this.clientID = clientID;
            this.contCurent = contCurent;
            this.contEconomii = contEtconomii;
            this.contInvestitii = contInvestitii;
        }
        /// <summary>
        /// Returneaza Cont Curent.
        /// </summary>
        /// <returns></returns>
        public ContCurent GetContCurent()
        {
            return this.contCurent;
        }
        /// <summary>
        /// Returneaza Cont Economii.
        /// </summary>
        /// <returns></returns>
        public Economii GetContEconomii()
        {
            return this.contEconomii;
        }
        /// <summary>
        /// Returneaza Cont Investitii
        /// </summary>
        /// <returns></returns>
        public Investitii GetContInvestitii()
        {
            return this.contInvestitii;
        }
        /// <summary>
        /// Returneaza ID-ul clientului.
        /// </summary>
        /// <returns></returns>
        public string GetID()
        {
            return this.clientID;
        }

    }
}
