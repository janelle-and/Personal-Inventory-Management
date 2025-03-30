using System;
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
        Box returnBox = new Box("Return", new List<Tuple<string, bool>>()); // Create a new box object to hold the items that are being returned
        public frmOutBox(Box OutBox)
        {
            InitializeComponent();

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
    }
}
