using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuynhDinh_BusinessLogic.Model;

namespace QuynhDinh_CarManagement.UI {
    public partial class ReportForm : Form {

        private Dealership _dealership;

        public ReportForm(Dealership dealership) {
            InitializeComponent();
            _dealership = dealership;
        }

        private void BtnClose_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void ReportForm_Load(object sender, EventArgs e) {
            cmbCarType.DataSource = Enum.GetValues(typeof(CarType));
            DisplayCars(_dealership.GetCarsByCarType(CarType.Hatchback));
            txtCurrentValue.Enabled = false;
            txtTotalPrice.Enabled = false;
        }

        private void CbCarType_SelectedIndexChanged(object sender, EventArgs e) {
            List<Car> matchingCars = _dealership.GetCarsByCarType((CarType)cmbCarType.SelectedItem);
            DisplayCars(matchingCars);
        }

        private void BtnShowAll_Click(object sender, EventArgs e) {
            DisplayCars(_dealership.Cars);
        }

        private void DisplayCars(List<Car> cars) {
            try {
                lstCars.Items.Clear();
                float total = 0f;
                float currentValue = 0f;
                foreach (Car car in cars) {
                    string info = $"License Plate: {car.LicensePlateNo}, Make: {car.Make}, Type: {car.CarType}, Purchase Price: {car.PurchasePrice}";
                    total += (float)car.PurchasePrice;
                    if (car.GetType() == typeof(UsedCar)) {
                        UsedCar usedCar = (UsedCar)car;
                        info += $", Model: {usedCar.Model}, Mileage: {usedCar.Mileage}, Insurance Depreciation: {usedCar.InsuranceDepreciation}, Total Depreciation: {usedCar.TotalDepreciation}";
                        currentValue += (float) (usedCar.PurchasePrice - (float)(usedCar.TotalDepreciation * (float)usedCar.PurchasePrice));
                    } else {
                        currentValue += (float)car.PurchasePrice;
                    }
                    lstCars.Items.Add(info);
                }

                txtTotalPrice.Text = total.ToString("F2");
                txtCurrentValue.Text = currentValue.ToString("F2");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
