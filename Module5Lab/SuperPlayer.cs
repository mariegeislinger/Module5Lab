using System;

namespace Module5Lab
{
    internal class SuperPlayer : Player
    {
        //SuperPlayer is the child of player
        //Inherits everything that player has (attributes and methods) plus
        // it has its own addt method
        public void Fly()
        {
            Console.WriteLine("SuperPlayer is flying!");
        }
    }
}

