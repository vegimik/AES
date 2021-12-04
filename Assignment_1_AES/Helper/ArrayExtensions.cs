﻿namespace Assignment_1_AES.Helper
{
    public static class ArrayExtensions
    {
        public static T[] Slice<T>(this T[] source, int start, int end)
        {
            if (end < 0)
                end = source.Length + end;

            int len = end - start;

            T[] res = new T[len];
            for (int i = 0; i < len; i++)
                res[i] = source[i + start];

            return res;
        }
    }

}
