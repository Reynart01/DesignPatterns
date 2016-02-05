using System.Collections.Generic;


namespace DesignPatternsWorkshop.Behavioral
{
    /// <summary>
    /// Definition: Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation. 
    /// </summary>
    public static class IteratorPattern
    {
        public static IEnumerable<string> EnumerateMe()
        {
            yield return "1";
            yield return "1";
            yield return "1";

            for (var i = 0; i < 10; i++)
            {
                yield return i.ToString();
            }
        } 
    }
}
