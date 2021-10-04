using System.Collections.Generic;
using ConsoleApp1.MakeThisWork;
using NUnit.Framework;

namespace UnitTests
{
    public class DictionaryApp
    {
        [Test]
        public void ReturnsDictionaryWithData()
        {
            Dictionary<string, string> result = GetDataFromDatabase.GetDictionaryData();

            Assert.IsInstanceOf<Dictionary<string, string>>(result);
            Assert.IsNotEmpty(result);
        }
    }
}