namespace Comparer
{
    /// <summary>
    /// Различие
    /// </summary>
    public class Difference
    {
        /// <summary>
        /// Путь до различающегося свойства
        /// </summary>
        public string Path { get; set; }
        
        /// <summary>
        /// Значение объекта First
        /// </summary>
        public object FirstValue { get; set; }

        /// <summary>
        /// Значение объекта Second
        /// </summary>
        public object SecondValue { get; set; }
    }
}
