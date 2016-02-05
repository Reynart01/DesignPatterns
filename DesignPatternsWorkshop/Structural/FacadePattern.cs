namespace DesignPatternsWorkshop.Structural
{
    /// <summary>
    /// Definition: Provide a unified interface to a set of interfaces in a subsystem. Façade defines a higher-level interface that makes the subsystem easier to use.
    /// </summary>
    public class Facade
    {
        private SubSystemA _subSystemA;
        private SubSystemB _subSystemB;

        public Facade()
        {
            _subSystemA = new SubSystemA();
            _subSystemB = new SubSystemB();
        }

        public void Method()
        {
            _subSystemA.Method1();
            _subSystemA.Method2();
            _subSystemB.Method1();
            _subSystemB.Method2();
        }
    }

    public class SubSystemA
    {
        public void Method1()
        {
            
        }

        public void Method2()
        {
            
        }
    }

    public class SubSystemB
    {
        public void Method1()
        {

        }

        public void Method2()
        {

        }
    }
}
