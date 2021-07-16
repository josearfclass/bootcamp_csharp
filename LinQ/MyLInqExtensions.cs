using System.Collections.Generic;
using System.Linq;

namespace System.LinQ
{
    public static class MyLInqExtensions
    {
        public static IEnumerable<T> ProcessSequences<T>(this IEnumerable<T> sequence)
        {
            return sequence;
        }
        
        public static int? Median(this IEnumerable<int?> sequence)
        {
            var ordered = sequence.OrderBy(item => item);
            int middlePosition = ordered.Count() / 2;
            return ordered.ElementAt(middlePosition);
        }

        public static int? Median<T>(this IEnumerable<T> sequence, Func<T, int?> selector)
        {
            return sequence.Select(selector).Median();
        }

        public static int? Moda(this IEnumerable<int?> sequence)
        {
            int? ValueMaxTimes = 0;
            int MaxTimes = 0;
            
            foreach (var i in sequence)
            {
                int count = 0;
                foreach (var j in sequence)
                {
                    if (i == j)
                        count++;
                }

                if (count > MaxTimes)
                {
                    MaxTimes = count;
                    ValueMaxTimes = i;
                }
            }

            return ValueMaxTimes;
        }

        public static int? Moda<T>(this IEnumerable<T> sequence, Func<T, int?> selector)
        {
            return sequence.Select(selector).Moda();
        }
        
        public static int? ContraryModa(this IEnumerable<int?> sequence)
        {
            int? ValueMinTimes = 0;
            int MinTimes = sequence.Count();
            
            foreach (var i in sequence)
            {
                int count = 0;
                foreach (var j in sequence)
                {
                    if (i == j)
                        count++;
                }

                if (count < MinTimes)
                {
                    MinTimes = count;
                    ValueMinTimes = i;
                }
            }

            return ValueMinTimes;
        }
        
        
        public static int? ContraryModa<T>(this IEnumerable<T> sequence, Func<T, int?> selector)
        {
            return sequence.Select(selector).ContraryModa();
        }
    }
}