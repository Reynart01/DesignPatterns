using System;

namespace DesignPatternsWorkshop.Structural
{
    public abstract class SubjectProxy
    {
        public abstract void Request();
    }

    public class RealSubjectProxy : SubjectProxy
    {
        public override void Request()
        {
            Console.WriteLine("Called RealSubject.Request()");
        }
    }

    class Proxy : SubjectProxy
    {
        private RealSubjectProxy _realSubjectProxy;

        public override void Request()
        {
            // Use 'lazy initialization'
            if (_realSubjectProxy == null)
            {
                _realSubjectProxy = new RealSubjectProxy();
            }

            _realSubjectProxy.Request();
        }
    }
}
