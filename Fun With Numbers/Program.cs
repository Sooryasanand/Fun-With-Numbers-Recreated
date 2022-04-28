using System;
using System.IO;

namespace Fun_With_Numbers_Recreated
{
    class Program
    {
        // Used for Stats
        static int numbersEntered = 0;
        static int totalNum = 0;
        static int smallestnumber = 0;
        static int largestnumber = 0;
        static int coordinatesPlotted = 0;

        // The Main Menu / starting point
        static void Main(string[] args)
        {
            // Reads the stats
            ReadStats();

            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("Welcome to Fun With Numbers");
                Console.WriteLine("Choose from the menu below: ");
                Console.WriteLine(" (A) Check number features");
                Console.WriteLine(" (B) Plot numbers");
                Console.WriteLine(" (C) Check overall stats");
                Console.WriteLine("");
                Console.WriteLine(" (X) Save and exits");

                Console.Write("Choice: ");

                // Gets User Input and Converts into uppercase
                string selection = Console.ReadLine().ToUpper();

                // Opens the method based on the user's choice
                if (selection == "A")
                {
                    optionA();
                }
                else if (selection == "B")
                {
                    optionB();
                }
                else if (selection == "C")
                {
                    optionC();

                }
                else if (selection == "X")
                {
                    // Exits the Application
                    Environment.Exit(0);
                };
            }
            SaveStats();
        }


        // When option A is clicked
        static public void optionA()
        {
            // Used for Prime Numbers
            int a = 0;

            Console.Clear();
            Console.Write("Please enter a whole number that will be checked over: ");

            // Gets the user input about the number
            int wholenum = int.Parse(Console.ReadLine());


            Console.WriteLine("");
            Console.WriteLine("The features of " + wholenum + " are...");

            // Finds if the number is postive or negative
            if (wholenum > 0)
            {
                Console.WriteLine(" Positve");
            }
            else if (wholenum == 0)
            {
                Console.WriteLine(" Postive");
            }
            else
            {
                Console.WriteLine(" Negative");
            }

            // Finds if the number is Even or Odd
            if (wholenum % 2 == 0)
            {
                Console.WriteLine(" Even");
            }
            else
            {
                Console.WriteLine(" Odd");
            }

            // Finds all the Factors of the number
            Console.Write(" Factors are ");
            for (int x = 1; x <= wholenum; x++)
            {
                if (wholenum % x == 0)
                {
                    Console.Write(x + " ");
                }
            }
            Console.WriteLine("");

            // Finds if the number is prime or not
            for (int i = 1; i <= wholenum; i++)
            {
                if (wholenum % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine(" is a prime number");
            }
            else
            {
                Console.WriteLine(" Is not a prime number");
            }

            // For the Stats


            if (numbersEntered == 0)
            {
                smallestnumber = wholenum;
                largestnumber = wholenum;
            }
            else
            {
                if (wholenum < smallestnumber)
                {
                    smallestnumber = wholenum;
                }

                else if (wholenum > largestnumber)
                {
                    largestnumber = wholenum;
                }
            }

            numbersEntered++;
            totalNum = wholenum + totalNum;



            Console.ReadKey();
            return;

        }


        // When option B is clicked
        static public void optionB()
        {
            Console.Clear();
            // Create's a Plotter
            Console.WriteLine("                                             x axis");
            Console.WriteLine("      1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38");
            Console.WriteLine("   --------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("  1|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine("  2|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine("  3|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine("  4|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine("y 5|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine("a 6|                                                                                                                  |");
            Console.WriteLine("x  |                                                                                                                  |");
            Console.WriteLine("i 7|                                                                                                                  |");
            Console.WriteLine("s  |                                                                                                                  |");
            Console.WriteLine("  8|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine("  9|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine(" 10|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine(" 11|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine(" 12|                                                                                                                  |");
            Console.WriteLine("   --------------------------------------------------------------------------------------------------------------------");


            Console.WriteLine("Enter a corrdinate below to be added to the plot");

            // Check to see the exit function is true or not
            bool exit = false;

            while (!exit)
            {
                Console.Write("x-axis: ");

                // Gets the x-axis and saves them
                int xAxis = int.Parse(Console.ReadLine());

                // Checks if the x-axis is between our plotter
                if (xAxis >= 1 && xAxis <= 38)
                {
                    Console.Write("y-axis: ");
                    // Gets the y-axis and saves them
                    int yAxis = int.Parse(Console.ReadLine());

                    if (yAxis >= 1 && yAxis <= 12)
                    {
                        // Prints out the cursor from the axis's given by the user on to the plotter
                        Console.SetCursorPosition(0, 0);
                        Console.SetCursorPosition(3 + xAxis * 3, 1 + yAxis * 2);
                        Console.Write("x");
                        //Used For Stats
                        coordinatesPlotted++;
                        // For Spacing
                        Console.SetCursorPosition(0, 27);
                        Console.WriteLine("                                                      ");
                        Console.WriteLine("          ");
                        Console.WriteLine("          ");
                        Console.SetCursorPosition(0, 27);
                        // To Continue or Not
                        Console.Write("Do you wish to add another corrdinate (Y/N)? ");
                        // Gets user input and does accordingly.
                        string exitorno = Console.ReadLine().ToUpper();
                        if (exitorno == "N")
                        {
                            // Resets everything and goes back to the menu
                            Console.SetCursorPosition(0, 27);
                            Console.WriteLine("                                                      ");
                            Console.SetCursorPosition(0, 27);
                            Console.Write("Please enter to return to the menu...");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                            return;
                        }
                        else if (exitorno == "Y")
                        {
                            // Repeats the code
                            Console.SetCursorPosition(0, 27);
                            Console.WriteLine("                                                      ");
                            Console.SetCursorPosition(0, 27);
                        }
                        else
                        {
                            // Repeats the code
                            Console.SetCursorPosition(0, 27);
                            Console.WriteLine("                                                      ");
                            Console.SetCursorPosition(0, 27);
                        }
                    }
                }
            }

            Console.ReadKey();
        }


        // When option C is clicked
        static public void optionC()
        {
            //Saves the stats
            SaveStats();

            //Prints the Stats
            Console.Clear();
            Console.WriteLine("Here are your statics of overall use: ");
            Console.WriteLine($" Numbers entered: {numbersEntered}");
            Console.WriteLine($" Total of numbers: {totalNum}");
            Console.WriteLine($" Average of numbers: {totalNum / numbersEntered}");
            Console.WriteLine($" Smallest number entered: {smallestnumber}");
            Console.WriteLine($" Largest number entered: {largestnumber}");
            Console.WriteLine($" Coordinates plotted: {coordinatesPlotted}");
            Console.ReadKey();

        }

        // Saves the stats to the file
        static void SaveStats()
        {
            // Create's the txt file
            StreamWriter myFile = File.CreateText("stats.txt");
            // Writes the values to the txt file
            myFile.WriteLine(numbersEntered);
            myFile.WriteLine(totalNum);
            myFile.WriteLine(smallestnumber);
            myFile.WriteLine(largestnumber);
            myFile.WriteLine(coordinatesPlotted);
            myFile.Close();
        }

        // Reads the stats from the file
        static void ReadStats()
        {
            // To Check if the file exists or note
            if (!File.Exists("stats.txt"))
            {
                return;
            }

            StreamReader myFile = File.OpenText("stats.txt");
            numbersEntered = int.Parse(myFile.ReadLine());
            totalNum = int.Parse(myFile.ReadLine());
            smallestnumber = int.Parse(myFile.ReadLine());
            largestnumber = int.Parse(myFile.ReadLine());
            coordinatesPlotted = int.Parse(myFile.ReadLine());
            myFile.Close();
        }

    }
}