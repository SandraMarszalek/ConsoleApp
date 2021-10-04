using System;
using System.Collections.Generic;

namespace ConsoleApp1.MakeThisWork
{
    public class Logic
    {
        public Dictionary<string,string> DictionaryApp()
        {
            Dictionary<string, string> myDictionary = GetDataFromDatabase.GetDictionaryData();
            var keyInfo = Console.ReadKey();

            if(keyInfo.Key.Equals(ConsoleKey.Spacebar))
            {
                foreach (var pair in myDictionary)
                {
                    if (keyInfo.Key.Equals(ConsoleKey.Spacebar))
                    {
                        Console.WriteLine(pair.Key);
                        var keyInfoForValue = Console.ReadKey();
                        if (keyInfoForValue.Key.Equals(ConsoleKey.Spacebar))
                        {
                            Console.WriteLine(pair.Value);
                        }
                    }
                    keyInfo = Console.ReadKey();
                }
            }

            return myDictionary;
        }

        public void CarApp()
        {
            var carInfo = GetDataFromDatabase.GetCarData();

            foreach(var car in carInfo)
            {
                double discount = ((car.Price * car.Discount) / 100);
                double carPriceWithDiscount = car.Price - discount;
                Console.WriteLine("Car model: " + car.Model + "\r\n" + "Car price before discount: " + car.Price + "\r\n" 
                    + "Discount[%]: " + car.Discount + "%" + "\r\n" + "Car price discount: " + discount + "\r\n" 
                    + "Car price with discount: " + carPriceWithDiscount + "\r\n");
            }
        }
    }
}