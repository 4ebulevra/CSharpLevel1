﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Устюжанин Максим Николаевич*/
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

    /*3.
    *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
    Предусмотреть методы сложения, вычитания, умножения и деления дробей.
    Написать программу, демонстрирующую все разработанные элементы класса.
    ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
    ArgumentException("Знаменатель не может быть равен 0");
    Добавить упрощение дробей.
    */
    class FractionalNumber
    {
        int numerator;
        int divider;
        int integer;

        private static void Сomplicating(ref int integer , ref int numerator , ref int divider)
        {
            if (integer < 0)
            {
                numerator *= -1;
            }
            numerator = numerator + (integer * divider);
            integer = 0;
        }
        /// <summary>
        /// Перегрузка операции сложения возвращающая резальтат в виде экземпляра класса FractionalNumber
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="f2"></param>
        /// <returns></returns>
        public static FractionalNumber operator +(FractionalNumber f1 , FractionalNumber f2)
        {
            FractionalNumber rez = new FractionalNumber(1 , 1 , 1);

            int newDiv;
            FractionalNumber tempA = new FractionalNumber(f1.Integer , f1.Numerator , f1.Divider);
            FractionalNumber tempB = new FractionalNumber(f2.Integer , f2.Numerator , f2.Divider);
            newDiv = tempA.Divider * tempB.Divider;

            rez.Integer = 0;
            Сomplicating(ref tempA.integer , ref tempA.numerator , ref tempA.divider);
            Сomplicating(ref tempB.integer , ref tempB.numerator , ref tempB.divider);

            tempA.Numerator = tempA.Numerator * tempB.Divider;
            tempB.Numerator = tempB.Numerator * tempA.Divider;
            tempA.Divider = newDiv;
            tempB.Divider = newDiv;


            rez.Divider = newDiv;
            rez.Numerator = tempA.Numerator + tempB.Numerator;
            rez.Recount();
            rez.Simplification();
            return rez;

        }

        /// <summary>
        /// Перегрузка операции вычитания возвращающая резальтат в виде экземпляра класса FractionalNumber
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="f2"></param>
        /// <returns></returns>
        public static FractionalNumber operator -(FractionalNumber f1 , FractionalNumber f2)
        {
            FractionalNumber rez = new FractionalNumber(1 , 1 , 1);

            int newDiv;
            FractionalNumber tempA = new FractionalNumber(f1.Integer , f1.Numerator , f1.Divider);
            FractionalNumber tempB = new FractionalNumber(f2.Integer , f2.Numerator , f2.Divider);
            newDiv = tempA.Divider * tempB.Divider;

            rez.Integer = 0;
            Сomplicating(ref tempA.integer , ref tempA.numerator , ref tempA.divider);
            Сomplicating(ref tempB.integer , ref tempB.numerator , ref tempB.divider);

            tempA.Numerator = tempA.Numerator * tempB.Divider;
            tempB.Numerator = tempB.Numerator * tempA.Divider;
            tempA.Divider = newDiv;
            tempB.Divider = newDiv;


            rez.Divider = newDiv;
            rez.Numerator = tempA.Numerator - tempB.Numerator;
            rez.Recount();
            rez.Simplification();
            return rez;
        }

        /// <summary>
        /// Перегрузка операции умножения возвращающая резальтат в виде экземпляра класса FractionalNumber
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="f2"></param>
        /// <returns></returns>
        public static FractionalNumber operator *(FractionalNumber f1 , FractionalNumber f2)
        {
            FractionalNumber rez = new FractionalNumber(1 , 1 , 1);

            FractionalNumber tempA = new FractionalNumber(f1.Integer , f1.Numerator , f1.Divider);
            FractionalNumber tempB = new FractionalNumber(f2.Integer , f2.Numerator , f2.Divider);

            rez.Integer = 0;
            Сomplicating(ref tempA.integer , ref tempA.numerator , ref tempA.divider);
            Сomplicating(ref tempB.integer , ref tempB.numerator , ref tempB.divider);

            rez.Numerator = tempA.Numerator * tempB.Numerator;
            rez.Divider = tempA.Divider * tempB.Divider;

            rez.Recount();
            rez.Simplification();
            return rez;
        }

        /// <summary>
        /// Перегрузка операции деления возвращающая резальтат в виде экземпляра класса FractionalNumber
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="f2"></param>
        /// <returns></returns>
        public static FractionalNumber operator /(FractionalNumber f1 , FractionalNumber f2)
        {
            FractionalNumber rez = new FractionalNumber(1 , 1 , 1);

            FractionalNumber tempA = new FractionalNumber(f1.Integer , f1.Numerator , f1.Divider);
            FractionalNumber tempB = new FractionalNumber(f2.Integer , f2.Numerator , f2.Divider);

            rez.Integer = 0;
            Сomplicating(ref tempA.integer , ref tempA.numerator , ref tempA.divider);
            Сomplicating(ref tempB.integer , ref tempB.numerator , ref tempB.divider);

            rez.Numerator = tempA.Numerator * tempB.Divider;
            rez.Divider = tempA.Divider * tempB.Numerator;

            rez.Recount();
            rez.Simplification();
            return rez;
        }


        /// <summary>
        /// Возвращает наибольший общий делитель двух чисел
        /// </summary>
        /// <param name="a">первое число</param>
        /// <param name="b">второе число</param>
        /// <returns></returns>
        private int NOD(int a , int b)
        {
            if (a < 0)
            {
                a = a * -1;
            }
            if (b < 0)
            {
                b = b * -1;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="integer">Целое</param>
        /// <param name="numerator">Числитель</param>
        /// <param name="divider">Знаменатель</param>
        public FractionalNumber(int integer , int numerator , int divider)
        {
            Numerator = numerator;
            Divider = divider;
            Integer = integer;
            Recount();
            Simplification();
        }
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Divider
        {
            get { return divider; }
            set
            {
                if (value != 0)
                {
                    divider = value;
                }
            }
        }
        public int Integer
        {
            get { return integer; }
            set { integer = value; }
        }
        /// <summary>
        /// Метод приведения дроби в правильную дробь
        /// </summary>
        void Recount()
        {
            this.integer += this.numerator / this.divider;
            this.numerator = this.numerator % this.divider;
            if (this.Integer < 0)
            {
                if (this.Numerator < 0)
                {
                    this.Numerator *= -1;
                }
                if (this.Divider < 0)
                {
                    this.Divider *= -1;
                }
            }
            if (this.Numerator < 0 && this.Divider < 0)
            {
                this.Numerator *= -1;
                this.Divider *= -1;
            }
        }
        /// <summary>
        /// Метод упрощения дроби
        /// </summary>
        void Simplification()
        {
            if (this.Numerator != 0)
            {
                int nod = NOD(numerator , divider);
                numerator = numerator / nod;
                divider = divider / nod;
            }
        }
        /// <summary>
        /// Метод возвращающий строку с описанием представления дроби
        /// </summary>
        /// <returns></returns>
        public string _ToString()
        {
            Simplification();
            Recount();
            return Integer + " целых и " + numerator + "/" + divider;
        }
    }
}
