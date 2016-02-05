namespace DesignPatternsWorkshop.Creational
{
    /// <summary>
    /// Definition: Specify the kind of objects to create using a prototypical instance, and create new objects by copying this prototype.
    /// </summary>
    public abstract class Prototype
    {
        public string Id { get; private set; }

        protected Prototype(string id)
        {
            Id = id;
        }

        public abstract Prototype Clone();
    }

    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype) this.MemberwiseClone();
        }
    }

    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string id)
            : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
