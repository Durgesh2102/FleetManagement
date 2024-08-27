
using FM_DotNet.Models;

namespace Fleetmanagement_new.Services
{
    public interface ICarService
    {
        Task<IEnumerable<Car>> GetAllCarsAsync();
        Task<Car> GetCarByIdAsync(long carId);
        Task<Car> CreateCarAsync(Car car);
        Task<Car> UpdateCarAsync(long carId, Car car);
        Task<bool> DeleteCarAsync(long carId);
    }
}
