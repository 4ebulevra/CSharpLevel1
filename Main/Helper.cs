using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Устюжанин Максим Николаевич*/
namespace Helper
{
    class MyLibrary
    {
        public static void Pause()
        {
            Print("\nНажмите любую клавишу для продолжения");
            Console.ReadKey();
        }
        public static void Print(string str)
        {
            Console.Write(str);
        }
        public static void Print(string str , int row , int coll)
        {
            Console.SetCursorPosition(coll , row);
            Console.Write(str);
        }
        public static void Print(string str , string arrange)
        {
            int lengthSTR = str.Length;
            switch (arrange)
            {
                case "centr":
                    Console.SetCursorPosition((Console.BufferWidth / 2) - (str.Length / 2) , Console.CursorTop);
                    Console.Write(str);
                    break;
                default:
                    Console.Write(str);
                    break;
            }
        }
    }
}
