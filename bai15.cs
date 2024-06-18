using System;
using System.Globalization;
using System.Text;

class bai15
{
    static byte ReadByte(byte min, byte max)
    {
        byte value;
        while (true)
        {
            if (byte.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
                return value;
            else
                Console.WriteLine($"Nhập sai, vui lòng nhập số nguyên từ {min} đến {max}!");
        }
    }

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

    static float[] ReadFloatArray(byte n)
    {
        float[] arr = new float[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            arr[i] = ReadFloat();
        }
        return arr;
    }

    static void Main(string[] args)
    {
        // Thiết lập encoding để hiển thị tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        // Đọc giá trị n từ bàn phím
        Console.Write("Nhập số lượng phần tử của mảng (2 - 10): ");
        byte n = ReadByte(2, 10);
        Console.WriteLine($"Số lượng phần tử của mảng: {n}");

        // Khai báo và cấp phát bộ nhớ cho mảng a
        float[] a = new float[n];

        // Đọc các phần tử của mảng a từ bàn phím
        Console.WriteLine("Nhập các phần tử của mảng:");
        a = ReadFloatArray(n);

        // In ra giá trị các phần tử của mảng a
        Console.WriteLine("Các phần tử của mảng a:");
        foreach (float item in a)
            Console.WriteLine(item);
    }
}