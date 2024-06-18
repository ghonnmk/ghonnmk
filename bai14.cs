using System;
using System.Globalization;
using System.Text;

class bai14
{
    static float ReadFloat()
    {
        float value;
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out value))
                return value;
            else
                Console.WriteLine("Nhập sai, vui lòng nhập lại!");
        }
    }

    static void Main(string[] args)
    {
        // Thiết lập encoding để hiển thị tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        // Đọc giá trị x từ bàn phím
        Console.Write("Nhập giá trị x: ");
        float x = ReadFloat();
        Console.WriteLine($"Giá trị x đã nhập: {x}");
    }
}