using System.Collections.Generic;

namespace DesignPatternsWorkshop.Creational
{
    /// <summary>
    /// Definition: Separate the construction of a complex object from its representation so that the same construction process can create different representations.
    /// </summary>
    public class Director
    {
        private readonly IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
        }
    }

    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        Product GetResult();
    }

    public class Builder : IBuilder
    {
        private Product _product = new Product();

        public void BuildPartA()
        {
            _product.Add("PartA");
        }

        public void BuildPartB()
        {
            _product.Add("PartA");
        }

        public Product GetResult()
        {
            return _product;
        }
    }

    public class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public int GetCountOfParts()
        {
            return _parts.Count;
        }
    }
}
