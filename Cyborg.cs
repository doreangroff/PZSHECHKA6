using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microchelik2
{
    internal class Cyborg : RepuckByIluhich
    {
        Head head;
        Body body;
        Hands hands;
        Legs legs;

        public Cyborg(Head head, Body body, Hands hands, Legs legs)
        {
            this.head = head;
            this.body = body;   
            this.hands = hands;
            this.legs = legs;
        }
        private int _power; 
        public int Power
        {
            get {return _power;}
            set
            {
                if (value > body.Height * body.Lenght)
                {
                    _power = value;
                    Console.WriteLine("Жесткий и рисковый");
                }
                else
                {
                    Console.WriteLine("Бро тебе надо тренироваться. Потвори попытку");
                }
            }
        }
        
        
    }
}
