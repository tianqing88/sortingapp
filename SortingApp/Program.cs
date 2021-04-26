using Microsoft.Extensions.Configuration;
using SortingApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SortingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Appsettings Configuration
            //Read file path from appsettings
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            IConfiguration config = builder.Build();
            FilePathSettings filePathSettings = config.GetSection("FilePathSettings").Get<FilePathSettings>();
            #endregion

            #region Main Code
            //Store file name 
            string filePath = filePathSettings.BasePath + "unsorted-names-list.txt";

            //Init FileReader class
            FileReader fileReader = new FileReader();

            //Get unsorted string list from file
            List<string> unsortedList = fileReader.ReadFileAsStringList(filePath);

            //Init validator
            Validator validator = new Validator();

            if (!validator.IsValidName(unsortedList))
            {
                Console.WriteLine("The file contains invalid name");
            }
            else
            {
                //Get sorted result
                NameSorter nameSorter = new NameSorter();
                List<string> resultList = nameSorter.ReverseName(unsortedList);

                Console.WriteLine("The sorted name list:");
                foreach (string s in resultList)
                {
                    Console.WriteLine(s);
                }

                //Write list to the file
                string path = filePathSettings.BasePath + "sorted-names-list.txt";
                File.WriteAllLines(path, resultList, Encoding.UTF8);
            }            
            #endregion
        }
    }
}
