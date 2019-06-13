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
    }
}
