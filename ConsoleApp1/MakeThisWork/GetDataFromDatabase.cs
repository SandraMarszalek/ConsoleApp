using System.Collections.Generic;
using System.Linq;
using Database;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.MakeThisWork
{
    public class GetDataFromDatabase
    {
        public static Dictionary<string, string> GetDictionaryData()
        {
            AppDb appDb = new AppDb();
            var query = appDb.Dictionary;
            Dictionary<string, string> myDictionary = query.ToDictionary(t => t.PlWord, t => t.EngWord);
            return myDictionary;
        }

        public static DbSet<CarDb> GetCarData()
        {
            AppDb appDb = new AppDb();
            var query = appDb.Car;
            return query;
        }
    }
}