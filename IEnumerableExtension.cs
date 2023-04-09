namespace TheThirteenthProgram
{
    public static class IEnumerableExtension
    {
        /// <summary>
        /// Возвращает заданное количество процентов от выборки с округлением количества элементов в большую сторону.
        /// </summary>
        public static IEnumerable<T> Top<T>(this IEnumerable<T> source, int x)
        {
            if (source is null || !source.Any())
            {
                throw new ArgumentException("Вывод результата невозможен из-за отсутствия данных.");
            }
            if (x > 100 || x < 1)
            {
                throw new ArgumentException("Введеное значение должно быть в диапазоне от 1 до 100.");
            }
            double percent = source.Count() * x / 100.00;
            int value = (int)Math.Ceiling(percent);
            var result = source.TakeLast(value).OrderByDescending(x => x);
            return result;
        }

        public static IEnumerable<T> Top<T, TKey>(this IEnumerable<T> source, int x, Func<T, TKey> keySelector)
        {
            if (source is null || !source.Any())
            {
                throw new ArgumentException("Вывод результата невозможен из-за отсутствия данных.");
            }
            if (x > 100 || x < 1)
            {
                throw new ArgumentException("Введеное значение должно быть в диапазоне от 1 до 100.");
            }
            double parcent = source.Count() * x / 100.00;
            int value = (int)Math.Ceiling(parcent);
            var result = source.OrderByDescending(keySelector).Take(value);
            return result;
        }
    }
}
