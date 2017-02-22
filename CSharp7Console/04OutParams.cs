using System;

namespace CSharp7Console
{
    public class OutParams
    {
        public static void GetDetails(out int userId, out string username)
        {
            userId = 12;
            username = "Test User";
        }

        private  static void OutParamsExample()
        {
            //As it currently stands
            int userId;
            string userName;
            GetDetails(out userId, out userName);

            //new method
            GetDetails(out int userIdNew, out string userNameNew);
            Console.WriteLine($"{userIdNew} {userNameNew}");

            //Use var instead of actual  type..
            GetDetails(out var userIdVar, out var userNameVar);

            //Talk of allowing *, but not implemented.
            //GetDetails(out var userIdVar, *);

        }

    }
}
