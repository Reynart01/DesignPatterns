namespace DesignPatternsWorkshop.Behavioral
{
    /// <summary>
    /// Definition: Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
    /// </summary>
    public interface IStrategy
    {
        int ComputeReallyComplicateAlgorithm();
    }

    public class Strategy1 : IStrategy
    {
        public int ComputeReallyComplicateAlgorithm()
        {
            return 1;
        }
    }

    public class Strategy2 : IStrategy
    {
        public int ComputeReallyComplicateAlgorithm()
        {
            return 2;
        }
    }

    public class Context
    {
        private readonly IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int Compute()
        {
            return _strategy.ComputeReallyComplicateAlgorithm();
        }
    }
}
