using System;

class bai17
{
    static int CountWords(string str)
    {
        // Xử lý xâu rỗng
        if (string.IsNullOrWhiteSpace(str))
            return 0;

        // Tách xâu thành mảng các từ dựa trên khoảng trắng
        string[] words = str.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        // Trả về số lượng từ
        return words.Length;
    }

    static void Main()
    {
        Console.Write("Nhập xâu kí tự: ");
        string st = Console.ReadLine();

        if (st == "#")
        {
            // Phát tiếng beep nếu xâu là "#"
            Console.Beep();
        }
        else
        {
            // In ra số lượng từ
            int wordCount = CountWords(st);
            Console.WriteLine($"Số từ trong xâu: {wordCount}");
        }
    }
}