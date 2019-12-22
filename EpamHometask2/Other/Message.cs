using System;
using System.Collections.Generic;
using System.Text;

namespace EpamHometask2
{
    static class Message
    {
        public static void Send(string text)
        {
            Console.WriteLine(text);
        }
        public static void SendError(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ошибка: {text}");
            Console.ResetColor();
        }
        public static void SendError(string text, int value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ошибка: {text}");
            Console.WriteLine($"Некорректное значение: {value}");
            Console.ResetColor();
        }

        public static void SendEvent(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"**{text}**");
            Console.ResetColor();
        }
    }
}
