using System.Collections.Generic;

namespace DesignPatternsWorkshop.Creational
{
    /// <summary>
    /// Definition: Ensure a class has only one instance and provide a global point of access to it.
    /// </summary>
    public sealed class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        private List<string> _initialState;

        private Singleton()
        {
            _initialState = new List<string>()
            {
                "1",
                "2",
                "3"
            };
        }

        public static Singleton GetSingleton()
        {
            return _instance;
        }
    }
}
