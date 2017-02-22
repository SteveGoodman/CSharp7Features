using System;

namespace CSharp7Console
{
    public class Tuples
    {

        //Currently tuples are ref types, and immutable, meaning each time you change a value a new object is created
        //this makes them very inefficient, but thread safe.
        //New  Tuples are value types,  making them still thread safe, but now more efficient.

        private static Tuple<int, string> GetEmployeeByIdExisting(int employeeId)
        {
            var empAge = 32;
            var dept = "HR";
            return new Tuple<int, string>(empAge, dept);
        }

        //Shortened syntax for the tuple
        private static (int, string) GetEmployeeByIdShortenedSyntax(int employeeId)
        {
            var empAge = 32;
            var dept = "HR";
            return (empAge, dept);
        }

        //Shortened named fields in the tuple
        private static (int age, string department) GetEmployeeByIdNamedFields(int employeeId)
        {
            var empAge = 32;
            var dept = "HR";
            return (empAge, dept);
        }

        public static void TupleExample()
        {
            var employeeTuple = GetEmployeeByIdExisting(1);
            var age = employeeTuple.Item1;
            var dept = employeeTuple.Item2;

            //newer approach with shortened syntax..
            var employeeShortSyntaxTuple = GetEmployeeByIdShortenedSyntax(1);
            age = employeeShortSyntaxTuple.Item1;
            dept = employeeShortSyntaxTuple.Item2;

            //newer approach with named fields..
            var employee = GetEmployeeByIdNamedFields(1);
            age = employee.age;
            dept = employee.department;   //bug reverts to items2
            dept = employee.Item2;        //intelli sense is  screwed up..

            Console.WriteLine($"{age} {dept}");
        }

    }
}
