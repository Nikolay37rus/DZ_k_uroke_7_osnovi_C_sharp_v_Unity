//2. Реализовать метод расширения для поиска количество символов в строке.
using System;
using System.Text;

public sealed class App
{
    static void Main()
    {
        
        StringBuilder sb = new StringBuilder("ABC", 50);

        
        sb.Append(new char[] { 'D', 'E', 'F' });

        
        sb.AppendFormat("GHI{0}{1}", 'J', 'k');

        
        Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());

        
        sb.Insert(0, "Alphabet: ");

        
        sb.Replace('k', 'K');

        
        Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());

        Console.ReadKey();
    }
}

