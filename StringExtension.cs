using System;
using System.Collections.Generic;


namespace PadawansTask12
{
    public static class StringExtension
    {
        public static bool AllCharactersAreUnique(string source)
        {
            HashSet<char> hashSet = new HashSet<char>(source);
            return hashSet.Count==source.Length ?  true : false;
        }
    }
}