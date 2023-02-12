using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Radio
    {
        public bool _isOn = false;
        public void On()
        {
            if (_isOn) Console.WriteLine("Радио включён. Играет приятная музыка");
            else
            {
                _isOn = true;
                Console.WriteLine("Вы включили радио. Заиграла приятная музыка");
            }
        }

        public void Off()
        {
            if (_isOn)
            {
                _isOn = false;
                Console.WriteLine("Вы выключили радио. Вам стало намного скучнее");
            } else Console.WriteLine("Радио выключен. Вы всё ещё слышите лишь шум мотора");
        }
    }
}
