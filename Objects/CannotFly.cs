namespace StrategyPatternExample.Objects
{
    public class CannotFly : Flies
    {
        public string Fly()
        {
            return "Staying on the ground.";
        }
    }
}