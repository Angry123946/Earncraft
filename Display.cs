using System;

namespace Earncraft
{
    class Display
    {
        public static void WriteAt(int columnNumber, int rowNumber, string text)
        {
            Console.SetCursorPosition(columnNumber, rowNumber);
            Console.Write(text);
        }
        public static void WriteAt(int columnNumber, int rowNumber, char sign)
        {
            Console.SetCursorPosition(columnNumber, rowNumber);
            Console.Write(sign);
        }
    }
}
