using Microsoft.Extensions.Configuration;
using SortingApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
            //Type file name
            Console.WriteLine("Enter file name:");
            //Store file name 
            string fileName = Console.ReadLine();
            string filePath = filePathSettings.BasePath + fileName + ".txt";

            //Get sorted result
            NameSorter nameSorter = new NameSorter();
            List<string> resultList = nameSorter.ReverseName(filePath);

            Console.WriteLine("The sorted name list:");

            foreach (string s in resultList)
            {
                Console.WriteLine(s);
            }
            #endregion
        }
    }
}
