using System;

namespace Comparer
{
    /// <summary>
    /// Персона
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// Адрес
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Дата обновления сведений
        /// </summary>
        public DateTime UpdatedAt { get; set; }
    }
}
