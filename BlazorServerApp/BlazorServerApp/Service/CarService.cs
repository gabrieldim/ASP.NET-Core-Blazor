using BlazorServerApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerApp.Service
{
    public class CarService : ICarService
    {

        private readonly TestContext _dbContext = null;

        public CarService(TestContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public List<Car> getCars()
        {
            return _dbContext.Cars.ToList();
        }
        public void DeleteCar(Car car)
        {
            _dbContext.Cars.Remove(car);
            _dbContext.SaveChanges();
        }
    }
}
