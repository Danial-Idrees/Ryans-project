using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static public int square_1()
        {
            int squarenum = 1;
            Console.WriteLine("You wake up in a forest, to the east is a bungalow, to the south is a house");
            Console.WriteLine("Go east");
            Console.WriteLine("Go south");

            string action = Console.ReadLine();

            switch (action)
            {

                case "south":
                    squarenum = squarenum + 5;
                    break;

                case "east":
                    squarenum = squarenum + 1;
                    break;


            }
            return squarenum;
        }


        static public int square_2()
        {
            int squarenum = 2;
            Console.WriteLine("You are in a bungalow, to the east is table with symbols, and to the south is a garden");
            Console.WriteLine("Go east");
            Console.WriteLine("Go south");

            string action = Console.ReadLine();

            switch (action)
            {

                case "south":
                    squarenum = squarenum + 5;
                    break;

                case "east":
                    squarenum = squarenum + 1;
                    break;


            }
            return squarenum;
        }

        static public int square_3()
        {
            int squarenum = 3;
            Console.WriteLine("You are at table with symbols on it, underneath is a trap door you can enter, to the south is a porch outside the bungalow");
            Console.WriteLine("Go east to trap door");
            Console.WriteLine("Go south");

            string action = Console.ReadLine();

            switch (action)
            {


                case "south":
                    squarenum = squarenum + 5;
                    break;

                case "east":
                    squarenum = squarenum + 1;
                    break;


            }
            return squarenum;
        }

        static public int square_6()
        {
            int squarenum = 6;
            Console.WriteLine("You have come to a house, to the east is a backgarden, to the south is a staircase,");
            Console.WriteLine("Go east");
            Console.WriteLine("Go south");


            string action = Console.ReadLine();

            switch (action)
            {


                case "south":
                    squarenum = squarenum + 5;
                    break;

                case "east":
                    squarenum = squarenum + 1;
                    break;


            }
            return squarenum;
        }

        static public int square_7()
        {
            int squarenum = 7;
            Console.WriteLine("You are in a backgarden, to the north is the bungalow, to the east is a porch outside the bungalow, to the south is a side door to house");
            Console.WriteLine("Go north");
            Console.WriteLine("Go east");
            Console.WriteLine("Go south ");

            string action = Console.ReadLine();

            switch (action)
            {
                case "north":
                    squarenum = squarenum - 5;
                    break;

                case "south":
                    squarenum = squarenum + 5;
                    break;

                case "east":
                    squarenum = squarenum + 1;
                    break;


            }
            return squarenum;
        }

        static public int square_8()
        {
            int squarenum = 8;
            Console.WriteLine("You are at the porch, to the north a table with symbols in the bungalow, to the east is an open field, to the south is a hatch in a field.");
            Console.WriteLine("Go east");
            Console.WriteLine("Go south");
            Console.WriteLine("Go north");


            string action = Console.ReadLine();

            switch (action)
            {
                case "north":
                    squarenum = squarenum - 5;
                    break;

                case "south":
                    squarenum = squarenum + 5;
                    break;

                case "east":
                    squarenum = squarenum + 1;
                    break;
            }
            return squarenum;
        }

        static public int square_4()
        {
            int squarenum = 4;
            Console.WriteLine("You have fallen through the trap door, to the east is a small door, to the south is a dark room.");
            Console.WriteLine("Go east");
            Console.WriteLine("Go south");



            string action = Console.ReadLine();

            switch (action)
            {

                case "south":
                    squarenum = squarenum + 5;
                    break;

                case "east":
                    squarenum = squarenum + 1;
                    break;

            }
            return squarenum;
        }

        static public int square_9()
        {
            int squarenum = 9999;
            Console.WriteLine("You have fallen into a spike trap and died, game over");
            Console.ReadLine();

            return squarenum;
        }

        static public int square_5()
        {
            int squarenum = 5;
            Console.WriteLine("You have entered a long corridor that turns south, you can go forward towards a large room or go back.");
            Console.WriteLine("Go east");
            Console.WriteLine("Go south to room");



            string action = Console.ReadLine();

            switch (action)
            {


                case "south":
                    squarenum = squarenum + 5;
                    break;

                case "east":
                    squarenum = squarenum + 1;
                    break;


            }
            return squarenum;
        }

        static public int square_11()
        {
            int squarenum = 11;
            Console.WriteLine("You find a staircase, carry on south to go up, east is a window to an open field, ");
            Console.WriteLine("Go east");
            Console.WriteLine("Go south");

            string action = Console.ReadLine();

            switch (action)
            {

                case "south":
                    squarenum = squarenum + 5;
                    break;

                case "east":
                    squarenum = squarenum + 1;
                    break;


            }
            return squarenum;
        }


        static public int square_12()
        {
            int squarenum = 12;
            Console.WriteLine("You have climbed out of a small window, to the east is a small hatch in an open field, to the south there is a road, to the north is the backgarden");
            Console.WriteLine("Go east");
            Console.WriteLine("Go south");
            Console.WriteLine("Go north");



            string action = Console.ReadLine();

            switch (action)
            {
                case "north":
                    squarenum = squarenum - 5;
                    break;

                case "south":
                    squarenum = squarenum + 5;
                    break;

                case "east":
                    squarenum = squarenum + 1;
                    break;
            }
            return squarenum;

        }


        static void Main(string[] args)
        {
            int squarenum = 1;
            while (squarenum > 0 && squarenum < 999)
            {
                switch (squarenum)
                {
                    case 1:
                        squarenum = square_1();
                        break;
                    case 2:
                        squarenum = square_2();
                        break;
                    case 3:
                        squarenum = square_3();
                        break;
                    case 6:
                        squarenum = square_6();
                        break;
                    case 7:
                        squarenum = square_7();
                        break;
                    case 8:
                        squarenum = square_8();
                        break;
                    case 4:
                        squarenum = square_4();
                        break;
                    case 9:
                        squarenum = square_9();
                        break;
                    case 5:
                        squarenum = square_5();
                        break;
                    case 11:
                        squarenum = square_11();
                        break;
                    case 12:
                        squarenum = square_12();
                        break;




                }


            }
        }



    }
}