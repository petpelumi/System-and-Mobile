using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCK_PAPER_SCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string Player;
            string AI;
            int myAI;
            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine("\t\t\t ROCK, PAPER AND SCISSORS");
               
                int Playerscore = 0;
                int AIscore = 0;



                while (Playerscore < 2 && AIscore < 2)
                {
                   
                    Player = Console.ReadLine();
                    Player = Player.ToUpper();

                    Random rand = new Random();
                    myAI = rand.Next(1,4);


                    switch (myAI)
                    {
                        case 1:
                            AI = "ROCK";
                            Console.WriteLine("\t AI CHOSE ROCK");
                            if (Player == "ROCK")
                            {
                                Console.WriteLine("\t\t DRAW");
                            }
                            else if (Player == "PAPER")
                            {
                                Console.WriteLine("\t\t PLAYER WINS");
                                Playerscore++;
                            }
                            else if (Player == "SCISSORS")
                            {
                                Console.WriteLine("\t\t AI WINS");
                                AIscore++;
                            }
                            else
                            {
                                Console.WriteLine("..................INVALID ENTRY : PLEASE ENTER ROCK, PAPER OR SCISSORS.....................");
                            }
                            break;

                        case 2:
                            AI = "PAPER";
                            Console.WriteLine("\t AI CHOSE PAPER");
                            if (Player == "PAPER")
                            {
                                Console.WriteLine("\t\t DRAW");
                            }
                            else if (Player == "ROCK")
                            {
                                Console.WriteLine("\t\t AI WINS");
                                AIscore++;
                            }
                            else if (Player == "SCISSORS")
                            {
                                Console.WriteLine("\t\t PLAYER WINS");
                                Playerscore++;
                            }
                            else
                            {
                                Console.WriteLine("..................INVALID ENTRY : PLEASE ENTER ROCK, PAPER OR SCISSORS.....................");
                            }
                            break;

                        case 3:
                            AI = "SCISSORS";
                            Console.WriteLine("\t AI CHOSE SCISSORS");
                            if (Player == "SCISSORS")
                            {
                                Console.WriteLine("\t\t DRAW");
                            }
                            else if (Player == "ROCK")
                            {
                                Console.WriteLine("\t\t PLAYER WINS");
                                Playerscore++;
                            }
                            else if (Player == "PAPER")
                            {
                                Console.WriteLine("\t\t AI WINS");
                                AIscore++;
                            }
                            else
                            {
                                Console.WriteLine("..................INVALID ENTRY : PLEASE ENTER ROCK, PAPER OR SCISSORS.....................");
                            }
                            break;
                    }

                    Console.WriteLine("\t\t\t Player Score:({0}) AI Score:({1})", Playerscore, AIscore);
                    
                }
                if (Playerscore == 2)
                {
                    Console.WriteLine("\n \t\t\t\t PLAYER WON!!!");
                }
                else if (AIscore == 2)
                {
                    Console.WriteLine("\n \t\t\t\t AI WON!!!");
                }
            start:
                Console.WriteLine("Do you wish to play again? >>Enter Y/N <<");

               
                string retry = Console.ReadLine();
                if (retry == "y" || retry == "Y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (retry == "n" || retry == "N")
                {
                    playAgain = false;
                }
//simpler to test for entered key  else {Console.WriteLine("invalid input pls enter y or n");
                else if(retry != "N" || retry != "n" && retry != "y" || retry != "Y")
                {
                    Console.WriteLine("Please Enter 'Y' " + "Or 'N'");
                    goto start;
                }          
                
            }
            Console.ReadKey();
        }
    }
}
