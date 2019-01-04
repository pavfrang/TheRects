using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRects
{
    public static class RandomExtensions
    {

        /// <summary>
        /// Knuth / Fisher–Yates shuffle
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="times"></param>
        public static void Shuffle<T>(this List<T> list)
        {
            Random r = new Random();
            int n = list.Count;
            while (n > 1)
            {
                int k = r.Next(n--);
                T temp = list[n];
                list[n] = list[k];
                list[k] = temp;
            }
        }
    }
}
