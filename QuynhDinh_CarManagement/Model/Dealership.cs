using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuynhDinh_CarManagement.Model {
    public class Dealership {
        private string _businessNumber;
        private string _name;
        private string _address;
        private string _email;
        private int _phone;
        private List<Car> _cars;

        public string BusinessNumber {
            get { return _businessNumber; }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new Exception("Invalid business number!");
                } else {
                    _businessNumber = value;
                }
            }
        }

        public string Name {
            get { return _name; }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new Exception("Business name cannot be blank!");
                } else {
                    _name = value;
                }
            }
        }

        public string Address {
            get { return _address; }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new Exception("Address of business cannot be blank!");
                } else {
                    _address = value;
                }
            }
        }

        public string Email {
            get { return _email; }
            set { _email = value; }
        }

        public int Phone {
            get { return _phone; }
            set { _phone = value; }
        }

        public List<Car> Cars {
            get { return _cars; }
            private set {
                if (value != null) {
                    _cars = value;
                }
            }
        }

        public Dealership(string businessNumber, string name, string address, string email, int phone) {
            BusinessNumber = businessNumber;
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
        }

        public Car FindCarByLicensePlateNo(string licensePlateNo) {
            Car matchingCar = null;
            foreach (Car car in _cars) {
                if (car.LicensePlateNo == licensePlateNo) {
                    matchingCar = car;
                }
            }
            return matchingCar;
        }

        public void AddCar(string licensePlateNo, string make, CarType carType, float purchasePrice) { }
    }
}
