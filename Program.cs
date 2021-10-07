using System;
using StrategyPatternExample.Objects;

namespace StrategyPatternExample
{
    /*
     * The majority of this code is mocked or directly taken from the Derek Banas YouTube series in
     * an effort to teach myself and get familiar with these patterns.  None of this is meant to be
     * original content, and if you see this and wonder why it's in my repo, mostly it's for me, but
     * I'm happy that you're here and here's proof that I have at least heard of this particular
     * pattern!
     *
     * Author: Nicholas Larsen
     * Date: 2021/10/07
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy Pattern!");
            Animal sparky = new Dog();
            Animal tweety = new Bird();

            // This is the strategy pattern in action, calling the same method
            // But getting two different results
            Console.WriteLine("Dog: " + sparky.tryToFly());
            Console.WriteLine("Bird: " + tweety.tryToFly());
            
            // Dynamically changing the object to change the result is also part
            // of the strategy pattern
            sparky.FlyingType = new ItFlies();
            Console.WriteLine("Dog: " + sparky.tryToFly());
        }
    }
}
