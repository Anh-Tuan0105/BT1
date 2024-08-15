using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            handle handle = new handle();
            string[] menu = new string[]
            {
                "Tìm số lớn nhất trong mảng",
                "Tìm số nhỏ nhất trong mảng",
                "Sắp xếp mảng giảm dần",
                "Đếm số lần xuất hiện của số",
                "Tìm số lớn thứ hai trong mảng",
                "Thoát"
            };
            handle.ShowMenu(menu);
        }
    }
    public class handle
    {
        int positions = 0;
        bool CheckKey;
        public void ClearConsole()
        {
            /*StringBuilder consles = new StringBuilder();
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < Console.BufferHeight - 2; i++)
            {
                for (int y = 0; y < Console.WindowWidth; y++)
                {
                    consles.Append(" ");
                }
                consles.AppendLine();
            }
            Console.WriteLine(consles); //in đè
            Console.ResetColor();
            */
            
            

            Console.Clear();

            Console.SetCursorPosition(0, 0);
        }
        private int HandleKey(string[] array)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.W || key.Key == ConsoleKey.UpArrow)
            {
                if (positions == 0)
                {
                    positions = array.Length;
                }
                positions--;
            }
            if (key.Key == ConsoleKey.S || key.Key == ConsoleKey.DownArrow)
            {
                positions++;
                if (positions == array.Length)
                {
                    positions = 0;
                }
            }
            if (key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.Spacebar)
            {
                if (positions == 0)
                {
                    CheckKey = false;
                    ClearConsole();
                    Console.WriteLine("Chuc Nang 1");
                    Console.ReadKey();
                    ShowMenu(array);
                }
                else if (positions == 1)
                {
                    CheckKey = false;
                    ClearConsole();
                    Console.WriteLine("Chuc Nang 2");
                    Console.ReadKey();
                    ShowMenu(array);
                }
                else if (positions == 2)
                {
                    CheckKey = false;
                    ClearConsole();
                    Console.WriteLine("Chuc Nang 3");
                    Console.ReadKey();
                    ShowMenu(array);
                }
                else if (positions == 3)
                {
                    CheckKey = false;
                    ClearConsole();
                    Console.WriteLine("Chuc Nang 4");
                    Console.ReadKey();
                    ShowMenu(array);
                }
                else if (positions == 4)
                {
                    CheckKey = false;
                    ClearConsole();
                    Console.WriteLine("Chuc Nang 5");
                    Console.ReadKey();
                    ShowMenu(array);
                }
                else if (positions == 5)
                {
                    CheckKey = false;
                    ClearConsole();
                }
            }
            return positions;
        }
        public int ShowMenu(string[] array)
        {
            CheckKey = true;

            while (CheckKey)
            {
                ClearConsole();
                for (int i = 0; i < array.Length; i++)
                {
                    Functions.printf_Positions(array[i], 0, i);
                    if (i == positions)
                    {
                        Functions.printf_Positions_color(" " + array[i], 0, i, ConsoleColor.Green);
                        Functions.printf_Positions_color("<", array[i].Length + 1, i, ConsoleColor.Red);
                        Functions.printf_Positions_color(">", 0, i, ConsoleColor.Red);
                    }
                    
                }
                HandleKey(array);
                //ClearConsole();
            }
            return positions;
        }
    }
    internal static class Functions
    {
        /// <summary>
        /// chức năng này dùng để in ra màn hình tại một vị trí được chỉ định 
        /// </summary>
        /// <param name="s">Nội dung xuất ra màn hình</param>
        /// <param name="x">,y</param>
        public static void printf_Positions(string s, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(s);
        }
        public static void printf_Positions_color(string s, int x, int y, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(s);
            Console.ResetColor();
        }
    }
}
