using System;
namespace Deliverable__1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Tries all lines of code inside of brackets
            try
            {
                //The variables used
                string series = "";
                int input = 0;
                
                //To check if input is an integer in between 1 and 100 and loop until acceptable input
                while (true)
                {
                    Console.WriteLine("Please enter an integer between 1 and 100: ");
                    input = int.Parse(Console.ReadLine());

                    if (input >= 1 && input <= 100)
                    {
                        break;
                    }
                }

                //To check if input is an either even or odd and loop until acceptable input 
                while (true)
                {
                    Console.Write("Please choose even or odd: ");
                    series = Console.ReadLine();

                    if (series == "even" || series == "odd")
                    {
                        break;
                    }
                }
                
                    //If even series is chosen
                    if (series == "even")
                    {
                        //To display the message of what series the user has chosen and calculate distance between 0 and the chosen integer
                        Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + " are: ");
                        for (int i = 0; i <= input; i = i + 2)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    
                    //If odd series is chosen
                    if (series == "odd")
                    {
                        //To display the message of what series the user has chosen and calculate distance between 0 and the chosen integer
                        Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + " are: ");
                        for (int i = 1; i <= input; i = i + 2)
                        {
                            Console.WriteLine(i);
                        }
                    }
                
            }
            //To catch any erroneous inputs from the user
            catch
            {
                //Tells user to input integer between 1-100
                //Tells user to specify even or odd values
                Console.WriteLine("Please try one of the following:");
                Console.WriteLine("Enter an integer value between 1 and 100 and try again");
                Console.WriteLine("Specify even or odd values and try again");
                Console.ReadKey(true);
            }
           
        }
    }
}
