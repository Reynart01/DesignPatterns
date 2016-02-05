namespace DesignPatternsWorkshop.Creational
{
    /// <summary>
    /// Definition: Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
    /// </summary>
    public interface IFactory
    {
        ProductA CreateProductA();
        ProductB CreateProductB();
    }

    public class ProductB
    {
    }

    public class ProductA
    {
    }

    public class Factory : IFactory
    {
        public ProductA CreateProductA()
        {
            return new ProductA();
        }

        public ProductB CreateProductB()
        {
            return new ProductB();
        }
    }
}
