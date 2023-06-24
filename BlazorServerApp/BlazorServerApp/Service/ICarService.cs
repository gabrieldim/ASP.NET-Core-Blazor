using BlazorServerApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerApp.Service
{
    public interface ICarService
    {

        List<Car> getCars();

        void DeleteCar(Car car);

        void AddCar(Car car);
    }
}
