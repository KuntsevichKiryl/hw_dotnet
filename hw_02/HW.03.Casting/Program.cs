using System;

namespace HW._03.Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            double src = uint.MaxValue / 1_000_000D;
            float srcToFloat = (float)src;
            int srcToInt = (int)src;
            byte srcToByte = (byte)src;
            char srcToChar = (char)src;
            decimal srcToDecimal = (decimal)src;

            Console.WriteLine(
$@"Source double: {src}
    To float: {srcToFloat}
    To int: {srcToInt}
    To byte: {srcToByte}
    To char: {srcToChar}
    To decimal: {srcToDecimal}"
            );

            byte src2 = byte.MaxValue;
            short src2ToShort = src2;
            ushort src2ToUshort = src2;
            uint src2ToUint = src2;
            float src2ToFloat = src2;
            decimal src2ToDecimal = src2;

            Console.WriteLine(
$@"Source byte: {src2}
    To short: {src2ToShort}
    To ushort: {src2ToUshort}
    To uint: {src2ToUint}
    To float: {src2ToFloat}
    To decimal: {src2ToDecimal}"
            );

            object[] boxing = new Object[] { srcToFloat, srcToInt, srcToByte, srcToChar, srcToDecimal};

            Console.WriteLine($"Boxing [{string.Join("; ", boxing)}]");

            Console.WriteLine(
 $@"Unboxing 
    float: {(float) boxing[0]}
    int: {(int) boxing[1]}
    byte: {(byte) boxing[2]}
    char: {(char) boxing[3]}
    decimal: {(decimal) boxing[4]}"
             );
        }
    }
}
