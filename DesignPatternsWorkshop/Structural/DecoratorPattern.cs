namespace DesignPatternsWorkshop.Structural
{
    /// <summary>
    /// Definition: Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
    /// </summary>
    public class DecorationResult
    {
        public int Force { get; set; }
        public int Strength { get; set; }
    }

    public interface IComponent
    {
        DecorationResult Operation();
    }

    public class Component : IComponent
    {
        private readonly DecorationResult _result;

        public Component(DecorationResult result)
        {
            _result = result;
        }

        public DecorationResult Operation()
        {
            _result.Force = 1;
            _result.Strength = 1;

            return _result;
        }
    }

    public abstract class Decorator : IComponent
    {
        protected IComponent _component;

        public Decorator(IComponent component)
        {
            _component = component;
        }

        public abstract DecorationResult Operation();
    }

    public class DecoratorA : Decorator
    {
        public DecoratorA(IComponent component) : base(component)
        {}

        public override DecorationResult Operation()
        {
            var result = _component.Operation();
            result.Force += 1;
            result.Strength += 1;

            return result;
        }
    }

    public class DecoratorB : Decorator
    {
        public DecoratorB(IComponent component)
            : base(component)
        { }

        public override DecorationResult Operation()
        {
            var result = _component.Operation();
            result.Force += 10;
            result.Strength += 0;

            return result;
        }
    }

}
