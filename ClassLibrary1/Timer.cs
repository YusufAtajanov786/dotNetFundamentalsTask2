using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Timer
    {
        public static string CurrentTime()
        {
            return DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}
