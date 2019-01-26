using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    /*
    1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры;
    б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;
    */
    class Complex_class
    {
        public double im;
        public double re;

        /// <summary>
        /// Возращает результат вычитания комплексных чисел
        /// </summary>
        /// <param name="x">Аргумент принимающий второе комплечное число</param>
        /// <returns></returns>
        public Complex_class Subtraction(Complex_class x)
        {
            Complex_class y = new Complex_class();
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        /// <summary>
        /// Возвращает результат сложения двух комплексных чисел
        /// </summary>
        /// <param name="x">Аргумент принимающий второе комплечное число</param>
        /// <returns></returns>
        public Complex_class Plus(Complex_class x)
        {
            Complex_class y = new Complex_class();
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        /// <summary>
        /// Возвращает результат произведения двух комплексных чисел
        /// </summary>
        /// <param name="x">Аргумент принимающий второе комплечное число</param>
        /// <returns></returns>
        public Complex_class Multi(Complex_class x)
        {
            Complex_class y = new Complex_class();
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    struct Complex_struct
    {
        public double im;
        public double re;

        /// <summary>
        /// Возращает результат вычитания комплексных чисел
        /// </summary>
        /// <param name="x">Аргумент принимающий второе комплечное число</param>
        /// <returns></returns>
        public Complex_struct Subtraction(Complex_struct x)
        {
            Complex_struct y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        /// <summary>
        /// Возвращает результат сложения двух комплексных чисел
        /// </summary>
        /// <param name="x">Аргумент принимающий второе комплечное число</param>
        /// <returns></returns>
        public Complex_struct Plus(Complex_struct x)
        {
            Complex_struct y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        /// <summary>
        /// Возвращает результат произведения двух комплексных чисел
        /// </summary>
        /// <param name="x">Аргумент принимающий второе комплечное число</param>
        /// <returns></returns>
        public Complex_struct Multi(Complex_struct x)
        {
            Complex_struct y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
}
