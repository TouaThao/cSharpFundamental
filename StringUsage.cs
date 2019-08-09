using System.Collections.Generic;
using System;
namespace c_Demo
{
    public class StringUsage
    {
         public static string summerize(string text,int maxWords = 20)
        {

            if (text.Length < maxWords)
            {
                return text;
            }
            else
            {
                //we need to remove the empty space
                //So if the words is "The brown fox" it will return an array [The][Brown][Fox]
                var words = text.Split(' ');
                var totalWords = 0;
                var summeyList = new List<string>();
                foreach (var word in words)
                {
                    summeyList.Add(word);
                    totalWords += words.Length + 1;
                    if (totalWords > maxWords)
                    {
                        break;
                    }

                }
                var summery = String.Join(" ", summeyList) + "...";
                return summery;
            };

        }
    }
}