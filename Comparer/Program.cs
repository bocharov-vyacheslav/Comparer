using System;
using System.Linq;

namespace Comparer
{
    class Program
    {
        /// <summary>
        /// Основная функция
        /// </summary>
        public static void Main()
        {
            var first = new Person
            {
                FirstName = "Иван",
                LastName = "Иванов",
                Address = new Address

                {
                    City = new City() { Name = "Пермь", Region = "Пермский край" },
                    Street = "Ленина",
                    House = 1
                },
                UpdatedAt = new DateTime(2021, 5, 5)
            };

            var second = new Person
            {
                FirstName = "Иван",
                LastName = "Сидоров",
                Address = new Address
                {
                    City = new City() { Name = "Екатеринбург", Region = "Свердловская область" },
                    Street = "Малышева",
                    House = 4
                },
                UpdatedAt = new DateTime(2021, 5, 4)
            };

            var comparer = new ValueComparer();
            var differences = comparer.Compare(first, second);

            if (differences.Count() > 0)
            {
                Console.WriteLine("{0,-30} {1,-30} {2,-30}", "Путь", "First", "Second");
                foreach (var item in differences)
                    Console.WriteLine("{0,-30} {1,-30} {2,-30}", item.Path, item.FirstValue, item.SecondValue);
            }

            Console.WriteLine();
            Console.WriteLine("Для завершения работы программы нажмите клавишу Enter...");
            Console.ReadLine();
        }
    }
}
