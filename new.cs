using System;
classs new{
    static public void Main()
    {
        byte[] B = { 2, 4, 6, 8, 10};
        Console.Writeline("BArray is :{0}",BitConverter.ToString(B));

        Console.Writeline();
        String str = Convert.ToBase64String(B);
        Console.WriteLine("Base 64 string is :{0}",str);
    }
}