using System;

namespace HW02_04.Types
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sb = 1;
            SByte sbClr = 11;
            short sh = 2;
            Int16 shClr = 22;
            int i = 3;
            Int32 iClr = 33;
            long l = 4;
            Int64 lClr = 44;
            byte b = 5;
            Byte bClr = 55;
            ushort us = 6;
            UInt16 usClr = 66;
            char c = 'a';
            Char cClr = 'A';
            uint u = 7;
            UInt32 uClr = 77;
            ulong ul = 8;
            UInt64 ulClr = 88;
            float f = 9;
            Single fClr = 99;
            double d = 10;
            Double dClr = 1010;
            decimal de = 11;
            Decimal deClr = 1111;
            bool bo = true;
            Boolean boClr = false;
            string str = "12";
            String strClr = "1212";
            object ob = new object[13];
            Object obClr = new Object[13, 13];

            Console.WriteLine(
                $"sbyte:\n\tC#: {sb.GetType().FullName}\n\tCLR: {sbClr.GetType().FullName}" +
                $"\nshort:\n\tC#: {sh.GetType().FullName}\n\tCLR: {shClr.GetType().FullName}" +
                $"\nint:\n\tC#: {i.GetType().FullName}\n\tCLR: {iClr.GetType().FullName}" +
                $"\nlong:\n\tC#: {l.GetType().FullName}\n\tCLR: {lClr.GetType().FullName}" +
                $"\nbyte:\n\tC#: {b.GetType().FullName}\n\tCLR: {bClr.GetType().FullName}" +
                $"\nushort:\n\tC#: {us.GetType().FullName}\n\tCLR: {usClr.GetType().FullName}" +
                $"\nchar:\n\tC#: {c.GetType().FullName}\n\tCLR: {cClr.GetType().FullName}" +
                $"\nuint:\n\tC#: {u.GetType().FullName}\n\tCLR: {uClr.GetType().FullName}" +
                $"\nulong:\n\tC#: {ul.GetType().FullName}\n\tCLR: {ulClr.GetType().FullName}" +
                $"\nfloat:\n\tC#: {f.GetType().FullName}\n\tCLR: {fClr.GetType().FullName}" +
                $"\ndouble:\n\tC#: {d.GetType().FullName}\n\tCLR: {dClr.GetType().FullName}" +
                $"\ndecimal:\n\tC#: {de.GetType().FullName}\n\tCLR: {deClr.GetType().FullName}" +
                $"\nbool:\n\tC#: {bo.GetType().FullName}\n\tCLR: {boClr.GetType().FullName}" +
                $"\nstring:\n\tC#: {str.GetType().FullName}\n\tCLR: {strClr.GetType().FullName}" +
                $"\nobject:\n\tC#: {ob.GetType().FullName}\n\tCLR: {obClr.GetType().FullName}"
            );
        }
    }
}
