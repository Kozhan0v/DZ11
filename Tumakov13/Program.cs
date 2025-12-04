using System;
using Tumakov13.Classes;
using Tumakov13.Enums;

namespace Tumakov13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Упражнение 13.1
            Console.WriteLine("Упражнение 13.1");

            BankAccount account = new BankAccount(650, TypeOfBankAccount.Current);
            Console.WriteLine("Баланс - " + account.Balance);
            Console.WriteLine("Тип счета - " + account.BankAccountType);
            account.Holder = "Kozhanov Kirill";
            Console.WriteLine("Держатель счета - " + account.Holder);


            // Упражнение 13.2
            Console.WriteLine("\nУпражнение 13.2");

            BankAccount account2 = new BankAccount();

            account.Deposit(350);
            account.Withdrow(650);
            account.Deposit(1000);
            account.Withdrow(700);

            Console.WriteLine(account[0].ToString());
            Console.WriteLine(account[1].ToString());
            Console.WriteLine(account[2].ToString());
            Console.WriteLine(account[3].ToString());
            Console.WriteLine(account.ToString());


            // Домашнее задание 13.1
            Console.WriteLine("\nДомашнее задание 13.1");

            House house = new House();

            house.Height = 10;
            house.NumberOfFloors = 5;
            house.NumberOfFlats = 100;
            house.NumberOfEntrances = 5;

            Console.WriteLine("Номер дома - " + house.HouseNum);
            Console.WriteLine("Высота дома - " + house.Height);
            Console.WriteLine("Кол-во этажей - " + house.NumberOfFloors);
            Console.WriteLine("Кол-во квартир - " + house.NumberOfFlats);
            Console.WriteLine("Кол-во подъездов - " + house.NumberOfEntrances);


            // Домашнее задание 13.2
            Console.WriteLine("\nДомашнее задание 13.2");

            House house1 = new House(6.5, 5, 150, 10);
            House house2 = new House();
            House house3 = new House();
            House house4 = new House();
            House house5 = new House();
            House house6 = new House();
            House house7 = new House();
            House house8 = new House();
            House house9 = new House();
            House house10 = new House();

            Street shumilova = new Street(house1, house2, house3, house4, house5, house6, house7, house8, house9, house10);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(shumilova[i].ToString());
            }
        }
    }
}