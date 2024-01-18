using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutomobileLibrary.BusinessObject;
using AutomobileLibrary.DataAccess;
namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public void deleteCar(int carId) => CarDBContext.Instance.Remove(carId);

        public Car getCarByID(int carId) => CarDBContext.Instance.getCarByID(carId);

        public IEnumerable<Car> GetCars() => CarDBContext.Instance.getCarList;
        public void insertCar(Car car) => CarDBContext.Instance.addNew(car);

        public void UpdateCar(Car car) => CarDBContext.Instance.Update(car);
    }
}
