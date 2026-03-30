using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Partices.InterviewQuestion
{
    public class StartwithCharactor
    {
        public List<T> ReturnValue<T>(string value)
        {
            List<string> listOfName = new List<string>() { "Arun", "Shibi", "Mohana", "Gokul" };
            return listOfName.Where(x=>x.StartsWith(value)).Cast<T>().ToList();
        }
      
        public void LinqOnlyStartwithCharter()
        {
            Console.WriteLine("-----LinqOnlyStartwithCharter----");
            var allData = new List<string> { "Apple", "Banana", "Mango", "Kiwi", "Gova", "Grapes" };

              var result=  allData.GroupBy(x => x[0]).Select(
                   y=> new
                    {
                        key=y.Key,
                        value=y.ToList()
                    });
            foreach (var item in result)
            {
                Console.WriteLine(item.key+":"+string.Join(',', item.value));
            }
        }
        public void BasedONLenght()
        {
            Console.WriteLine("-----BasedONLenght----");
            var fruits = new List<string> { "Apple", "Banana", "Mango", "Kiwi", "Gova", "Grapes" };
             var value=fruits
                .GroupBy(x => x.Length)
                .Select(y => new { key = y.Key, item = y.ToList() });
            foreach(var item in value)
            {
                Console.WriteLine(item.key+","+string.Join(',',item.item));
            }
            
        }
        public void OrderByString()
        {
            Console.WriteLine("-----OrderByString----");
            var fruits = new List<string> { "Apple", "Banana", "Mango", "Kiwi", "Gova", "Grapes" };
            var value= fruits.GroupBy(x => x[0]).
                OrderBy(y => y.Key);

            Console.WriteLine(value.Count());
            foreach (var item in value)
             Console.WriteLine(item.Key+" , "+string.Join(',',item));
        }
    }
}
