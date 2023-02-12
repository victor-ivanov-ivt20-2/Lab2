using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[3];
            cars[0] = new Buggati(400, CreateRegistrationPlate(1002));
            cars[1] = new Ferrari(480, CreateRegistrationPlate(82498));
            cars[2] = new Toyota(300, CreateRegistrationPlate(923));
            Radio radio = new Radio();
            int your_car = -1;
            string[] menuItems = new string[] { "Буггати", "Феррари", "Тойота", "Выход" };
            string[] menuActions = new string[] { "Газ", "Включить радио", "Увеличить скорость", "Уменьшить скорость", "Назад" };
            string[] ChangeRadio = new string[] { "Включить радио", "Выключить радио" };
            string[] ChangeState = new string[] { "Газ", "Стоп" };
            string title = "Выберите машину для покупки";
            Console.WriteLine(title);
            Console.WriteLine();

            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;
            int whichMenu = 0;
            string title2 = "Выберите действие";
            while (true)
            {   
                if (whichMenu == 0)
                {
                    DrawMenu(menuItems, row, col, index);
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.DownArrow:
                            if (index < menuItems.Length - 1)
                                index++;
                            break;
                        case ConsoleKey.UpArrow:
                            if (index > 0)
                                index--;
                            break;
                        case ConsoleKey.Enter:
                            switch (index)
                            {
                                case 0:
                                    whichMenu = 1;
                                    ReDraw(title2, menuActions.Length);
                                    cars[index].Buy();
                                    your_car = index;
                                    index = 0;
                                    break;
                                case 1:
                                    whichMenu = 1;
                                    ReDraw(title2, menuActions.Length);
                                    cars[index].Buy();
                                    your_car = index;
                                    index = 0;
                                    break;
                                case 2:
                                    whichMenu = 1;
                                    ReDraw(title2, menuActions.Length);
                                    cars[index].Buy();
                                    your_car = index;
                                    index = 0;
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("Вы были в магазине \"Крутые тачки\"");
                                    return;
                                default:
                                    Console.WriteLine($"Пожалуйста, выберите машину!");
                                    break;
                            }
                            break;
                    }
                } else
                {
                    DrawMenu(menuActions, row, col, index);
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.DownArrow:
                            if (index < menuActions.Length - 1)
                                index++;
                            break;
                        case ConsoleKey.UpArrow:
                            if (index > 0)
                                index--;
                            break;
                        case ConsoleKey.Enter:
                            switch (index)
                            {
                                case 0:
                                    ReDraw(title2, menuActions.Length);
                                    if (cars[your_car]._current_speed > 0)
                                    {
                                        cars[your_car].Stop();
                                        menuActions[index] = ChangeState[0];
                                    } else
                                    {
                                        cars[your_car].Start();
                                        menuActions[index] = ChangeState[1];
                                    }
                                    break;
                                case 1:
                                    ReDraw(title2, menuActions.Length);
                                    if (!radio._isOn)
                                    {
                                        radio.On();
                                        menuActions[index] = ChangeRadio[1];
                                    } else
                                    {
                                        radio.Off();
                                        menuActions[index] = ChangeRadio[0];
                                    }
                                    break;
                                case 2:
                                    ReDraw(title2, menuActions.Length);
                                    cars[your_car].IncreaseSpeed();
                                    break;
                                case 3:
                                    ReDraw(title2, menuActions.Length);
                                    cars[your_car].DecreaseSpeed();
                                    if (cars[your_car]._current_speed <= 0)
                                    {
                                        menuActions[0] = ChangeState[0];
                                    }
                                    break;
                                case 4:
                                    whichMenu = 0;
                                    index = 0;
                                    radio.Off();
                                    menuActions[1] = ChangeRadio[0];
                                    ReDraw(title, menuItems.Length);
                                    break;
                                default:
                                    break;
                            }
                            break;
                    }
                }
            }
        }
        private static void DrawMenu(string[] items, int row, int col, int index)
        {
            Console.SetCursorPosition(col, row);
            for (int i = 0; i < items.Length; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(items[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        private static void ReDraw(string title, int elements)
        {
            Console.Clear();
            Console.WriteLine(title);
            Console.WriteLine();
            for (int i = 0; i < elements; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        private static string CreateRegistrationPlate(int n)
        {
            Random random = new Random();
            string alphabet = "АВЕКМНОРСТУХ";
            string numbers = "0123456789";
            string region = "14RUS";
            string s = "";
            s += alphabet[random.Next(0, n) % 12];
            for (int i = 1; i < 6; i++)
            {
                if (i < 4)
                {
                    s += numbers[random.Next(0, n) % 10];
                }
                else
                {
                    s += alphabet[random.Next(0, n) % 12];
                }
            }
            s = s + "/" + region;
            return s;
        }
    }
}
