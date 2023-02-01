#define HW5

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace HW_2022_12_05
{
    /*Задание 4
    Создайте класс «Веб-сайт». Необходимо хранить в полях класса: название сайта, путь к сайту, описание 
    сайта, ip адрес сайта. Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным 
    полям через методы класса. */
    class WebSite
    {
        public string Name;
        public string https;
        public string description;
        public int ipAddress;
        public void GetInfo()
        {
            Console.WriteLine("Введите информацию о сайте: ");
            Console.WriteLine("Введите название сайта :");
            Name = Console.ReadLine();
            Console.WriteLine("Ведите адрес сайта: ");
            https = Console.ReadLine();
            Console.WriteLine("Введите описание сайта :");
            description = Console.ReadLine();
            Console.WriteLine("Введите IP адрес сайта: ");
            ipAddress = int.Parse(Console.ReadLine());
            Console.Clear();
        }
        public void Print()
        {
            Console.WriteLine("Информация о сайте:");
            Console.WriteLine($"Название сайта: {Name}");
            Console.WriteLine($"Адрес сайта: {https}");
            Console.WriteLine($"Описание сайта: {description}");
            Console.WriteLine($"IP адрес сайта: {ipAddress}");
        }
    }

    /*Задание 5
    Создайте класс «Журнал». Необходимо хранить в полях класса: название журнала, год основания,
    описание журнала, контактный телефон, контактный e-mail. Реализуйте методы класса для ввода данных, вывода 
    данных, реализуйте доступ к отдельным полям через методы класса.*/

    class Journal
    {
        public string Name;
        public int year;
        public string description;
        public int numberPhone;
        public string email;
        public void GetInfo()
        {
            Console.WriteLine("Введите информацию о журнале: ");
            Console.WriteLine("Введите название магазина");
            Name = Console.ReadLine();
            Console.WriteLine("Ведите год основания: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите описание журнала :");
            description = Console.ReadLine();
            Console.WriteLine("Введите номер телефона: ");
            numberPhone = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите email: ");
            email = Console.ReadLine();
            Console.Clear();
        }
        public void Print()
        {
            Console.WriteLine("Информация о Журнале:");
            Console.WriteLine($"Название журнала: {Name}");
            Console.WriteLine($"Год основания: {year}");
            Console.WriteLine($"Описание журнала: {description}");
            Console.WriteLine($"Номер телефона: {numberPhone}");
            Console.WriteLine($"Email: {email}");
        }

        /*Задание 6
        Создайте класс «Магазин». Необходимо хранить в полях класса: название магазина, адрес, описание 
        профиля магазина, контактный телефон, контактный e-mail. Реализуйте методы класса для ввода данных, вывода 
        данных, реализуйте доступ к отдельным полям через методы класса.*/

        class Shop
        {
            public string Name;
            public string address;
            public string description;
            public int numberPhone;
            public string email;
            public void GetInfo()
            {
                Console.WriteLine("Введите информацию о магазине: ");
                Console.WriteLine("Введите название магазина");
                Name = Console.ReadLine();
                Console.WriteLine("Адрес магазина: ");
                address = Console.ReadLine();
                Console.WriteLine("Введите описание магазина :");
                description = Console.ReadLine();
                Console.WriteLine("Введите номер телефона: ");
                numberPhone = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите email: ");
                email = Console.ReadLine();
                Console.Clear();
            }
            public void Print()
            {
                Console.WriteLine("Информация о магазине:");
                Console.WriteLine($"Название магазина: {Name}");
                Console.WriteLine($"Адрес магазина: {address}");
                Console.WriteLine($"Описание магазина: {description}");
                Console.WriteLine($"Номер телефона: {numberPhone}");
                Console.WriteLine($"Email: {email}");
            }
        }

        internal class Program
        {

            /*Задание 1
            Напишите метод, который отображает квадрат из некоторого символа. 
            Метод принимает в качестве параметра: длину стороны квадрата, символ.*/
            static void Squer(int x, char c = ' ')
            {
                int[,] array = new int[x, x];
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        array[i, j] = c;
                        Console.Write(c + " ");
                    }
                    Console.WriteLine();
                }
            }

            /*Задание 2
            Напишите метод, который проверяет является ли переданное число «палиндромом». Число передаётся в
            качестве параметра.Если число палиндром нужно вернуть из метода true, иначе false.
            Палиндром — число, которое читается одинаково как справа налево, так и слева направо.Например:
            1221 — палиндром;
            3443 — палиндром;
            7854 — не палиндром.*/

            static bool PolidromNamber(int a)
            {
                int res = 0, revers, original;
                original = a;
                while (a != 0)
                {
                    revers = a % 10;
                    res = res * 10 + revers;
                    a /= 10;
                }
                if (original == res) return true;
                else return false;
            }



            /*Задание 3
            Напишите метод, фильтрующий массив на основании переданных параметров. Метод принимает параметры: 
            оригинальный_массив, массив_с_данными_для_фильтрации.
            Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации.
            Например:
            1 2 6 -1 88 7 6 — оригинальный массив;
            6 88 7 — массив для фильтрации;
            1 2 -1 — результат работы метода.*/

            static void FilterArray(int[] arrayOriginal, int[] arrayFilter)
            {
                Console.WriteLine("Введите элементы первого массива");
                for (int i = 0; i < arrayOriginal.Length; i++)
                {
                    Console.ReadLine();
                }
                Console.WriteLine("введите элементы первого массива для фильтрации");
                for (int j = 0; j < arrayFilter.Length; j++)
                {
                    Console.ReadLine();
                }
            }

            static void Main(string[] args)
            {
#if HW1
            //Задание 1
            Console.WriteLine("Задание 1: \n");
            Squer(10, '+');
            Console.WriteLine();
#endif

#if HW2
            //Задание 2
            Console.WriteLine("Задание 2: \n");
            Console.WriteLine("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(PolidromNamber(number));
            Console.WriteLine();
#endif

#if HW3
            // не решила
            //Задание 3
            Console.WriteLine("Задание 3: \n");
            Console.WriteLine("Выберите кол-во элементов массива");
            int langth = int.Parse(Console.ReadLine());
            int[] arrayOriginal= new int[langth];
            int[] arrayFilter= new int[langth];
            FilterArray(arrayOriginal, arrayFilter);
            Console.WriteLine();

#endif

#if HW4

            //Задание 4
            Console.WriteLine("Задание 4: \n");
            var webSite = new WebSite();
            webSite.GetInfo();
            webSite.Print();
            Console.WriteLine();

#endif

#if HW5
                //Задание 5
                Console.WriteLine("Задание 5: \n");
                var journal = new Journal();
                journal.GetInfo();
                journal.Print();
                Console.WriteLine();

#endif

#if HW6

            //Задание 6
            Console.WriteLine("Задание 6: \n");
            var shop = new Shop();
            shop.GetInfo();
            shop.Print();
            Console.WriteLine();
#endif
            }

        }
    }
}
