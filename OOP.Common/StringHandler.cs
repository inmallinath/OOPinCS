﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Common
{
    public static class StringHandler
    {
        public static string InsertSpaces(this string source)
        {
            string result = String.Empty;

            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
                result = result.Trim();
            }

            return result;
        }
    }
}
