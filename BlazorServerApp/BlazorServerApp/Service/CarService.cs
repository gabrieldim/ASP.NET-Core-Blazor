using BlazorServerApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerApp.Service
{
    public class CarService : ICarService
    {

        /// <summary>
        /// Variable used to be able to connect to the database
        /// </summary>
        private readonly TestContext _dbContext = null;

        /// <summary>
        /// Constructor for database context
        /// </summary>
        public CarService(TestContext dbContext)
        {
            this._dbContext = dbContext;
        }

        /// <summary>
        /// Fetch the data for the cars from the DB
        /// </summary>
        public List<Car> getCars()
        {
            return _dbContext.Cars.ToList();
        }

        /// <summary>
        /// Delete a given car from the DB
        /// </summary>
        public void DeleteCar(Car car)
        {
            _dbContext.Cars.Remove(car);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Add a car from the DB
        /// </summary>
        public void AddCar(Car car)
        {
            _dbContext.Cars.Add(car);
            _dbContext.SaveChanges();
        }
    }
}
