using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01Intro
{
    public class Intro
    {
        static void PrintFile(string FileName)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(FileName);
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                counter++;
            }
            file.Close();
            Thread.Sleep(1500);
            Console.Clear();
        }
        public static void IntroAnimation()
        {
        
            PrintFile("../../IntroHungry.txt");
            PrintFile("../../IntroPython.txt");
            PrintFile("../../IntroPythonAnimal.txt");
            PrintFile("../../BeBlessed.txt");

           
            // Suspend the screen.

            
            Console.ReadLine();
        }
    }
}
