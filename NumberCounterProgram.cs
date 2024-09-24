using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NumberCounter
{
    public class NumberCounterProgram
    {
        
        public float Current_Number = 0;
        public bool running = true;
        public void DisplayInfo()
        {
            Clear();
            WriteLine("Press 1 to Add a Number, Press 2 to subtract a number, press 3 to exit. ");
            WriteLine("Current Number Is: " + Current_Number);
        }
        public void Numbers()
        {
            while (running)
            {
                mainprogram:
                DisplayInfo();
                if (ReadKey(true).Key == ConsoleKey.D1)
                {
                    Current_Number++;
                }
                if (ReadKey(true).Key == ConsoleKey.D2)
                {
                    Current_Number--;
                }
                if (ReadKey(true).Key == ConsoleKey.D3)
                {
                    WriteLine("Press ENTER to close the console:");
                    if(ReadKey(true).Key == ConsoleKey.Enter)
                    {
                        running = false;
                    }
                    else if(ReadKey(true).Key != ConsoleKey.Enter)
                    {
                        goto mainprogram;
                    }
                }
            }
        }
    }
}
