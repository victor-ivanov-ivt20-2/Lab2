using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Car
    {
        public string _registration_plate;
        public int _max_speed;
        public int _current_speed;

        public Car(int max_speed, string registration_plate) 
        {
            _max_speed = max_speed;
            _registration_plate = registration_plate;
        }
        public string PreBuy()
        {
            return "Вы приобрели машину с номером " + _registration_plate + " и с максимальной скоростью " + _max_speed + "км/ч";
        }
        public virtual void Buy()
        {
            Console.WriteLine(PreBuy());
            Console.WriteLine("Ваша модель машины не определена!");
        }
        public virtual void Start()
        {
            _current_speed = 1;
            Console.WriteLine($"Вы поехали со скоростью {_current_speed}км/ч");
        }
        public virtual void Stop()
        {
            _current_speed = 0;
            Console.WriteLine($"Вы остановились");
        }
        public virtual void IncreaseSpeed() 
        {
            if (_current_speed <= _max_speed && _current_speed > 0) 
            {
                _current_speed += 1;
                Console.WriteLine($"Ваша скорость {_current_speed}км/ч");
            } else
            {
                Console.WriteLine("Вы достигли максимальной скорости!");
            }
            
        }
        public virtual void DecreaseSpeed()
        {
            if (_current_speed > 0)
            {
                _current_speed -= 1;
                Console.WriteLine($"Ваша скорость {_current_speed}км/ч");
            } else
            {
                _current_speed = 0;
                Console.WriteLine("Вы остановились. Ваша скорость достигла минимума");
            }
            
        }
    }
}
