using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp._05.DIP.Interfaces
{
    public interface IVehicleRepository
    {
        List<Vehicle> Add(Vehicle vehicle);

        void Delete(Vehicle vehicle);

        List<Vehicle> GetAll();

        List<Vehicle> GetAllByVehicleId(Vehicle vehicleId);
    }
}
