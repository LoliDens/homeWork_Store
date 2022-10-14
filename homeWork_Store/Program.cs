using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            int amountCrystals;
            int crystalPrice = 34;
            bool canBuyCrystals;

            Console.WriteLine($"Добро пожаловать в магазин кристалов. Курс одного кристалла сегодны {crystalPrice}");
            Console.Write("Сколько золата у вас есть: ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Склдько кристалов вы хотике купить: ");
            amountCrystals = Convert.ToInt32(Console.ReadLine());
            
            canBuyCrystals = money > (crystalPrice * amountCrystals);
            amountCrystals *= Convert.ToInt32(canBuyCrystals);
            money -= amountCrystals * crystalPrice;

            Console.WriteLine($"Количество кристалов: {amountCrystals}. Количесто золота: {money}");
            Console.ReadKey();
            

        }
    }
}
