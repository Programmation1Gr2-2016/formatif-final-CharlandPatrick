using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Auteur: Patrick Charland
 * 29-11-2016
 * Description: Exercice sur For Loop.
 */
namespace ExamenFormatif_Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            bool[] tableGameBoard = new bool[100];
            int nbRandomValue = 0;
            Random rnd = new Random();

            //Génération du tableau
            for(int i = 0; i<tableGameBoard.Length;i++)
            {
                nbRandomValue = rnd.Next(2);
                if (nbRandomValue == 0)
                {
                    tableGameBoard[i] = true;
                }
                else
                {
                    tableGameBoard[i] = false;
                }
                Console.Write(tableGameBoard[i]+" ");
            }
            Console.ReadKey();

        }
    }
}
