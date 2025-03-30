﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Inventory_Management
{
    public partial class frmOutBox : Form
    {
        public Box OutBox = new Box("OutBox", new List<Tuple<string, bool, string?>>()); // Create a new box object to hold the items that have been taken out
        public Box returnBox = new Box("Return", new List<Tuple<string, bool, string?>>()); // Create a new box object to hold the items that are being returned
        public frmOutBox(Box outBox)
        {
            InitializeComponent();

            OutBox = outBox; // Set the OutBox object to the passed box object
            lstOutItems.Items.Clear(); // Clear any existing items in the listbox before adding new ones
            /* Add the items from the Box's items list to the ListBox display */
            if (OutBox.items.Count > 0)
            {
                foreach (var item in OutBox.items)
                {
                    lstOutItems.Items.Add(item);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; // Set the dialog result to OK because the user wants to save the changes
            this.Close(); // Close the form
        }

        private void btnReturnItem_Click(object sender, EventArgs e)
        {
            if (lstOutItems.SelectedIndex != -1)
            {
                int index = lstOutItems.SelectedIndex;
                returnBox.items.Add(OutBox.items[index]);
                OutBox.items.RemoveAt(index);
                lstOutItems.Items.RemoveAt(index);
            }
        }
    }
}
