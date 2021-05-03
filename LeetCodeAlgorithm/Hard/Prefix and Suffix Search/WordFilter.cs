using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithm
{
    public class WordFilter
    {
        private string[] givenStrArr;

        public WordFilter(string[] words)
        {
            this.givenStrArr = words;
        }

        public int F(string prefix, string suffix)
        {
            for (int index = this.givenStrArr.Length - 1; index >= 0; index--)
            {
                bool isPrefixMatch = true;
                bool isSuffixMatch = true;

                var currentStr = this.givenStrArr[index];

                for (int p = 0; p < prefix.Length; p++)
                {
                    if (currentStr[p] != prefix[p])
                    {
                        isPrefixMatch = false;
                        break;
                    }
                }

                if (!isPrefixMatch)
                    continue;

                var suffixStartIndex = currentStr.Length - suffix.Length;
                for (int s = 0; s < suffix.Length; s++)
                {
                    if (currentStr[s + suffixStartIndex] != suffix[s])
                    {
                        isSuffixMatch = false;
                        break;
                    }
                }

                //isPrefixMatch = currentStr.Substring(0, prefix.Length) == prefix;
                //isSuffixMatch = currentStr.Substring(currentStr.Length - suffix.Length, suffix.Length) == suffix;

                if (isPrefixMatch && isSuffixMatch)
                    return index;
            }

            return -1;
        }
    }
}
