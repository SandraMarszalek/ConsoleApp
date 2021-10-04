using System.Collections.Generic;
using ConsoleApp1.MakeThisWork;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace UnitTests
{
    public class CarApp
    {
        [Test]
        public void CarAppDbReturnsCarDbSet()
        {
            var carData = GetDataFromDatabase.GetCarData();
            Assert.IsInstanceOf<DbSet<CarDb>>(carData);
        }

        [Test]
        public void CarDataIsLikeExpected()
        {
            List<CarDb> expectedCars = new List<CarDb>();

            CarDb car1 = new CarDb();
            car1.Id = 10001;
            car1.Model = "ModelX";
            car1.Price = 100000;
            car1.Discount = 12;

            CarDb car2 = new CarDb();
            car2.Id = 20002;
            car2.Model = "ModelY";
            car2.Price = 145000;
            car2.Discount = 8;

            CarDb car3 = new CarDb();
            car3.Id = 30003;
            car3.Model = "ModelZ";
            car3.Price = 243000;
            car3.Discount = 14;

            expectedCars.Add(car1);
            expectedCars.Add(car2);
            expectedCars.Add(car3);

            var carsData = GetDataFromDatabase.GetCarData();
            List<CarDb> carList = new List<CarDb>();

            foreach(var car in carsData)
            {
                carList.Add(car);
            }
            
            for(int i = 0; i < expectedCars.Count; i++)
            {
                foreach (var carA in carsData)
                {
                    foreach (var carB in expectedCars)
                    {
                        Assert.AreEqual(carA.Model, carB.Model);
                        Assert.AreEqual(carA.Price, carB.Price);
                        Assert.AreEqual(carA.Discount, carB.Discount);
                        break;
                    }
                    break;
                }
            }
        }
    }
}