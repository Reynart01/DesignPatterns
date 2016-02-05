using DesignPatternsWorkshop.Creational;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsWorkshop
{
    [TestClass]
    public class DesignPatternsCreationalTests
    {
        [TestMethod]
        public void BuilderPattern_TestIfDirectorHasBuildAProductWithABuilder()
        {
            // Arrange
            var builder = new Builder();
            var director = new Director(builder);
            
            // Act
            director.Construct();
            var result = builder.GetResult();

            // Assert
            Assert.IsTrue(result.GetCountOfParts() == 2);
        }

        [TestMethod]
        public void FactoryPattern_TestIfFacoryCreatesProperItems()
        {
            // Arrange
            var factory = new Factory();

            // Act
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            // Assert
            Assert.IsInstanceOfType(productA, typeof(ProductA));
            Assert.IsInstanceOfType(productB, typeof(ProductB));
        }

        [TestMethod]
        public void SingletonPattern_TestIfSingletonHasOnlyOneInstance()
        {
            // Arrange, Act
            var instance1 = Singleton.GetSingleton();
            var instance2 = Singleton.GetSingleton();

            // Assert
            Assert.AreSame(instance1, instance2);
        }

        [TestMethod]
        public void PrototypePattern_TestCreationOfProtptypicalInstances()
        {
            // Arrange
            const string id1 = "I";
            const string id2 = "II";
            var concretePrototype1 = new ConcretePrototype1(id1);
            var concretePrototype2 = new ConcretePrototype2(id2);

            // Act
            var clonedConcretePrototype1 = (ConcretePrototype1)concretePrototype1.Clone();
            var clonedConcretePrototype2 = (ConcretePrototype2)concretePrototype2.Clone();

            // Assert
            Assert.AreEqual(id1, clonedConcretePrototype1.Id);
            Assert.AreEqual(id2, clonedConcretePrototype2.Id);
        }
    }
}
