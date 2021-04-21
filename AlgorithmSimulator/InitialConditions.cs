using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlgorithmSimulator
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Creates a 20 integer random array
        /// </summary>
        /// <returns>Returns a 20 integer random array</returns>
        int[] GetRandomIntArray()
        {
            int[] randomarray = new int[20];
            Random _random = new Random();

            for (int i = 0; i < randomarray.Length; i++)
            {
                randomarray[i] = _random.Next(0, 500);
            }
            return randomarray;
        }

        /// <summary>
        /// Creates a 20 integer nearly sorted array. By nearly sorted it means
        /// that maximum 7 elements in the array are not sorted correctly.
        /// </summary>
        /// <returns>Returns a 20 integer nearly sorted array</returns>
        int[] GetNearlySortedIntArray()
        {
            List<int> randomarray = new List<int>();
            Random _random = new Random();

            for (int i = 0; i < 20; i++)
            {
                randomarray.Add(_random.Next(0, 500));
            }
            randomarray.Sort();
            for (int i = 0; i < 8; i++)
            {
                randomarray[_random.Next(0,19)] = _random.Next(0, 500);
            }
            return randomarray.ToArray();
        }

        /// <summary>
        /// Creates a 20 integer reversed sorted array
        /// </summary>
        /// <returns>Returns a 20 integer reversed sorted array</returns>
        int[] GetReversedSortedIntArray()
        {
            List<int> randomarray = new List<int>();
            Random _random = new Random();

            for (int i = 0; i < 20; i++)
            {
                randomarray.Add(_random.Next(0, 500));
            }
            randomarray.Sort();
            randomarray.Reverse();
            return randomarray.ToArray();
        }
    }
}