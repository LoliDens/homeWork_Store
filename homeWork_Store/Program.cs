using System;

namespace homeWork_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountGold;
            int amountCrystals;
            int crystalPrice = 34;
            bool canBuyCrystals;

            Console.WriteLine($"Добро пожаловать в магазин кристалов. Курс одного кристалла сегодны {crystalPrice}");
            Console.Write("Сколько золата у вас есть: ");
            amountGold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Склдько кристалов вы хотике купить: ");
            amountCrystals = Convert.ToInt32(Console.ReadLine());
            
            canBuyCrystals = amountGold > (crystalPrice * amountCrystals);
            amountCrystals *= Convert.ToInt32(canBuyCrystals);
            amountGold -= amountCrystals * crystalPrice;

            Console.WriteLine($"Количество кристалов: {amountCrystals}. Количесто золота: {amountGold}");
            Console.ReadKey();
            

        }
    }
}
