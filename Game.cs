using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;
using TextRPG.States;

namespace TextRPG
{
    public class Game
    {
        // variables
        private bool end;
        public bool End
        {
            get { return end; }
            set { end = value; }
        }

        private Stack<State> states;

        // private functions
        private void InitVariables()
        {
            this.end = false;
        }

        private void InitStates()
        {
            this.states = new Stack<State>();
            // Console.WriteLine(this.states.GetHashCode());

            // push the first state
            this.states.Push(new State(this.states));
        }

        public Game()
        {
            this.InitVariables();
            this.InitStates();
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