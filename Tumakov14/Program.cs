#define DEBUG_ACCOUNT
using System;
using System.Reflection;
using Tumakov14.Attributes;
using Tumakov14.Classes;

namespace Tumakov14
{
    class Program()
    {
        static void Main(string[] args)
        {
            // Упражнение 14.1
            Console.WriteLine("Упражнение 14.1");

            BankAccount account = new BankAccount(650);

            account.DumpToScreen();


            // Упражнение 14.2
            Console.WriteLine("\nУпражнение 14.2");

            MemberInfo member;
            member = typeof(Rational);
            object[] attrs = member.GetCustomAttributes(false);

            foreach (Attribute attr in attrs)
            {
                if (attr is DeveloperInfoAttribute)
                {
                    DeveloperInfoAttribute dia = (DeveloperInfoAttribute)attr;
                    Console.WriteLine($"Developer - {dia.DeveloperName}, date - {dia.Date.ToString("dd/MM/yyyy")}");
                }
            }


            // Домашнее задание 14.1
            Console.WriteLine("\nДомашнее задание 14.1");

            MemberInfo typeInfo = typeof(House);
            object[] atrs = typeInfo.GetCustomAttributes(false);

            foreach (Attribute atr in atrs)
            {
                if (atr is HouseInfoAttribute)
                {
                    HouseInfoAttribute dia = (HouseInfoAttribute)atr;
                    Console.WriteLine($"Разработчик - {dia.DeveloperName}. Организация - {dia.OrganizationName}");
                }
            }
        }
    }
}