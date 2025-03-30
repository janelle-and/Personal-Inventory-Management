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
        public Box sending { get ; set; } // initialize the box for sending things to the outbox
        public bool moved;
        public frmBoxPage(Box box) {
            InitializeComponent();
            newBox = new Box(box.Name, new List<Tuple<string, bool>>(box.items)); // Create a copy of the passed box to work with in this form
            sending = new Box("sending", new List<Tuple<string, bool>>(box.items));
            /* Make sure the box name isn't empty */
            if (!string.IsNullOrEmpty(box.Name)) {
                txtName.Text = box.Name; // set the Name textbox text to the name of the box
            }
            lstItems.Items.Clear(); // Clear any existing items in the listbox before adding new ones
            /* Add the items from the Box's items list to the ListBox display */
            if (box.items.Count > 0) {
                foreach (var item in box.items) {
                    lstItems.Items.Add(item);
                }
            }
        }
        /* function to handle when the user clicks the save button */
        private void button1_Click(object sender, EventArgs e) { 
            /* Make sure the box name isn't empty before saving */
            if (txtName.Text.Length >= 1) {
                newBox.Name = txtName.Text; // save the new name of the box
                DialogResult = DialogResult.OK; // Set the dialog result to OK because the user wants to save the changes
                this.Close(); // Close the form
            }
            else {
                MessageBox.Show("Please enter a name for the box"); // show a message box telling the user to give the box name
            }
        }
        /* funciton to handle when the user clicks the add item button */
        private void btnAddItem_Click(object sender, EventArgs e) {
            frmItemData itemData = new frmItemData();
            itemData.ShowDialog();
            newBox.items.Add(new Tuple<string, bool>("Winter Boots | My favourite winter boots :)", false)); // currently hard coded but this adds the item to the box item list
            lstItems.Items.Add(newBox.items[0]); // display the newly added item in the listbox display
        }
        /* function to handle when the user clicks the update item button */
        private void btnUpdateItem_Click(object sender, EventArgs e) {
            int index = lstItems.SelectedIndex; // get the index of the selected item
            /* make sure its a valid index before doing anything */
            if (index != -1) {
                frmItemData itemData = new frmItemData();
                itemData.ShowDialog();
                var modifiedItem = new Tuple<string, bool>("newStringValue", false); // set the values for the updated item
                newBox.items[index] = modifiedItem; // add the updated item to the box list by replacing the old version
                lstItems.Items[index] = modifiedItem; // add the updated item to the listbox dispaly by replacing the old version
            }
            else {
                MessageBox.Show("Please select an item to update"); // show a messagebox telling the user to select an item to update
            }
            index = -1; // set the index to an invalid index to prevent trying to immediately access an item that doesnt exist anymore
        }
        /* function to handle when the user clicks the delete item button */
        private void btnDeleteItem_Click(object sender, EventArgs e) {
            int index = lstItems.SelectedIndex; // get the index of the selected item
            /* make sure its a valid index before doing anything */
            if (index != -1) {
                newBox.items.RemoveAt(index); // remove the item from the box list
                lstItems.Items.RemoveAt(index); // remove the item from listbox display
            }
            else {
                MessageBox.Show("Please select an item to delete"); // show a messagebox telling the user to select an item to delete
            }
            index = -1; // set the index to an invalid index to prevent trying to immediately access an item that doesnt exist anymore
        }
        /* function to handle when the user clicks the delete box button */
        private void btnDeleteBox_Click_1(object sender, EventArgs e) {
            DialogResult = DialogResult.No; // send a different DialogResult if the user wants to delete the box
            this.Close();
        }
        /* function to handle when the user clicks the move to outbox button */
        private void btnMoveToOutBox_Click(object sender, EventArgs e) {
            moved = false;
            int index = lstItems.SelectedIndex; // Get the index of the selected item
            if (index != -1) {
                var selectedItem = newBox.items[index]; // store the selected item
                var updatedItem = new Tuple<string, bool>(selectedItem.Item1, true); // Create a new tuple with the same string value and the updated out status
                newBox.items[index] = updatedItem; // Replace the old tuple in the list with the new one
                lstItems.Items.RemoveAt(index); // remove the outdated item
                lstItems.Items.Add(newBox.items[index]); // add the updated item
                sending.items.Add(updatedItem); // Add the entire tuple to the sending box
                index = -1; // set the index to an invalid index to prevent trying to immediately access an item that doesnt exist anymore
                moved = true;
            }
            else {
                MessageBox.Show("Please select an item to send to the outbox"); // show a messagebox telling the user to select an item to send to the outbox
            }
        }
        /* function to handle when the user clicks the cancel button */
        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}