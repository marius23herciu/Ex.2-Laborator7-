using System;
using System.Globalization;

namespace Ex._2_Laborator7_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             • Ex 2 – conturi bancare
              Scrieti un program care va modela conturile bancare. Un cont bancar poate fi de
              economii sau cont curent.
             • In ambele conturi vom putea depune bani.
              La depunerea banilor soldul curent va crește cu valoarea depusa
             Din ambele contrui vom putea extrage bani
              În situatia in care suma ceruta depașește soldul curent, pe ecran va fi afișat un mesaj
             corespunzator, iar suma extrasă va fi 0
             • Contul de economii va oferi posibilitatea recalculării soldului astfel încât noului
             sold îi va fi adaugată dobânda corespunzatoare, valoarea dobânzii fiind
             specificată la fiecare recalculare.
             Creeați clasele, adăugați câteva instanțe in Main, testați și rulați programul

            • Exercițiul 2.1– contul de investiții
            Contul de investiții este un cont bancar care se comportă precum un cont de
            economii, cu mențiunea că nu vor putea fi extrași bani decât în situația în care
            termenul extragerii a fost atins.
            Dacă se incearcă extragerea banilor înainte de termen, contul va afișa un
            mesaj corespunzător iar suma extrasă va fi 0.
            Contul de investiții va pune la dispoziție o modalitate prin care se va putea
            specifica dacă termenul de extragere a fost sau nu atins. 
             */

            ClientID client = CreareClient();
            Console.WriteLine($"Doriti sa faceti modificari pentru clientul cu ID: {client.GetID()} ?   y/n");
            char raspuns = Console.ReadKey().KeyChar;
            if (raspuns == 'y')
            {
                Console.WriteLine();
                ContCurent contCurentModificare = client.GetContCurent();
                contCurentModificare = MiscariContCurent(contCurentModificare);

                if (client.GetNumarConturi() >= 2)
                {
                    Console.WriteLine($"Doriti sa faceti modificari in contul de economii?");
                    raspuns = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    if (raspuns == 'y')
                    {
                        Economii contEconomiiModificare = client.GetContEconomii();
                        contEconomiiModificare = MiscariContEconomii(contEconomiiModificare);
                    }
                }
                if (client.GetNumarConturi() == 3)
                {
                    Console.WriteLine($"Doriti sa faceti modificari in contul de Investitii?");
                    raspuns = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    if (raspuns == 'y')
                    {
                        Investitii contInvestitiiModificare = client.GetContInvestitii();
                        contInvestitiiModificare = MiscariContInvestitii(contInvestitiiModificare);
                    }
                }
            }
        }

        public static ClientID CreareClient()
        {
            Console.WriteLine("Introduceti ID-ul clientului");
            string ID = Console.ReadLine();
            Console.WriteLine("Introduceti numarul contului curent al clientului");
            string numarContCurent = Console.ReadLine();
            Console.WriteLine("Introduceti suma din contul curent al clientului");
            int valoareMonetaraCurent = int.Parse(Console.ReadLine());
            ContCurent contCurent = new ContCurent(numarContCurent, valoareMonetaraCurent);
            ClientID client = new ClientID(ID, contCurent);
            //Poate poti separa adugarea conturilor economii si investitii in functii diferite
            Console.WriteLine("Doriti sa adaugati un cont de economii? y/n");
            char raspuns = Console.ReadKey().KeyChar;
            Console.WriteLine();
            string numarContEconomii = string.Empty;
            int valoareMonetaraEconomii = 0;
            Economii contEconomii = new Economii(numarContEconomii, valoareMonetaraEconomii);
            if (raspuns == 'y')
            {
                Console.WriteLine("Introduceti numarul contului de economii al clientului");
                numarContEconomii = Console.ReadLine();
                Console.WriteLine("Introduceti suma din contul de economii al clientului");
                valoareMonetaraEconomii = int.Parse(Console.ReadLine());
                contEconomii = new Economii(numarContEconomii, valoareMonetaraEconomii);
                client = new ClientID(ID, contCurent, contEconomii);
            }
            if (raspuns != 'y')
            {
                return client;
            }
            Console.WriteLine("Doriti sa adaugati un cont de investitii? y/n");
            raspuns = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (raspuns == 'y')
            {
                Console.WriteLine("Introduceti numarul contului de investitii al clientului");
                string numarContInvestitii = Console.ReadLine();
                Console.WriteLine("Introduceti suma din contul de investitii al clientului");
                int valoareMonetaraInvestitii = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduceti data in care veti putea sa faceti retragere in format zz/LL/aaaa");
                string dataRetragere = Console.ReadLine();
                Investitii contInvestitii = new Investitii(numarContInvestitii, valoareMonetaraInvestitii, dataRetragere);
                client = new ClientID(ID, contCurent, contEconomii, contInvestitii);
            }
            return client;
        }
        public static ContCurent MiscariContCurent(ContCurent contCurent)
        {
            Console.WriteLine("Contul curent are valoarea: ");
            contCurent.Afisare();
            Console.WriteLine("Doriti sa adaugati bani in contul curent? y/n ");
            char raspuns = Console.ReadKey().KeyChar;
            //poate separi aduagarea si retragerea in 2 funtii: AdaugareContCurent si RetragereContCurent
            Console.WriteLine();
            if (raspuns == 'y')
            {
                Console.WriteLine("Introduceti suma pe care o adaugati: ");
                int plus = int.Parse(Console.ReadLine());
                contCurent.SetValoareMonetara(plus);
            }
            else
            {
                Console.WriteLine("Doriti sa retrageti bani in contul curent? y/n ");

                raspuns = Console.ReadKey().KeyChar;
                if (raspuns == 'y')
                {
                    Console.WriteLine();
                    Console.Write($"Puteti retrage maxim ");
                    Console.WriteLine(contCurent.GetSoldCurent());
                    Console.WriteLine("Introduceti suma pe care o retrageti: ");
                    int minus = int.Parse(Console.ReadLine());
                    double sold = contCurent.GetSoldCurent();
                    if (sold >= minus)
                    {
                        contCurent.SetValoareMonetara(-minus);
                    }
                    else
                    {
                        Console.WriteLine($"Fonduri insuficiente!");
                    }
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Valoarea actuala a contului curent: ");
            contCurent.Afisare();
            return contCurent;
        }
        public static Economii MiscariContEconomii(Economii contEconomii)
        {
            Console.WriteLine("Contul de economii are valoarea: ");
            contEconomii.Afisare();
            Console.WriteLine("Doriti sa adaugati bani in contul de economii ? y/n ");
            char raspuns = Console.ReadKey().KeyChar;
            //poate separi aduagarea si retragerea in 2 funtii: AdaugareContCurent si RetragereContCurent
            Console.WriteLine();
            if (raspuns == 'y')
            {
                Console.WriteLine("Introduceti suma pe care o adaugati: ");
                int plus = int.Parse(Console.ReadLine());
                contEconomii.SetValoareMonetara(plus);
                Console.WriteLine($"Noua dobanda este {contEconomii.GetDobanda()}.");
            }
            else
            {
                Console.WriteLine("Doriti sa retrageti bani in contul de economii? y/n ");

                raspuns = Console.ReadKey().KeyChar;
                if (raspuns == 'y')
                {
                    Console.WriteLine();
                    Console.Write($"Puteti retrage maxim ");
                    Console.WriteLine(contEconomii.GetSoldEconomii());
                    Console.WriteLine("Introduceti suma pe care doriti sa o retrageti: ");
                    int minus = int.Parse(Console.ReadLine());
                    double sold = contEconomii.GetSoldEconomii();
                    if (sold >= minus)
                    {
                        contEconomii.SetValoareMonetara(-minus);
                        Console.WriteLine($"Noua dobanda este {contEconomii.GetDobanda()}.");
                    }
                    else
                    {
                        Console.WriteLine($"Fonduri insuficiente!");
                    }
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Valoarea actuala a contului de economii: ");
            contEconomii.Afisare();
            return contEconomii;
        }

        public static Investitii MiscariContInvestitii(Investitii contInvestitii)
        {
            Console.WriteLine("Contul de investitii are valoarea: ");
            contInvestitii.Afisare();
            Console.WriteLine("Doriti sa adaugati bani in contul de investitii ? y/n ");
            char raspuns = Console.ReadKey().KeyChar;
            //poate separi aduagarea si retragerea in 2 funtii: AdaugareContCurent si RetragereContCurent
            Console.WriteLine();
            if (raspuns == 'y')
            {
                Console.WriteLine("Introduceti suma pe care o adaugati: ");
                int plus = int.Parse(Console.ReadLine());
                contInvestitii.SetValoareMonetara(plus);
                Console.WriteLine($"Noua dobanda este {contInvestitii.GetDobanda()}.");
            }
            else
            {
                Console.WriteLine("Doriti sa retrageti bani in contul de Investitii? y/n ");

                raspuns = Console.ReadKey().KeyChar;
                if (raspuns == 'y')
                {
                    string data = contInvestitii.GetDataRetragere();
                    DateTime dataRetragere = DateTime.ParseExact(data, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    if (dataRetragere < DateTime.Today)
                    {
                        Console.WriteLine();
                        Console.Write($"Puteti retrage maxim ");
                        Console.WriteLine(contInvestitii.GetSoldInvestitii());
                        Console.WriteLine("Introduceti suma pe care doriti sa o retrageti: ");
                        int minus = int.Parse(Console.ReadLine());
                        double sold = contInvestitii.GetSoldInvestitii();
                        if (sold >= minus)
                        {
                            contInvestitii.SetValoareMonetara(-minus);
                            Console.WriteLine($"Noua dobanda este {contInvestitii.GetDobanda()}.");
                        }
                        else
                        {
                            Console.WriteLine($"Fonduri insuficiente!");
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Veti putea retrage bani din contul de investitii dupa data de {data}");
                        Console.WriteLine($"Dobanda este {contInvestitii.GetDobanda()}.");
                    }
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Valoarea actuala a contului de Investitii: ");
            contInvestitii.Afisare();
            return contInvestitii;
        }
    }
}
