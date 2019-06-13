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
    public partial class AddVehicleForm : Form {

        private Dealership _dealership;

        public AddVehicleForm(Dealership dealership) {
            InitializeComponent();
            _dealership = dealership;
        }

        private void AddVehicleForm_Load(object sender, EventArgs e) {
            cbCarType.DataSource = Enum.GetValues(typeof(CarType));
            pnOldCar.Enabled = false;
        }

        private void BtnViewAll_Click(object sender, EventArgs e) {

        }

        private void ChbxIsNew_CheckedChanged(object sender, EventArgs e) {
            if (chbxIsNew.Checked) {
                pnOldCar.Enabled = true;
            } else {
                pnOldCar.Enabled = false;
            }
        }

        private void BtnAddRecord_Click(object sender, EventArgs e) {
            try {
                _dealership.AddCar(tbLicensePlate.Text, tbMake.Text, (CarType)cbCarType.SelectedItem, (float)Convert.ToDouble(tbPurchasePrice.Text), 
                    chbxIsNew.Checked, Convert.ToInt32(tbModel.Text), Convert.ToInt32(tbMileage.Text), 
                    (int) Convert.ToInt32(tbInsuranceDepreciation.Text));
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
