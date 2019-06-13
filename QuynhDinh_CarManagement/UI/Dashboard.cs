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
    public partial class Dashboard : Form {

        private Dealership _dealership;

        public Dashboard() {
            InitializeComponent();
            _dealership = new Dealership("BUSI0000", "QD Car Dealership", "1470 Trafalgar Road", "customer_service@qdcardealership.com", 123456789);
        }

        private void BtnAddVehicle_Click(object sender, EventArgs e) {
            AddVehicleForm addVehicleForm = new AddVehicleForm(_dealership);
            addVehicleForm.ShowDialog();
        }

        private void BtnOpenDealership_Click(object sender, EventArgs e) {
            DealershipForm dealershipForm = new DealershipForm(_dealership);
            dealershipForm.ShowDialog();
        }
    }
}
