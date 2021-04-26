using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingApp
{
    public class NameSorter
    {
        public List<string> ReverseName(string filePath)
        {
            //Init FileReader class
            FileReader fileReader = new FileReader();

            //Get content string list from file
            List<string> inputList = fileReader.ReadFileAsStringList(filePath);

            //Sort the list by first Alphabet
            List<string> resultList = inputList.OrderBy(o => o.Trim().Split(" ").Last()).ToList();

            return resultList;
        }
    }
}
