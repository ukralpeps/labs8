using System;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<Action<float, float>, bool> func = GetTrue; //создание делегата 
            Action<float, float> action = Draw; //инициализация делегата
            func.Invoke(action); //вызов делегата
            func = GetFalse; // инициализация делегата
            func.Invoke(action); //вызов делегата

        }

        static void Draw(float x, float y) //метод вывода на экран
        {
            Console.WriteLine($"{x} and {y}");

        }
        static bool GetTrue(Action<float, float> draw) //true
        {
            draw.Invoke(1.33f, 8.17f);
            return true;
        }
        static bool GetFalse(Action<float, float> draw) //false
        {
            draw.Invoke(0, 35.177f);
            return false;
        }


    }
}
