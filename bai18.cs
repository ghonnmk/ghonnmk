using System;

class bai18
{
    static double ReadDouble()
    {
        double value;
        while (true)
        {
            Console.Write("Nhập số thực 8 byte: ");
            if (double.TryParse(Console.ReadLine(), out value))
                return value;
            Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại.");
        }
    }

    static void Main()
    {
        double x = ReadDouble();
        Console.WriteLine($"Căn bậc 2 của {x} là {Math.Sqrt(x)}");
    }
}