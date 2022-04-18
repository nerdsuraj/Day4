using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class SnackLadder1
    {
        public static int num1, optNum1;
        public static int position = 0;
        public static int dicecount = 0;


        public static void SingleMethod()
        {
            
            Console.WriteLine(" Single player Snake Ladder Game ");
            while (position < 100)
            {
                //value for dice
                Random obj1 = new Random();
                num1 = obj1.Next(1, 7);

                // value for option
                Random opt1 = new Random();
                optNum1 = opt1.Next(1, 4);

                if (optNum1 == 1)  //optNum1=1 ----no play ,,,,, optNum1=2 ----ladder,,,,optNum1=3 ----snake
                {

                    dicecount++;
                    Console.WriteLine("You got NO PLAY Option  \n Dice value: {0} \n", num1);

                }
                else if (optNum1 == 2)
                {
                    Console.WriteLine("You got Ladder Option \n  Dice value: {0} \n", num1);
                    dicecount++;
                    position = position + num1;

                    if (position > 100)
                    {
                        dicecount++;
                        position = position - num1;
                        Console.WriteLine("You got Ladder  \n Dice value: {0} \n", num1);


                    }

                    Console.WriteLine(" your position: {0}", position);

                }
                else
                {

                    dicecount++;
                    position = position - num1;

                    Console.WriteLine("You got Snake Option\n Dice value: {0}\n", num1);

                    if (position < 0)
                    {

                        position = 0;

                        Console.WriteLine("\n Starting game  again \n");


                    }
                    Console.WriteLine("You got snake \n your position: {0} \n ", position);

                }




            }
            Console.WriteLine("Number of times dice Roll for winning 100 positin is : {0}", dicecount);
        }
    }
}
