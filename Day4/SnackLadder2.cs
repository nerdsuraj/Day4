using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class SnackLadder2
    {
        public static int num1, num2, num3, num4, optNum1, optNum2, diff3;
        public static int position1 = 0, position2 = 0;
        public static int dicecount1 = 0, dicecount2 = 0;
        public static void TwoPlayerMethod()
        {
            Console.WriteLine("\n\n Two player game Begins here....................................................................................\n");

            while (position1 < 100 && position2 < 100)
            {
                //value for dice of player1
                Random obj1 = new Random();
                num1 = obj1.Next(1, 7);

                //value for dice of player2
                Random obj2 = new Random();
                num2 = obj1.Next(1, 7);

                // value for option for player1
                Random opt1 = new Random();
                optNum1 = opt1.Next(1, 4);

                // value for option for player2
                Random opt2 = new Random();
                optNum2 = opt2.Next(1, 4);

                if (optNum1 == 1)  //optNum1=1 ----no play ,,,,, optNum1=2 ----ladder,,,,optNum1=3 ----snake
                {
                    dicecount1++;//  dicecount = dicecount+1;
                    Console.WriteLine("Player1 got NO PLAY Option \n Player1 Dice value: {0} \n Player1 Position: {1}\n", num1, position1);
                }
                else if (optNum1 == 2)
                {
                    position1 = position1 + num1;

                    if (position1 > 100)
                    {
                        position1 = position1 - num1;
                    }

                    Console.WriteLine("Player1 got Ladder Option \n Player1 Dice value: {0} \n player1 position : {1}", num1, position1);
                    Console.WriteLine("Playing again since Player1 got ladder ");
                    //Again rolling dice since got ladder
                    Random obj3 = new Random();
                    num3 = obj3.Next(1, 7);
                    position1 = position1 + num3;
                    Console.WriteLine("Player1 second chance Dice value: {0} ", num3);
                    dicecount1++;
                    dicecount1++;

                    if (position1 > 100)
                    {
                        position1 = position1 - num3;
                        Console.WriteLine("Player1 got Ladder \n Player1 Dice value: {0} ", num3);
                    }
                    Console.WriteLine(" Player1 position: {0}\n", position1);
                }

                else
                {
                    dicecount1++;
                    position1 = position1 - num1;
                    if (position1 < 0)
                    {
                        position1 = 0;
                        Console.WriteLine(" Starting game  again fpr Player1");
                    }
                    Console.WriteLine("Player1 got snake \n Player1 position: {0} ", position1);
                    Console.WriteLine("Player1 Dice value: {0}\n", num1);
                }

                // Programing for player 2...................................................................

                if (optNum2 == 1)  //optNum1=1 ----no play ,,,,, optNum1=2 ----ladder,,,,optNum1=3 ----snake
                {
                    dicecount2++;    //  dicecount = dicecount+1;
                    Console.WriteLine("Player2 got NO PLAY Option \n Player2 Dice value: {0} \n", num1);
                }
                else if (optNum2 == 2)
                {
                    dicecount2++;
                    position2 = position2 + num2;

                    if (position2 > 100)
                    {
                        position2 = position2 - num2;
                    }

                    Console.WriteLine("Player2 got Ladder Option \n Player2 Dice value: {0} \n player2 position : {1} ", num2, position2);
                    Console.WriteLine("Playing again since Player2  got ladder ");
                    Random obj4 = new Random();
                    num4 = obj4.Next(1, 7);
                    position2 = position2 + num4;
                    Console.WriteLine(" Player2 second chance Dice value: {0} ", num4);
                    dicecount2++;

                    if (position2 > 100)
                    {
                        position2 = position2 - num4;
                        Console.WriteLine("Player2 got Ladder \n Player2 Dice value: {0} ", num2);
                    }
                    Console.WriteLine(" Player2 position: {0}\n", position2);
                }
                else
                {
                    dicecount2++;
                    position2 = position2 - num2;
                    Console.WriteLine("\nPlayer2 got Snake Option \n Player2 Dice value: {0}", num2);
                    if (position2 < 0)
                    {
                        position2 = 0;
                        Console.WriteLine(" Starting game  again for Player2 ");
                    }
                    Console.WriteLine(" Player2 position: {0} \n ", position2);
                }
            }

            if (position1 > position2)
            {
                diff3 = position1 - position2;
                Console.WriteLine("\nPlayer 1 win over player 2 by " + diff3);
            }
            else
            {
                diff3 = position2 - position1;
                Console.WriteLine("\nPlayer 2 win over player 1 by " + diff3);
            }
            Console.WriteLine("\nNumber of times dice Roll for Player2 : {0}", dicecount2);
            Console.WriteLine("\nNumber of times dice Roll for Player1 : {0}", dicecount1);
        }
    }
}
