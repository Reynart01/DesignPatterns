using System;
using System.Collections.Generic;

namespace DesignPatternsWorkshop.Structural
{
    public abstract class ComponentComposite
    {
        protected readonly string Name;

        protected ComponentComposite(string name)
        {
            Name = name;
        }

        public abstract void Add(ComponentComposite component);
        public abstract void Remove(ComponentComposite component);
        public abstract void Display(int depth);
    }

    public class Composite : ComponentComposite
    {
        private List<ComponentComposite> _children = new List<ComponentComposite>(); 

        public Composite(string name) : base(name)
        {
        }

        public override void Add(ComponentComposite component)
        {
            _children.Add(component);
        }

        public override void Remove(ComponentComposite component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);

            foreach (var item in _children)
            {
                item.Display(depth + 2);
            }
        }
    }

    public class Leaf : ComponentComposite
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(ComponentComposite component)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(ComponentComposite component)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
        }
    }
}
