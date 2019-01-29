using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Helper.MyLibrary;

/*Устюжанин Максим Николаевич*/
namespace Main
{
    class Program
    {
        /// <summary>
        /// Демонстрация задания 1
        /// </summary>
        static void Presentation_Task1()
        {
            Console.Clear();
            /*****************************************************************************************/
            Print("-=Демонстрация задания 1_Структура комплексного числа=-\n" , "centr");
            Complex_struct complex1;
            complex1.re = 13;
            complex1.im = 18;

            Complex_struct complex2;
            complex2.re = 79;
            complex2.im = 14;

            Print("\n*Сложение комплексных чисел*\n");
            Complex_struct result = complex1.Plus(complex2);
            Console.WriteLine($"{complex1.ToString()} + {complex2.ToString()} = {result.ToString()}");

            Print("\n*Умножение комплексных чисел*\n");
            result = complex1.Multi(complex2);
            Console.WriteLine($"{complex1.ToString()} x {complex2.ToString()} = {result.ToString()}");

            Print("\n*Вычитание комплексных чисел*\n");
            result = complex1.Subtraction(complex2);
            Console.WriteLine($"{complex1.ToString()} - {complex2.ToString()} = {result.ToString()}");
            /*****************************************************************************************/
            Print("\n\n");
            /*****************************************************************************************/
            Print("-=Демонстрация задания 1_Класс комплексного числа=-\n" , "centr");
            Complex_class complex1_cls = new Complex_class();
            complex1_cls.re = 16;
            complex1_cls.im = 75;

            Complex_class complex2_cls = new Complex_class();
            complex2_cls.re = 9;
            complex2_cls.im = 66;

            Print("\n*Сложение комплексных чисел*\n");
            Complex_class result_cls = complex1_cls.Plus(complex2_cls);
            Console.WriteLine($"{complex1_cls.ToString()} + {complex2_cls.ToString()} = {result_cls.ToString()}");

            Print("\n*Умножение комплексных чисел*\n");
            result_cls = complex1_cls.Multi(complex2_cls);
            Console.WriteLine($"{complex1_cls.ToString()} x {complex2_cls.ToString()} = {result_cls.ToString()}");

            Print("\n*Вычитание комплексных чисел*\n");
            result_cls = complex1_cls.Subtraction(complex2_cls);
            Console.WriteLine($"{complex1_cls.ToString()} - {complex2_cls.ToString()} = {result_cls.ToString()}");
            /*****************************************************************************************/
        }
        /*
        2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
        Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
        б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
        При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
        */
        /// <summary>
        /// Возвращает истину если число больше или равно нулю, само число возращает по ссылке вторым аргументом.
        /// </summary>
        /// <param name="input">Проверяемое целое число</param>
        /// <param name="output">Передает введеное пользователем число из input в output вне зависимости от истинности условия</param>
        /// <returns></returns>

        /// <summary>
        /// Демонстрация задания 2
        /// </summary>
        static void Presentation_Task2()
        {
            Print("-=Демонстрация задания 2=-\n" , "centr");
            int inputData;
            int n = 1;//счетчик для циклов
            List<int> intList = new List<int>();
            int sum = 0;
            while (true)
            {
                Console.Write($"Введите неотрицательное целое число № {n} или 0 для завершения: ");
                try
                {
                    if (!PositiveNum(Convert.ToInt32(Console.ReadLine()) , out inputData))
                    {
                        throw new Exception("Введенное число, не соответствует условию.");
                    }
                    if (inputData == 0)
                    {
                        break;
                    }
                    intList.Add(inputData);
                    n++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message} Пожалуйста введите данные, требуемые условием.");
                }
            }
            n = 1;
            foreach (int item in intList)
            {
                if (item % 2 != 0)
                {
                    Console.WriteLine($"Число введенное под номером №{n}, нечетное: {item}");
                    sum += item;
                }
                n++;
            }
            Console.WriteLine($"Сумма всех нечетных элементов: {sum}");
        }
        static bool PositiveNum(int input , out int output)
        {
            output = input;
            if (input >= 0)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Демонстрация задания 3
        /// </summary>
        static void Presentation_Task3()
        {
            Print("-=Демонстрация задания 3_Дроби=-\n" , "centr");
            int[] int_num_div = new int[3];

            consoleInputFractNums("первой дроби",out int_num_div[0], out int_num_div[1], out int_num_div[2]);
            FractionalNumber a = new FractionalNumber(int_num_div[0] , int_num_div[1] , int_num_div[2]);
            consoleInputFractNums("второй дроби" , out int_num_div[0] , out int_num_div[1] , out int_num_div[2]);
            FractionalNumber b = new FractionalNumber(int_num_div[0] , int_num_div[1] , int_num_div[2]);

            Print($"{a._ToString()}\n{b._ToString()}\n");

            Print($"{a._ToString()} + {b._ToString()} = {(a + b)._ToString()}\n");
            Print($"{a._ToString()} - {b._ToString()} = {(a - b)._ToString()}\n");
            Print($"{a._ToString()} * {b._ToString()} = {(a * b)._ToString()}\n");
            Print($"{a._ToString()} / {b._ToString()} = {(a / b)._ToString()}\n");
        }
        /// <summary>
        /// Метод берет у пользователя данные для дроби и проверяет их корректность
        /// </summary>
        /// <param name="text">описание какой дроби требуется ввести значения, например _первой дроби_</param>
        /// <param name="integer">возвращает введенную целую часть</param>
        /// <param name="numerator">возвращает введенный числитель</param>
        /// <param name="divider">возвращает введный делитель</param>
        static void consoleInputFractNums(string text , out int integer , out int numerator , out int divider)
        {
            int[] int_num_div = new int[3];
            string parrFractNaum = "";
            for (int i = 0 ; i < int_num_div.Length ; i++)
            {
                switch (i)
                {
                    case 0:
                        parrFractNaum = "целое";
                        break;
                    case 1:
                        parrFractNaum = "числитель";
                        break;
                    case 2:
                        parrFractNaum = "делитель";
                        break;
                }
                while (true)
                {
                    Print($"Введите {parrFractNaum} {text}: ");
                    try
                    {
                        int_num_div[i] = Convert.ToInt32(Console.ReadLine());
                        if (i == 2 & int_num_div[i] == 0)
                        {
                            throw new Exception("Делитель не может быть равен нулю.");
                        }
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{ex.Message} Пожалуйста введите корректные данные");
                    }
                }
            }
            integer = int_num_div[0];
            numerator = int_num_div[1];
            divider = int_num_div[2];

        }
        static void Main(string[] args)
        {
            Presentation_Task1();

            Pause();
            Console.Clear();

            
            Presentation_Task2();
            Pause();
            Console.Clear();

            Presentation_Task3();




            Pause();
        }
    }
}
