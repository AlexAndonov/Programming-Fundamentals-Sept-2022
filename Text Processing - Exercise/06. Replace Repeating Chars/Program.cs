﻿using System;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] != text[i + 1])
                {
                    Console.Write(text[i]);
                }
            }
            Console.Write(text[text.Length - 1]);
        }
    }
}
