
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutomobileLibrary.BusinessObject;
namespace AutomobileLibrary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car getCarByID(int carId);
        void insertCar(Car car);
        void deleteCar(int carId);
        void UpdateCar(Car car);
    }
}
