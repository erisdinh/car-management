using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuynhDinh_CarManagement.Model {

    /// <summary>
    /// New Car object that represents for new car
    /// </summary>
    public class NewCar : Car {

        /// <summary>
        /// Construct of new car object
        /// </summary>
        /// <param name="licensePlateNo">Serves as license plate number for new car object</param>
        /// <param name="make">Serves as car make parameter for new car object</param>
        /// <param name="carType">Serves as car type parameter for new car object</param>
        /// <param name="purchasePrice">Serves as purchase price parameter for new car object</param>
        public NewCar(string licensePlateNo, string make, CarType carType, float purchasePrice) : base(licensePlateNo, make, carType, purchasePrice) { }
    }
}
