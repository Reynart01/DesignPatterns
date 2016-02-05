using System;

namespace DesignPatternsWorkshop.Behavioral
{
    /// <summary>
    /// Definition: Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
    /// </summary>
    public abstract class AbstractClass
    {
        public  abstract void PrimitiveOperation1();
        public  abstract void PrimitiveOperation2();

        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
        }
    }

    public class ConcreteClass : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("1. Step of an algorithm");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("1. Step of an algorithm");
        }
    }
}
