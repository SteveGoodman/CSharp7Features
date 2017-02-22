using System;

namespace CSharp7Console
{
    public class Deconstruction
    {
        //Shortened named fields in the tuple
        private static (int age, string department) GetEmployeeByIdNamedFields(int employeeId)
        {
            var empAge = 32;
            var dept = "HR";
            return (empAge, dept);
        }

        public static void DeconstructionExample()
        {
            //deconstruct immediately and remove the need to hold onto the tuple.
            (int age, string dept) = GetEmployeeByIdNamedFields(1);
            Console.WriteLine($"{age} {dept}");

            //or with var
            (var employeeAge, var employeeDept) = GetEmployeeByIdNamedFields(1);
            Console.WriteLine($"{employeeAge} {employeeDept}");


            //Even lazier var...
            var (employeeAge2, employeeDept2) = GetEmployeeByIdNamedFields(1);
            Console.WriteLine($"{employeeAge2} {employeeDept2}");
        }

    }
}
