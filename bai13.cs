using System;
using System.Text;

class bai13
{
    static byte ReadByte()
    {
        byte value;
        while (true)
        {
            if (byte.TryParse(Console.ReadLine(), out value) && value >= 2 && value <= 10)
                return value;
            else
                Console.WriteLine("Nhập sai, vui lòng nhập lại (giá trị từ 2 đến 10)!");
        }
    }

    static void Main(string[] args)
    {
        // Thiết lập encoding để hiển thị tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        // Đọc giá trị n từ bàn phím
        Console.Write("Nhập giá trị n: ");
        byte n = ReadByte();
        Console.WriteLine($"Giá trị n đã nhập: {n}");
    }
}