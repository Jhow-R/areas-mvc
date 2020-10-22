using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Web;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in Power(2, 10))
               Console.Write("{0} ", i);

            Console.ReadLine();
        }

        public static IEnumerable<int> Power(int number, int exponent)
        {
            int counter = 0;
            int result = 1;
            while (counter++ < exponent)
            {
                result = result * number;

                if (result <= 256)
                    yield return result;
                else
                    yield break;
            }
        }
    }
}
