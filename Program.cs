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
                List<Cyborg> humans = new List<Cyborg>();
                //кортеж
               
                int s;
                string name;
                int num;
                Console.WriteLine("Введите количество людей");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите список людей");
                
                while(num > 0)
                {
                    Console.WriteLine("Введите имя человека");
                    name = Console.ReadLine();
                    Console.WriteLine();

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
                    Cyborg chel = new Cyborg(head, body, hands, legs);
                    chel.name = name;
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
                    
                    humans.Add(chel);

                    --num;
          
                    Console.WriteLine();
                }

                Console.WriteLine("Список созданных людей:");
               

                vivod(humans);

               

            }
            catch
            {
                Console.WriteLine("эм чел лол кринж");
            }

            Console.ReadKey();

        }

        public static void vivod(List<Cyborg> chels)
        {
            var coolchels = chels.Where(c => c.legs.L > 90 && c.hands.L > 65).Select(c => c.name).ToList();
            coolchels.ForEach(c => Console.WriteLine(c));
        }

        public static void vvod(List<Cyborg> chels, int c = 0)
        {
            if (c < chels.Count)
            { 
                Console.WriteLine(chels[c].name);
                c++;
                vvod(chels, c);
            }
        }
    }
}
