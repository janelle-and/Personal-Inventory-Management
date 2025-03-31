namespace Personal_Inventory_Management;
public partial class frmItemData : Form {
    
    /* initialize public variables for the info so it can be passed to the calling form */
    public string itemname = "";
    public string itemdesc = "";
    
    /* initialize private variables to be used in this form */
    private string partone = "";
    private string[] splits;
    private string parttwo = "";
    private bool passedstatus = false;
    
    private Box? box; // Declare a private field to store the box object
    
    public frmItemData(Box? box, int? index) {
        InitializeComponent();
        this.box = box; // Store the box in the class-level variable
        int validIndex = 0; // store the index of the item in the passed box
        
        /* make sure its a valid index before saving it */
        if (index.HasValue) {
            validIndex = index.Value;
        }

        lblStatusState.Text = "No"; // set the default outbox status text to false
        handleBox(box, validIndex); // call the handle box function with the box and the index of the item
    }
    
    /* function to handle when the user wants to update an item instead of adding a new one */
    private void handleBox(Box passed, int indexed) {
        /* set the text fields to the values in the item that the user passed from the calling form if the box not null */
        if (box != null) {
            partone = box.items[indexed].Item1;  // Get the first part of the item list which is the string value for name and description
            splits = partone.Split('|');   // Split the string by the '|' character
            parttwo = splits[1].Trim();  // Take the second part (after the '|') and trim spaces
            passedstatus = box.items[indexed].Item2;  // Get the status passed from the calling form
            
            /* Set the textboxes based on the split result */
            txtItemName.Text = splits[0].Trim();  // Set item name as the first part of the split
            txtItemDescription.Text = parttwo;  // Set description from the second part of the split
            
            /* Set the outbox status text based on the passed status */
            if (passedstatus) { ;
                lblStatusState.Text = "Yes";
            } 
            else {
                lblStatusState.Text = "No";
            }
        }
    }
    
    /* function to handle when the user clicks the save button */
    private void btnSave_Click(object sender, EventArgs e) {
            /* check if the item name is empty */
            if (string.IsNullOrEmpty(txtItemName.Text)) {
                MessageBox.Show("Please enter an item name."); // display a messagebox telling the user to enter an item name if its empty
                return; // return from the function so the form doesnt close and the user can make the required changes
            }

            /* store the values */
            itemname = txtItemName.Text;
            itemdesc = txtItemDescription.Text;
            DialogResult = DialogResult.OK;
            this.Close();
    }
    
    /* function to handle when the user clicks the cancel button */
    private void btnCancel_Click(object sender, EventArgs e) {
        DialogResult = DialogResult.Cancel; // set the dialog result to cancel which is handled in the calling form
        this.Close(); // close the window
    }
}