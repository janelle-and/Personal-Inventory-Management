namespace Personal_Inventory_Management;
public partial class frmItemData : Form {
    /* initialize public variables for the info so it can be passed the the calling form */
    public string itemname = "";
    public string itemdesc = "";
    public bool status = false;
    private string partone = "";
    private string[] splits;
    private string parttwo = "";
    private bool passedstatus = false;
    // Declare a private field to store the box object
    private Box? box;

    public frmItemData(Box? box, int? index) {
        InitializeComponent();
        this.box = box; // Store the box in the class-level variable
        int validIndex = 0; // store the index of the item in the passed box
        if (index.HasValue) {
            validIndex = index.Value;
        }
        handleBox(box, validIndex);
    }
    private void handleBox(Box passed, int indexed) {
        /* set the text fields and radio button selection to the values in the item that the user passed from the calling form if the box not null */
        if (box != null) {
            partone = box.items[indexed].Item1;  // Get the first part of the item list which is the string value for name and description
            splits = partone.Split('|');   // Split the string by the '|' character
            parttwo = splits[1].Trim();  // Take the second part (after the '|') and trim spaces
            passedstatus = box.items[indexed].Item2;  // Get the status passed from the calling form
            /* Set the textboxes and radio buttons based on the split result */
            txtItemName.Text = splits[0].Trim();  // Set item name as the first part of the split
            txtItemDescription.Text = parttwo;  // Set description from the second part of the split
            /* Set radio button selection based on the passed status */
            if (passedstatus) {
                rdbYes.Checked = true;
            } else {
                rdbNo.Checked = true;
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
            /* make sure at least one radio button is clicked */
            if (rdbNo.Checked == false && rdbYes.Checked == false) {
                MessageBox.Show("Please choose a status");
                return;
            }
            /* store the values */
            itemname = txtItemName.Text;
            itemdesc = txtItemDescription.Text;
            /* check which radio button is checked and change status accordingly */
            if (rdbNo.Checked) {
                status = false;
            }
            else {
                status = true;
            }
            DialogResult = DialogResult.OK;
            this.Close();
    }
    /* function to handle when the user clicks the cancel button */
    private void btnCancel_Click(object sender, EventArgs e) {
        DialogResult = DialogResult.Cancel; // set the dialog result to cancel which is handled in the calling form
        this.Close(); // close the window
    }
}