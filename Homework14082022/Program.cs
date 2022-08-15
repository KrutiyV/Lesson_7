using System;
using System.Text;
using System.Linq;

class Homework
{
    static void Compare()
    {
        Console.WriteLine("Input two words to compare if they are equals or not");
        var str1 = Console.ReadLine();
        var str2 = Console.ReadLine();

        if (str1 == str2)
        {
            bool isTrue = true;
            Console.WriteLine(isTrue);
        }
        else
        {
            bool isTrue = false;
            Console.WriteLine(isTrue);
        }
    }

    static void Analyze()
    {
        Console.WriteLine("Input word or sentence to find numbers of characters, digits, etc");
        var str3 = Convert.ToString(Console.ReadLine());
        Console.WriteLine(str3.Length);
    }

    static void Dublicate()
    {
        Console.WriteLine("Input two words or sentences to compare them and find characters duplicates");
        var FirstWord = Convert.ToString(Console.ReadLine());
        var SecondWord = Convert.ToString(Console.ReadLine());

        for (int i = 0; i < FirstWord.Length; i++)
        {
            for (int j = 0; j < SecondWord.Length; j++)
            {
                if (FirstWord[i] == SecondWord[j])
                {
                    Console.Write(FirstWord[i] + " ");
                }
            }
        }
    }
    //when find dublicated chars - you should return the list of dublicated chars only, not a list of every match

    static void Sort()
    {
        Console.WriteLine("\nInput a word. It will return all characters sorted in alphabetical order");
        String str4 = Console.ReadLine();

        str4 = String.Concat(str4.OrderBy(ch => ch));

        Console.WriteLine(str4);
    }

    public static void Main()
    {
        Compare();
        Analyze();
        Dublicate();
        Sort();
    }
}
//checked
