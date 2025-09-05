namespace Problems
{
    public static class LinqExtensions
    {
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(

            this IEnumerable<TSource> source,

            Func<TSource, TKey> keySelector)

        {

            if (source == null) throw new ArgumentNullException(nameof(source));

            if (keySelector == null) throw new ArgumentNullException(nameof(keySelector));

            var seen = new HashSet<TKey>();

            foreach (var element in source)

            {

                var key = keySelector(element);

                if (seen.Add(key))

                    yield return element;

            }

        }

    }

}


