using BlazorServerApp.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
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
            int nextId = -1;
            nextId = _dbContext.Cars.Max(c => c.id) + 1;
            if(nextId == -1)
            {
                nextId = 0;
            }
            car.id = nextId;
            _dbContext.Cars.Add(car);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Get car count with name starting by @name.
        /// </summary>
        /// <param name="name">The search string.</param>
        /// <returns></returns>
        public async Task<int> GetCarCountWithNameStartingWithAsync(string name)
        {
            using (var connection = new SqlConnection(_dbContext.Database.GetConnectionString()))
            {
                await connection.OpenAsync();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "GetCarCountWithNameStartingWith";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@name", name);

                    return (int)await command.ExecuteScalarAsync();
                }
            }
        }










    }
}
