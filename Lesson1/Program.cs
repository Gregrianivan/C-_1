using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Program
    {
        /*
        * При вводе необходимо следить за типами данных
        * исключения не перехваываются
        */
        private static void Main(string[] args)
        {
            var x = 0;
            var b = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Введите номер задачи 1-5, ввод другого номер закроет приложение: ");
                x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        task1();
                        break;
                    case 2:
                        task2();
                        break;
                    case 3:
                        task3();
                        break;
                    case 4:
                        task4();
                        break;
                    case 5:
                        task5();
                        break;
                    default:
                        b = !b;
                        Console.Write("Программа выключатеся. нажмите любой кнопка.");
                        break;
                }
                Console.ReadKey();
            } while (b);
        }



        /// <summary>
        /// Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
        ///а) используя склеивание;
        ///б) используя форматированный вывод;
        ///в) используя вывод со знаком $
        /// </summary>


        private static void task1()
        {
            string name, surname;
            int age;
            double weight, high;

            Console.Write("Введите ваше имя.");
            name = Console.ReadLine();
            Console.Write("Введите вашу фамилию.");
            surname = Console.ReadLine();
            Console.Write("Каков ваш возраст?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введте ваш рост");
            high = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введте ваш вес");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(name + " " + surname + " " + age + " лет, " + high + " сантиметров, " + weight + "кг.");
            Console.WriteLine("Имя: {0}, Фамилия: {1}, Возраст: {2}, Вес: {3}, Рост: {4} ", name, surname, age, weight, high);
        }

        /// <summary>
        /// 1.	Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h*h); где m-масса тела в килограммах, h - рост в метрах
        ///*Интерпритировать показания ИМТ.
        /// </summary>
        private static void task2()
        {
            double weight, high;
            Console.Write("Введите ваш вес: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ваш рост: ");
            high = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("I = {0:f2}", (weight / (high * high)));
        }

        /// <summary>
        /// 3.	а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат используя спецификатор формата .2f (с двумя знаками после запятой);
        ///     б) *Выполните предыдущее задание оформив вычисления расстояния между точками в виде метода;
        /// </summary>
        private static void task3()
        {
            double x2, y2, x1, y1;
            Console.Write("Введите x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0:f2}", (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))));
            methodTask3(x1, y1, x2, y2);
        }

        /// <summary>
        /// Метод который выводи на экран растояние между двумя заданными точками
        /// </summary>
        /// <param name="x1">первая координата первой точки</param>
        /// <param name="y1">вторая координата первой точки</param>
        /// <param name="x2">первая координата второй точки</param>
        /// <param name="y2">вторая координата второй точки</param>
        private static void methodTask3(double x1, double y1, double x2, double y2)
        {
            Console.WriteLine("{0:f2}", (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))));
        }

        /// <summary>
        /// 4.	Написать программу обмена значениями двух переменных
        ///     а) с использованием третьей переменной;
        ///     б) *без использования третьей переменной.
        /// </summary>
        private static void task4()
        {
            double a, b;
            Console.Write("Введите значение а: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b: ");
            b = Convert.ToDouble(Console.ReadLine());

            /*вариант "А" с тремя переменными:*/
            double c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Вариант с тремя переменными а: " + a + "  b:" + b);

        }

        /// <summary>
        /// 5.	а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        ///     б) *Сделайте задание, только вывод организуйте в центре экрана
        ///     в) **Сделайте задание  б с использованием собственных методов(например, Print(string ms, int x, int y)
        /// </summary>

        private static void task5()
        {
            avtorInfo(); // выводин инфу об авторе

            Console.SetCursorPosition(15, 15);
            Console.WriteLine("Сыроватский Иван Сергеевич");
        }

        /// <summary>
        /// информация об авторе сего дивного приложения
        /// </summary>
        private static void avtorInfo()
        {
            Console.WriteLine("Сыроватский Иван Сергеевич");
        }
    }
}








