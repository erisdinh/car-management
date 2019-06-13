using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuynhDinh_BusinessLogic.Model {

    /// <summary>
    /// Used car object that represents for the used car
    /// </summary>
    public class UsedCar : Car {
        private int _model;
        private int _mileage;
        private float _insuranceDepreciation;
        private float _totalDepreciation;

        /// <summary>
        /// Model of the used car
        /// </summary>
        public int Model {
            get { return _model; }
            set {
                if (value < 0) {
                    throw new Exception("Invalid model!");
                } else {
                    _model = value;
                }
            }
        }

        /// <summary>
        /// Mileage of the used car
        /// </summary>
        public int Mileage {
            get { return _mileage; }
            set {
                if (value <= 0) {
                    throw new Exception("Invalid mileage!");
                } else {
                    _mileage = value;
                }
            }
        }

        /// <summary>
        /// Insurance Depreciation of the used car
        /// </summary>
        public float InsuranceDepreciation{
            get { return _insuranceDepreciation; }
            set {
                if (value < 0) {
                    throw new Exception("Invalid insurance depreciation!");
                } else {
                    _insuranceDepreciation = value;
                }
            }
        }

        /// <summary>
        /// Total Depreciation of the used car
        /// </summary>
        public float TotalDepreciation {
            get {
                int _curentYear = DateTime.Now.Year;
                int yearDifference = _curentYear - Model;
                float yearDepreciation = yearDifference * 0.1f;
                float mileageDepreciation = Mileage * 0.009f;
                _totalDepreciation = yearDepreciation + mileageDepreciation;
                return _totalDepreciation;
            }
        }

        /// <summary>
        /// Constructor of the used car object
        /// </summary>
        /// <param name="licensePlateNo">Serves  as license plate number parameter for used car object</param>
        /// <param name="make">Serves as car make parameter for used car object</param>
        /// <param name="carType">Serves as car type parameter for used car object</param>
        /// <param name="purchasePrice">Serves as purchase price parameter for used car object</param>
        /// <param name="model">Serves as model parameter for used car object</param>
        /// <param name="mileage">Serves as mileage parameter for used car object</param>
        /// <param name="insuranceDepreciation">Serves as insurance depreciation parameter for used car object</param>
        public UsedCar(string licensePlateNo, string make, CarType carType, float purchasePrice, int model, int mileage, float insuranceDepreciation)
            : base(licensePlateNo, make, carType, purchasePrice) {
        }
    }
}
