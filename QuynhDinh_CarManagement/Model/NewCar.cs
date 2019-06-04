using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuynhDinh_CarManagement.Model {
    public class NewCar : Car {

        public NewCar(string licensePlateNo, string make, CarType carType, float purchasePrice) : base(licensePlateNo, make, carType, purchasePrice) { }
    }
}
