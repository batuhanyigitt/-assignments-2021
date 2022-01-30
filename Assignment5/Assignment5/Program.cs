using System;
using System.Collections.Generic;

namespace Assigment5
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateNow = DateTime.UtcNow.ToString("yyyy-MM-dd");
            string fileName = dateNow + ".txt";

            string ThisSave = System.IO.Path.Combine(@"./", fileName);

            List<string> captainsLog = new List<string>();
            Console.WriteLine("Write the text this area : ");
            string userInput;

            bool typingnow = true;

            while (typingnow != false)
            {
                userInput = Console.ReadLine();
                if (userInput == "start")
                {
                    do
                    {
                        userInput = Console.ReadLine();
                        if (userInput != "stop")
                        {
                            captainsLog.Add(userInput);
                        }
                    } while (userInput != "stop");

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(ThisSave))
                    {
                        file.WriteLine("Captains's log \nStardate " + dateNow + "\n");
                        foreach (var allwewant in captainsLog)
                        {
                            file.WriteLine(allwewant);
                        }
                        file.WriteLine("\n" + "Jean-Luc Picard");
                    }

                    if (userInput == "stop")
                    {
                        typingnow = false;
                    }
                }
            }
        }
    }
}