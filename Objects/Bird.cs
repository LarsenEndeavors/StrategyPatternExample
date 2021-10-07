namespace StrategyPatternExample.Objects
{
    public class Bird : Animal
    {
        public Bird()
        {
	        Sound = "Tweet";
            FlyingType = new ItFlies();
        }
    }
}