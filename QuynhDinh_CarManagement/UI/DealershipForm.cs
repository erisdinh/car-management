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
            lbName.Text = _dealership.Name;
            lbBusinessNumber.Text = _dealership.BusinessNumber;
            tbPhone.Text = _dealership.Phone.ToString();
            tbEmail.Text = _dealership.Email;
            tbAddress.Text = _dealership.Address;

            tbPhone.Enabled = false;
            tbEmail.Enabled = false;
            tbAddress.Enabled = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e) {
            tbPhone.Enabled = true;
            tbEmail.Enabled = true;
            tbAddress.Enabled = true;

            btnOK.Text = "Save";
        }

        private void BtnOK_Click(object sender, EventArgs e) {

            if (btnOK.Text.Equals("OK")) {
                this.Hide();
            } else {
                try {
                    _dealership.Phone = Convert.ToInt32(tbPhone.Text);
                    _dealership.Email = tbEmail.Text;
                    _dealership.Address = tbAddress.Text;

                    tbPhone.Enabled = false;
                    tbEmail.Enabled = false;
                    tbAddress.Enabled = false;

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
