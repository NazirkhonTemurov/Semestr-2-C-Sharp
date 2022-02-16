/*******************************
*Название: Возведение в Степень*
*Дата:     10.02.2022          *
*Автор:    Темуров Назирхон    *
********************************/
using System;

namespace Первые_Шаги_Чать_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Возведение В Степень");
            Console.WriteLine("_____________________\n");
            Console.Write("Введите число:");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.Write("В какую Степень поднять:");
            int Stepen = Convert.ToInt32(Console.ReadLine());

            int Result = 1;

            for (int Step = 1; Step <= Stepen; ++Step )
            {
                Result *= Number; 
            }

            Console.WriteLine("Ответ:" + Result);
            
            Console.ReadKey();
        }
    }
}
