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
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; // set dialog result to OK because the user wants to save the changes they made
            Close(); // close form after sending confirm dialog
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close(); // close the form on cancel button click
        }
    }
}
