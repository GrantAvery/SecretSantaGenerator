//-----------------------------------------------------------------------
// <copyright file="SecretSanta.cs" company="GrantAvery">
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
    /// The primary Secret Santa class.
    /// </summary>
    class SantaGenerator
    {
        static public string SantaOutput;

        /// <summary>
        /// Secrets the santa assignment.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <param name="int_tries">The number of tries.</param>
        /// <returns>The assignments array.</returns>
        public static int[] SecretSantaAssignment(int n, out int int_tries)
        {
            int[] assignments = new int[n];

            for (int i = 0; i < n; i++)
            {
                assignments[i] = i;
            }

            int_tries = 0;

            StringBuilder Output = new StringBuilder();

            for (; ; )
            {
                int_tries++;

                assignments.Randomize();

                bool is_valid = true;
                for (int i = 0; i < n; i++)
                {
                    if (assignments[i] == i)
                    {
                        is_valid = false;
                        break;
                    }
                }

                if (is_valid)
                {
                    Output.Append("Attempt #" + int_tries + "\r\n");
                    break;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Output.Append("Person " + (i + 1).ToString() + " is Secret Santa for person " + (assignments[i] + 1).ToString() + "; \r\n");
            }

            SantaOutput = Output.ToString();

            return assignments;
        }
    }
}
