using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals
{
    public class NumberTextList : List<NumberText>
    {
        public void Add(int number, string text)
        {
            Add(new NumberText{Number = number, Text = text});
        }

        public NumberText GetNearestNumber(int number)
        {
             return this.Where(x =>  x.Number <= number).OrderBy(x => x.Number).Last();
        }
    }

}