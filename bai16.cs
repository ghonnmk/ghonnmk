using System;

class bai16
{
    static void Main(string[] args)
    {
        // Khai báo số nguyên m,n 1 byte không dấu
        byte m, n;

        // Gọi hàm để nhập giá trị của m,n
        ReadByteValue(out m, out n);
        Console.WriteLine($"Giá trị của m: {m}, giá trị của n: {n}");

        // Khai báo mảng 2 chiều các số nguyên 4 byte a, và cấp phát để a gồm m*n phần tử
        int[,] a = new int[m, n];

        // Gọi hàm để nhập giá trị các phần tử của mảng a từ bàn phím
        ReadArray2D(a);
        PrintArray2D(a);

        // Gọi hàm để tính tổng các phần tử của mảng chia hết cho 2024
        int sum = SumDivisibleByP(a, 2024);
        Console.WriteLine($"Tổng các phần tử chia hết cho 2024: {sum}");
    }

    // Hàm đọc từ bàn phím số nguyên 1 byte, không dấu, nằm trong khoảng 2 đến 10, nếu nhập sai thì nhập lại
    static void ReadByteValue(out byte value1, out byte value2)
    {
        Console.Write("Nhập giá trị của m: ");
        while (!byte.TryParse(Console.ReadLine(), out value1) || value1 < 2 || value1 > 10)
        {
            Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại.");
        }

        Console.Write("Nhập giá trị của n: ");
        while (!byte.TryParse(Console.ReadLine(), out value2) || value2 < 2 || value2 > 10)
        {
            Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại.");
        }
    }

    // Hàm đọc từ bàn phím 1 giá trị số nguyên 4 byte, nếu nhập sai thì nhập lại
    static int ReadIntValue()
    {
        int value;
        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại.");
        }
        return value;
    }

    // Hàm nhập vào 1 mảng 2 chiều các số nguyên 4 byte
    static void ReadArray2D(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"Nhập giá trị phần tử [{i},{j}]: ");
                arr[i, j] = ReadIntValue();
            }
        }
    }

    // Hàm in ra màn hình giá trị của mảng 2 chiều
    static void PrintArray2D(int[,] arr)
    {
        Console.WriteLine("Giá trị của mảng 2 chiều:");
        for (int i = 0; i < arr.GetLength