using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals
{    
    public class NumberStringList : List<Tuple<int,string>>
    {

        public void Add(int number, string text)
        {
            Add(new Tuple<int, string>(number, text));
        }

        public Tuple<int,string> GetNearestNumber(int number)
        {
             return this.Where(x =>  x.Item1 <= number).OrderBy(x => x.Item1).Last();
        }
    }

}