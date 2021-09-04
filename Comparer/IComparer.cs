using System.Collections.Generic;

namespace Comparer
{
    /// <summary>
    /// Интерфейс для сравнения объектов
    /// </summary>
    interface IComparer
    {
        /// <summary>
        /// Сравнение объектов
        /// </summary>
        /// <typeparam name="T">Дженерик-тип</typeparam>
        /// <param name="first">Первый объект</param>
        /// <param name="second">Второй объект</param>
        /// <returns>Различия между объектами</returns>
        IEnumerable<Difference> Compare<T>(T first, T second);
    }
}
