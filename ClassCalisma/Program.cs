using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCalisma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public string[,] Fiyatlar = { { "Sandwich", "10.5", }, { "Croissant", "7" }, { "Pancake", "9" } };

            int i = 1;
            Icecek icecek1 = new Icecek();
            Console.WriteLine("WELCOME!\n");
            Menu();
            Console.Write("\nENTER YOUR CHOICE ACCORDING TO MENU: ");
            int menu_choice = int.Parse(Console.ReadLine());
            if (menu_choice == 1)
            {
                Console.WriteLine();
                FoodMenu();
                Console.Write("\nENTER YOUR CHOICE ACCORDING TO MENU: ");
                int food_choice = int.Parse(Console.ReadLine());
                if (food_choice == 1)
                {
                    Console.WriteLine();
                    BreakfastMenu();
                }
            }
            while (true)
            {
                Console.Write(i + ". icerik = ");
                string getIcerik = Console.ReadLine();
                if (getIcerik == "q") break;
                icecek1.icerik.Add(getIcerik);
                i++;
            }
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Icerik Goster --> 1");
                Console.WriteLine("Ucret Goster --> 2");
                Console.WriteLine("Icerik Adi --> 3");
                Console.Write("Menuden gormek istediginiz bilgiyi tuslayiniz: ");
                int secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        icecek1.IcerikGoster();
                        break;
                    case 2:
                        icecek1.UcretGoster();
                        break;
                    case 3:
                        icecek1.IcecekAdi();
                        break;
                }

            }

        }
        enum Foods
        {
            Breakfast = 1, Dinner, Vegetarian
        }
        enum Breakfast
        {
            Sandwich = 1, Croissant, Pancake
        }
        enum Dinner
        {
            Chickenbreast = 1, Fries, Pasta, Salmon, Pizza
        }
        enum Vegetarian
        {
            Salad = 1, Enchiladas, Fennel
        }
        enum Drinks
        {
            Smoothie = 1, Milkshake, Cola, IceTea, Water
        }
        enum Smoothies
        {
            Banana = 1, Strawberry, Kiwi, Blueberry, Mango, Pineapple, Peach, Orange, Grape
        }
        enum Milkshakes
        {
            Chocolate = 1, Banana, Strawberry, Vanilla
        }
        enum IceTeas
        {
            Peach = 1, Mango, Lemon
        }
        static void Menu()
        {
            Console.WriteLine("*****MENU*****\n");
            Console.WriteLine("1)FOODS\n2)DRINKS");
        }
        static void FoodMenu()
        {
            for (int i = 1; i <= 3; i++)
            {
                Foods food = (Foods)i;
                Console.WriteLine(food + " --> " + (int)food);
            }
        }
        static void BreakfastMenu()
        {
            for (int i = 1; i <= 3; i++)
            {
                Breakfast breakfast = (Breakfast)i;
                Console.WriteLine(breakfast + " --> " + (int)breakfast);

    }
        }

