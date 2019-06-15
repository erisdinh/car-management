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
            _dealership = new Dealership("BUSI0000", "QD Car Dealership", "1430 Trafalgar Road, Oakville, ON", "customer_service@qdcardealership.ca", 647850850);
        }

        private void AddVehicle(object sender, EventArgs e) {
            AddVehicleForm addVehicleForm = new AddVehicleForm(_dealership);
            addVehicleForm.ShowDialog();
        }

        private void EditDealership(object sender, EventArgs e) {
            DealershipForm dealershipForm = new DealershipForm(_dealership);
            dealershipForm.ShowDialog();
        }

        private void ViewReport(object sender, EventArgs e) {
            ReportForm reportForm = new ReportForm(_dealership);
            reportForm.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
