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
            cmbCarType.DataSource = Enum.GetValues(typeof(CarType));
            pnlOldCar.Enabled = false;
            ckbtnIsNew.Checked = true;
        }

        private void BtnViewAll_Click(object sender, EventArgs e) {
            ReportForm reportForm = new ReportForm(_dealership);
            reportForm.ShowDialog();
            this.Hide();
        }

        private void ChbxIsNew_CheckedChanged(object sender, EventArgs e) {
            if (ckbtnIsNew.Checked) {
                pnlOldCar.Enabled = false;
            } else {
                pnlOldCar.Enabled = true;
            }
        }

        private void BtnAddRecord_Click(object sender, EventArgs e) {
            try {
                if (ckbtnIsNew.Checked) {
                    _dealership.AddCar(txtLicensePlate.Text, txtMake.Text, (CarType)cmbCarType.SelectedItem, float.Parse(txtPurchasePrice.Text));
                } else {
                    _dealership.AddCar(txtLicensePlate.Text, txtMake.Text, (CarType)cmbCarType.SelectedItem, float.Parse(txtPurchasePrice.Text), ckbtnIsNew.Checked, int.Parse(txtModel.Text), int.Parse(txtMileage.Text), float.Parse(txtInsuranceDepreciation.Text));
                }
                MessageBox.Show("Added record!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
