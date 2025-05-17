using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextRPG.States
{
    public class State
    {
        Stack<State> states;
        public State(Stack<State> states)
        {
            this.states = states;
            // Console.WriteLine(this.states.GetHashCode());
        }
    }
}