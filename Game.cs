using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Game
    {
        // variables
        bool end;

        // private functions
        private void InitVariables()
        {
            end = false;
        }

        public Game()
        {
            this.InitVariables();
            Console.WriteLine("Game Class");
        }

        public void Run()
        {
            while (this.end == false)
            {
                Console.WriteLine("Write a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    this.end = true;
                }
                else
                {
                    Console.WriteLine("Your input: {0}", number);
                }
            }

            Console.WriteLine("Ending game...");
        }
    }
}