using InveonBootcamp._05.DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp._05.DIP.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        public List<Vehicle> Add(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public void Delete(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> GetAll()
        {
            return [
                new Vehicle(){
                    Id = 1,
                    Brand = "Tesla",
                    Description = "Elektrikli",
                    Model = "Model Y",
                    Name = "MyTesla"
                },
                new Vehicle(){
                    Id = 2,
                    Brand = "Volvo",
                    Description = "Benzinli",
                    Model = "S90",
                    Name = "MyVolvo"
                },
            ];
        }

        public List<Vehicle> GetAllByVehicleId(Vehicle vehicleId)
        {
            throw new NotImplementedException();
        }
    }
}
