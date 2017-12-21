//-----------------------------------------------------------------------
// <copyright file="RandomizationExtensions.cs" company="GrantAvery">
//     Copyright (c) Grant Avery. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SecretSantaV2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The class for randomizing arrays and lists.
    /// </summary>
    public static class RandomizationExtensions
    {
        /// <summary>
        /// The rand
        /// </summary>
        private static Random rand = new Random();

        /// <summary>
        /// Randomizes the specified items.
        /// </summary>
        /// <typeparam name="T">The randomize parameter.</typeparam>
        /// <param name="items">The items.</param>
        public static void Randomize<T>(this T[] items)
        {
            for (int i = 0; i < items.Length - 1; i++)
            {
                int j = rand.Next(i, items.Length);
                T temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }
        }

        /// <summary>
        /// Randomizes the specified items. Currently unused by program.
        /// </summary>
        /// <typeparam name="T">The randomize parameter.</typeparam>
        /// <param name="items">The items.</param>
        public static void Randomize<T>(this List<T> items)
        {
            T[] item_array = items.ToArray();

            item_array.Randomize();

            items.Clear();
            items.AddRange(item_array);
        }
    }
}
