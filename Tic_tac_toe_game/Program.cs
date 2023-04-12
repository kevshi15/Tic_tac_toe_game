using System;

namespace Tic_tac_toe_game
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int i = 0;
            char[] pos = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int counter = 0;
            int placement = 0;
            bool valid = true;

            //Introducing game and displaying rules
            Console.WriteLine("Welcome to the Tic-Tac-Toe-Game!\n\n-The rules of this game are the following:\n\n-Two players min and max.\n\n-Each player will take turns choosing a corresponding spot on the board.\n\n-To do so,the player will be asked to pick a certain numbered space where they want to place their shape.\n\nTo win this game,a player must have a straight line either vertical or horizontal or a diagonal\nfilled with their corresponding shape.\n\nPress any key to continue!");
            Console.ReadKey();

            string[] N = new string[2]; //saving names into array

            //both player name input 
            for (i = 0; i < 2; i++)
            {
                Console.Write("Please enter Player " + (i + 1) + "'s name: ");
                N[i] = Console.ReadLine();
            }
            Console.Clear();
            for (i = 0; i < 9; i++) //game has max of 9 moves
            {
                //display input
                Console.WriteLine("\t  " + pos[0] + "|" + pos[1] + "|" + pos[2]);
                Console.WriteLine("\t---------");
                Console.WriteLine("\t  " + pos[3] + "|" + pos[4] + "|" + pos[5]);
                Console.WriteLine("\t---------");
                Console.WriteLine("\t  " + pos[6] + "|" + pos[7] + "|" + pos[8]);

                if (i%2==0)  //all pair number is player ones turn
                {
                    Console.WriteLine("\nIt's " + N[0] + "'s turn");
                    Console.Write("Please mark an area on the board(X):");
                    valid = int.TryParse(Console.ReadLine(), out placement);
                    while (valid == false || placement < 1 || placement > 9)
                    {
                        Console.WriteLine("Please enter a positive integer from 1 to 9");
                        valid = int.TryParse(Console.ReadLine(), out placement);
                    }
                    while (pos[placement - 1] == 'X' || pos[placement - 1] == 'O') //if position already marked,player will have to reinput a number 
                    {
                        Console.WriteLine("Please enter a positive integer from 1 to 9 that is not already marked");
                        valid = int.TryParse(Console.ReadLine(), out placement);
                        while (valid == false || placement < 1 || placement > 9)
                        {
                            Console.WriteLine("Please enter a positive integer from 1 to 9");
                            valid = int.TryParse(Console.ReadLine(), out placement);
                        }
                    }

                    pos[placement - 1] = 'X';
                }

                else  //odd number is player twos turn
                {

                    Console.WriteLine("\nIt's " + N[1] + "'s turn");
                    Console.Write("Please mark an area on the board(O):");
                    valid = int.TryParse(Console.ReadLine(), out placement);
                    while (valid == false || placement < 1 || placement > 9)
                    {
                        Console.WriteLine("Please enter a positive integer from 1 to 9");
                        valid = int.TryParse(Console.ReadLine(), out placement);
                    }
                    while (pos[placement - 1] == 'X' || pos[placement - 1] == 'O')
                    {
                        Console.WriteLine("Please enter a positive integer from 1 to 9 that is not already marked");
                        valid = int.TryParse(Console.ReadLine(), out placement);
                        while (valid == false || placement < 1 || placement > 9)
                        {
                            Console.WriteLine("Please enter a positive integer from 1 to 9");
                            valid = int.TryParse(Console.ReadLine(), out placement);
                        }
                    }

                    pos[placement - 1] = 'O';
                }
                if  //these are all the possible winnings can be vertical line,horizontal line,or diagonal line
                                (pos[0] == pos[3] && pos[3] == pos[6] ||
                                pos[1] == pos[4] && pos[4] == pos[7] ||
                                pos[2] == pos[5] && pos[5] == pos[8] ||
                                pos[0] == pos[1] && pos[1] == pos[2] ||
                                pos[3] == pos[4] && pos[4] == pos[5] ||
                                pos[6] == pos[7] && pos[7] == pos[8] ||
                                pos[0] == pos[4] && pos[4] == pos[8] ||
                                pos[6] == pos[4] && pos[4] == pos[2]
                                )
                {
                    Console.Clear(); //each time postion is marked new display is brought
                    Console.WriteLine("\t  " + pos[0] + "|" + pos[1] + "|" + pos[2]);
                    Console.WriteLine("\t---------");
                    Console.WriteLine("\t  " + pos[3] + "|" + pos[4] + "|" + pos[5]);
                    Console.WriteLine("\t---------");
                    Console.WriteLine("\t  " + pos[6] + "|" + pos[7] + "|" + pos[8]);
                    if (counter%2==0) //if player one wins
                        Console.WriteLine("\n\nCongratulation " + N[0] + ".YOU ARE THE WINNER!!! ");

                   else
                        Console.WriteLine("\n\nCongratulation " + N[1] + ". YOU ARE THE WINNER!!! ");//if player two wins

                    break;
                }


                counter++;
                Console.Clear();
            }


            if (counter == 9) //if 9 moves have been used that means game has tied so display this message
                Console.WriteLine("\n\nTOUGH GAME.THE GAME ENDS AS A TIE!");
        }
    }
}





        
    

