using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.CompilerServices;

namespace microchelik2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Head head = new Head();
                Body body = new Body();
                Hands hands = new Hands();
                Legs legs = new Legs();              
                //кортеж
               
                int s;
                //голова
                Console.WriteLine("Введите данные головы");
                Console.WriteLine($"Корординаты центра головы (x)");
                head.X = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Корординаты центра головы (y)");
                head.Y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Радиус");
                head.R = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                //туловище
                Console.WriteLine("Введите данные туловища");
                Console.WriteLine($"Корординаты верхнего левого угла (x)");
                body.X = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Корординаты верхнего левого угла (y)");
                body.Y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Высота туловища");
                body.Height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Ширина туловища");
                body.Lenght = Convert.ToInt32(Console.ReadLine());
                s = body.Lenght * body.Height;
                Console.WriteLine();
                //руки
                Console.WriteLine("Введите данные рук");
                Console.WriteLine($"Длина рук");
                hands.L = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Угол положения");
                hands.Angle = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                //ноги
                Console.WriteLine("Введите данные ног");
                Console.WriteLine($"Длина ног");
                legs.L = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Угол положения");
                legs.Angle = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                //рост
                Console.WriteLine("Расчитать рост? (Да/Нет)");
                if (Console.ReadLine().ToLower() == "да")
                {
                    Console.WriteLine($"Ваш рост = {head.R * 2 + body.Height + legs.L}");
                }
                else 
                {
                    Console.WriteLine("Ну ладна");
                    
                }

                Console.WriteLine();
                //киборг
                Cyborg kiborg = new Cyborg(head, body, hands, legs);
                kiborg.Power = 0;
                Console.WriteLine("Теперь настало время киборга");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите мощь экзоскилета");
                Console.WriteLine($"ВАЖНО!!! Мощь экзоскилета должна быть не менее площади туловища ({s})");
                do
                {
                    kiborg.Power = Convert.ToInt32(Console.ReadLine());
                    //if (kiborg.Power > s)
                    //{
                    //    Console.WriteLine("Жесткий и рисковый");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Бро надо тренироваться. Повтори попытку");

                    //}
                    
                } while (kiborg.Power < s);
                kiborg.yadaun();

            }
            catch
            {
                Console.WriteLine("эм чел лол кринж");
            }

            Console.ReadKey();

        }
    }
}
