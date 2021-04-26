using Microsoft.Extensions.Options;
using SortingApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SortingApp
{
    public class FileReader
    {
        public List<string> ReadFileAsStringList(string filePath)
        {
            //Read string list from text file line by line
            List<string> list = File.ReadAllLines(filePath).ToList();

            return list;
        }
    }
}
