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
    public partial class DealershipForm : Form {

        Dealership _dealership;

        public DealershipForm(Dealership dealership) {
            InitializeComponent();
            _dealership = dealership;
        }

        private void DealershipForm_Load(object sender, EventArgs e) {
            lblName.Text = _dealership.Name;
            txtBusinessNo.Text = _dealership.BusinessNumber;
            txtPhone.Text = _dealership.Phone.ToString();
            txtEmail.Text = _dealership.Email;
            txtAddress.Text = _dealership.Address;

            txtBusinessNo.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            txtAddress.Enabled = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e) {
            txtBusinessNo.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            txtAddress.Enabled = true;

            btnOK.Text = "Save";
        }

        private void BtnOK_Click(object sender, EventArgs e) {

            if (btnOK.Text.Equals("OK")) {
                this.Hide();
            } else {
                try {
                    _dealership.BusinessNumber = txtBusinessNo.Text;
                    _dealership.Phone = Convert.ToInt32(txtPhone.Text);
                    _dealership.Email = txtEmail.Text;
                    _dealership.Address = txtAddress.Text;

                    txtBusinessNo.Enabled = false;
                    txtPhone.Enabled = false;
                    txtEmail.Enabled = false;
                    txtAddress.Enabled = false;

                    btnOK.Text = "OK";
                    MessageBox.Show("Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
