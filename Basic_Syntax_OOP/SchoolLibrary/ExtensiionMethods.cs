using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public static class ExtensiionMethods
    {

        public static int wordCount(this String str)
        {
            var wordCount = str.Split(new char[] { ' ', ' ', ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            return wordCount;
        }
    }
}
