using System;

namespace CSharp7Console
{
    //Not available in c# 7 yet

    /*
    public class PersonThrowException
    {
        public string Name { get; }

        public PersonThrowException(string name) => Name = name ?? throw new ArgumentNullException(name);

        public string GetFirstName()
        {
            var parts = Name.Split(' ');
            return (parts.Length > 0) ? parts[0] : throw new InvalidOperationException("No name!");
        }

        public string GetLastName() => throw new NotImplementedException();
    }
    */

    public class ThrowException
    {
        //public static int ThrowExceptionExample()
        //{
        //    var x = 0;
        //    var y = 0;

        //    return y != 0 ? x / y : throw new DivideByZeroException();
        //}
    }
}
