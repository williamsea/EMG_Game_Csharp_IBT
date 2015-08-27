using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hai_EMG_Game
{
    public static class Extend
    {
        private static Random rng = new Random();

        public static double StandardDeviation(this IEnumerable<double> values)
        {
            double avg = values.Average();
            return Math.Sqrt(values.Average(v => Math.Pow(v - avg, 2)));
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k]; //value is a temp variable
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static T PopAt<T>(this List<T> list, int index)
        {
            T element = list[index];
            list.RemoveAt(index);
            return element;
        }
    }
}
