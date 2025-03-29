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
        public Box newBox { get;  set; } // initialize a new box object
        public Box sending { get ; set; }
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
        private void btnAddItem_Click(object sender, EventArgs e) {
            newBox.items.Add(new Tuple<string, bool>("Winter Boots | My favourite winter boots :)", false));
            lstItems.Items.Add(newBox.items[0]);
        }
        private void btnUpdateItem_Click(object sender, EventArgs e) {
            int index = lstItems.SelectedIndex; // get the index of the selected item
            /* make sure its a valid index before doing anything */
            if (index != -1) {
                var modifiedItem = new Tuple<string, bool>("newStringValue", false); // set the values for the updated item
                newBox.items[index] = modifiedItem; // add the updated item to the box list
                lstItems.Items[index] = modifiedItem; // add the updated item to the listbox dispaly
            }
            else {
                MessageBox.Show("Please select an item to update");
            }
            index = -1; // set the index to an invalid index to prevent trying to immediately access an item that doesnt exist anymore
        }
        private void btnDeleteItem_Click(object sender, EventArgs e) {
            int index = lstItems.SelectedIndex; // get the index of the selected item
            /* make sure its a valid index before doing anything */
            if (index != -1) {
                newBox.items.RemoveAt(index); // remove the item from the box list
                lstItems.Items.RemoveAt(index); // remove the item from listbox display
            }
            else {
                MessageBox.Show("Please select an item to delete");
            }
            index = -1; // set the index to an invalid index to prevent trying to immediately access an item that doesnt exist anymore
        }
        private void btnDeleteBox_Click_1(object sender, EventArgs e) {
            DialogResult = DialogResult.No; // send a different DialogResult if the user wants to delete the box
            this.Close();
        }
        private void btnMoveToOutBox_Click(object sender, EventArgs e) {
            int index = lstItems.SelectedIndex; // get the index of the selected item
            /* make sure its a valid index before doing anything */
            if (index != -1) {
                sending.items.Add(newBox.items[index]);
            }
            else {
                MessageBox.Show("Please select an item to send to the outbox");
            }
            index = -1; // set the index to an invalid index to prevent trying to immediately access an item that doesnt exist anymore
            DialogResult = DialogResult.Ignore;
            this.Close();
        }
    }
}