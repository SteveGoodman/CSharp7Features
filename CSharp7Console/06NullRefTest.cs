using System;
using System.Text;

namespace CSharp7Console
{
    public class NullRefTest
    {
        public static void NullRefTestExample()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder = null;

            Console.WriteLine(stringBuilder.Capacity); // the ide will now say that stringbuilder is null, no need to guess anymore..
        }
    }
}
