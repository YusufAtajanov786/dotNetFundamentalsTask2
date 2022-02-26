using System;

namespace ClassLibrary
{
    public class Timer
    {
        public static string CurrentTime()
        {
            return DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}
