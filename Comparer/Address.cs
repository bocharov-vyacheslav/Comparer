namespace Comparer
{
    /// <summary>
    /// Адрес
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Город
        /// </summary>
        public City City { get; set; }
        
        /// <summary>
        /// Улица
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Номер дома
        /// </summary>
        public int House { get; set; }
    }
}
