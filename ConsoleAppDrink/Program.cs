using System;

namespace ConsoleAppDrink
{
    class Program
    {
        static void Main(string[] args)
        {

            Tea t1 = new Tea("каркаде");
            Coffee c1 = new Coffee("бразильский черный");

            Console.WriteLine(t1.Pour());
            Console.WriteLine(t1.AddSugar());
            Console.WriteLine(t1.AddJae());
            Console.WriteLine(t1.DrinkUp());

            Console.WriteLine();

            Console.WriteLine(c1.Pour());
            Console.WriteLine(c1.AddMilk());
            Console.WriteLine(c1.DrinkUp());
            Console.WriteLine("А здесь сделаем вывод сообщения чтобы научиться фиксировать правки в коде через GitHub");

            Console.ReadKey();
        }
    }
}
