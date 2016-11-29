using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Auteur: Patrick Charland
 * 29-11-2016
 * Description: Examen formatif 3
 */

namespace ExamenFormatif3_Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration variables
            int nbChoixJoueur = 0;
            int nbSomme = 0;
            bool pair = true;

            //Prise de données
            Console.WriteLine("Veuillez choisir un nombre: ");
            Console.Write("Choix: ");
            nbChoixJoueur = int.Parse(Console.ReadLine());

            //Calcul
            if((nbChoixJoueur%2)==0)
            {
                pair = true;
            }
            else
            {
                pair = false;
            }

            for (int i = 0; i <= nbChoixJoueur;)
            {
                if(pair)
                {
                    nbSomme += i;
                    i += 2;
                    Console.Write(nbSomme + " ");
                }
                else
                {
                    nbSomme += i;
                    if (i==0)
                    {
                        i += 1;
                        
                    }
                    else
                    {
                        i += 2;
                    }      
                    Console.Write(nbSomme + " ");
                }
            }
            Console.WriteLine("\n"+nbSomme);
            Console.ReadKey();

        }
    }
}
