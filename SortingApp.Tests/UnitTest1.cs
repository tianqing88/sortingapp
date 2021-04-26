using NUnit.Framework;
using SortingApp;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            FileReader fileReader = new FileReader();
            NameSorter nameSorter = new NameSorter();

            //original text file path
            string unsortedFile = "..\\..\\..\\Files\\input.txt";
            //after sorted text file path
            string sortedFile = "..\\..\\..\\Files\\result.txt";

            List<string> list = fileReader.ReadFileAsStringList(unsortedFile);
            List<string> unsortedList = nameSorter.ReverseName(list).Select(o => o.Trim()).ToList();

            List<string> sortedList = fileReader.ReadFileAsStringList(sortedFile).Select(o => o.Trim()).ToList();

            Assert.AreEqual(unsortedList, sortedList);
        }

        [Test]
        public void Test2()
        {
            FileReader fileReader = new FileReader();

            //original text file path
            string unsortedFile = "..\\..\\..\\Files\\invalid_input.txt";

            List<string> list = fileReader.ReadFileAsStringList(unsortedFile);

            Validator validator = new Validator();
                       
            Assert.AreEqual(validator.IsValidName(list), false);
        }
    }
}