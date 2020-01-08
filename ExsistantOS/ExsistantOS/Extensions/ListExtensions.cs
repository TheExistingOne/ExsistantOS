using System;
using System.Collections.Generic;
using System.Text;

namespace ExistentOS.Extensions
{
    static class ListExtensions
    {
        public static List<int> AllIndexesOf(this string str, string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("the string to find may not be empty", "value");
            int valCount = (str.Length - str.Replace(value, "").Length) / value.Length;
            List<int> indexes = new List<int>();
            for (int index = 0; index < valCount; index += value.Length)
            {
                index = str.IndexOf(value, index);
                indexes.Add(index);
            }
            return indexes;
        }
    }
}
