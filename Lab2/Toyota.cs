using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Toyota : Car
    {
        public Toyota(int max_speed, string registration_plate) : base(max_speed, registration_plate)
        {
        }

        public override void Buy()
        {
            Console.WriteLine(PreBuy());
            Console.WriteLine("Модель вашей машины Toyota");
        }
        public override void Start()
        {
            _current_speed = 2;
            Console.WriteLine($"Вы на своей Toyota поехали со скоростью {_current_speed}км/ч");
        }
        public override void IncreaseSpeed()
        {
            if (_current_speed <= 0)
            {
                Console.WriteLine("Машина не заведена. Нажмите \"Газ\"");
            } else {
                _current_speed += 43;
                if (_current_speed <= _max_speed)
                    Console.WriteLine($"Вы увеличили скорость машины на 43км/ч. Ваша скорость {_current_speed}км/ч");
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
                _current_speed -= 39;
                if (_current_speed < 0)
                {
                    Console.WriteLine("Вы стоите на месте");
                    _current_speed = 0;
                }
                else Console.WriteLine($"Вы уменьшили скорость машины на 39км/ч. Ваша скорость {_current_speed}км/ч");
            } else Console.WriteLine("Машина не заведена. Нажмите \"Газ\"");
        }
    }
}
