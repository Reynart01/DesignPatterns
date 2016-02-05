using System;

namespace DesignPatternsWorkshop.Structural
{
    /// <summary>
    /// Definition: Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
    /// Others: Also known as Wrapper.
    /// </summary>
    public interface ITarget
    {
        void Request();
    }

    public class Adapter : ITarget
    {
        private Adaptee _adaptee = new Adaptee();

        public void Request()
        {
            _adaptee.SpecificRequest();
        }
    }

    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Specific Request");
        }
    }
}
