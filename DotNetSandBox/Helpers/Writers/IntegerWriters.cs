using DotNetSandBox.Helpers.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSandBox.Helpers.Writers
{
    public class IntegerWriters
    {
        public int SelectionWriter(string msg)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(msg);
                    var userInput = Console.ReadLine();

                    if (userInput.Equals(""))
                    {
                        Console.WriteLine("Please insert a valid input please");
                        continue;
                    }

                    if (!userInput.IsValidNumber())
                    {
                        Console.WriteLine("Your input is not valid, please enter a valid number");
                        continue;
                    }

                    var numberSelector = Convert.ToInt32(userInput);

                    if (numberSelector <= 3)
                    {
                        return numberSelector;
                    }
                    else
                    {
                        Console.WriteLine("Your input is valid, however it needs to be less than 3 to be correct");
                        continue;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public int SelectionWriter(string msg, string userInput)
        {
            try
            {
                Console.WriteLine(msg);

                if (!userInput.IsValidNumber()) return -1;

                var numberSelector = Convert.ToInt32(userInput);

                if (numberSelector <= 3) return numberSelector;
                else return -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int IntWriter(string msg)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(msg);
                    var userInput = Console.ReadLine();

                    if (userInput.Equals(""))
                    {
                        Console.WriteLine("Please insert a valid input please");
                        continue;
                    }

                    if (!userInput.IsValidNumber())
                    {
                        Console.WriteLine("Your input is not valid, please enter a valid number");
                        continue;
                    }

                    return Convert.ToInt32(userInput);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public int IntWriter(string msg, string userInput)
        {
            try
            {
                Console.WriteLine(msg);

                if (!userInput.IsValidNumber()) return -1;

                return Convert.ToInt32(userInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
    }
}
