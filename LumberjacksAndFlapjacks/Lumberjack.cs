using System;
using System.Collections.Generic;
using System.Text;

namespace LumberjacksAndFlapjacks
{
    class Lumberjack
    {
        private Stack<Flapjack> flapjackStack = new Stack<Flapjack>();
        public string Name { get; private set; }

        public Lumberjack(string name)
        {
            this.Name = name;
        }

        public void TakeFlapjack(Flapjack flapjack)
        {
            this.flapjackStack.Push(flapjack);
        }

        public void EatFlapjacks()
        {
            Console.WriteLine($"{this.Name} is eating flapjacks");
            while (this.flapjackStack.Count > 0)
            {
                Console.WriteLine(
                    $"{this.Name} ate a {this.flapjackStack.Pop().ToString().ToLower()} flapjack");
            }
        }
    }

}
