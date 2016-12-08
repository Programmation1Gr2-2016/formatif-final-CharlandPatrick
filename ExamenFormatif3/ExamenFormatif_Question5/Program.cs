using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Auteur: Patrick Charland
 * 29-11-2016
 * Description: Exercice sur For Loop.
 * 8 / 15
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
            int playerPosition = 0;
            bool gameOn = true;
            string keyPressed = "";
            string modeAffichage = "p";
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
            tableGameBoard[0] = true;
            tableGameBoard[99] = true;

            //Game logic

            while(gameOn)
            {
                Console.Clear();
                Console.WriteLine("Veuillez appuyer sur [A,S,D,G ou H] puis confirmer avec [ENTRER]");
                Console.WriteLine("(Appuyer sur [P] pour afficher les 10 prochaines cases ou [Y] pour l'entièretée du tableau");
                Console.WriteLine("Appuyer sur [Q] pour quitter");
                keyPressed = Console.ReadLine();

                switch(keyPressed.ToLower()) // a s d g h
                {
                    case "a":
                        if(playerPosition>2)
                        {
                            if(tableGameBoard[playerPosition-3]==true)
                            {
                                playerPosition -= 3;
                                if(modeAffichage.ToLower() == "p")
                                {
                                    Affichage10(tableGameBoard, playerPosition);
                                    Console.WriteLine("Position: " + playerPosition);
                                }
                                else if (modeAffichage.ToLower() == "y")
                                {
                                    AffichageEntier(tableGameBoard, playerPosition);
                                    Console.WriteLine("Position: " + playerPosition);
                                }
                            }
                        }
                        break;

                        // Autres touches?
                }
            }


            Console.ReadKey();

        }
        static void AffichageEntier(bool[] tableGameBoard,int playerPosition)
        {
            string displayCell = "";

            Console.Clear();
            for (int i = 0; i < tableGameBoard.Length; i++)
            {
                
                if(tableGameBoard[i]==true)
                {
                    displayCell = "[_]";
                }
                else if (tableGameBoard[i] == false)
                {
                    displayCell = "[X]";
                }
                if(i==playerPosition)
                {
                    displayCell = "[#]";
                }
                Console.Write(displayCell);
            }
        }
        static void Affichage10(bool[] tableGameBoard, int playerPosition)
        {
            string displayCell = "";
            int cellLimit = 0;

            Console.Clear();


            // cell Limit = tableGameBoard.Length - playerPosition (Pour 90 et +)
            switch (playerPosition)
            {
                case 90:
                    cellLimit = 10;
                    break;
                case 91:
                    cellLimit = 9;
                    break;
                case 92:
                    cellLimit = 8;
                    break;
                case 93:
                    cellLimit = 7;
                    break;
                case 94:
                    cellLimit = 6;
                    break;
                case 95:
                    cellLimit = 5;
                    break;
                case 96:
                    cellLimit = 4;
                    break;
                case 97:
                    cellLimit = 3;
                    break;
                case 98:
                    cellLimit = 2;
                    break;
                case 99:
                    cellLimit = 1;
                    break;
                default:
                    cellLimit = 10;
                    break;
            }

            for (int i = playerPosition; i <=cellLimit; i++)
            {

                if (tableGameBoard[i] == true)
                {
                    displayCell = "[_]";
                }
                else if (tableGameBoard[i] == false)
                {
                    displayCell = "[X]";
                }
                if (i == playerPosition)
                {
                    displayCell = "[#]";
                }
                Console.Write(displayCell);
            }
        }
    }
}


