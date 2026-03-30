using System;
using System.Collections.Generic;
using System.Text;

namespace Partices.InterviewQuestion
{
    public class SecondlargestDuplicateNumber
    {
        string s = "AAnnndddss";
        //find the duplicate issue fix
        public void deuplicate()
        {
           var data= s.ToCharArray().GroupBy(c => c).Select(c => new
            {
                key = c.Key,
                value = c.ToList()
            }).OrderByDescending(x => x.key).Skip(1).FirstOrDefault();
           Console.WriteLine(data.key+" "+data.value.Count());
            /*
                        var data1 = s.ToCharArray().
                             GroupBy(x => x).
                             Select(s => new { key = s.Key, value = s.ToList() }).OrderByDescending(x => x.value.Count()).ToList();

                        var secondcount = data1.Select(x => x.value.Count()).Distinct().Skip(1).ToList();

                        data1.Where(x=>x.c==secondcount)*/

            /* var result = s
                     .GroupBy(c => c)
                     .Select(g => new { Char = g.Key, Count = g.Count() })
                     .OrderByDescending(x => x.Count)
                     .ToList();

             var secondCount = result.Select(x => x.Count).Distinct().Skip(1).First();

             var secondChars = result
                 .Where(x => x.Count == secondCount)
                 .Select(x => x.Char);

             Console.WriteLine(string.Join(",", secondChars));*/

            var data1 = s.GroupBy(x => x).Select(x => new { key = x.Key, Count = x.Count() }).OrderByDescending(x => x.Count).ToList();

            var secondcount = data1.Select(x => x.Count).Distinct().Skip(1).First();

            var result = data1.Where(x => x.Count == secondcount).Select(x => x.key).FirstOrDefault();
            Console.WriteLine(string.Join(',',result));

        }

        public void splitVowles()
        {
            string alltext = "AdgsAGDB**##657eHISJOU";
            StringBuilder volwels = new StringBuilder();
            StringBuilder SpecialChar=new StringBuilder();
            StringBuilder CharOnly=new StringBuilder(); char[] chars = alltext.ToCharArray();
            foreach(char c in chars)
            {
                if ("AEIOUaeiou".Contains(c))
                {
                    volwels.Append(c);
                }
                //important Is letter on Char
                else if (char.IsLetter(c))
                {
                    CharOnly.Append(c);
                }
                else
                {
                    SpecialChar.Append(c);
                }
            }
            Console.WriteLine(volwels+" "+SpecialChar+" "+CharOnly);
        }
        public void revwersetheString()
        {
            string reverese = "";
            string word = "Shibi";
            char[] c = word.ToCharArray();
            for(int i = c.Length - 1; i >= 0; i--)
            {
                reverese = reverese + c[i];
            }
            Console.WriteLine(reverese);
            var data = word.GroupBy(x => x).Select(x => x.Key).OrderByDescending(y => y).ToList();
            Console.Write(data.);

            unchecked
            {
                int i = int.MaxValue;
                i = i + 1;

            }
        }

    }

}
