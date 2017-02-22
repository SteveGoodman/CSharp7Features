using System;

namespace CSharp7Console
{
    public class LocalFunctions
    {
        /// <summary>
        /// Embed a function within a function, this gives the advantage that no other method can call the embedded function.
        /// You can't test the embedded
        /// </summary>
        /// <returns></returns>
        private static int GetSalary()
        {
            var salary = GetBonus() * 2;

            return salary;

            int GetBonus()
            {
                return 10000;
            }
        }

        public static void LocalFunctionExample()
        {
            Console.WriteLine("Salary is: " + GetSalary());
        }
    }
}
