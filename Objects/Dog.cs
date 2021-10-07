using System;

namespace StrategyPatternExample.Objects
{
    public class Dog : Animal	
    {
        public void digHole(){
		
            Console.WriteLine("Dug a hole");
		
        }
	
        public Dog()
        {
	        Sound = "Bark";
		
            FlyingType = new CannotFly();
		
        }
    }
}