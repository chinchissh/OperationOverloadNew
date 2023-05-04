using System;

namespace OperationOverloadNew//Лабораторная работа по Мищенко №8
{
    class Program
    {
        static void Main()
        {
            Time t1 = new Time(1, 30, 0);
            Time t2 = new Time(2, 45, 15);

            Console.WriteLine($"Первое время - t1 = {t1}");
            Console.WriteLine($"Второе время - t2 = {t2}");

            Time sum = t1 + t2;
            Console.WriteLine($"Суммая времени t1 + t2 = {sum}");

            Time diff = t2 - t1;
            Console.WriteLine($"Разница времени t2 - t1 = {diff}");

            Console.WriteLine($"Различные операции с временем: ");

            Console.WriteLine($"t1 == t2? {t1 == t2}");
            Console.WriteLine($"t1 != t2? {t1 != t2}");
            Console.WriteLine($"t1 < t2? {t1 < t2}");
            Console.WriteLine($"t1 > t2? {t1 > t2}");
            Console.WriteLine($"t1 <= t2? {t1 <= t2}");
            Console.WriteLine($"t1 >= t2? {t1 >= t2}");

            Console.WriteLine($"t1++ = {t1++}");
            Console.WriteLine($"++t1 = {++t1}");
            Console.WriteLine($"t2-- = {t2--}");
            Console.WriteLine($"--t2 = {--t2}");
        }
    }

}
