using System.Collections.Generic;

namespace Comparer
{
    /// <summary>
    /// Реализация интерфейса для сравнения объектов
    /// </summary>
    public class ValueComparer : IComparer
    {
        /// <summary>
        /// Сравнение объектов
        /// </summary>
        /// <typeparam name="T">Дженерик-тип</typeparam>
        /// <param name="first">Первый объект</param>
        /// <param name="second">Второй объект</param>
        /// <returns>Различия между объектами</returns>
        public IEnumerable<Difference> Compare<T>(T first, T second)
        {
            var differences = new List<Difference>();

            if ((first == null) || (second == null))
                return differences;

            var firstType = first.GetType();
            var secondType = second.GetType();
            if (!firstType.IsClass || firstType != secondType)
                return differences;

            var stringType = typeof(string);
            foreach (var property in firstType.GetProperties())
            {
                var firstValue = property.GetValue(first);
                var secondValue = property.GetValue(second);

                if (property.PropertyType.IsClass && property.PropertyType != stringType)
                {
                    var list = Compare(firstValue, secondValue);
                    foreach (var item in list)
                        item.Path = $"{property.Name}.{item.Path}";
                    differences.AddRange(list);
                }
                else
                {
                    if (!firstValue.Equals(secondValue))
                        differences.Add(new Difference() { Path = property.Name, FirstValue = firstValue, SecondValue = secondValue });
                }
            }

            return differences;
        }
    }
}
