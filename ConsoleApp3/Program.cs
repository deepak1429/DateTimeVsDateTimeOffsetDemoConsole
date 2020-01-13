using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
                DateTimeOffset localTime = DateTimeOffset.Now;
                DateTimeOffset utcTime = DateTimeOffset.UtcNow;
                DateTime dateTime = DateTime.Now;
                DateTime dateTimeutc = DateTime.UtcNow;

                Console.WriteLine("Local Time:          {0}", localTime.ToString("T"));
                Console.WriteLine("Difference from UTC: {0}", localTime.Offset.ToString());
                Console.WriteLine("UTC:                 {0}", utcTime.ToString("T"));
                Console.WriteLine("datetime:                 {0}", dateTime.ToString("T"));
                Console.WriteLine("datetime UTC:                 {0}", dateTimeutc.ToString("T"));
                Console.ReadLine();
            
        }
    }
    
}
