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
        public Box newBox { get; private set; } // initialize a new box object
        public frmBoxPage() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) { 
            /* make sure the box name isn't empty before saving it */
            if (txtName.Text.Length >= 1) {
                newBox = new Box(txtName.Text, new List<Tuple<string, bool>>()); // store the info for the new box
                DialogResult = DialogResult.OK; // set dialog result to OK because the user wants to save the changes they made
                this.Close(); // close form after sending confirm dialog
            }
            /* show a message box if it is */
            else {
                MessageBox.Show("Please enter a name for the box");
            }
        }
        private void btnDeleteBox_Click_1(object sender, EventArgs e) {
            DialogResult = DialogResult.No; // send a different DialogResult if the user wants to delete the box
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close(); // close the form on cancel button click
        }
    }
}