using System;
using System.Collections.Generic;
using System.Linq;

namespace Partices.InterviewQuestion
{
    public class StringsBasedQuestions
    {
        public void DuplicateValue() {
            var str = "madam";
           var duplicate= str.GroupBy(x => x).ToDictionary(x => x.Key, y => y.Count()).ToList().Where(x => x.Value > 1);
            foreach (var item in duplicate) { 
                Console.WriteLine(item.Key+ " "+item.Value);
            }
        }
    }
}
