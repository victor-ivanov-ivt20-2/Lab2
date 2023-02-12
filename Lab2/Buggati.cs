using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Buggati : Car
    {
        public Buggati(int max_speed, string registration_plate) : base(max_speed, registration_plate)
        {
        }

        public override void Buy()
        {
            Console.WriteLine(PreBuy());
            Console.WriteLine("Модель вашей машины Buggati");
        }

        public override void Start()
        {
            _current_speed = 5;
            Console.WriteLine($"Вы на своей Buggati поехали со скоростью {_current_speed}км/ч");
        }
        public override void IncreaseSpeed()
        {
            if (_current_speed <= 0 ) 
            {
                Console.WriteLine("Машина не заведена. Нажмите \"Газ\"");
            } else
            {
                _current_speed += 67;
                if (_current_speed <= _max_speed) 
                    Console.WriteLine($"Вы увеличили скорость машины на 67км/ч. Ваша скорость {_current_speed}км/ч");
                else
                {
                    _current_speed = _max_speed;
                    Console.WriteLine("Вы достигли максимальной скорости!");
                }
            }
        }
        public override void DecreaseSpeed()
        {
            if (_current_speed > 0)
            {
                _current_speed -= 62;
                if (_current_speed < 0)
                {
                    Console.WriteLine("Вы стоите на месте");
                    _current_speed = 0;
                } else Console.WriteLine($"Вы уменьшили скорость машины на 62км/ч. Ваша скорость {_current_speed}км/ч");
            } else Console.WriteLine("Машина не заведена. Нажмите \"Газ\"");
        }
    }
}
