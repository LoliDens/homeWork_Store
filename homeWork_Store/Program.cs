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
            int coutCrystal;
            int crystalPrice = 34;
            bool enougtMoney;

            Console.WriteLine($"Добро пожаловать в магазин кристалов. Курс одного кристалла сегодны {crystalPrice}");
            Console.Write("Сколько золата у вас есть: ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Склдько кристалов вы хотике купить: ");
            coutCrystal = Convert.ToInt32(Console.ReadLine());
            
            enougtMoney = money > (crystalPrice * coutCrystal);
            coutCrystal *= Convert.ToInt32(enougtMoney);
            money -= coutCrystal * crystalPrice;

            Console.WriteLine($"Количество кристалов: {coutCrystal}. Количесто золота: {money}");
            Console.ReadKey();
            

        }
    }
}
