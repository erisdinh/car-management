using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuynhDinh_BusinessLogic.Model {

    /// <summary>
    /// Dealership object that represents for the Dealership
    /// </summary>
    public class Dealership {
        private string _businessNumber;
        private string _name;
        private string _address;
        private string _email;
        private int _phone;
        private List<Car> _cars;

        /// <summary>
        /// Business number of the dealership
        /// </summary>
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

        /// <summary>
        /// Name of the dealership
        /// </summary>
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

        /// <summary>
        /// Address of the dealership
        /// </summary>
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

        /// <summary>
        /// Email of the dealership
        /// </summary>
        public string Email {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        /// Phone number of the dealership
        /// </summary>
        public int Phone {
            get { return _phone; }
            set { _phone = value; }
        }

        /// <summary>
        /// Car records of the dealership
        /// </summary>
        public List<Car> Cars {
            get { return _cars; }
            private set {
                if (value != null) {
                    _cars = value;
                }
            }
        }

        /// <summary>
        /// Constructor for dealership object
        /// </summary>
        /// <param name="businessNumber">Serves as business number parameter for dealership object</param>
        /// <param name="name">Serves as name parameter for dealership object</param>
        /// <param name="address">Serves as address parameter for dealership object</param>
        /// <param name="email">Serves as email parameter for dealership object</param>
        /// <param name="phone">Serves as phone parameter for dealership object</param>
        public Dealership(string businessNumber, string name, string address, string email, int phone) {
            BusinessNumber = businessNumber;
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
            _cars = new List<Car>();
        }

        /// <summary>
        /// Find car record from dealership's records by license plate number
        /// </summary>
        /// <param name="licensePlateNo">Serves as input license plate number</param>
        /// <returns>Return a matching car that has the matching license plate number dealership records</returns>
        public Car FindCarByLicensePlateNo(string licensePlateNo) {
            Car matchingCar = null;
            foreach (Car car in _cars) {
                if (car.LicensePlateNo.Equals(licensePlateNo)) {
                    matchingCar = car;
                }
            }
            return matchingCar;
        }

        /// <summary>
        /// Insert car information into dealership's records
        /// </summary>
        /// <param name="licensePlateNo">Serves as license plate number</param>
        /// <param name="make">Serves as car make</param>
        /// <param name="carType">Serves as type of car</param>
        /// <param name="purchasePrice">Serves as purchase price of car</param>
        /// <param name="isNew">Serves to check whether the car is new car or used car</param>
        /// <param name="model">Serves as an optional parameter of used car model</param>
        /// <param name="mileage">Serves as an optional parameter of used car mileage</param>
        /// <param name="insuranceDep">Serves as an optional parameter of used car's insurance depreciation</param>
        public void AddCar(string licensePlateNo, string make, CarType carType, float purchasePrice, bool isNew=true, int model=0, int mileage=0, float insuranceDep=0f) {

            // Check if the car already exists in dealership's records
            Car car = FindCarByLicensePlateNo(licensePlateNo);

            // If there is no matching car, create and insert the car
            // Ensure that each and every car in records is unique and has required license plate number
            //// else throw a new exception
            if (car == null && (!string.IsNullOrEmpty(licensePlateNo))) {
                if (isNew) {
                    car = new NewCar(licensePlateNo, make, carType, purchasePrice);
                } else {
                    int _curentYear = DateTime.Now.Year;
                    if (!((_curentYear - model) > 5 || mileage > 500000)) {
                        car = new UsedCar(licensePlateNo, make, carType, purchasePrice, model, mileage, insuranceDep);
                    } else {
                        throw new Exception("We cannot accept cars that are more than 5 years or have a mileage > 500,000Km!");
                    }
                }
                _cars.Add(car);
            } else {
                throw new Exception("Car already exists or invalid car license plate number!");
            }
        }

        /// <summary>
        /// Get all car records corresponding to the selected CarType
        /// </summary>
        /// <param name="carType">Serves as seeking car type of car</param>
        /// <returns>Return list of matching cars</returns>
        public List<Car> GetCarsByCarType(CarType carType) {
            List<Car> matchingCars = new List<Car>();
                foreach (Car car in _cars) {
                    if (car.CarType == carType) {
                    matchingCars.Add(car);
                    }
                }

            return matchingCars;
        }
    }
}
