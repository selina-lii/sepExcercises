using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MethodExample
    {
        public int Factorial(int x)
        {
            int fact = 1;
            for (int i = x; i > 1; i--)
            {
                fact *= i;
            }
            return fact;
        }


        public decimal AddTwoNumbers(decimal x, decimal y)
        {
            return x + y;
        }

        /// <summary>
        /// pass by value.
        /// A copy of actual parameters is passed to the formal parameters.
        /// Any change in the formal parameters values will not reflect in actual parameters.
        /// </summary>
        /// <param name="x"></param>
        public void PassingByValue(int x)
        {
            x = 100;
        }
        /// <summary>
        /// The memory reference of the actual parameters are passed to the formal parameters.
        /// Change in formal parameter values will reflect in actual parameter values
        /// </summary>
        /// <param name="x"></param>
        public void PassingByRefernce(ref int x)
        {
            x = 100;
        }

        /// <summary>
        /// Out mode of parameter is sued to return the result from the method.
        /// It is must of the method to give them a value.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool IsAuthenticated(string username, string password, out string message)
        {
            message = "You have logged in";
            return true;
        }

        public double OptionalParameter(int radius, double pi=3.14)
        {
            return pi * radius * radius;
        }

    }
}
