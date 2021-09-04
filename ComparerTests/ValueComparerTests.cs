using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Comparer.Tests
{
    /// <summary>
    /// Тесты класса ValueComparer
    /// </summary>
    [TestClass()]
    public class ValueComparerTests
    {
        /// <summary>
        /// Сравнение объектов без различий
        /// </summary>
        [TestMethod()]
        public void CompareTest_AreEqual()
        {
            // arrange
            var first = new Person
            {
                FirstName = "Иван",
                LastName = "Иванов",
                Address = new Address
                {
                    City = new City() { Name = "Екатеринбург", Region = "Свердловская область" },
                    Street = "Ленина",
                    House = 1
                },
                UpdatedAt = new DateTime(2021, 5, 4)
            };

            var second = new Person
            {
                FirstName = "Иван",
                LastName = "Иванов",
                Address = new Address
                {
                    City = new City() { Name = "Екатеринбург", Region = "Свердловская область" },
                    Street = "Ленина",
                    House = 1
                },
                UpdatedAt = new DateTime(2021, 5, 4)
            };

            // act
            var comparer = new ValueComparer();
            var differences = comparer.Compare(first, second);

            // assert
            Assert.IsTrue(differences.Count() == 0);
        }

        /// <summary>
        /// Сравнение объектов с различиями
        /// </summary>
        [TestMethod()]
        public void CompareTest_AreNotEqual()
        {
            // arrange
            var first = new Person
            {
                FirstName = "Иван",
                LastName = "Иванов",
                Address = new Address

                {
                    City = new City() { Name = "Пермь", Region = "Пермский край" },
                    Street = "Чапаева",
                    House = 2
                },
                UpdatedAt = new DateTime(2021, 5, 4)
            };

            var second = new Person
            {
                FirstName = "Александр",
                LastName = "Сидоров",
                Address = new Address
                {
                    City = new City() { Name = "Екатеринбург", Region = "Свердловская область" },
                    Street = "Малышева",
                    House = 4
                },
                UpdatedAt = new DateTime(2021, 1, 4)
            };

            // act
            var comparer = new ValueComparer();
            var differences = comparer.Compare(first, second);

            // assert
            Assert.IsTrue(differences.Count() > 0);

        }
    }
}