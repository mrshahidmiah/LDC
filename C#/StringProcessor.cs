using System;
using System.Collections.Generic;
using System.Text;

namespace LDC
{
    public class StringProcessor : IStringProcessor
    {
        public string Process(string inputString)
        {
            try
            {
                // first, do character replacements
                string curString = inputString.Replace("$", "£")
                                              .Replace("_", "")
                                              .Replace("4", "");

                // remove contiguous duplicate characters
                char prevChar = new char();
                StringBuilder sb = new StringBuilder();

                foreach (char chr in curString)
                {
                    if (chr != prevChar)
                    {
                        sb.Append(chr);
                        prevChar = chr;
                    }
                }

                // only accept non-null/non-empty strings
                if (sb.Length != 0)
                {
                    // if length is greater than 15 chars then truncate to 15 chars
                    return sb.ToString().Length > 15 ? sb.ToString().Substring(0, 15) : sb.ToString();
                }
                else
                {
                    // output strings must not be null or empty strings, so ignore
                    // TODO - output to log for reference/troubleshooting?

                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public IEnumerable<string> ProcessCollection(string[] stringCollection)
        {
            foreach (string str in stringCollection)
                yield return Process(str);
        }
    }
}