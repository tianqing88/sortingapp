using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingApp
{
    public class NameSorter
    {
        public List<string> ReverseName(List<string> unsortedList)
        {
            //Sort the list by first Alphabet
            List<string> resultList = unsortedList.OrderBy(o => o.Trim().Split(" ").Last()).ToList();

            return resultList;
        }
    }
}
