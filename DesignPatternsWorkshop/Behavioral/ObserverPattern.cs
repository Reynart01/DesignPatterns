using System;
using System.Collections.Generic;

namespace DesignPatternsWorkshop.Behavioral
{
    /// <summary>
    /// Definition: Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
    /// </summary>
    public interface ISubject
    {
        void Attach(IObserver iboserver);
        void Detach(IObserver iboserver);
        void Notify();
        void BuisnessMethod(string info);
    }

    public interface IObserver
    {
        void Update(string state);
        string State { get;  set; }
    }

    public class SubjectObserver : ISubject
    {
        private List<IObserver> _observerList = new List<IObserver>();
        private string _businessInfo = String.Empty;

        public void Attach(IObserver iOboserver)
        {
            _observerList.Add(iOboserver);
        }

        public void Detach(IObserver iOboserver)
        {
            _observerList.Remove(iOboserver);
        }

        public void Notify()
        {
            foreach (var item in _observerList)
            {
                item.Update(_businessInfo);
            }
        }

        public void BuisnessMethod(string info)
        {
            _businessInfo = info;
        }
    }

    public class ObserverA : IObserver
    {
        public ObserverA(ISubject subject)
        {
            subject.Attach(this);
        }

        public void Update(string state)
        {
            State = state;
            Console.WriteLine("from {0}" + state, this);
        }

        public string State { get; set; }
    }

    public class ObserverB : IObserver
    {
        public ObserverB(ISubject subject)
        {
            subject.Attach(this);
        }

        public void Update(string state)
        {
            State = state;
            Console.WriteLine("from {0}" + state, this);
        }

        public string State { get; set; }
    }
}
