using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuynhDinh_CarManagement.Model {
    public abstract class Car {
        private string _licensePlateNo;
        private string _make;
        private CarType _carType;
        private float _purchasePrice;

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

        public CarType CarType {
            get { return _carType; }
            set { _carType = value; }
        }

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

        public Car(string licensePlateNo, string make, CarType carType, float purchasePrice) {
            LicensePlateNo = licensePlateNo;
            Make = make;
            CarType = carType;
            PurchasePrice = purchasePrice;
        }
    }
}
