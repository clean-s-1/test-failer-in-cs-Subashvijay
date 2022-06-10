using System;
using System.Diagnostics;

namespace AlerterSpace
{
    class Alerter
    {
        static int alertFailureCount = 0;
        static int networkAlertStub(float celsius)
        {
            Console.WriteLine("ALERT: Temperature is {0} celsius", celsius);
            // Return 200 for ok
            // Return 500 for not-ok
            // stub always succeeds and returns 200
            if (celsius is <= 333 and >= 220)
            {
                return 500;
            }
            return 200;
        }
        static void alertIncelsius(float farenheit)
        {
            float celsius = (farenheit - 32) * 5 / 9;
            int returnCode = networkAlertStub(celsius);
            if (returnCode != 200)
            {
                // non-ok response is not an error! Issues happen in life!
                // let us keep a count of failures to report
                // However, this code doesn't count failures!
                // Add a test below to catch this bug. Alter the stub above, if needed.
                alertFailureCount += 1;
            }
        }
        static void Main(string[] args)
        {
            alertIncelsius(400.5f);
            alertIncelsius(303.6f);
            Debug.Assert(networkAlertStub(230) == 500);
            Debug.Assert(networkAlertStub(430) == 200);
            Console.WriteLine("{0} alerts failed.", alertFailureCount);
            Console.WriteLine("All is well (maybe!)\n");
        }
    }
}
