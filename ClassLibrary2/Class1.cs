using System;

namespace ClassLibrary2
{
    public class Class1
    {
        public static string CurrentTime()
        {
            return DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}
