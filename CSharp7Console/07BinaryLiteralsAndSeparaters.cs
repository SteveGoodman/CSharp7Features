using System;

namespace CSharp7Console
{
    public class BinaryLiteralsAndSeparaters
    {
        public static void BinaryLiteralsExample()
        {
            var binary = new[] {0b1, 0b10, 0b11, 0b100, 0b101, 0b110, 0b111, 0x8, 0xF, 32};

            foreach (var binValue in binary)
            {
                Console.WriteLine(binValue);
            }


            #region//_ separator
            var separaters = new int[] { 1_01, 1_02, 1_03, 1_000_000, 1_000_000_000 };
            foreach (var value in separaters)
            {
                Console.WriteLine(value);
            }
            #endregion
        }
    }
}
