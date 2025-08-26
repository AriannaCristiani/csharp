using System;

namespace Strutture
{
    public class MyClass
    {
        public string myString;
        public int myInteger;
    }

    public struct MyStruct
    {
        public string myString;
        public int myInteger;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            MyStruct ms = new MyStruct();

            mc.myString = "Arianna"; mc.myInteger = 28;
            ms.myString = "Bianca"; ms.myInteger = 30;

            Console.WriteLine($"Prima: {mc.myInteger}, {mc.myString}");
            Console.WriteLine($"Prima: {ms.myInteger}, {ms.myString}");

            ClassMethod(mc, ms, 35, "Carlo");

            Console.WriteLine($"Dopo: {mc.myInteger}, {mc.myString}");
            Console.WriteLine($"Dopo: {ms.myInteger}, {ms.myString}");
        }

        static void ClassMethod(MyClass mc, MyStruct ms, int intValue, string strValue)
        {
            mc.myInteger = intValue;
            mc.myString = strValue;

            ms.myInteger = intValue;
            ms.myString = strValue;
        }
    }
}