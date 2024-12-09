using InveonBootcamp._05.DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp._05.DIP.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        //IOC: new'lemeden parametre olarak geçildi
        public VehicleService(IVehicleRepository vehicleRepository) { 
            _vehicleRepository = vehicleRepository;
        }

        public List<Vehicle> GetVehicles()
        {
            var vehicles = _vehicleRepository.GetAll();

            return vehicles;
        }
    }
}
