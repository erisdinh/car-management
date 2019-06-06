using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuynhDinh_CarManagement.Model {

    /// <summary>
    /// Car object that represents for car
    /// </summary>
    public abstract class Car {
        private string _licensePlateNo;
        private string _make;
        private CarType _carType;
        private float _purchasePrice;

        /// <summary>
        /// License plate number of the car
        /// </summary>
        public string LicensePlateNo {
            get { return _licensePlateNo; }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new Exception("License plate number cannot be null!");
                } else {
                    _licensePlateNo = value;
                }
            }
        }

        /// <summary>
        /// Car make of the car
        /// </summary>
        public string Make {
            get { return _make; }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new Exception("Car make cannot be null!");
                } else {
                    _make = value;
                }
            }
        }

        /// <summary>
        /// Car type of the car
        /// </summary>
        public CarType CarType {
            get { return _carType; }
            set { _carType = value; }
        }

        /// <summary>
        /// Purchase price of the car
        /// </summary>
        public float PurchasePrice{
            get { return _purchasePrice; }
            set {
                if (value <= 0) {
                    throw new Exception("Invalid purchase price!");
                } else {
                    _purchasePrice = value;
                }
            }
        }

        /// <summary>
        /// Constructor for car object
        /// </summary>
        /// <param name="licensePlateNo">Serves as license plate number parameter for car object</param>
        /// <param name="make">Serves as car make parameter for car object</param>
        /// <param name="carType">Serves as car type parameter for car object</param>
        /// <param name="purchasePrice">Serves as purchase price parameter for car object</param>
        public Car(string licensePlateNo, string make, CarType carType, float purchasePrice) {
            LicensePlateNo = licensePlateNo;
            Make = make;
            CarType = carType;
            PurchasePrice = purchasePrice;
        }
    }
}
