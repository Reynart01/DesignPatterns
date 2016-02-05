using System;
using DesignPatternsWorkshop.Behavioral;
using DesignPatternsWorkshop.Creational;
using DesignPatternsWorkshop.Structural;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsWorkshop
{
    [TestClass]
    public class DesignPatternsStructuralTests
    {
        [TestMethod]
        public void DecoratorPattern_TestIfDecoratedResultIsValid()
        {
            // Arrange
            var component = new Component(new DecorationResult());
            var decoratorA = new DecoratorA(component);
            var decoratorB = new DecoratorB(decoratorA);

            // Act
            var result = decoratorB.Operation();

            // Assert
            const int excpectedResult = 12;
            Assert.AreEqual(result.Force, excpectedResult);
        }

        [TestMethod]
        public void AdapterPattern_UseAdapter()
        {
            ITarget target = new Adapter();
            target.Request();
        }

        [TestMethod]
        public void FacadePattern_UseFacade()
        {
            var facade = new Facade();
            facade.Method();
        }

        [TestMethod]
        public void CompositePattern_UseComposite()
        {
            var root = new Composite("Root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            var comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            root.Display(1);
        }

        [TestMethod]
        public void ProxyPattern_UseProxy()
        {
            var proxy = new Proxy();
            proxy.Request();
        }
    }
}
