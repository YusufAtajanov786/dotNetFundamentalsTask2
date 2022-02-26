using System;

namespace ClassLib
{
    public class Time
    {
        public static string CurrentTime()
        {
            return DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}
