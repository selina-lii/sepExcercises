
Console.WriteLine("{0,-8} {1,-5} {2,-30} {3,-30}", "Type", "size", "type.MinValue", "type.MaxValue");
Console.WriteLine("{0,-8} {1,-5} {2,-30} {3,-30}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
Console.WriteLine("{0,-8} {1,-5} {2,-30} {3,-30}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
Console.WriteLine("{0,-8} {1,-5} {2,-30} {3,-30}", "short", sizeof(short), short.MinValue, short.MaxValue);
Console.WriteLine("{0,-8} {1,-5} {2,-30} {3,-30}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
Console.WriteLine("{0,-8} {1,-5} {2,-30} {3,-30}", "int", sizeof(int), int.MinValue, int.MaxValue);
Console.WriteLine("{0,-8} {1,-5} {2,-30} {3,-30}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
Console.WriteLine("{0,-8} {1,-5} {2,-30} {3,-30}", "long", sizeof(long), long.MinValue, long.MaxValue);
Console.WriteLine("{0,-8} {1,-5} {2,-30} {3,-30}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
Console.WriteLine("{0,-8} {1,-5} {2,-30} {3,-30}", "float", sizeof(float), float.MinValue, float.MaxValue);
Console.WriteLine("{0,-8} {1,-5} {2,-30} {3,-30}", "double", sizeof(double), double.MinValue, double.MaxValue);
Console.WriteLine("{0,-8} {1,-5} {2,-30} {3,-30}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);

Console.Write("Input: ");
ulong input = Convert.ToUInt64(Console.ReadLine());
ulong[] values = {1, 100, 365, 24, 60,  60, 100, 100, 100};
string[] units = { "centuries", "years", "days", "hours", "minutes", "seconds", "milliseconds", "microseconds", "nanoseconds" }; 
Console.Write("Output: ");
for(int i = 0; i < units.Length; i++)
{
    if (units[i].Equals("days"))
        input= input * values[i] + input/4 - input/100 + input/400;
    else
        input = input*values[i];
    Console.Write("= {0} {1} ", input, units[i]);
}

