using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Personal_Inventory_Management {
    public partial class frmBoxPage : Form {
        public frmBoxPage() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
