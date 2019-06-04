using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuynhDinh_CarManagement.Model {
    public class UsedCar : Car {
        private int _model;
        private int _mileage;
        private float _insuranceDepreciation;
        private float _totalDepreciation;

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

        public float TotalDepreciation {
            get {
                int yearDifference = 2019 - Model;
                float yearDepreciation = yearDifference * 0.1f;
                float mileageDepreciation = Mileage * 0.009f;
                _totalDepreciation = yearDepreciation + mileageDepreciation;
                return _totalDepreciation;
            }
        }

        public UsedCar(string licensePlateNo, string make, CarType carType, float purchasePrice, int model, int mileage, float insuranceDepreciation) 
            : base(licensePlateNo, make, carType, purchasePrice) {
            Model = model;
            Mileage = mileage;
            InsuranceDepreciation = insuranceDepreciation;
        }
    }
}
