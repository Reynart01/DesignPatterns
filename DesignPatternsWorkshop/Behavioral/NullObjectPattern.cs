using System;

namespace DesignPatternsWorkshop.Behavioral
{
    public abstract class AbstractOperation
    {
        public abstract void Operation();
    }

    public class RealOperation : AbstractOperation
    {
        public override void Operation()
        {
            Console.WriteLine("Real operation");
        }
    }

    public class NullOperation : AbstractOperation
    {
        public override void Operation()
        {
            // Do nothing
        }
    }
}
